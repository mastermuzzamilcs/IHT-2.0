using DataTransferObjects;
using System.Configuration;

namespace DAL
{
    public class DBContext
    {
        private string connectionstring = @"Data Source=DESKTOP-A61AK54\NEWTEST;Initial Catalog=StudentDataBase;Integrated Security=True";// ConfigurationManager.AppSettings["Con1"];           
        public Roles LoginObj;

        public DBContext()
        {
            //connectionstring = @"Data Source=.\NEWTEST;Initial Catalog=SchoolManagementSystem;Integrated Security=True";// ConfigurationManager.AppSettings["Con1"];            
            connectionstring = ConfigurationManager.AppSettings["Con1"];
        }
        public void setter(Roles obj)
        {
            LoginObj = obj;
            string a = LoginObj.Name;
            int j = LoginObj.LoginId;
            int k = LoginObj.EmpId;
        }
        protected string GetDBConnection()
        {
            return connectionstring;
        }
    }
}
