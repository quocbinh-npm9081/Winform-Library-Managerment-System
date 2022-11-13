using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Controller
{
    public class BookManager
    {
        private static BookManager instance;

        public static BookManager Instance
        {
            get { if (instance == null) instance = new BookManager(); return instance; }
            private set { instance = value; }
        }
        
        //Function
        #region Functions

        /// <summary>
        /// Get all book have in database and return a list of book
        /// </summary>
        /// <returns></returns>
        public List<C_book> GetBookList()
        {
            List<C_book> list = new List<C_book>();
            DataTable data = DataController.Instance.ExcuteQuery("SELECT * FROM BOOK");
            foreach (DataRow item in data.Rows)
            {
                C_book food = new C_book(item);
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
        public bool InsertBook(string id, string name, string author, string category, int quantity)
        {
            string query = string.Format("INSERT INTO BOOK(bookID,bookName,bookAuthor,bookCategory,quantity,releaseDate)" +
                         "VALUES(N'{0}', N'{1}', N'{2}', N'{3}', {4}, GETDATE());",id,name,author,category,quantity);
            int result = DataController.Instance.ExcuteNonQuery(query);
            return result > 0;
        }


        public bool EditBook(string id, string name, string author, string category, int quantity)
        {
            string query = string.Format("UPDATE BOOK SET  bookName=N'{0}', bookAuthor=N'{1}', " +
                "bookCategory=N'{2}', quantity={3} WHERE bookID=N'{4}'",name,author,category,quantity,id);
            int result = DataController.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteBook(string id)
        {
            string query = string.Format("DELETE BOOK WHERE bookID=N'{0}'",id);
            int result = DataController.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        #endregion

    }
}
