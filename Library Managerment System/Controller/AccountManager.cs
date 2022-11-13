using Library_Managerment_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Controller
{
     public class AccountManager
    {
        private static AccountManager instance;

        public static AccountManager Instance
        {
            get { if (instance == null) instance = new AccountManager(); return instance; }
            private set { instance = value; }

        }
        private AccountManager() { }
        public bool Login(string username, string password)
        {
            string query = "EXEC pd_login @username , @password";
            DataTable result = DataController.Instance.ExcuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataController.Instance.ExcuteQuery("SELECT * FROM Account WHERE USERNAME =N'" + username + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string username, string displayname, string password, string newpassword)
        {
            int result = DataController.Instance.ExcuteNonQuery("EXEC dbo.USP_UpdateAccount @userName , @displayName , @passWord , @newPassword ", new object[] { username, displayname, password, newpassword });
            return result > 0;
        }
    }
}
