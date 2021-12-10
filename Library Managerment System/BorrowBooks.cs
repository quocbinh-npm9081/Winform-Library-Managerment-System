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

namespace Library_Managerment_System
{
    public partial class BorrowBooks : Form
    {
        private LinkedList<C_book> books;
        private LinkedList<C_YourBooks> yourBooks;
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void show(LinkedList<C_book> books)
        {
            BindingSource ds = new BindingSource();
            ds.DataSource = books.ToList();
            dgv.DataSource = ds;
        }
        private C_book sreachBook(string codeBook)
        {
            foreach (C_book book in books)
            {
                if (book.codeBook == codeBook)
                {
                    return book;
                }
            }
            return null;
        }
        private bool saveFile_YourBooks(string nameFile,  LinkedList<C_YourBooks> yourBooks)
        {
            try
            {
                FileStream f = new FileStream(nameFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, yourBooks);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool saveFile_Books(string nameFile, LinkedList<C_book> Books)
        {
            try
            {
                FileStream f = new FileStream(nameFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, Books);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void BorrowBooks_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream("books.dat", FileMode.Open);
            // FileStream yourBooks_file = new FileStream("yourBooks.dat", FileMode.Open);
            yourBooks = new LinkedList<C_YourBooks>();

            //if (yourBooks_file == null)
            //{
            //    yourBooks = new LinkedList<C_YourBooks>();
            //}
            //else
            //{
                BinaryFormatter bf = new BinaryFormatter();
                books = bf.Deserialize(file) as LinkedList<C_book>;
              //  yourBooks = bf.Deserialize(yourBooks_file) as LinkedList<C_YourBooks>;
              //  yourBooks_file.Close();
                file.Close();
                show(books);
           // }
        }

        private void event_click_search(object sender, EventArgs e)
        {

        }

        private void event_selectionChange(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string code = r.Cells[0].Value.ToString();
                foreach (C_book x in books)
                {
                    if (x.codeBook == code)
                    {
                        txt_codeBook.Text = x.codeBook;
                        txt_nameBook.Text = x.nameBook;
                        txt_author.Text = x.author;
                        txt_category.Text = x.category;
                        txt_quantity.Text = "1";
                        return;
                    }
                }
            }
        }

        private void event_change_search(object sender, EventArgs e)
        {

        }

        private void event_index_change(object sender, EventArgs e)
        {
         
        }

        private void btn_add_click(object sender, EventArgs e)
        {
            C_YourBooks newBook = new C_YourBooks();
            newBook.codeBook = txt_codeBook.Text;
            C_book updateBook = sreachBook(newBook.codeBook);
            int st;
            if(int.Parse(txt_quantity.Text.Trim()) > updateBook.quantity  || int.TryParse(txt_quantity.Text, out st) == false || int.Parse(txt_quantity.Text) <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                show(books);
                txt_quantity.Text = "1";
            }
            else
            {
                newBook.nameBook = txt_nameBook.Text;
                newBook.author = txt_author.Text;
                newBook.category = txt_category.Text;
                newBook.quantity = int.Parse(txt_quantity.Text.Trim());
                newBook.createdAt = DateTime.Now;
                LinkedListNode<C_YourBooks> bookNode = new LinkedListNode<C_YourBooks>(newBook);
                FileStream fileYourBook = new FileStream("yourBooks.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                yourBooks = bf.Deserialize(fileYourBook) as LinkedList<C_YourBooks>;
                fileYourBook.Close();
                yourBooks.AddFirst(bookNode);
                System.Windows.Forms.DialogResult isLogout = MessageBox.Show("Bạn chắc chắn muốn đặc sách ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (isLogout == System.Windows.Forms.DialogResult.OK)
                {
                    FileStream file = new FileStream("books.dat", FileMode.Open);
                    BinaryFormatter bn = new BinaryFormatter();
                    books = bn.Deserialize(file) as LinkedList<C_book>;
                    file.Close();
                    for(LinkedListNode<C_book> book = books.First; book != null; book = book.Next)
                    {
                        if (book.Value.codeBook == newBook.codeBook)
                        {
                            book.Value.quantity = book.Value.quantity - newBook.quantity;
                            if (book.Value.quantity == 0)
                            {
                                books.Remove(book);
                            }
                        }
                    }
                    saveFile_YourBooks("yourBooks.dat", yourBooks);
                    saveFile_Books("books.dat", books);
                    show(books);
                }
            }              
        }

        private void btn_yourBooks_click(object sender, EventArgs e)
        {
            FormStore FormYourBooks = new FormStore();
            this.Hide();
            FormYourBooks.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selected_value_change(object sender, EventArgs e)
        {
            LinkedList<C_book> booksInCategory = new LinkedList<C_book>();
            FileStream file = new FileStream("books.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ComboBox cb = sender as ComboBox;
            string categoryInComBoBox = cb.SelectedItem.ToString();
            books = bf.Deserialize(file) as LinkedList<C_book>;
            file.Close();
            if (categoryInComBoBox == "Tất cả")
            {
               // MessageBox.Show(categoryInComBoBox);
                show(books);
            }
            else
            {
                for (LinkedListNode<C_book> booki = books.First; booki != null; booki = booki.Next)
                {
                    if (booki.Value.category == categoryInComBoBox)
                    {
                        // MessageBox.Show(booki.Value.category.ToString());
                        C_book x = new C_book();
                        x.codeBook = booki.Value.codeBook;
                        x.nameBook = booki.Value.nameBook;
                        x.author = booki.Value.author;
                        x.category = booki.Value.category;
                        x.quantity = booki.Value.quantity;
                        LinkedListNode<C_book> newBook = new LinkedListNode<C_book>(x);
                        booksInCategory.AddLast(newBook);
                    }

                }
                show(booksInCategory);
            }
              
        }
    }
}
