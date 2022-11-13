using Library_Managerment_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managerment_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }



        private void btn_click_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click_login(object sender, EventArgs e)
        {
            string username = text_userName.Text;
            string password = text_password.Text;
            if (AccountManager.Instance.Login(username,password))
            {
                string accountKind = AccountManager.Instance.GetAccountByUsername(username).Kind;
                if (accountKind=="admin")
                {
                    AdminPage adminHomePage = new AdminPage(username);
                    this.Hide();
                    adminHomePage.ShowDialog();
                }
                else 
                {
                    StudentPage userHomePage = new StudentPage();
                    this.Hide();
                    userHomePage.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
