﻿using System;
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

namespace Library_Managerment_System
{
    public partial class AdminPage : Form
    {
        private LinkedList<C_book> bookList;
        private login _login = new login();
        public AdminPage()
        {
            InitializeComponent();
        }
        private void show(LinkedList<C_book> bookList)
        {
            BindingSource ds = new BindingSource();
            ds.DataSource = bookList.ToList();
            dgv_admin.DataSource = ds;
            txt_codeBook.Text = "";
            txt_nameBook.Text = "";
            txt_author.Text = "";         
            txt_quantity.Text = "";
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
                            if (txt_nameBook.Text == a.nameBook && txt_author.Text == a.author && txt_category.Text == a.category)
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
                        if (txt_category.Text == "")
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
        private void save_books_admin() {
            try {
                FileStream file = new FileStream("books.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, bookList);
                file.Close();
                MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch (Exception fe)
            {
                MessageBox.Show(fe.Message);

            }
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            try {
                //bookList = new LinkedList<C_book>();
                FileStream file = new FileStream("books.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                bookList = bf.Deserialize(file) as LinkedList<C_book>;
                file.Close();
                show(bookList);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
        private void event_click_add(object sender, EventArgs e)
        {

            if (validator_add() == 1)
            {
                C_book x = new C_book();
                x.codeBook = txt_codeBook.Text;
                x.nameBook = txt_nameBook.Text;
                x.author = txt_author.Text;
                x.category = txt_category.Text;
                x.quantity = int.Parse(txt_quantity.Text);
                LinkedListNode <C_book> newBook= new LinkedListNode<C_book>(x);
                bookList.AddFirst(newBook);
                show(bookList);
            }
            else if(validator_add() == -3) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin của sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                show(bookList);
            }            
            else if (validator_add() == -2)
            {
                MessageBox.Show("Số lượng sách không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                show(bookList);
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
                show(bookList);
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
                foreach (DataGridViewRow r in dgv_admin.SelectedRows)
                {
                    string code = r.Cells[0].Value.ToString();
                    foreach (C_book a in bookList)
                    {
                        if (a.codeBook == code)
                        {
                            bookList.Remove(a);
                            break;
                        }
                    }
                }
                show(bookList);
            }
         
        }
        private void event_selectionChanged_click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_admin.SelectedRows)
            {
                string code = r.Cells[0].Value.ToString();
            
                foreach (C_book x in bookList)
                {
                    if (x.codeBook == code)
                    {
                        txt_codeBook.Text = x.codeBook;
                        txt_nameBook.Text = x.nameBook;
                        txt_author.Text = x.author;
                        txt_category.Text = x.category;
                        txt_quantity.Text = x.quantity.ToString();
                        return;

                    }
                }
            }
        }
        private void event_edit_click(object sender, EventArgs e)
        {
            try {
                if (validator_edit())
                {
                    string code = txt_codeBook.Text;
                    foreach (C_book x in bookList)
                    {
                        if (x.codeBook == code)
                        {
                            x.nameBook = txt_nameBook.Text;
                            x.author = txt_author.Text;
                            x.category = txt_category.Text;
                            x.quantity = int.Parse(txt_quantity.Text);
                            break;
                        }
                   
                    }
                    MessageBox.Show("Chỉnh sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    show(bookList);
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
                save_books_admin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void event_logout_click(object sender, EventArgs e) {
            System.Windows.Forms.DialogResult isLogout = MessageBox.Show("Lưu bản ghi trước khi đăng xuất !", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if(isLogout == System.Windows.Forms.DialogResult.Yes)
            {
                save_books_admin();
                this.Hide();
               _login.ShowDialog();
            }
            if (isLogout == System.Windows.Forms.DialogResult.No)
            {
                System.Windows.Forms.DialogResult isExit = MessageBox.Show("Bản ghi sẽ không được lưu,bạn có chắc muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if(isExit == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    _login.ShowDialog();
                }
                  
            }
        
        }
    }
}

