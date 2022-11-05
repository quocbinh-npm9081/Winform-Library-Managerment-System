using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Library_Managerment_System.Controller;

namespace Library_Managerment_System
{
    //
    //TODO: Fix function in this class form using file to database 
    //
    public partial class BorrowBooks : Form
    {
        private List<C_book> listBook;
        public BorrowBooks()
        {
            listBook = BookManager.Instance.GetBookList();
            InitializeComponent();
            show();
        }


        private void btn_logout(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult isLogout;
            isLogout = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if(isLogout == System.Windows.Forms.DialogResult.OK)
            {
                login login = new login();
                this.Hide();
                login.ShowDialog();
            }
          
        }
        private void show()
        {
            BindingSource ds = new BindingSource();
            ds.DataSource = listBook;
            dgv.DataSource = ds;
        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                txt_codeBook.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nameBook.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_author.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_category.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_quantity.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
