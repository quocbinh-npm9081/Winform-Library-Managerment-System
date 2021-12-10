using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System
{
    [Serializable]

    class C_YourBooks :C_book
    {
        public C_YourBooks() 
        {
            this.m_codeBook = "";
            this.m_nameBook = "";
            this.m_author = "";
            this.m_category = "";
            this.m_quantity = 0;
            this.m_createdAt = DateTime.Now;
        }
        public C_YourBooks(string codeBook, string nameBook, string author, string category, int quantity,DateTime createdAt)
        {
            this.m_codeBook = codeBook;
            this.m_nameBook = nameBook;
            this.m_author = author;
            this.m_category = category;
            this.m_quantity = quantity;
            this.m_createdAt = DateTime.Now;
        }
        public DateTime createdAt
        {
            get
            {
                return this.m_createdAt;
            }
            set
            {
                this.m_createdAt = value;
            }
        }
    }
}
