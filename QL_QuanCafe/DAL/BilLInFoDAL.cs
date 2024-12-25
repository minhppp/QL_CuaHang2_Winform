using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.DAL
{
    public class BilLInFoDAL
    {
        public BilLInFoDAL(string id, string idBill, string idFood, int count) 
        {
            this.id = id;
            this.idBill = idBill;
            this.idFood = idFood;
            this.count = count;
        }
        public BilLInFoDAL(DataRow row)
        {
            this.id = row["id"].ToString();
            this.idBill = row["idBill"].ToString();
            this.idFood = row["idFood"].ToString();
            this.count = (int)row["count"];
        }
        private string id;
        private string idBill;
        private string idFood;
        private int count;

        public string Id { get => id; set => id = value; }
        public string IdBill { get => idBill; set => idBill = value; }
        public string IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
