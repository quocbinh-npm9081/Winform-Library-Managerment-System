using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System
{
    [Serializable]
    class C_book
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
        public C_book(){
            this.m_codeBook = "";
            this.m_nameBook = "";
            this.m_author = "";
            this.m_category = "";
            this.m_quantity = 0;
        }
        public C_book(string codeBook, string nameBook, string author, string category, int quantity)
        {
            this.m_codeBook = codeBook;
            this.m_nameBook = nameBook;
            this.m_author = author;
            this.m_category = category;
            this.m_quantity = quantity;
        }
    }

 
}
