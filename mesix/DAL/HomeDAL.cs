using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HomeDAL : DBContext
    {

        SqlConnection con;//

        public HomeDAL()
        {
            con = new SqlConnection(connectionstring);
        }

        public List<Int32> GetAllCounts()
        {
            List<Int32> CountList = new List<Int32>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_ALL_COUNTS";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    int StudentCount = Convert.ToInt32(sdr["StudentCount"]);
                    sdr.NextResult();
                    sdr.Read();
                    int TeacherCount = Convert.ToInt32(sdr["TeacherCount"]);
                    sdr.NextResult();
                    sdr.Read();
                    int EmployeeCount = Convert.ToInt32(sdr["EmployeeCount"]);
                    CountList.Add(StudentCount);
                    CountList.Add(TeacherCount);
                    CountList.Add(EmployeeCount);
                }

                sdr.Close();
                con.Close();

                return CountList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable GetStClasses(int Class)
        {
            SqlCommand cmd = new SqlCommand("select Id,SubjectTitle from Subjects where ClassId =@class and IsDeleted=0", con);
            cmd.Parameters.AddWithValue("@class", Class);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public Roles IsValidAdmin(Roles Obj)
        {
            Obj.LoginId = 0;
            SqlCommand cmd = new SqlCommand("select Id from AdminLogin where Email=@email and Password=@pass and EmpType=2", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", Obj.Email);
            cmd.Parameters.AddWithValue("@pass", Obj.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Obj.LoginId = Convert.ToInt32(sdr["Id"]);
            }
            con.Close();
            return Obj;
        }

        public Roles IsValidStudent(Roles Obj)
        {
            Obj.LoginId = 0;
            SqlCommand cmd = new SqlCommand("select ID,SName+FName as 'Name',Class,Section from StudentTable where  Email=@email and Password=@pass", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", Obj.Email);
            cmd.Parameters.AddWithValue("@pass", Obj.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Obj.LoginId = Convert.ToInt32(sdr["Id"]);
                Obj.ClassId = Convert.ToInt32(sdr["Class"]);
                Obj.SectionId = Convert.ToInt32(sdr["Section"]);
                Obj.Name = Convert.ToString(sdr["Name"]);
            }
            con.Close();
            return Obj;
        }

        public Roles IsValidEmployee(Roles Obj)
        {
            Obj.LoginId = 0;
            SqlCommand cmd = new SqlCommand("select Id,FirstName,EmployeeTypeID from Employee where Email=@email and Password=@pass", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", Obj.Email);
            cmd.Parameters.AddWithValue("@pass", Obj.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Obj.LoginId = Convert.ToInt32(sdr["Id"]);
                Obj.Name = Convert.ToString(sdr["FirstName"]);
                Obj.EmpId = Convert.ToInt32(sdr["EmployeeTypeID"]);
            }
            con.Close();
            return Obj;
        }
        public Roles IsValidParents(Roles Obj)
        {
            Obj.LoginId = 0;
            SqlCommand cmd = new SqlCommand("select id,FirstName+LastName as 'Name' from Parents where  Email=@email and Password=@pass", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", Obj.Email);
            cmd.Parameters.AddWithValue("@pass", Obj.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Obj.LoginId = Convert.ToInt32(sdr["Id"]);
                Obj.Name = Convert.ToString(sdr["Name"]);
            }
            con.Close();
            return Obj;
        }
        public List<Roles> GetRoles()
        {
            List<Roles> RolesList = new List<Roles>();
            SqlCommand cmd = new SqlCommand("Select id,role from Roles", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                Roles rl = new Roles();

                rl.Id = Convert.ToInt32(sdr["id"]);
                rl.Role = Convert.ToString(sdr["role"]);
                RolesList.Add(rl);
            }
            con.Close();

            return RolesList;
        }

        public List<string> LoadGrammarAndCommands()
        {
            try
            {
                //string connectionstring = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                //SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandText = "SELECT LanguageData FROM GrammarDictionary";
                //sc.CommandType = CommandType.TableDirect;
                SqlDataReader sdr = sc.ExecuteReader();
                //Grammar commandgrammar= new Grammar(new GrammarBuilder();
                List<string> AllData = new List<string>();
                while (sdr.Read())
                {
                    var Loadcmd = sdr["LanguageData"].ToString();
                    //commandgrammar = new Grammar(new GrammarBuilder(new Choices(Loadcmd)));
                    AllData.Add(Loadcmd);


                }
                sdr.Close();
                con.Close();
                return AllData;
            }
            catch (Exception ex)
            {
                return null;
                //Jarvis.SpeakAsync("I've detected an in valid entry in your web commands, possibly a blank line. web commands will case to work until it is fixed." + ex.Message);
            }
        }

        public Users ValidateLogin(string username, string password)
        {
            try
            {
                Users User = new Users();
                User.isAuthenticated = false;
                con.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_USER_AUTH_C1";

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    User.UserID = Convert.ToInt32(sdr["UserID"]);
                    User.RoleID = Convert.ToInt32(sdr["RoleID"]);
                    User.Role = sdr["Role"].ToString();
                    User.UserName = sdr["UserName"].ToString();
                    User.FirstName = sdr["FirstName"].ToString();
                    User.SecondName = sdr["SecondName"].ToString();
                    User.Email = sdr["Email"].ToString();
                    User.DOB = sdr["DOB"].ToString();
                    User.school.SchoolID = Convert.ToInt32(sdr["SchoolID"].ToString());
                    User.school.SchoolName = sdr["SchoolName"].ToString();
                    User.school.picName = sdr["picName"].ToString();
                    User.school.Message = sdr["PrincipalMessage"].ToString();

                    User.isAuthenticated = true;
                }
                sdr.Close();
                con.Close();
                return User;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int SaveSchool(School s)
        {
            int res = 0;
            try
            {
                if (s.SchoolID <= 0)
                {
                    return 0;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_HOME_INFO_U";
                command.Parameters.AddWithValue("@SchoolID", s.SchoolID);
                command.Parameters.AddWithValue("@SchoolName", s.SchoolName);
                command.Parameters.AddWithValue("@picname", s.picName);
                command.Parameters.AddWithValue("@msg", s.Message);

                res=command.ExecuteNonQuery();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int ChangePassword(int uid,string o,string n)
        {
            int res = 0;
            try
            {
                if (uid <= 0)
                {
                    return 0;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_USER_PSWD_U";
                command.Parameters.AddWithValue("@userid", uid);
                command.Parameters.AddWithValue("@new", n);
                command.Parameters.AddWithValue("@old", o);

                //res = command.ExecuteNonQuery();

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    res= Convert.ToInt32(sdr["userid"]);
                }
                sdr.Close();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int SaveUser(Users u)
        {
            int res = 0;
            try
            {
                if (u.UserID <= 0)
                {
                    return 0;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_USER_U";
                command.Parameters.AddWithValue("@userid", u.UserID);
                command.Parameters.AddWithValue("@firstname", u.FirstName);
                command.Parameters.AddWithValue("@secondname", u.SecondName);
                command.Parameters.AddWithValue("@dob", u.DOB);
                command.Parameters.AddWithValue("@email", u.Email);
                command.Parameters.AddWithValue("@username", u.UserName);

                res = command.ExecuteNonQuery();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<int> CheckValidData(Users u)
        {
            List<int> res = new List<int>() { 0,0};
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_USER_VALD_C2";
                command.Parameters.AddWithValue("@userid", u.UserID);
                command.Parameters.AddWithValue("@username", u.UserName);
                command.Parameters.AddWithValue("@email", u.Email);
                
                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    if (Convert.ToInt32(sdr["usernme"]) > 0)
                    {
                        res[0] = Convert.ToInt32(sdr["usernme"]);
                    }
                    if (Convert.ToInt32(sdr["uemail"]) > 0)
                    {
                        res[1] = Convert.ToInt32(sdr["uemail"]);
                    }
                }

                //res = command.ExecuteNonQuery();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return new List<int>() { 0,0};
            }
        }
        
        public List<Notices> GetNoticesBySchool(int schoolid)
        {
            List<Notices> NoticesList = new List<Notices>();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_NOTC_S2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@schoolid", schoolid);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Notices item = new Notices();

                    item.NoticeID = Convert.ToInt32(sdr["NoticeID"]);
                    item.SchoolID = Convert.ToInt32(sdr["SchoolID"]);
                    item.DSCR = Convert.ToString(sdr["DSCR"]);

                    NoticesList.Add(item);
                }
                con.Close();

                return NoticesList;

            }
            catch (Exception)
            {
                return new List<Notices>();
            }
        }
        public int UpdateNotices(Notices item)
        {
            try
            {
                if (item.SchoolID <= 0)
                {
                    return 0;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_NOTC_U";
                command.Parameters.AddWithValue("@noticeid", item.NoticeID);
                command.Parameters.AddWithValue("@schoolid", item.SchoolID);
                command.Parameters.AddWithValue("@dscr", item.DSCR);

                var res = command.ExecuteNonQuery();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int InsertNotices(Notices item)
        {
            try
            {
                if (item.SchoolID <= 0)
                {
                    return 0;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_NOTC_I";
                command.Parameters.AddWithValue("@schoolid", item.SchoolID);
                command.Parameters.AddWithValue("@dscr", item.DSCR);

                var res = command.ExecuteNonQuery();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int DeleteNotices(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return 0;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_NOTC_D";
                command.Parameters.AddWithValue("@noticeid", id);

                var res = command.ExecuteNonQuery();

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public FinancialOvrv GetFinancialOvrv(int schoolid)
        {
            FinancialOvrv res = new FinancialOvrv();
            try
            {
                if (schoolid <= 0)
                {
                    return res;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_FNCL_OVRV";
                command.Parameters.AddWithValue("@schoolid", schoolid);

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    res.IncomePaidInvoices = Convert.ToDecimal(sdr["IncomePaidInvoices"]);
                    res.IncomeAllInvoices = Convert.ToDecimal(sdr["IncomeAllInvoices"]);
                    res.IncomeReceivables = Convert.ToDecimal(sdr["IncomeReceivables"]);
                    res.ExpensePaidInvoices = Convert.ToDecimal(sdr["ExpensePaidInvoices"]);
                    res.ExpenseAllInvoices = Convert.ToDecimal(sdr["ExpenseAllInvoices"]);
                    res.ExpensePayables = Convert.ToDecimal(sdr["ExpensePayables"]);
                }

                con.Close();
                return res;
            }
            catch (Exception)
            {
                return new FinancialOvrv();
            }
        }
        public void GenerateFeeAtMonthStart(Users u)
        {
            try
            {
                if (u.UserID <= 0)
                {
                    return;
                }
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_USER_MNTH_STRT_FEE_GEN";
                command.Parameters.AddWithValue("@roleid", u.RoleID);
                command.Parameters.AddWithValue("@schoolid", u.school.SchoolID);

                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {
                return;
            }
        }
        public School GetSchool(int UserID)
        {
            try
            {
                if (UserID <= 0)
                {
                    return null;
                }
                School s = new School();
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_HOME_INFO_S1";
                command.Parameters.AddWithValue("@UserID", UserID);

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    //implementation-required
                    s.SchoolID = Convert.ToInt32(sdr["SchoolID"]);
                    s.SchoolName = sdr["SchoolName"].ToString();
                    s.Message = sdr["PrincipalMessage"].ToString();
                    s.picName = sdr["picName"].ToString();
                }
                sdr.Close();
                con.Close();
                return s;
            }
            catch (Exception)
            {
                return new School();
            }
        }
        public SystemDate getCurrentSystemDate(int SchoolID)
        {
            try
            {
                SystemDate s = new SystemDate();
                con.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SYS_DATE_S1";
                command.Parameters.AddWithValue("@schoolid", SchoolID);

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    //implementation-required
                    s.DateID = Convert.ToInt32(sdr["DateID"]);
                    s.CurrDate = Convert.ToDateTime(sdr["CurrDate"]);
                    s.Month = Convert.ToInt32(sdr["Month"]);
                    s.Year = Convert.ToInt32(sdr["Year"]);
                    s.Status = Convert.ToBoolean(sdr["Status"]);
                    s.SchoolID = Convert.ToInt32(sdr["SchoolID"]);
                }
                sdr.Close();
                con.Close();
                return s;
            }
            catch (Exception)
            {
                return new SystemDate();
            }
        }
        public FinancialEntity GetFinancialOverview()
        {
            FinancialEntity item = new FinancialEntity();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_ALL_COUNTS";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    int StudentCount = Convert.ToInt32(sdr["StudentCount"]);
                    sdr.NextResult();
                    sdr.Read();
                    int TeacherCount = Convert.ToInt32(sdr["TeacherCount"]);
                    sdr.NextResult();
                    sdr.Read();
                    int EmployeeCount = Convert.ToInt32(sdr["EmployeeCount"]);
                }

                sdr.Close();
                con.Close();

                return item;
            }
            catch (Exception ex)
            {
                return new FinancialEntity();
            }
        }
    }
    public class Notices
    {
        public int NoticeID { get; set; }
        public int SchoolID { get; set; }
        public string DSCR { get; set; }
    }
    public class FinancialEntity
    {
        public FinancialEntity()
        {
            IncomeFees = 0;
            IncomeServices = 0;
            IncomeOther = 0;
            ExpenseSalary = 0;
            ExpenseAdvertising = 0;
            ExpenseOthers = 0;
            ExpenseMiscCharges = 0;
        }
        public decimal IncomeFees { get; set; }
        public decimal IncomeServices { get; set; }
        public decimal IncomeOther { get; set; }
        public decimal ExpenseSalary { get; set; }
        public decimal ExpenseAdvertising { get; set; }
        public decimal ExpenseOthers { get; set; }
        public decimal ExpenseMiscCharges { get; set; }
    }
    public class FinancialOvrv
    {
        public FinancialOvrv()
        {
            IncomePaidInvoices= 0;
            IncomeAllInvoices = 0;
            ExpenseAllInvoices = 0;
            ExpensePaidInvoices = 0;
            ExpensePayables = 0;
            IncomeReceivables=0;
        }
        public decimal IncomePaidInvoices { get; set; }
        public decimal IncomeAllInvoices { get; set; }
        public decimal ExpensePaidInvoices { get; set; }
        public decimal ExpenseAllInvoices { get; set; }
        public decimal IncomeReceivables { get; set; }
        public decimal ExpensePayables { get; set; }

    }
}
