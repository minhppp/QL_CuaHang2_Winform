using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe.BLL
{
    internal class FoodBLL
    {
        private static FoodBLL instance;

        public static FoodBLL Instance
        {
            get { if (instance == null) instance = new FoodBLL(); return FoodBLL.instance; }
            private set { FoodBLL.instance = value; }
        }
        private FoodBLL()
        {
        }
        public List<FoodDAL> GetcomboFooDALs(string id)
        {
            List<FoodDAL> FoodDALs = new List<FoodDAL>();
            string query = @"SELECT * FROM dbo.FOOD";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                FoodDAL inFo = new FoodDAL(item);
                FoodDALs.Add(inFo);
            }
            return FoodDALs;
        }
    }
}
