using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class SubjectDAL : DBContext
    {
        SqlConnection con;
        public SubjectDAL()
        {
            con = new SqlConnection(base.connectionstring);
        }
        public List<Subject> GetSubject()
        {
            List<Subject> Subjects = new List<Subject>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SUBJECT_S0";

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
        }
        public DataTable GetSubject(int id)
        {
            SqlCommand cmd = new SqlCommand("select s.Id,s.SubjectTitle from StudentTable as st inner join ClassTable as c on st.Class=c.ClassID inner join Subjects as s on c.ClassID=s.ClassId where st.ID=@id", con);
            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public List<Subject> GetSubjectsByClassId(int classId)
        {
            List<Subject> sbjct = new List<Subject>();
            SqlCommand cmd = new SqlCommand("Select Id,SubjectTitle from Subjects where classid=@id And IsDeleted=0", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", classId);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Subject s = new Subject();

                s.Id = Convert.ToInt32(sdr["ID"]);
                s.SName = Convert.ToString(sdr["SubjectTitle"]);
                sbjct.Add(s);
            }

            con.Close();
            return sbjct;

        }

        public DataTable GetCurriculum(curriculum c)
        {

            SqlCommand cmd = new SqlCommand("Select Id,Curriculum from Curriculum where ClassId=@class AND SubjectId=@Sub And SectionId=@Sec", con);
            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@class", c.ClassId);
            cmd.Parameters.AddWithValue("@Sub", c.SubjectId);
            cmd.Parameters.AddWithValue("@Sec", c.SectionId);

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }
        public void newsubjest(string subject, int classid)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Subjects ([ClassId],[SubjectTitle])VALUES(@classid,@subject)", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@Classid", classid);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void SaveCurriculum(curriculum c)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Curriculum(ClassId,SubjectId,SectionId,Curriculum)VALUES(@classid,@subject,@section,@curlum)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@classid", c.ClassId);
            cmd.Parameters.AddWithValue("@subject", c.SubjectId);
            cmd.Parameters.AddWithValue("@section", c.SectionId);
            cmd.Parameters.AddWithValue("@Curlum", c.Curriculum);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateCurriculum(curriculum c, int ID)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Curriculum set ClassId=@classid,SubjectId=@subject,SectionId=@section,Curriculum=@curlum where id=@id", con);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@classid", c.ClassId);
            cmd.Parameters.AddWithValue("@subject", c.SubjectId);
            cmd.Parameters.AddWithValue("@section", c.SectionId);
            cmd.Parameters.AddWithValue("@Curlum", c.Curriculum);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteCurriculum(int ID)
        {
            SqlCommand cmd = new SqlCommand("delete from Curriculum where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
