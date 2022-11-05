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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_click_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click_login(object sender, EventArgs e)
        {
            if (text_userName.Text == "admin" || text_userName.Text == "stu")
            {
                if (text_password.Text == "admin" || text_password.Text == "stu")
                {
                    string userName = text_userName.Text;
                    if (userName == "admin")
                    {
                        AdminPage adminHomePage = new AdminPage();
                        this.Hide();
                        adminHomePage.ShowDialog();
                    }
                    if (userName == "stu")
                    {
                        StudentPage userHomePage = new StudentPage();
                        this.Hide();
                        userHomePage.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect User Name !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
