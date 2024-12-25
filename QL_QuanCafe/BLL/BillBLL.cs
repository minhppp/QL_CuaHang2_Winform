using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe.BLL
{
    internal class BillBLL
    {
        private static BillBLL instance;

        public static BillBLL Instance
        {
            get { if (instance == null) instance = new BillBLL(); return BillBLL.instance; }
            private set { BillBLL.instance = value; }
        }
        private BillBLL() 
        {
        }

        public string getBillidByTTableid(string id)
        {
            string query = @"SELECT * FROM dbo.BILL WHERE dbo.BILL.idTTable = '"+id+"' and dbo.BILL.billstatus= 0 ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                BillDAL bill = new BillDAL(data.Rows[0]);
                return bill.Id;
            }
            return "Không";
        }
    }
}
