using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System
{
    [Serializable]

    class C_YourBooks :C_book
    {
        private int amount;
        private DateTime borrowDate;

        public C_YourBooks() 
        {
            this.m_codeBook = "";
            this.m_nameBook = "";
            this.m_author = "";
            this.m_category = "";
            this.m_quantity = 0;
            this.m_createdAt = DateTime.Now;
        }
        public C_YourBooks(DataRow row)
        {
            //Adding database value row table
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
