using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.BLL
{
    public class AccountBLL
    {
        private static AccountBLL instance;

        public static AccountBLL Instance 
        {
            get { if (instance == null) instance = new AccountBLL(); return AccountBLL.instance; }
            private set { AccountBLL.instance = value; }
        }
        public AccountBLL() { }

        public int Login(string Username, string Password)
        {
            

            // Truy vấn tham số hóa
            string query = "SELECT typeaccount FROM dbo.ACCOUNT WHERE username = '"+@Username+"' AND pass = '"+@Password+"'";

            // Tạo danh sách tham số
            object[] parameters = new object[]
            {
                new SqlParameter("@Username", Username),
                new SqlParameter("@Password", Password)
            };

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                // Lấy vai trò người dùng từ cột "Role"
                return Convert.ToInt32(result.Rows[0]["typeaccount"]);
            }

            // Trả về -1 nếu đăng nhập thất bại
            return -1;
        }
    }
}
