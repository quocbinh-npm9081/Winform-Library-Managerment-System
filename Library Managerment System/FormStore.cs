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

namespace Library_Managerment_System
{
    //
    //TODO: Update databse when using function in this class 
    //
    public partial class FormStore : Form
    {
        private LinkedList<C_YourBooks> yourBooks;
        private LinkedList<C_book> books;

        public FormStore()
        {
            InitializeComponent();
        }
        private void show(LinkedList<C_YourBooks> yourBooks)
        {
            BindingSource ds = new BindingSource();
            ds.DataSource = yourBooks.ToList();
            dgv.DataSource = ds;
        }
        private void FormStore_Load(object sender, EventArgs e)
        {
            show(yourBooks);
        }

        private void btn_back_click(object sender, EventArgs e)
        {
            BorrowBooks borrowBooks = new BorrowBooks();
            this.Hide();
            borrowBooks.ShowDialog();
        }

        private void event_selected_change(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string code = r.Cells[1].Value.ToString();
                foreach (C_YourBooks x in yourBooks)
                {
                    if (x.codeBook == code)
                    {
                        txt_codeBook.Text = x.codeBook;
                        txt_nameBook.Text = x.nameBook;
                        txt_author.Text = x.author;
                        txt_category.Text = x.category;
                        txt_quantity.Text = x.quantity.ToString();
                        txt_createdAt.Text = x.createdAt.ToString();
                        return;
                    }
                }
            }
        }

      
        private void txt_codeBook_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validator()
        {
            int st;
            if (int.TryParse(txt_quantity.Text.Trim(), out st) == false|| int.Parse(txt_quantity.Text.Trim()) < 0)
            {
                return false;
            }
            return true;
        }
        private void btn_returnBook_click(object sender, EventArgs e)
        {
            if (validator())
            {
                string code= txt_codeBook.Text;
                //Cập nhập dữ liệu sách của admin
                for(LinkedListNode<C_book> a = books.First; a != null; a = a.Next)
                {
                    if (a.Value.codeBook == code)
                    {                          
                       a.Value.quantity = a.Value.quantity + int.Parse(txt_quantity.Text.Trim());
                        break;
                    }
                    else
                    {
                        C_book y = new C_book();
                        y.codeBook = txt_codeBook.Text.Trim();
                        y.nameBook = txt_nameBook.Text.Trim();
                        y.author = txt_author.Text.Trim();
                        y.category = txt_category.Text;
                        y.quantity = int.Parse(txt_quantity.Text.Trim());
                        LinkedListNode<C_book> newBook = new LinkedListNode<C_book>(y);
                        books.AddFirst(newBook);
                        break;
                    }
                }
                //Cập nhập dữ liệu sách của Student
                for(LinkedListNode<C_YourBooks> x = yourBooks.First; x!=null;x=x.Next  )
                {
                    if (x.Value.codeBook == code)
                    {

                        x.Value.quantity = x.Value.quantity - int.Parse(txt_quantity.Text.Trim());
                        if(x.Value.quantity <= 0)
                        {
                            yourBooks.Remove(x);
                            break;
                        }
                        break;
                    }
               
                }
                MessageBox.Show("Trả sách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                show(yourBooks);

            }
            else
            {
                MessageBox.Show("Số lượng sách không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantity.Text = "1";
            }
        }
    }
}
