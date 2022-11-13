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
using Library_Managerment_System.Model;

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
            listBook = BookManager.Instance.GetBookList();
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
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            FormStore yourBooks = new FormStore();
            this.Hide();
            yourBooks.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //TODO Add bill
            if(txt_quantity.Text=="" || int.Parse(txt_quantity.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(BorrowBookManager.Instance.InsertBorrowBook(txt_codeBook.Text,txt_category.Text, int.Parse(txt_quantity.Text)))
                {
                    MessageBox.Show("Đặt sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show();
                }
            }
        }

        private void BorrowBooks_Load(object sender, EventArgs e)
        {
            txt_codeBook.Text = dgv.Rows[0].Cells[0].Value.ToString();
            txt_nameBook.Text = dgv.Rows[0].Cells[1].Value.ToString();
            txt_author.Text = dgv.Rows[0].Cells[2].Value.ToString();
            txt_category.Text = dgv.Rows[0].Cells[3].Value.ToString();
        }
    }
}
