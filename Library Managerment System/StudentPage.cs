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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_click_borowBook(object sender, EventArgs e)
        {
            BorrowBooks borrowBooks = new BorrowBooks();
            this.Hide();
            borrowBooks.ShowDialog();
        }

        private void btn_yourBooks_click(object sender, EventArgs e)
        {
            FormStore yourBooks = new FormStore();
            this.Hide();
            yourBooks.ShowDialog();
        }
    }
}
