using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.DAL
{
    public class TableDAL
    {
        public TableDAL(string id, string nametable, string statustable) 
        {
            this.id = id;
            this.nametable = nametable;
            this.statustable =statustable;
        }
        public static int tableWith = 70;
        public static int tableHeigh = 70;
        public TableDAL (DataRow row)
        {
            this.id = row["id"].ToString();
            this.nametable = row["nametable"].ToString();
            this.statustable = row["statustable"].ToString();

        }
        private string statustable;
        private string nametable;
        private string id;

        public string Statustable { get => statustable; set => statustable = value; }
        public string name { get => nametable; set => nametable = value; }
        public string iD { get => id; set => id = value; }
    }
}
