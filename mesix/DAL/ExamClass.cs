using DataTransferObjects.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class ExamClass : DBContext
    {
        SqlConnection con;
        public ExamClass()
        {
            con = new SqlConnection(connectionstring);
        }
        public void UpdateExamReport(int Id, decimal Obt, string rem)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SMS_EXAM_EDIT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Obt", Obt);
            cmd.Parameters.AddWithValue("@Rem", rem);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetExamsReportList(int Class, int Section, int Subjct, int Tst)
        {
            SqlCommand cmd = new SqlCommand("SMS_EXAM_REPORT_S3", con);
            cmd.Parameters.AddWithValue("@classid", Class);
            cmd.Parameters.AddWithValue("@sectionid", Section);
            cmd.Parameters.AddWithValue("@subjectid", Subjct);
            cmd.Parameters.AddWithValue("@testid", Tst);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetAttendanceList(int Subject, string Dat)
        {
            SqlCommand cmd = new SqlCommand("select sa.ID,st.SName,st.RollNo,sa.Status from StudentAttendance as sa inner join StudentTable as st on sa.StdId=st.ID where SubjectId=@subject and Date=@date", con);
            cmd.Parameters.AddWithValue("@subject", Subject);
            cmd.Parameters.AddWithValue("@date", Dat);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public void CreateAttendanceList(int Class, int Section, int subject, string dat)
        {
            List<int> IdList = new List<int>();
            SqlCommand cmd = new SqlCommand("select ID from StudentTable where Class = @class and Section =@section", con);
            cmd.Parameters.AddWithValue("@class", Class);
            cmd.Parameters.AddWithValue("@section", Section);


            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id;
                id = Convert.ToInt32(sdr["ID"]);
                IdList.Add(id);
            }
            con.Close();

            int count = IdList.Count;
            if (IdList.Count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into StudentAttendance (StdID,SubjectId,Date)Values(@stdid,@subject,@date)", con);
                    cmd1.Parameters.AddWithValue("@stdid", IdList[i]);
                    cmd1.Parameters.AddWithValue("@subject", subject);
                    cmd1.Parameters.AddWithValue("@date", dat);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public DataTable GetExamsReportList(int Class, int Section, int Subjct, int Tst, int Tid)
        {
            SqlCommand cmd = new SqlCommand("Select ER.Id,TE.Date,ST.SName AS Name,ST.FName AS 'Father Name',TE.TestName AS 'Exam Name',TE.TotalMarks AS 'Total Marks',TE.PassingMarks AS 'Passing Marks',ObtMarks AS 'Obtained',Remarks AS 'Remarks' from ExamsReport AS ER INNER JOIN StudentTable AS ST on ER.StudentId=ST.ID Inner join TestNExam AS TE on ER.TestId=TE.ID where ER.isDeleted=0 AND ER.ClassId=@class AND ER.SectionId=@section AND ER.SubjectId=@subject AND ER.TestId=@test and TE.TeacherID=@tid", con);
            cmd.Parameters.AddWithValue("@class", Class);
            cmd.Parameters.AddWithValue("@tid", Tid);
            cmd.Parameters.AddWithValue("@section", Section);
            cmd.Parameters.AddWithValue("@subject", Subjct);
            cmd.Parameters.AddWithValue("@test", Tst);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetSections(int ClassId)
        {
            SqlCommand cmd = new SqlCommand("Select Id,CT.ClassName AS Class,Section from Sections AS s Inner Join ClassTable AS CT on s.Classid=CT.ClassID where  s.Classid=@id", con); //CHange krna ay
            cmd.Parameters.AddWithValue("@id", ClassId);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetExams(int Classid, int Section, int Subjct)
        {
            SqlCommand cmd = new SqlCommand("SMS_TEST_S1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@classid", Classid);
            cmd.Parameters.AddWithValue("@sectionid", Section);
            cmd.Parameters.AddWithValue("@subjectid", Subjct);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

        public DataTable GetExamsBySubject(int Subject)
        {
            SqlCommand cmd = new SqlCommand("Select T.ID,Date,TestName AS 'Test Name',E.FirstName+' '+E.LastName AS 'Teacher',TotalMarks as 'Total Marks',PassingMarks As 'Passing Marks',T.Description from TestNExam AS T  Inner join Employee as E on T.TeacherID=E.Id  where T.IsDeleted=0  AND  T.SubjectID=@subject", con);
            cmd.Parameters.AddWithValue("@subject", Subject);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetAttendanceBySubject(int Subject, int id)
        {
            SqlCommand cmd = new SqlCommand("Select ID,Date,Status from StudentAttendance where  SubjectId=@subject and StdId = @id", con);
            cmd.Parameters.AddWithValue("@subject", Subject);
            cmd.Parameters.AddWithValue("@id", id);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetExams(int Classid, int Section, int Subjct, int Tid)
        {
            SqlCommand cmd = new SqlCommand("Select T.ID,Date,TestName AS 'Test Name',CT.ClassName As 'Class',S.SubjectTitle As 'Subject',sec.Section as 'Section',E.FirstName+' '+E.LastName AS 'Teacher',TotalMarks as 'Total Marks',PassingMarks As 'Passing Marks',T.Description from TestNExam AS T Inner join ClassTable As CT on T.ClassID=CT.ClassID Inner join Subjects as S on T.SubjectID=S.Id inner join Sections as sec on T.SectionID=sec.id Inner join Employee as E on T.TeacherID=E.Id  where T.IsDeleted=0 AND T.ClassID=@class AND T.SectionID=@section AND T.SubjectID=@subject and E.Id=@tid", con);
            cmd.Parameters.AddWithValue("@class", Classid);
            cmd.Parameters.AddWithValue("@section", Section);
            cmd.Parameters.AddWithValue("@subject", Subjct);
            cmd.Parameters.AddWithValue("@tid", Tid);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public Test ViewExamDetail(int id)
        {
            SqlCommand cmd = new SqlCommand("SMS_TEST_S2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@testid", id);
            Test tst = new Test();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                try
                {
                    tst.date = Convert.ToDateTime(sdr["Date"]);
                }
                catch (Exception ex)
                {
                    tst.date = DateTime.Now;
                }
                tst.TName = Convert.ToString(sdr["TestName"]);
                tst.Class = Convert.ToInt32(sdr["ClassID"]);
                tst.Subject = Convert.ToInt32(sdr["SubjectID"]);
                tst.Section = Convert.ToInt32(sdr["SectionID"]);
                //tst.TeacherId = Convert.ToInt32(sdr["TeacherID"]);
                try
                {
                    tst.TotalMarks = Convert.ToInt32(sdr["TotalMarks"]);
                }
                catch (Exception)
                {
                    tst.TotalMarks = 0;
                }
                try
                {
                    tst.PassingMarks = Convert.ToInt32(sdr["PassingMarks"]);
                }
                catch (Exception)
                {

                    tst.TotalMarks = 0;
                }
                tst.Description = Convert.ToString(sdr["Description"]);
            }
            con.Close();
            return tst;
        }
        public List<Test> GetTests()
        {
            List<Test> Tests = new List<Test>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Test item = new Test();
                    item.Id = Convert.ToInt32(sdr["ID"]);
                    item.TName = sdr["TestName"].ToString();

                    Tests.Add(item);
                }
                sdr.Close();
                con.Close();

                return Tests;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void InsertExam(Test Exam)
        {

            SqlCommand cmd = new SqlCommand("SMS_TEST_I", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@testname", Exam.TName);
            cmd.Parameters.AddWithValue("@date", Exam.date);
            cmd.Parameters.AddWithValue("@classid", Exam.Class);
            cmd.Parameters.AddWithValue("@subjectid", Exam.Subject);
            cmd.Parameters.AddWithValue("@totalmarks", Exam.TotalMarks);
            cmd.Parameters.AddWithValue("@passingmarks", Exam.PassingMarks);
            cmd.Parameters.AddWithValue("@dsc", Exam.Description);
            //cmd.Parameters.AddWithValue("@totalmarks", Exam.TotalMarks);
            //cmd.Parameters.AddWithValue("@passingmarks", Exam.PassingMarks);
            //cmd.Parameters.AddWithValue("@description", Exam.Description);
            cmd.Parameters.AddWithValue("@sectionid", Exam.Section);
            //cmd.Parameters.AddWithValue("@teacherid", Exam.TeacherId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("New Exam Inserted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateExam(Test Exam, int Id)
        {

            SqlCommand cmd = new SqlCommand("SMS_TEST_U", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@testid", Id);
            cmd.Parameters.AddWithValue("@testname", Exam.TName);
            cmd.Parameters.AddWithValue("@date", Exam.date);
            cmd.Parameters.AddWithValue("@classid", Exam.Class);
            cmd.Parameters.AddWithValue("@subjectid", Exam.Subject);
            cmd.Parameters.AddWithValue("@totalmarks", Exam.TotalMarks);
            cmd.Parameters.AddWithValue("@passingmarks", Exam.PassingMarks);
            cmd.Parameters.AddWithValue("@description", Exam.Description);
            cmd.Parameters.AddWithValue("@sectionid", Exam.Section);
            //cmd.Parameters.AddWithValue("@teacherid", Exam.TeacherId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Records...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteExam(int ID)
        {
            SqlCommand cmd = new SqlCommand("Update TestNExam Set IsDeleted = 1 where ID = @id", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", ID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public List<Test> GetTests(int classid, int secid, int subid)
        {
            List<Test> Tests = new List<Test>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_S1";
                command.Parameters.AddWithValue("@classid", classid);
                command.Parameters.AddWithValue("@sectionid", secid);
                command.Parameters.AddWithValue("@subjectid", subid);
                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Test item = new Test();
                    item.Id = Convert.ToInt32(sdr["ID"]);
                    item.TName = sdr["Test Name"].ToString();

                    Tests.Add(item);
                }
                sdr.Close();
                con.Close();

                return Tests;
            }
            catch (Exception ex)
            {
                return new List<Test>();
            }
        }
        public List<SectionClass> GetSectionsByClassId(int ClassId)
        {
            List<SectionClass> Sections = new List<SectionClass>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SECTION_S1";
                command.Parameters.AddWithValue("@classid", ClassId);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    SectionClass item = new SectionClass();
                    item.Id = Convert.ToInt32(sdr["SectionID"]);
                    item.classid = Convert.ToInt32(sdr["ClassID"]);
                    item.SecName = sdr["SectionName"].ToString();

                    Sections.Add(item);
                }
                sdr.Close();
                con.Close();

                return Sections;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public TestDetails GetTestDetails(int id)
        {
            TestDetails tst = new TestDetails();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_S2";
                command.Parameters.AddWithValue("@testid", id);
                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        tst.Date = Convert.ToDateTime(sdr["Date"]);
                        tst.Teacher = Convert.ToString(sdr["TestName"]);
                    }
                }
                sdr.Close();
                con.Close();

                return tst;
            }
            catch (Exception ex)
            {
                return new TestDetails();
            }
        }
        public List<TestSections> GetTestSectionsByTestID(int id)
        {
            List<TestSections> Sections = new List<TestSections>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_SECN_S1";
                command.Parameters.AddWithValue("@testid", id);
                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        TestSections item = new TestSections();
                        item.TestSectionID = Convert.ToInt32(sdr["TestSectionID"]);
                        item.TestID = Convert.ToInt32(sdr["TestID"]);
                        item.SecID = Convert.ToInt32(sdr["SecID"]);
                        item.TotalMarks = Convert.ToDecimal(sdr["TotalMarks"]);
                        item.Title = Convert.ToString(sdr["Title"]);
                        item.IsObjective = Convert.ToBoolean(sdr["IsObjective"]);

                        Sections.Add(item);
                    }
                }
                sdr.Close();
                con.Close();

                return Sections;
            }
            catch (Exception ex)
            {
                return new List<TestSections>();
            }
        }
        public List<QuestionModel> GetTestQuestionModelsByTestSectionID(int id)
        {
            List<QuestionModel> Questions = new List<QuestionModel>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_QUES_S1";
                command.Parameters.AddWithValue("@secid", id);
                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        QuestionModel q = new QuestionModel();
                        q.QuesID = Convert.ToInt32(sdr["QuestionID"]);
                        q.TestID = Convert.ToInt32(sdr["TestID"]);
                        q.SecID = Convert.ToInt32(sdr["SecID"]);
                        q.QuesSrNo = Convert.ToInt32(sdr["QuesSrNo"]);
                        q.DESC = Convert.ToString(sdr["DESC"]);
                        q.Marks = Convert.ToDecimal(sdr["Marks"]);
                        q.isObjective = Convert.ToBoolean(sdr["IsObjective"]);
                        q.ChoiceA = Convert.ToString(sdr["ChoiceA"]);
                        q.ChoiceB = Convert.ToString(sdr["ChoiceB"]);
                        q.ChoiceC = Convert.ToString(sdr["ChoiceC"]);
                        q.ChoiceD = Convert.ToString(sdr["ChoiceD"]);
                        q.IsPersisted = true;
                        Questions.Add(q);
                    }
                }
                sdr.Close();
                con.Close();

                return Questions;
            }
            catch (Exception ex)
            {
                return new List<QuestionModel>();
            }
        }
        public int InsertTestSection(TestSections item)
        {
            int res = 0;
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_SECN_I";
                command.Parameters.AddWithValue("@testid", item.TestID);
                command.Parameters.AddWithValue("@secid", item.SecID);
                command.Parameters.AddWithValue("@totalmarks", item.TotalMarks);
                command.Parameters.AddWithValue("@title", item.Title);
                command.Parameters.AddWithValue("@isobj", item.IsObjective);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        res = Convert.ToInt32(sdr["Id"]);
                    }
                }
                sdr.Close();
                con.Close();

                return res;
            }
            catch (Exception ex)
            {
                return res;
            }
        }
        public int DeleteTestSection(int id)
        {
            int res = 0;
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_TEST_SECN_D";
                command.Parameters.AddWithValue("@testid", id);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        res = Convert.ToInt32(sdr["Id"]);
                    }
                }
                sdr.Close();
                con.Close();

                return res;
            }
            catch (Exception ex)
            {
                return res;
            }
        }
        public bool InsertTestQuestion(QuestionModel item)
        {
            try
            {
                int res = 0;
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_QUES_I";
                command.Parameters.AddWithValue("@testid", item.TestID);
                command.Parameters.AddWithValue("@secid", item.SecID);
                command.Parameters.AddWithValue("@quessrno", item.QuesSrNo);
                command.Parameters.AddWithValue("@dsc", item.DESC);
                command.Parameters.AddWithValue("@marks", item.Marks);
                command.Parameters.AddWithValue("@isobj", item.isObjective);
                command.Parameters.AddWithValue("@choicea", item.ChoiceA);
                command.Parameters.AddWithValue("@choiceb", item.ChoiceB);
                command.Parameters.AddWithValue("@choicec", item.ChoiceC);
                command.Parameters.AddWithValue("@choiced", item.ChoiceD);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        res = Convert.ToInt32(sdr["Id"]);
                    }
                }
                sdr.Close();
                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
    public class TestDetails
    {
        public DateTime Date;
        public string Teacher;
    }
    public class Test
    {
        public int Id { get; set; }
        public string TName { get; set; }
        public DateTime date { get; set; }
        public int Class { get; set; }
        public int Section { get; set; }
        public int Subject { get; set; }
        public decimal TotalMarks { get; set; }
        public decimal PassingMarks { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
    }
    public class TestEdit
    {
        public int TestID { get; set; }
        public List<TestSections> TestSection { get; set; }
        public TestEdit()
        {
            this.TestSection = new List<TestSections>();
        }
    }
    public class QuestionModel
    {
        public int TestID { get; set; }
        public int QuesID { get; set; }
        public int QuesSrNo { get; set; }
        public int SecID { get; set; }
        public bool isObjective { get; set; }
        public bool IsPersisted { get; set; }
        public string DESC { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
        public Decimal Marks { get; set; }
        public EntityState State { get; set; }

    }
    public class TestSections
    {
        public int TestSectionID { get; set; }
        public int TestID { get; set; }
        public int SecID { get; set; }
        public int SrNoCount { get; set; }
        public EntityState State { get; set; }
        public Decimal TotalMarks { get; set; }
        public string Title { get; set; }
        public bool IsObjective { get; set; }
        public List<QuestionModel> Questions { get; set; }
        public TestSections()
        {
            this.Questions = new List<QuestionModel>();
        }
    }
}
