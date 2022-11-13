using Library_Managerment_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managerment_System.Controller
{
    class CategoryManager
    {
        private static CategoryManager instance;

        public static CategoryManager Instance
        {
            get { if (instance == null) instance = new CategoryManager(); return instance; }
            private set { instance = value; }

        }

        public List<Category> GetCategoryList()
        {
            List<Category> list = new List<Category>();
            DataTable data = DataController.Instance.ExcuteQuery("SELECT * FROM CATEGORY");
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
    }
}
