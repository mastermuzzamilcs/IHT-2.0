using DataTransferObjects;

namespace DAL
{
    public class IdentifierContext : DBContext
    {
        public IdentifierContext()
        {

        }
        public Roles InfoGetter()
        {
            return LoginObj;
            string a = LoginObj.Name;
            int j = LoginObj.LoginId;
            int k = LoginObj.EmpId;
        }
    }

}
