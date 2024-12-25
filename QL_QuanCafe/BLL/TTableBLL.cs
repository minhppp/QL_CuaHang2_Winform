using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe.BLL
{
    public class TTableBLL
    {
        private static TTableBLL instance;
        public static TTableBLL Instance 
        {
            get { if (instance == null) instance = new TTableBLL(); return TTableBLL.instance; }
            private set { TTableBLL.instance = value; }
        }
        private TTableBLL() { }
        public void UpdateTableStatus(int tableID, string status)
        {
            string query = "UPDATE TTable SET Status = @status WHERE ID = '"+@tableID+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<TableDAL> loadTTable()
        {
            List<TableDAL> tablelist = new List<TableDAL>();
            string query = @"SELECT * FROM TTABLE";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                TableDAL table = new TableDAL(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        
    }
}
