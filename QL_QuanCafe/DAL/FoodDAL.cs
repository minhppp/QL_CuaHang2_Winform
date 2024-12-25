using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.DAL
{
    internal class FoodDAL
    {
        public FoodDAL(string id, string namefood,string idFoodcategory, float price, int statusfood)
        {
            this.id = id;
            this.namefood = namefood;
            this.idFoodcategory = idFoodcategory;
            this.price = price;
            this.statusfood = statusfood;
        }
        public FoodDAL(DataRow row)
        {
            this.id = row["id"].ToString();
            this.namefood = row[" namefood"].ToString();
            this.idFoodcategory = row["idFoodcategory"].ToString();
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.statusfood = (int)row["statusfood"];
        }
        private string id;
        private  string namefood;
        private string idFoodcategory;
        private float price;
        private int statusfood;

        public string Id { get => id; set => id = value; }
        public string Namefood { get => namefood; set => namefood = value; }
        public string IdFoodcategory { get => idFoodcategory; set => idFoodcategory = value; }
        public float Price { get => price; set => price = value; }
        public int Statusfood { get => statusfood; set => statusfood = value; }
    }
}
