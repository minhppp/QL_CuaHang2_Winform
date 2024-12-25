using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe.BLL
{
    public class CategoryBLL
    {
        private static CategoryBLL instance;

        public static CategoryBLL Instance
        {
            get { if (instance == null) instance = new CategoryBLL(); return CategoryBLL.instance; }
            private set { CategoryBLL.instance = value; }
        }
        private CategoryBLL()
        { 
        }
        public List<CategoryDAL> GetcomboCategory(string id)
        {
            List<CategoryDAL> categoryDALs = new List<CategoryDAL>();
            string query = @"SELECT * FROM dbo.FOODCATEGORY";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                CategoryDAL inFo = new CategoryDAL(item);
                categoryDALs.Add(inFo);
            }
            return categoryDALs;
        }
    }
}
