using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class EmployeeClass : DBContext
    {
        SqlConnection con;
        public EmployeeClass()
        {
            con = new SqlConnection(GetDBConnection());
        }
        public List<EmployeeProp> GetTeachers()
        {
            List<EmployeeProp> Teachers = new List<EmployeeProp>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_EMPLOYEES_S3";
                command.Parameters.AddWithValue("@roleid", (int)SystemRole.Teacher);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    EmployeeProp item = new EmployeeProp();
                    item.ID = Convert.ToInt32(sdr["EmployeeID"]);
                    item.empName = Convert.ToString(sdr["FirstName"]) + " " + Convert.ToString(sdr["SecondName"]);

                    Teachers.Add(item);
                }
                sdr.Close();
                con.Close();

                return Teachers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int GetEmployeeCount()
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
                command.CommandText = "SMS_EMPLOYEES_COUNT";

                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    count = Convert.ToInt32(sdr["Employees"]);
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
        public DataTable GetEmployeesList(int pageNumber = 0, int Pagesize = 10)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_EMPLOYEES_S0";
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

            //SqlCommand cmd = new SqlCommand("Select Id,FirstName,LastName,Email,Department,EmployeeId from Employee where isDeleted=0", con);
            //DataTable dt = new DataTable();
            //con.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();
            //return dt;
        }
        public DataTable GetAttendanceReport(int stdid, int subject)
        {
            SqlCommand cmd = new SqlCommand("select Date,Status from StudentAttendance where StdId=@stdid and SubjectId=@subject", con);
            cmd.Parameters.AddWithValue("@stdid", stdid);
            cmd.Parameters.AddWithValue("@subject", subject);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetStudList()
        {
            SqlCommand cmd = new SqlCommand("Select ID,SName,RollNo,ct.ClassName,Address,c.CityName from StudentTable as st inner join ClassTable as ct on st.Class=ct.ClassID inner join Cities as c on st.City=c.CityID where st.isDeleted=0", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public EmployeeView ViewEmployeeInfo(int id)
        {
            EmployeeView emp = new EmployeeView();

            SqlCommand cmd = new SqlCommand("SMS_EMPLOYEES_S1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                emp.FirstName = Convert.ToString(sdr["FirstName"]);
                emp.LastName = Convert.ToString(sdr["SecondName"]);
                emp.EmpId = Convert.ToString(sdr["EmployeeNumber"]);
                emp.CNIC = Convert.ToString(sdr["Email"]);
                emp.Phone = Convert.ToString(sdr["Contact"]);
                emp.DOB = Convert.ToString(sdr["CNIC"]);
                emp.Email = Convert.ToString(sdr["DOB"]);
                emp.PictureName = Convert.ToString(sdr["UserName"]);
                emp.PictureName = Convert.ToString(sdr["BloodID"]);
                emp.PictureName = Convert.ToString(sdr["Gender"]);
                emp.PictureName = Convert.ToString(sdr["Address"]);
                emp.PictureName = Convert.ToString(sdr["salary"]);
            }
            con.Close();
            return emp;
        }
        public EmployeeProp GetEmployeeProfile(int id)
        {
            EmployeeProp Eobj = new EmployeeProp();

            SqlCommand cmd = new SqlCommand("SMS_EMPLOYEES_S1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Eobj.FirstName = Convert.ToString(sdr["FirstName"]);
                Eobj.LastName = Convert.ToString(sdr["SecondName"]);
                //Eobj.CityName = Convert.ToString(sdr["CityName"]);
                Eobj.Phone = Convert.ToInt64(sdr["Contact"]);
                Eobj.Email = Convert.ToString(sdr["Email"]);
                Eobj.user.UserName = Convert.ToString(sdr["UserName"]);
                Eobj.CNIC = Convert.ToInt64(sdr["CNIC"]);
                Eobj.BloodID = Convert.ToInt32(sdr["BloodID"]);
                Eobj.GenderID = Convert.ToInt32(sdr["Gender"]);
                Eobj.Salary = Convert.ToInt32(sdr["salary"]);
                //Eobj.Dept = Convert.ToString(sdr["Department"]);
                //Eobj.Qualification = Convert.ToString(sdr["Qualification"]);
                Eobj.EmpId = Convert.ToString(sdr["EmployeeNumber"]);
                Eobj.DOB = Convert.ToDateTime(sdr["DOB"]);
                Eobj.Address = Convert.ToString(sdr["Address"]);
                //Eobj.Desc = Convert.ToString(sdr["Description"]);
                //Eobj.PictureName = Convert.ToString(sdr["PictureName"]);

                //Eobj.EmpId = Convert.ToInt32(sdr["EmployeeTypeId"]);

                Eobj.isActive = Convert.ToBoolean(sdr["isActive"]);
                //Eobj.Type = Convert.ToString(sdr["Type"]);
            }
            con.Close();
            return Eobj;
        }
        public DataTable GetChildrenFromParentId(int id)
        {
            SqlCommand cmd = new SqlCommand("Select s.ID,s.SName,s.FName,s.ROllNo,c.ClassName from StudentTable as s inner join ClassTable as c on s.Class=c.ClassID where s.isDeleted=0 And s.ParentId=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public ParentProp GetParentProfile(int id)
        {
            SqlCommand cmd = new SqlCommand("Select p.FirstName,p.LastName,ct.CityName,p.Phone,p.Email,p.CNIC,p.Gender,p.Address from Parents as p inner join Cities as ct on p.CityId=ct.CityId where p.Id=@ID AND isDeleted=0", con);
            cmd.Parameters.AddWithValue("@ID", id);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            ParentProp obj = new ParentProp();
            while (sdr.Read())
            {
                obj.FirstName = Convert.ToString(sdr["FirstName"]);
                obj.LastName = Convert.ToString(sdr["LastName"]);
                obj.CNIC = Convert.ToInt64(sdr["CNIC"]);
                obj.CityName = Convert.ToString(sdr["CityName"]);
                obj.Email = Convert.ToString(sdr["Email"]);
                obj.Phone = Convert.ToInt64(sdr["phone"]);
                obj.Gender = Convert.ToString(sdr["Gender"]);
                obj.Address = Convert.ToString(sdr["Address"]);
            }
            con.Close();
            return obj;
        }
        public EmployeeProp GetEmployeeInfo(int id)
        {

            SqlCommand cmd = new SqlCommand("SMS_EMPLOYEES_S1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            EmployeeProp Eobj = new EmployeeProp();
            while (sdr.Read())
            {
                Eobj.ID = Convert.ToInt32(sdr["EmployeeID"]);
                Eobj.FirstName = Convert.ToString(sdr["FirstName"]);
                Eobj.LastName = Convert.ToString(sdr["SecondName"]);
                Eobj.EmpId = Convert.ToString(sdr["EmployeeNumber"]);
                Eobj.user.UserName = Convert.ToString(sdr["UserName"]);
                Eobj.Email = Convert.ToString(sdr["Email"]);
                //Eobj.City = Convert.ToInt32(sdr["CityId"]);
                Eobj.Phone = Convert.ToInt64(sdr["Contact"]);
                Eobj.CNIC = Convert.ToInt64(sdr["CNIC"]);
                Eobj.BloodID = Convert.ToInt32(sdr["BloodID"]);
                Eobj.isActive = Convert.ToBoolean(sdr["isActive"]);
                decimal checkIfInterger;
                if (sdr["salary"].ToString() != null && Decimal.TryParse(sdr["salary"].ToString(), out checkIfInterger))
                {
                    Eobj.Salary = Convert.ToDecimal(sdr["salary"]);
                }
                else
                {
                    Eobj.Salary = 0;
                }
                Eobj.GenderID = Convert.ToInt32(sdr["GenderID"]);
                Eobj.Qualification = Convert.ToString(sdr["Qualification"]);
                Eobj.Dept = Convert.ToString(sdr["Department"]);
                //Correct it - exception
                try
                {
                    Eobj.DOB = Convert.ToDateTime(sdr["DOB"]);

                }
                catch (Exception)
                {

                    Eobj.DOB = DateTime.Now;
                }
                Eobj.Address = Convert.ToString(sdr["Address"]);
                Eobj.Tag = Convert.ToInt32(sdr["EmpType"]);
                Eobj.Title = Convert.ToString(sdr["EmpTitle"]);
                Eobj.Address = Convert.ToString(sdr["Address"]);
                Eobj.Desc = Convert.ToString(sdr["Dsc"]);
                //Eobj.PictureName = Convert.ToString(sdr["PictureName"]);
            }
            con.Close();
            return Eobj;
        }
        public DataTable SearchEmployeeList(string textToSearch, int FilterId)
        {
            SqlCommand cmd;
            int checkIfInterger;
            if (int.TryParse(textToSearch, out checkIfInterger))
            {
                cmd = new SqlCommand("SELECT Id,FirstName,LastName,Email,Department,EmployeeId FROM Employee WHERE FirstName = @text AND EmployeeTypeId=@id AND IsDeleted=0 ", con);
            }
            else
            {
                cmd = new SqlCommand("SELECT  Id,FirstName,LastName,Email,Department,EmployeeId FROM Employee WHERE EmployeeTypeId=@id AND IsDeleted=0 AND FirstName LIKE '%'+@text+'%'", con);
            }

            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@text", textToSearch);
            cmd.Parameters.AddWithValue("@id", FilterId);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable SearchEmployeeList(int FilterId)
        {
            SqlCommand cmd = new SqlCommand("SELECT  Id,FirstName,LastName,Email,Department,EmployeeId FROM Employee WHERE EmployeeTypeId=@id AND IsDeleted=0", con);

            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@id", FilterId);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable SearchEmployeesList(string _empName = "", int _filterid = 0)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_EMPLOYEES_S4";
                if (_empName != "")
                {
                    command.Parameters.AddWithValue("@empname", _empName);
                }
                if (_filterid > 0)
                {
                    command.Parameters.AddWithValue("@filterid", _filterid);
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
        public List<EmployeeProp> SearchEmployeesListForSalary(string textToSearch)
        {
            List<EmployeeProp> Employees = new List<EmployeeProp>();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_EMPLOYEES_S4", con);
                cmd.CommandType = CommandType.StoredProcedure;
                int checkIfInterger;

                cmd.Parameters.AddWithValue("@empname", textToSearch);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    EmployeeProp item = new EmployeeProp();
                    item.ID = Convert.ToInt32(sdr["Id"]);
                    item.FirstName = sdr["FirstName"].ToString();
                    item.LastName = sdr["SecondName"].ToString();
                    item.Email = sdr["Email"].ToString();
                    item.Phone = Convert.ToInt64( sdr["Contact"]);
                    item.CNIC = Convert.ToInt64(sdr["CNIC"]);
                    item.Dept = sdr["Department"].ToString();
                    item.EmpId = sdr["EmployeeId"].ToString();
                    item.isActive = Convert.ToBoolean( sdr["isActive"]);

                    Employees.Add(item);
                }
                sdr.Close();
                con.Close();
                return Employees;
            }
            catch (Exception)
            {
                return Employees;
            }
        }
        public DataTable SearchEmployeeList(string textToSearch)
        {
            SqlCommand cmd;
            int checkIfInterger;
            if (int.TryParse(textToSearch, out checkIfInterger))
            {
                cmd = new SqlCommand("SELECT Id,FirstName,LastName,Email,Department,EmployeeId FROM Employee WHERE EmployeeTypeId=@text AND IsDeleted=0", con);
            }
            else
            {
                cmd = new SqlCommand("SELECT  Id,FirstName,LastName,Email,Department,EmployeeId FROM Employee WHERE IsDeleted=0 AND FirstName LIKE '%'+@text+'%'", con);
            }

            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@text", textToSearch);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public void UpdateStudent(EmployeeProp empObj, int Id)
        {
            SqlCommand cmd = new SqlCommand("SMS_EMPLOYEES_U", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empID", Id);
            cmd.Parameters.AddWithValue("@UserName", empObj.user.UserName);
            cmd.Parameters.AddWithValue("@FirstName", empObj.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", empObj.LastName);
            cmd.Parameters.AddWithValue("@EmployeeNumber", empObj.EmpId);
            cmd.Parameters.AddWithValue("@Email", empObj.Email);
            cmd.Parameters.AddWithValue("@Contact", empObj.Phone);
            cmd.Parameters.AddWithValue("@DOB", empObj.DOB);
            //cmd.Parameters.AddWithValue("@city", empObj.City);
            cmd.Parameters.AddWithValue("@BloodID", empObj.BloodID);
            cmd.Parameters.AddWithValue("@Gender", empObj.GenderID);
            cmd.Parameters.AddWithValue("@isactive", empObj.isActive);
            cmd.Parameters.AddWithValue("@CNIC", empObj.CNIC);
            cmd.Parameters.AddWithValue("@Address", empObj.Address);
            cmd.Parameters.AddWithValue("@qualification", empObj.Qualification);
            //cmd.Parameters.AddWithValue("@address", empObj.Address);
            cmd.Parameters.AddWithValue("@dept", empObj.Dept);
            cmd.Parameters.AddWithValue("@empType", empObj.Tag);
            cmd.Parameters.AddWithValue("@desc", empObj.Desc);
            //cmd.Parameters.AddWithValue("@picname", empObj.PictureName);
            //cmd.Parameters.AddWithValue("@etypeid", empObj.Tag);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Record...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteEmployee(int ID)
        {
            SqlCommand cmd = new SqlCommand("Update Employee set IsDeleted=1 where EmployeeID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted Record", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InsertEmployee(EmployeeProp TempObj)
        {
            // put InsertEmployee ProcCall
            SqlCommand cmd = new SqlCommand("SMS_EMPLOYEES_I", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserName", TempObj.user.UserName);
            cmd.Parameters.AddWithValue("@FirstName", TempObj.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", TempObj.LastName);
            //cmd.Parameters.AddWithValue("@EmployeeNumber", TempObj.EmpId);
            cmd.Parameters.AddWithValue("@EmployeeNumber", String.Empty);
            //cmd.Parameters.AddWithValue("@Email", TempObj.Email);
            cmd.Parameters.AddWithValue("@Email", String.Empty);
            cmd.Parameters.AddWithValue("@Contact", TempObj.Phone);
            cmd.Parameters.AddWithValue("@DOB", TempObj.DOB);
            if (TempObj.BloodID == null)
            {
                cmd.Parameters.AddWithValue("@BloodID", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@BloodID", TempObj.BloodID);
            }
            cmd.Parameters.AddWithValue("@Gender", TempObj.GenderID);
            cmd.Parameters.AddWithValue("@isactive", TempObj.isActive);
            cmd.Parameters.AddWithValue("@CNIC", TempObj.CNIC);
            cmd.Parameters.AddWithValue("@Address", TempObj.Address);
            cmd.Parameters.AddWithValue("@schoolid", TempObj.user.school.SchoolID);
            cmd.Parameters.AddWithValue("@emptype", TempObj.Tag);
            cmd.Parameters.AddWithValue("@dsc", TempObj.Desc);
            //cmd.Parameters.AddWithValue("@salary_amt", TempObj.Salary);
            //cmd.Parameters.AddWithValue("@RoleID", TempObj.RoleID);
            cmd.Parameters.AddWithValue("@dept", TempObj.Dept);
            cmd.Parameters.AddWithValue("@qualification", TempObj.Qualification);
            //cmd.Parameters.AddWithValue("@addres", TempObj.Address);
            //cmd.Parameters.AddWithValue("@desc", TempObj.Desc);
            //cmd.Parameters.AddWithValue("@picname", TempObj.PictureName);
            //cmd.Parameters.AddWithValue("@etypeid", Convert.ToInt32(TempObj.Tag));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("New Employee Inserted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<EmpTag> GetTags()
        {
            List<EmpTag> Tags = new List<EmpTag>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_EMPLOYEES_TYPE_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    EmpTag item = new EmpTag();
                    item.TagName = Convert.ToString(sdr["Type"]);
                    item.Id = Convert.ToInt32(sdr["id"]);

                    Tags.Add(item);
                }
                sdr.Close();
                con.Close();

                return Tags;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable SearchStudentList(int FilterId)
        {
            SqlCommand cmd = new SqlCommand("SELECT ID,SName,RollNo,ct.ClassName,Address,c.CityName FROM StudentTable as st inner join ClassTable as ct on st.Class=ct.ClassID inner join Cities as c on st.City=c.CityID WHERE Class = @text", con);

            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@text", FilterId);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable GetEmployeeAttendanceSummary(int id)
        {
            SqlCommand cmd = new SqlCommand("select Date,Status from EmpAttendance where EmpId=@id", con);

            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable SearchStudentList(string textToSearch, int FilterId)
        {
            SqlCommand cmd;
            int checkIfInterger;
            if (int.TryParse(textToSearch, out checkIfInterger))
            {
                cmd = new SqlCommand("SELECT st.StudentID , u.FirstName,st.RollNo,ct.ClassName,null as 'Address',c.CityName FROM Student as st inner join Class as ct on st.ClassID=ct.ClassID left join Cities as c on st.city=c.CityID inner join Users u on u.UserID=st.UserID WHERE st.ClassID=@id AND s.RollNo=@text", con);
            }
            else
            {
                cmd = new SqlCommand(@"SELECT st.StudentID , u.FirstName,st.RollNo,ct.ClassName,null as 'Address',c.CityName FROM Student as st inner join Class as ct on st.ClassID=ct.ClassID left join Cities as c on st.city=c.CityID inner join Users u on u.UserID=st.UserID WHERE st.ClassID=@id AND u.FirstName like '%'+@text+'%'", con);
            }

            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@text", textToSearch);
            cmd.Parameters.AddWithValue("@id", FilterId);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public EmployeeProp CheckLogin(EmployeeProp emp)
        {
            SqlCommand cmd = new SqlCommand("Select E.Id,FirstName+' '+Lastname AS Name, Email, Department, EmployeeId,ET.Type, c.CityName from Employee AS E Inner join EmpType AS ET ON E.EmployeeTypeID=ET.id inner join Cities as c on e.CityId=c.CityID Where Email=@email", con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.Parameters.AddWithValue("@email", emp.Email);
            //cmd.Parameters.AddWithValue("@cnic", emp.CNIC);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    emp.ID = Convert.ToInt32(sdr["Id"]);
                    emp.empName = Convert.ToString(sdr["Name"]);
                    emp.Email = Convert.ToString(sdr["Email"]);
                    emp.Dept = Convert.ToString(sdr["Department"]);
                    emp.EmpId = Convert.ToString(sdr["EmployeeId"]);
                    emp.FirstName = Convert.ToString(sdr["Type"]);
                    emp.CityName = Convert.ToString(sdr["CityName"]);
                }
            }
            else
            {
                emp.ID = 0;
                MessageBox.Show("Invalid login", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return emp;
        }
        public void MarkAttendance(Attendance et, int id)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO EmpAttendance(EmpId,Date,Status)VALUES(@empid,@date,@status)", con);
            cmd.Parameters.AddWithValue("@date", et.date);
            cmd.Parameters.AddWithValue("@status", et.status);
            cmd.Parameters.AddWithValue("@empid", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Attendance Marked", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public children GetChildrenInfo(int StdId)
        {
            SqlCommand cmd = new SqlCommand("select st.SName,ct.ClassName,e.FirstName+' '+e.LastName as Teacher ,S.Section from StudentTable as st inner join ClassTable as ct on st.Class=ct.ClassID inner join Employee as e on ct.TID=e.Id inner join Sections as s on st.Section=s.id where st.isDeleted=0 and st.ID=@id", con);
            cmd.Parameters.AddWithValue("@id", StdId);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            children ch = new children();
            while (sdr.Read())
            {
                ch.ChildName = Convert.ToString(sdr["SName"]);
                ch.ClassName = Convert.ToString(sdr["ClassName"]);
                ch.SectionName = Convert.ToString(sdr["Teacher"]);
                ch.TeacherName = Convert.ToString(sdr["Section"]);
            }
            con.Close();
            return ch;
        }
        //public SalaryCnfg GetEmployeeSalaryCnfg(int empID)
        //{
        //    try
        //    {
        //        FeeCnfg item = new FeeCnfg();
        //        SqlCommand command = new SqlCommand();

        //        command.Connection = con;
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.CommandText = "SMS_FEE_CNFG_S1";
        //        command.Parameters.AddWithValue("@studentid", studentid);

        //        con.Open();
        //        SqlDataReader sdr = command.ExecuteReader();
        //        while (sdr.Read())
        //        {
        //            item.FeeCnfgID = Convert.ToInt32(sdr["FeeCnfgID"]);
        //            item.StudentID = Convert.ToInt32(sdr["StudentID"]);
        //            item.Amount = Convert.ToDecimal(sdr["Amount"].ToString());
        //            item.Status = Convert.ToBoolean(sdr["Status"]);
        //        }
        //        sdr.Close();
        //        con.Close();

        //        return item;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        public List<SalaryCnfg> GetSalaryCnfg(int _id)
        {
            List<SalaryCnfg> salaryCnfg = new List<SalaryCnfg>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SLRY_CNFG_S2";
                command.Parameters.AddWithValue("@empid", _id);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    SalaryCnfg item = new SalaryCnfg();
                    item.SalaryCnfgID = Convert.ToInt32(sdr["SalaryCnfgID"]);
                    item.EmployeeID = Convert.ToInt32(sdr["EmployeeID"]);
                    item.Amount = Convert.ToDecimal(sdr["Amount"]);
                    item.Status = Convert.ToBoolean(sdr["Status"]);

                    salaryCnfg.Add(item);
                }
                sdr.Close();
                con.Close();

                return salaryCnfg;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void InsertSalaryCnfg(SalaryCnfg c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SLRY_CNFG_I", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@amount", c.Amount);
                cmd.Parameters.AddWithValue("@empid", c.EmployeeID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public List<EmployeeProp> SearchEmployeesList(string textToSearch)
        //{
        //    List<EmployeeProp> Employees = new List<EmployeeProp>();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("SMS_STUDENT_S2", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        int checkIfInterger;

        //        if (int.TryParse(textToSearch, out checkIfInterger))
        //        {
        //            cmd.Parameters.AddWithValue("@isRollNumSearch", true);
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@isRollNumSearch", false);
        //        }
        //        cmd.Parameters.AddWithValue("@text", textToSearch);
        //        con.Open();
        //        SqlDataReader sdr = cmd.ExecuteReader();
        //        while (sdr.Read())
        //        {
        //            EmployeeProp item = new EmployeeProp();
        //            item.stdID = Convert.ToInt32(sdr["StudentID"]);
        //            item.FatherName = sdr["FName"].ToString();
        //            item.Name = sdr["FirstName"].ToString();
        //            //item.SecondName = sdr["SecondName"].ToString();
        //            item.Roll = Convert.ToInt32(sdr["RollNo"].ToString());
        //            item.Class = sdr["ClassName"].ToString();
        //            item.ClassId = Convert.ToInt32(sdr["ClassID"]);
        //            item.SectionId = Convert.ToInt32(sdr["SectionID"]);
        //            item.Section = sdr["SectionName"].ToString();
        //            item.Contact1 = sdr["Contact1"].ToString();
        //            //item.Dsc = sdr["Dsc"].ToString();
        //            //item.City = sdr["CityName"].ToString();

        //            Employees.Add(item);
        //        }
        //        sdr.Close();
        //        con.Close();
        //        return Employees;
        //    }
        //    catch (Exception)
        //    {
        //        return Employees;
        //    }
        //}
        public FeeDetailEntity GetSalaryDetailEntity(int Mode, int InvcID = 0, int _eID = 0)
        {
            FeeDetailEntity item = new FeeDetailEntity();

            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SLRY_CNFG_S3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoiceid", InvcID);
                cmd.Parameters.AddWithValue("@empid", _eID);
                cmd.Parameters.AddWithValue("@mode", Mode);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    item.Receivables = Convert.ToDecimal(sdr["Receivables"]);
                    item.Paid = Convert.ToDecimal(sdr["Paid"]);
                    item.Outstandings = Convert.ToDecimal(sdr["Outstandings"]);
                }
                sdr.Close();
                //dt.Load(sdr);
                con.Close();
                return item;
            }
            catch (Exception)
            {
                return new FeeDetailEntity();
            }
        }
        public List<SalaryInvoiceDetail> IsSlryInvcExists(int eID, DateTime d)
        {
            List<SalaryInvoiceDetail> SlryInvoices = new List<SalaryInvoiceDetail>();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SLRY_INVC_S2";
                command.Parameters.AddWithValue("@empid", eID);
                command.Parameters.AddWithValue("@invcdte", d.Date);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    SalaryInvoiceDetail item = new SalaryInvoiceDetail();
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.EmpID = Convert.ToInt32(sdr["EmpID"]);
                    item.InvoiceDate = Convert.ToDateTime(sdr["INVC_DTE"]);
                    item.InvoiceAmount = Convert.ToDecimal(sdr["Amount"]);
                    item.Status = Convert.ToBoolean(sdr["Status"]);
                    item.INSR_DTE = Convert.ToDateTime(sdr["INSR_DTE"]);

                    SlryInvoices.Add(item);
                }
                sdr.Close();
                con.Close();

                return SlryInvoices;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<SalaryInvoiceDetail> SalaryInvoiceDetails(int eID)
        {
            List<SalaryInvoiceDetail> fees = new List<SalaryInvoiceDetail>();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SLRY_INVC_S1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", eID);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    SalaryInvoiceDetail item = new SalaryInvoiceDetail();
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.EmpID = Convert.ToInt32(sdr["EmpID"]);
                    item.InvoiceDate = Convert.ToDateTime(sdr["InvcDate"]);
                    item.InvoiceAmount = Convert.ToDecimal(sdr["InvcAmount"]);
                    item.Comments = sdr["Comments"].ToString();
                    item.Status = Convert.ToBoolean(sdr["Status"]);

                    fees.Add(item);
                }
                sdr.Close();
                con.Close();
                return fees;
            }
            catch (Exception)
            {
                return new List<SalaryInvoiceDetail>();
            }
        }
        public SalaryInvoiceDetail GetInvoiceByID(int InvoiceID)
        {
            SalaryInvoiceDetail item = new SalaryInvoiceDetail();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SLRY_INVC_S3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoiceid", InvoiceID);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.EmpID = Convert.ToInt32(sdr["EmpID"]);
                    item.InvoiceDate = Convert.ToDateTime(sdr["InvcDate"]);
                    item.InvoiceAmount = Convert.ToDecimal(sdr["InvcAmount"]);
                    item.Comments = sdr["Comments"].ToString();
                    item.Status = Convert.ToBoolean(sdr["Status"]);
                }
                sdr.Close();
                con.Close();
                return item;
            }
            catch (Exception)
            {
                return new SalaryInvoiceDetail();
            }
        }
    }
}
public class SalaryInvoiceDetail
{
    //public FeesInvoiceDetail()
    //{
    //    this.RcblDetail = new List<FeesPaidDetail>();
    //}
    public int InvoiceID { get; set; }
    public int EmpID { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime INSR_DTE { get; set; }
    public decimal InvoiceAmount { get; set; }
    public bool Status { get; set; }
    public string Comments { get; set; }
    //public List<FeesPaidDetail> RcblDetail { get; set; }
}
public class children
{
    public string ChildName { get; set; }
    public string ClassName { get; set; }
    public string SectionName { get; set; }
    public string TeacherName { get; set; }
}
public class EmployeeProp
{
    public EmployeeProp()
    {
        this.user = new Users();
    }
    public Users user { get; set; }
    public bool isActive { get; set; }
    public int ID { get; set; }
    public int RoleID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string empName { get; set; }
    public string Address { get; set; }
    public int City { get; set; }
    public string CityName { get; set; }
    public string BloodGroup { get; set; }
    public int BloodID { get; set; }
    public DateTime DOB { get; set; }
    public string PictureName { get; set; }
    public string Email { get; set; }
    public string Dept { get; set; }
    public string Type { get; set; }
    public Decimal Salary { get; set; }
    public Int64 CNIC { get; set; }
    public string Qualification { get; set; }
    public Int64 Phone { get; set; }
    public int Tag { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public string Gender { get; set; }
    public int GenderID { get; set; }
    public string EmpId { get; set; }
}
public class ParentProp
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public int City { get; set; }
    public string CityName { get; set; }
    public string Email { get; set; }
    public Int64 CNIC { get; set; }
    public Int64 Phone { get; set; }
    public string Gender { get; set; }
}
public class EmployeeView
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DOB { get; set; }
    public string PictureName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string CNIC { get; set; }
    public string Tag { get; set; }
    public string EmpId { get; set; }

}

public class EmpTag
{
    public string TagName { get; set; }
    public int Id { get; set; }

}
public class SalaryCnfg
{
    public int SalaryCnfgID { get; set; }
    public int EmployeeID { get; set; }
    public decimal Amount { get; set; }
    public bool Status { get; set; }
}
