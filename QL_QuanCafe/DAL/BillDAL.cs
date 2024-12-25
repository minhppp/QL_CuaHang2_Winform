using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.DAL
{
    public class BillDAL
    {
        public BillDAL(string id, DateTime datecheckin, DateTime datecheckuot, int billstatus) 
        {
            this.id = id;
            this.datecheckin = datecheckin;
            this.datecheckout = datecheckuot;
            
            this.billstatus = billstatus;
        }
        public BillDAL(DataRow row) 
        {
            this.id = row["id"].ToString();
            this.datecheckin = (DateTime)row["datecheckin"];
            this.datecheckout = (DateTime)row["datecheckout"];
            this.billstatus = (int)row["billstatus"];
        }
        private string id;
        private DateTime datecheckin;
        private DateTime datecheckout;
        
        private int billstatus;

        public string Id { get => id; set => id = value; }
        public DateTime Datecheckin { get => datecheckin; set => datecheckin = value; }
        public DateTime Datecheckout { get => datecheckout; set => datecheckout = value; }
        
        public int Billstatus { get => billstatus; set => billstatus = value; }
    }
}
