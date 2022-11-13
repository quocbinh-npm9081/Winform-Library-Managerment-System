using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Model
{
    public class Category
    {
        private string categoryID;
        private string categoryName;

        public string CategoryID
        {
            get { return categoryID; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public Category()
        {
            categoryID = "null";
            categoryName = "null";
        }

        public Category(DataRow dataRow)
        {
            categoryID = dataRow["categoryID"].ToString();
            categoryName = dataRow["categoryName"].ToString();
        }
    }
}
