using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe.BLL
{
    public class MenuBLL
    {
        private static MenuBLL instance;

        public static MenuBLL Instance
        {
            get { if (instance == null) instance = new MenuBLL(); return MenuBLL.instance; }
            private set { MenuBLL.instance = value; }
        }
        private MenuBLL() { }

        public List<MenuDAL> GetListMenubyTable(string id) 
        { 
            List<MenuDAL> listmenu = new List<MenuDAL>();

            string query = @"SELECT dbo.FOOD.namefood , dbo.BILLINFO.count, dbo.FOOD.price, dbo.FOOD.price * dbo.BILLINFO.count as totalprice
                            FROM dbo.BILLINFO, dbo.BILL, dbo.FOOD
							WHERE dbo.BILLINFO.idBill = dbo.BILL.id and dbo.BILLINFO.idFood = dbo.FOOD.id  and dbo.BILL.idTTable ='"+id+"'"; 
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                MenuDAL menu = new MenuDAL(dr);
                listmenu.Add(menu);
            }

            return listmenu;
        }
    }

}
