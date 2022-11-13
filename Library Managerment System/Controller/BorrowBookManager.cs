using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Controller
{
    class BorrowBookManager
    {

        private static BorrowBookManager instance;

        public static BorrowBookManager Instance
        {
            get { if (instance == null) instance = new BorrowBookManager(); return instance; }
            private set { instance = value; }
        }


        /// <summary>
        /// Insert book with paramaters
        /// </summary>
        /// <param name="id">codebook</param>
        /// <param name="name">namebook</param>
        /// <param name="author">author</param>
        /// <param name="category">category</param>
        /// <param name="quantity">quatity</param>
        /// <returns></returns>
        public bool InsertBorrowBook(string bookID,string categoryID, int amount)
        {
            string query = string.Format("INSERT INTO BORROWBOOK(bookID,categoryID,amount,borrowDate) VALUES (N'{0}',N'{1}',{2},GETDATE())", bookID,categoryID,amount);
            int result = DataController.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
