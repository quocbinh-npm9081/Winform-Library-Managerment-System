using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Library_Managerment_System.Controller;

namespace Library_Managerment_System
{
    //
    //TODO: Fix function in this class form using file to database 
    //
    public partial class AdminPage : Form
    {
        private List<C_book> bookList;
        private login _login = new login();
        public AdminPage(string username)
        {
            InitializeComponent();
            userName_txt.Text = username;
            show();
            LoadCategoryIntoCombobox(cbb_category);
        }
        private void show()
        {
            bookList = BookManager.Instance.GetBookList();
            BindingSource ds = new BindingSource();
            ds.DataSource = bookList.ToList();
            dgv_admin.DataSource = ds;
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryManager.Instance.GetCategoryList();
            cb.DisplayMember = "categoryName";
        }
        private int validator_add()
        {
            int st;
            //validator input
            if (txt_codeBook.Text == "")
            {
                return -3;
            }
            else
            {
                if (txt_nameBook.Text == "")
                {
                    return -3;

                }
                if (txt_author.Text == "")
                {
                    return -3;
                }             
                if (int.TryParse(txt_quantity.Text, out st) == false || int.Parse(txt_quantity.Text) <=0)
                {
                    return -2;
                }
                else
                {
                    foreach (C_book a in bookList)
                    {

                        if (txt_codeBook.Text == a.codeBook)
                        {
                            if (txt_nameBook.Text == a.nameBook && txt_author.Text == a.author && cbb_category.Text == a.category)
                            {
                                return 0;
                            }
                            return -1;
                        }
                    }
                }

            }

            return 1;
        }
        private bool validator_edit()
        {
            int st;
            //validator input
            if (txt_codeBook.Text == "")
            {
                MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (txt_nameBook.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else
                {
                    if (txt_author.Text == "")
                    {
                        MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (cbb_category.Text == "")
                        {
                            MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            if (int.TryParse(txt_quantity.Text, out st) == false  && int.Parse(txt_quantity.Text) > 0)
            {
                MessageBox.Show("Số lượng sách không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        private void event_click_add(object sender, EventArgs e)
        {

            if (validator_add() == 1)
            {
                C_book x = new C_book();
                x.codeBook = txt_codeBook.Text;
                x.nameBook = txt_nameBook.Text;
                x.author = txt_author.Text;
                x.category = cbb_category.Text;
                x.quantity = int.Parse(txt_quantity.Text);
                if (BookManager.Instance.InsertBook(x.codeBook, x.nameBook, x.author, x.category, x.quantity))
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    show();
                }
            }
            else if(validator_add() == -3) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin của sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                show();
            }            
            else if (validator_add() == -2)
            {
                MessageBox.Show("Số lượng sách không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                show();
            }
            else if (validator_add() == 0)
            {
                foreach (C_book a in bookList)
                {

                    if (txt_codeBook.Text == a.codeBook)
                    {
                        a.quantity = a.quantity + int.Parse(txt_quantity.Text);

                    }
                }
                show();
            }
            else
            {
                MessageBox.Show("Có gì đó sai sai :V","??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void event_click_delete(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult isDetroy = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (isDetroy == System.Windows.Forms.DialogResult.OK)
            {
                if (BookManager.Instance.DeleteBook(txt_codeBook.Text))
                {
                    show();
                }
                else
                {
                    MessageBox.Show("Có gì đó sai sai :V", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void event_edit_click(object sender, EventArgs e)
        {
            try {
                if (validator_edit())
                {
                    string code = txt_codeBook.Text;
                    string name = txt_nameBook.Text;
                    string author = txt_author.Text;
                    string category = cbb_category.Text;
                    int quantity = int.Parse(txt_quantity.Text);
                    if (BookManager.Instance.EditBook(code, name, author, category, quantity))
                    {
                        MessageBox.Show("Chỉnh sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        show();
                    }
                    else
                    {
                        MessageBox.Show("Có gì đó sai sai :V", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void event_save_click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_logout_click(object sender, EventArgs e) {
            System.Windows.Forms.DialogResult isLogout = MessageBox.Show("Bạn có chắc muốn thoát? !", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if(isLogout == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
               _login.ShowDialog();
            }
        
        }

        private void dgv_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_admin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_admin.CurrentRow.Selected = true;
                txt_codeBook.Text = dgv_admin.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nameBook.Text = dgv_admin.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_author.Text = dgv_admin.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbb_category.Text = dgv_admin.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_quantity.Text = dgv_admin.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            txt_codeBook.Text = dgv_admin.Rows[0].Cells[0].Value.ToString();
            txt_nameBook.Text = dgv_admin.Rows[0].Cells[1].Value.ToString();
            txt_author.Text = dgv_admin.Rows[0].Cells[2].Value.ToString();
            cbb_category.Text = dgv_admin.Rows[0].Cells[3].Value.ToString();
            txt_quantity.Text = dgv_admin.Rows[0].Cells[4].Value.ToString();
        }
    }
}

