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
using Library_Managerment_System.Model;
using Library_Managerment_System.Controller;

namespace Library_Managerment_System
{
    //
    //TODO: Update databse when using function in this class 
    //
    public partial class FormStore : Form
    {
        private List<C_YourBooks> yourBooks;

        public FormStore()
        {
            InitializeComponent();
        }
        private void show()
        {
            yourBooks = BorrowBookManager.Instance.GetListBorrowedBooks();
            BindingSource ds = new BindingSource();
            ds.DataSource = yourBooks.ToList();
            dgv.DataSource = ds;
        }
        private void FormStore_Load(object sender, EventArgs e)
        {
            show();
            txt_billID.Text = dgv.Rows[0].Cells[0].Value.ToString();
            txt_codeBook.Text = dgv.Rows[0].Cells[1].Value.ToString();
            txt_category.Text = dgv.Rows[0].Cells[2].Value.ToString();
            txt_quantity.Text = dgv.Rows[0].Cells[3].Value.ToString();
            txt_createdAt.Text= dgv.Rows[0].Cells[4].Value.ToString();
        }

        private void btn_back_click(object sender, EventArgs e)
        {
            BorrowBooks borrowBooks = new BorrowBooks();
            this.Hide();
            borrowBooks.ShowDialog();
        }


        private void btn_returnBook_click(object sender, EventArgs e)
        {
            int billID = int.Parse(txt_billID.Text);
            if (BorrowBookManager.Instance.DeleteBorrowBook(billID))
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show();
            }
            else
            {
                MessageBox.Show("Số lượng sách không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                txt_billID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_codeBook.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_category.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_quantity.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_createdAt.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
