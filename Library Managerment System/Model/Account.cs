using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Model
{
    public class Account
    {
        string accountID;
        string userName;
        string password;
        string phone;
        string kind;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public Account()
        {
            accountID = "";
            userName = "";
            password = "";
            phone = "";
            kind = "";
        }
        public Account(DataRow dataRow)
        {
            accountID = dataRow["accountID"].ToString();
            userName = dataRow["username"].ToString();
            password = dataRow["passwd"].ToString();
            phone = dataRow["phone"].ToString();
            kind = dataRow["kind"].ToString();
        }
    }
}
