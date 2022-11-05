using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System
{
   
    public class C_book
    {
        protected string m_codeBook;
        protected string m_nameBook;
        protected string m_author;
        protected string m_category;
        protected int m_quantity;
        protected DateTime m_createdAt;
        public string codeBook
        {
            get
            {
                return this.m_codeBook;
            }
            set
            {
                this.m_codeBook = value;
            }
        }
        public string nameBook
        {
            get
            {
                return this.m_nameBook;
            }
            set
            {
                this.m_nameBook = value;
            }

        }
        public string author
        {
            get
            {
                return this.m_author;
            }
            set
            {
                this.m_author = value;
            }

        }
        public string category
        {
            get
            {
                return this.m_category;
            }
            set
            {
                this.m_category = value;
            }

        }
        public int quantity
        {
            get {
                return m_quantity;
            }
            set {
                this.m_quantity = value;
            }
        }
        public DateTime createdAt
        {
            get
            {
                return m_createdAt;
            }
            set
            {
                this.m_createdAt = value;
            }
        }

        public C_book(){
            this.m_codeBook = "";
            this.m_nameBook = "";
            this.m_author = "";
            this.m_category = "";
            this.m_quantity = 0;
        }
        public C_book(DataRow row)
        {
            this.m_codeBook = row["bookID"].ToString();
            this.m_nameBook = row["bookName"].ToString();
            this.m_author = row["bookAuthor"].ToString();
            this.m_category = row["bookCategory"].ToString();
            this.m_quantity = (int)row["quantity"];
            this.m_createdAt = DateTime.Parse(row["releaseDate"].ToString());
        }
    }

 
}
