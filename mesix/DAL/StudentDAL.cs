using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class StudentDAL : DBContext
    {
        SqlConnection con;//

        public StudentDAL()
        {
            con = new SqlConnection(connectionstring);
        }
        public DataTable GetStudentList(int pageNumber = 0, int Pagesize = 10)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_STUDENT_S0";
                command.Parameters.AddWithValue("@pagenum", pageNumber);
                command.Parameters.AddWithValue("@pagesize", Pagesize);

                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int GetStudentCount()
        {
            try
            {
                con.Open();
                int count = 0;

                //SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                //DataTable dt = new DataTable();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_STUDENT_COUNT";

                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    count = Convert.ToInt32(sdr["Students"]);
                }

                //adapter = new SqlDataAdapter(command);
                //adapter.Fill(dt);
                con.Close();
                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public DataTable SearchStudentList(string sName = "", int ClassID = 0)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_STUDENT_S3";
                if (sName != "")
                {
                    command.Parameters.AddWithValue("@sname", sName);
                }
                if (ClassID > 0)
                {
                    command.Parameters.AddWithValue("@classid", ClassID);
                }

                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable GetCuriculum()
        {
            SqlCommand cmd = new SqlCommand("Select * from Curriculum", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public Student GetStudentProfile(int id)
        {
            SqlCommand cmd = new SqlCommand("Select st.ID,st.SName,st.FName,st.RollNo,c.ClassName,sec.Section,st.Address,ct.CityName,st.BloodGroup,st.AdmId,st.AdmDate,st.PictureName,st.Email,st.Password,p.FirstName+' '+p.LastName as 'Parent' from StudentTable as st inner join Parents as p on st.ParentId=p.id inner join Sections as sec on st.Section=sec.id inner join Cities as ct on st.City=ct.CityId inner join ClassTable as c on st.Class =c.ClassID where st.ID=@id AND st.isDeleted=0", con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Student sObj = new Student();
            while (sdr.Read())
            {
                sObj.stdID = Convert.ToInt32(sdr["ID"]);
                sObj.FirstName = Convert.ToString(sdr["SName"]);
                sObj.FatherName = Convert.ToString(sdr["FName"]);
                sObj.Roll = Convert.ToInt32(sdr["RollNo"]);
                sObj.AdmissionId = Convert.ToInt32(sdr["AdmId"]);
                sObj.Class = Convert.ToString(sdr["ClassName"]);
                sObj.Section = Convert.ToString(sdr["Section"]);
                sObj.Address = Convert.ToString(sdr["Address"]);
                sObj.City = Convert.ToString(sdr["CityName"]);
                sObj.BloodGroup = Convert.ToString(sdr["BloodGroup"]);
                sObj.AdmissionDate = Convert.ToString(sdr["AdmDate"]);
                sObj.PictureName = Convert.ToString(sdr["PictureName"]);
                sObj.Email = Convert.ToString(sdr["Email"]);
                sObj.Password = Convert.ToString(sdr["Password"]);
                sObj.Parent = Convert.ToString(sdr["Parent"]);
            }
            con.Close();
            return sObj;
        }
        public void UpdateStudent(Student TempObj)
        {
            SqlCommand cmd = new SqlCommand("SMS_STUDENT_U", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentid", TempObj.stdID);
            cmd.Parameters.AddWithValue("@userid", TempObj.userObj.UserID);
            cmd.Parameters.AddWithValue("@name", TempObj.Name);
            cmd.Parameters.AddWithValue("@fname", TempObj.FatherName);
            cmd.Parameters.AddWithValue("@fOcup", TempObj.FOccupation);
            cmd.Parameters.AddWithValue("@rollno", TempObj.Roll);
            cmd.Parameters.AddWithValue("@bloodid", TempObj.BloodID);
            cmd.Parameters.AddWithValue("@gender", TempObj.GenderID);
            cmd.Parameters.AddWithValue("@classid", TempObj.ClassId);
            cmd.Parameters.AddWithValue("@sectionid", TempObj.SectionId);
            cmd.Parameters.AddWithValue("@address", TempObj.Address);
            cmd.Parameters.AddWithValue("@dob", TempObj.DOB);
            cmd.Parameters.AddWithValue("@contact", TempObj.Contact1);
            cmd.Parameters.AddWithValue("@cnic", TempObj.CNIC);
            cmd.Parameters.AddWithValue("@isCR", TempObj.IsCR);
            //cmd.Parameters.AddWithValue("@cityid", 1);
            //cmd.Parameters.AddWithValue("@admid", TempObj.AdmissionId);
            //cmd.Parameters.AddWithValue("@admdate", TempObj.AdmissionDate);
            //cmd.Parameters.AddWithValue("@picname", TempObj.PictureName);
            //cmd.Parameters.AddWithValue("@email", TempObj.Email);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Record...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InsertStudent(Student TempObj)
        {

            SqlCommand cmd = new SqlCommand("SMS_STUDENT_I", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", TempObj.Name);
            cmd.Parameters.AddWithValue("@SecondName", "");
            cmd.Parameters.AddWithValue("@UserName", TempObj.userObj.UserName);
            cmd.Parameters.AddWithValue("@FName", TempObj.FatherName);
            cmd.Parameters.AddWithValue("@RollNo", TempObj.Roll);
            cmd.Parameters.AddWithValue("@DOB", TempObj.DOB);
            cmd.Parameters.AddWithValue("@ClassID", TempObj.ClassId);
            cmd.Parameters.AddWithValue("@SectionID", TempObj.SectionId);
            cmd.Parameters.AddWithValue("@RoleID", 2);
            cmd.Parameters.AddWithValue("@Contact1", TempObj.Contact1);
            cmd.Parameters.AddWithValue("@CNIC", TempObj.CNIC);
            cmd.Parameters.AddWithValue("@Address", TempObj.Address);
            cmd.Parameters.AddWithValue("@BloodID", TempObj.BloodID);
            cmd.Parameters.AddWithValue("@FOccupation", TempObj.FOccupation);
            cmd.Parameters.AddWithValue("@Gender", TempObj.GenderID);
            cmd.Parameters.AddWithValue("@isCR", TempObj.IsCR);
            //cmd.Parameters.AddWithValue("@city", TempObj.City);
            //cmd.Parameters.AddWithValue("@bloodgroup", TempObj.BloodGroup);
            //cmd.Parameters.AddWithValue("@admid", TempObj.AdmissionId);
            //cmd.Parameters.AddWithValue("@admdate", TempObj.AdmissionDate);
            //cmd.Parameters.AddWithValue("@picturename", TempObj.PictureName);
            cmd.Parameters.AddWithValue("@Email", TempObj.Email);
            cmd.Parameters.AddWithValue("@admDate", TempObj.AdmissionDate);
            cmd.Parameters.AddWithValue("@schoolid", TempObj.userObj.school.SchoolID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("New Student Inserted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteStudent(int ID)
        {
            SqlCommand cmd = new SqlCommand("Update Student set isDeleted=1 where StudentID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", ID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCurricullum(int ID)
        {
            SqlCommand cmd = new SqlCommand("Delete from Curriculum where Id=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", ID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public Student ViewStudentInfo(int id)
        {
            Student s = new Student();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_STUDENT_S1";
                command.Parameters.AddWithValue("@StudentID", id);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        s.userObj.FirstName = sdr["FirstName"].ToString();
                        s.userObj.SecondName = sdr["SecondName"].ToString();
                        s.userObj.UserName = sdr["UserName"].ToString();
                        s.userObj.UserID = Convert.ToInt32(sdr["UserID"]);
                        s.FatherName = sdr["FName"].ToString();
                        s.stdID = Convert.ToInt32(sdr["StudentID"]);
                        s.FatherName = sdr["FName"].ToString();
                        s.Roll = Convert.ToInt32(sdr["RollNo"]);
                        s.userObj.Email = sdr["Email"].ToString();
                        s.Contact1 = sdr["Contact1"].ToString();
                        s.Contact2 = sdr["Contact2"].ToString();
                        s.CNIC = sdr["CNIC"].ToString();
                        s.ClassId = Convert.ToInt32(sdr["ClassID"]);
                        s.Class = sdr["ClassName"].ToString();
                        s.Section = sdr["SectionName"].ToString();
                        s.SectionId = Convert.ToInt32(sdr["SectionID"]);
                        s.BloodID = Convert.ToInt32(sdr["BloodID"]);
                        s.DOB = sdr["DOB"].ToString();
                        //Implementation required for AdmID
                        s.AdmissionId = 0;
                        s.PictureName = "";
                        s.Name = s.userObj.FirstName + " " + s.userObj.SecondName;
                        s.FOccupation = sdr["FOccupation"].ToString();
                        s.GenderID = Convert.ToInt32(sdr["Gender"]);
                        s.Dsc = sdr["Dsc"].ToString();
                        s.IsCR = Convert.ToBoolean(sdr["isCR"]);
                        s.Address = Convert.ToString(sdr["Address"]);
                    }
                }
                sdr.Close();
                con.Close();

                return s;
            }
            catch (Exception ex)
            {
                return new Student();
            }
        }
        public StudentProp GetStudentInfo(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT SName,FName,RollNo,Class,Section,Address,City,BloodGroup,AdmId,AdmDate,PictureName,Email FROM StudentTable where isDeleted = 0 AND ID=@id", con);

            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            StudentProp st = new StudentProp();
            while (sdr.Read())
            {
                st.Name = Convert.ToString(sdr["SName"]);
                st.FatherName = Convert.ToString(sdr["FName"]);
                st.Roll = Convert.ToInt32(sdr["RollNo"]);
                st.ClassId = Convert.ToInt32(sdr["Class"]);
                st.Section = Convert.ToInt32(sdr["Section"]);
                st.Address = Convert.ToString(sdr["Address"]);
                st.City = Convert.ToInt32(sdr["City"]);
                st.BloodGroup = Convert.ToString(sdr["BloodGroup"]);
                st.AdmissionId = Convert.ToInt32(sdr["AdmId"]);
                st.AdmissionDate = Convert.ToString(sdr["AdmDate"]);
                st.Email = Convert.ToString(sdr["Email"]);
                st.PictureName = Convert.ToString(sdr["PictureName"]);

            }
            con.Close();
            return st;
        }

        public void UpdateCurriculum(string curricurum, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Curriculum SET Curriculum=@Crum where ID=@Id", con);
            cmd.Parameters.AddWithValue("@Crum", curricurum);
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Student> SearchStudentList(string textToSearch)
        {
            List<Student> students = new List<Student>();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_STUDENT_S2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                int checkIfInterger;

                if (int.TryParse(textToSearch, out checkIfInterger))
                {
                    cmd.Parameters.AddWithValue("@isRollNumSearch", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@isRollNumSearch", false);
                }
                cmd.Parameters.AddWithValue("@text", textToSearch);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Student item = new Student();
                    item.stdID = Convert.ToInt32(sdr["StudentID"]);
                    item.FatherName = sdr["FName"].ToString();
                    item.Name = sdr["FirstName"].ToString();
                    //item.SecondName = sdr["SecondName"].ToString();
                    item.Roll = Convert.ToInt32(sdr["RollNo"].ToString());
                    item.Class = sdr["ClassName"].ToString();
                    item.ClassId = Convert.ToInt32(sdr["ClassID"]);
                    item.SectionId = Convert.ToInt32(sdr["SectionID"]);
                    item.Section = sdr["SectionName"].ToString();
                    item.Contact1 = sdr["Contact1"].ToString();
                    //item.Dsc = sdr["Dsc"].ToString();
                    //item.City = sdr["CityName"].ToString();

                    students.Add(item);
                }
                sdr.Close();
                con.Close();
                return students;
            }
            catch (Exception)
            {
                return students;
            }
        }
        public List<FeeCnfg> GetSchoolFeesList(int studentid)

        {
            List<FeeCnfg> feeCnfgCol = new List<FeeCnfg>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_FeeCnfg_S1";
                command.Parameters.AddWithValue("@studentid", studentid);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    FeeCnfg item = new FeeCnfg();
                    item.FeeCnfgID = Convert.ToInt32(sdr["FeeCnfgID"]);
                    item.StudentID = Convert.ToInt32(sdr["FeeCnfgID"]);
                    item.Amount = Convert.ToDecimal(sdr["StudentID"].ToString());
                    item.Status = Convert.ToBoolean(sdr["Status"]);

                    feeCnfgCol.Add(item);
                }
                sdr.Close();
                con.Close();

                return feeCnfgCol;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public FeeCnfg GetStudentFeeCnfg(int studentid)
        {
            try
            {
                FeeCnfg item = new FeeCnfg();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_FEE_CNFG_S1";
                command.Parameters.AddWithValue("@studentid", studentid);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    item.FeeCnfgID = Convert.ToInt32(sdr["FeeCnfgID"]);
                    item.StudentID = Convert.ToInt32(sdr["StudentID"]);
                    item.Amount = Convert.ToDecimal(sdr["Amount"].ToString());
                    item.Status = Convert.ToBoolean(sdr["Status"]);
                }
                sdr.Close();
                con.Close();

                return item;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<FeeMonths> GetFeesMonthList()
        {
            List<FeeMonths> feeMonths = new List<FeeMonths>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_MONTHS_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    FeeMonths item = new FeeMonths();
                    item.Id = Convert.ToInt32(sdr["MonthID"]);
                    item.Month = sdr["Month"].ToString();

                    feeMonths.Add(item);
                }
                sdr.Close();
                con.Close();

                return feeMonths;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void SaveBankRecipt(int reciptno)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into FeeRecords VALUES(@recipt)", con);
            cmd.Parameters.AddWithValue("@recipt", reciptno);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int SubmitFee(FeesModel f)
        {
            //Implementation-Pending
            int res = 0;
            SqlCommand cmd = new SqlCommand("SMS_FEES_I", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studentid", f.StudentID);
            cmd.Parameters.AddWithValue("@datetime", f.SubmitDateTime);
            //Validate at UI paidAmount cant be null
            cmd.Parameters.AddWithValue("@paidfee", Convert.ToDecimal(f.PaidAmount));
            cmd.Parameters.AddWithValue("@rem", Convert.ToDecimal(f.Balance));
            cmd.Parameters.AddWithValue("@monthid", f.Month);
            cmd.Parameters.AddWithValue("@year", f.Year);
            cmd.Parameters.AddWithValue("@day", f.Day);
            cmd.Parameters.AddWithValue("@userid", f.SubmittedByUserID);

            con.Open();
            SqlDataReader sda = cmd.ExecuteReader();
            while (sda.Read())
            {
                res = Convert.ToInt32(sda["Id"]);
            }
            con.Close();

            return res;
        }
        public int SubmitFees(FeesPaidDetail f, bool IsStudent)
        {
            //Implementation-Pending
            int res = 0;
            SqlCommand cmd;
            if (IsStudent)
            {
                cmd = new SqlCommand("SMS_FEES_PAID_I", con);
            }
            else
            {
                cmd = new SqlCommand("SMS_SLRY_PAID_I", con);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invoiceid", f.InvoiceID);
            cmd.Parameters.AddWithValue("@datetime", Convert.ToDateTime(f.PaidDate));
            //Validate at UI paidAmount cant be null
            cmd.Parameters.AddWithValue("@paidamount", Convert.ToDecimal(f.PaidAmount));

            con.Open();
            SqlDataReader sda = cmd.ExecuteReader();
            while (sda.Read())
            {
                res = Convert.ToInt32(sda["Id"]);
            }
            con.Close();

            return res;
        }
        public bool LogIn(string userName, string password)
        {
            SqlCommand cmd = new SqlCommand("select userName, pasword from UserAdress where UserName=@user and pasword =@pass", con);
            cmd.Parameters.AddWithValue("@user", userName);
            cmd.Parameters.AddWithValue("@pass", password);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            string fetchedUserName, fetchedPassword;
            try
            {
                if (!sdr.HasRows)
                    return false;
                while (sdr.Read())
                {
                    fetchedUserName = Convert.ToString(sdr["userName"]);
                    fetchedPassword = Convert.ToString(sdr["pasword"]);
                    if (string.IsNullOrEmpty(fetchedUserName))
                        return false;
                }
                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Subject> GetSubjects(int ClassId)
        {
            List<Subject> Subjects = new List<Subject>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SUBJECT_S1";
                command.Parameters.AddWithValue("@classid", ClassId);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Subject item = new Subject();
                    item.Id = Convert.ToInt32(sdr["ID"]);
                    item.ClassID = Convert.ToInt32(sdr["classid"]);
                    item.SName = sdr["SubjectTitle"].ToString();

                    Subjects.Add(item);
                }
                sdr.Close();
                con.Close();

                return Subjects;
            }
            catch (Exception ex)
            {
                return null;
            }




            //SqlCommand cmd = new SqlCommand("SMS_SUBJECT_S1", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@classid", ClassId);
            //DataTable dt = new DataTable();
            //con.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();
            //return dt;
        }
    }
    public class FeeSubmitReturnParam
    {
        public int FeeID { get; set; }
    }
    public class FeesModel
    {
        public int FeeID { get; set; }
        public int StudentID { get; set; }
        public bool isPaid { get; set; }
        public decimal IssuedAmount { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public string INSR_DTE { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public string SubmitDateTime { get; set; }
        public string SubmittedBy { get; set; }
        public int SubmittedByUserID { get; set; }
        public string ReceiptNumber { get; set; }
    }
    public class FeesInvoiceDetail
    {
        //public FeesInvoiceDetail()
        //{
        //    this.RcblDetail = new List<FeesPaidDetail>();
        //}
        public int InvoiceID { get; set; }
        public int StudentID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime INSR_DTE { get; set; }
        public decimal InvoiceAmount { get; set; }
        public bool Status { get; set; }
        //public List<FeesPaidDetail> RcblDetail { get; set; }
    }
    public class FeesPaidDetail
    {
        public int RcblID { get; set; }
        public int InvoiceID { get; set; }
        public DateTime PaidDate { get; set; }
        public decimal PaidAmount { get; set; }

    }
    public class FeeDetailEntity
    {
        public decimal Receivables { get; set; }
        public decimal Paid { get; set; }
        public decimal Outstandings { get; set; }
    }
}
