using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.DAL
{
    public class MenuDAL
    {
        public MenuDAL(string namefood, int count, float price, float totalprice = 0)
        {
            this.namefood = namefood;
            this.count = count;
            this.price = price;
            this.totalprice = totalprice;
        }

        public MenuDAL(DataRow row)
        {
            this.namefood = row["namefood"].ToString();
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }
        private string namefood;
        private int count;
        private float price;
        private float totalprice;

        public string Namefood { get => namefood; set => namefood = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
