using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe.BLL
{
    public class BilLInFoBLL
    {
        private static BilLInFoBLL instance;

        public static BilLInFoBLL Instance
        {
            get { if (instance == null) instance = new BilLInFoBLL(); return BilLInFoBLL.instance; }
            private set { BilLInFoBLL.instance = value; }
        }
        private BilLInFoBLL() { }
        public List<BilLInFoDAL> GetlistBilLInFoDAL(string id)
        {
            List<BilLInFoDAL> bilLInFoDAL = new List<BilLInFoDAL>();
            string query = @"SELECT * FROM dbo.BILLINFO WHERE idBill = '"+id+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                BilLInFoDAL inFo = new BilLInFoDAL(item);
                bilLInFoDAL.Add(inFo);
            }
            return bilLInFoDAL;
        }
    }
}
