using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class ClassDAL : DBContext
    {
        SqlConnection con;

        public ClassDAL()
        {
            con = new SqlConnection(GetDBConnection());
        }
        public List<SchoolClass> GetClasses()
        {

            List<SchoolClass> classess = new List<SchoolClass>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_CLASS_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    SchoolClass item = new SchoolClass();
                    item.Id = Convert.ToInt32(sdr["ClassID"]);
                    item.CName = sdr["ClassName"].ToString();

                    classess.Add(item);
                }
                sdr.Close();
                con.Close();

                return classess;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<SchoolClass> GetClasses(int TID)
        {
            List<SchoolClass> classess = new List<SchoolClass>();
            SqlCommand cmd1 = new SqlCommand("Select [ClassID],[ClassName], [ClassFee],[TID] from ClassTable where IsDeleted=0 and TID=@tid", con);
            cmd1.Parameters.AddWithValue("@tid", TID);
            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                SchoolClass cl = new SchoolClass();
                cl.Id = Convert.ToInt32(sdr1["ClassId"]);
                cl.CName = Convert.ToString(sdr1["ClassName"]);
                cl.ClassFee = Convert.ToDecimal(sdr1["ClassFee"]);
                cl.TID = Convert.ToInt32(sdr1["TID"]);
                classess.Add(cl);
            }
            con.Close();
            return classess;
        }
        public DataTable GetTeacherClasses(int TID)
        {
            SqlCommand cmd1 = new SqlCommand("Select ct.ClassID,ct.ClassName,sec.Section,s.SubjectTitle from ClassTable As ct Left outer join Sections as sec on ct.ClassID=sec.Classid left outer join Subjects as s on ct.ClassID = s.ClassId where ct.IsDeleted=0 and ct.TID=1", con);
            cmd1.Parameters.AddWithValue("@tid", TID);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd1.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public void InsertClass(SchoolClass c)
        {
            SqlCommand cmd = new SqlCommand("SMS_CLASS_I", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassName", c.CName);
            //cmd.Parameters.AddWithValue("@ClassFee", c.ClassFee);
            //cmd.Parameters.AddWithValue("@tid", c.TID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateClass(SchoolClass s, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Class set ClassName=@cname where ClassID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            //cmd.Parameters.AddWithValue("@cFee", s.ClassFee);
            cmd.Parameters.AddWithValue("@cname", s.CName);
            //cmd.Parameters.AddWithValue("@tid", s.TID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateClass(int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Class set IsDeleted=1 where ClassID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public List<SectionClass> GetSections()
        {
            List<SectionClass> Sections = new List<SectionClass>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SECTION_S0";

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
        public void InsertSection(SectionClass s)
        {
            SqlCommand cmd = new SqlCommand("SMS_SECTION_I", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Sectionname", s.SecName);
            cmd.Parameters.AddWithValue("@classid", s.classid);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Inserted Successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateSection(SectionClass s, int id)
        {
            SqlCommand cmd = new SqlCommand("SMS_SECTION_U", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@sectionid", id);
            cmd.Parameters.AddWithValue("@Sectionname", s.SecName);
            cmd.Parameters.AddWithValue("@classid", s.classid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateSection(int id)
        {
            SqlCommand cmd = new SqlCommand("SMS_SECTION_D", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sectionid", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InsertSubject(Subject s)
        {
            SqlCommand cmd = new SqlCommand("INSERT into Subjects(SubjectTitle,ClassId) VALUES(@subject,@class)", con);
            cmd.Parameters.AddWithValue("@subject", s.SName);
            cmd.Parameters.AddWithValue("@class", s.Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateSubject(int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Subjects set IsDeleted=1 where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateSubject(Subject s, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Subjects set SubjectTitle=@subject,ClassId=@class where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@subject", s.SName);
            cmd.Parameters.AddWithValue("@class", s.Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
