using Library_Managerment_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Controller
{
    public class BorrowBookManager
    {

        private static BorrowBookManager instance;

        public static BorrowBookManager Instance
        {
            get { if (instance == null) instance = new BorrowBookManager(); return instance; }
            private set { instance = value; }
        }

        public List<C_YourBooks> GetListBorrowedBooks()
        {
            List<C_YourBooks> list = new List<C_YourBooks>();
            DataTable data = DataController.Instance.ExcuteQuery("SELECT * FROM BORROWBOOK");
            foreach (DataRow item in data.Rows)
            {
                C_YourBooks food = new C_YourBooks(item);
                list.Add(food);
            }
            return list;
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

        public bool DeleteBorrowBook(int billID)
        {
            string query = string.Format("DELETE BORROWBOOK WHERE billID={0}",billID);
            int result = DataController.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
