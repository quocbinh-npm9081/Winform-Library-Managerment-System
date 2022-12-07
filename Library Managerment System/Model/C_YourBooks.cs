using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Model
{
    public class C_YourBooks
    {
        int billID;
        string bookID;
        string categoryID;
        int amount;
        DateTime borrowDate;

        public int BillID
        {
            get { return billID; }
        }

        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }
        public C_YourBooks()
        {

        }
        public C_YourBooks(DataRow data)
        {
            billID = (int)data["billID"];
            bookID = data["bookID"].ToString();
            categoryID = data["categoryID"].ToString();
            amount = (int)data["amount"];
            borrowDate = DateTime.Parse(data["borrowDate"].ToString());
        }
    }
}
