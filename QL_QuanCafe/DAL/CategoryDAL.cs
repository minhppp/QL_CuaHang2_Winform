using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.DAL
{
    public class CategoryDAL
    {
        
        public CategoryDAL(string id,string namecategory) 
        { 
            this.id=id; 
            this.namecategory=namecategory;   
        }
        public CategoryDAL(DataRow row) 
        {
            this.id = row["id"].ToString();
            this.namecategory = row["namecategory"].ToString();
        }
        private string id;
        private string namecategory;

        public string Id { get => id; set => id = value; }
        public string Namecategory { get => namecategory; set => namecategory = value; }
    }
}
