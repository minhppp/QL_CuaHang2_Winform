using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCafe.BLL
{
    public class DataProvider
    {
        //LOPDUNGCHUNG

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }


        private DataProvider() { }

        private string diachi = "Data Source=DESKTOP-PRV1S2L;Initial Catalog=QLQUANCAFE;Integrated Security=True;";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(diachi))
            {   
            //kết nối
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(data);
            sqlConnection.Close();
            }return data;  
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(diachi))
            {
                //kết nối
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                data = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(diachi))
            { 
                SqlCommand comm = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ketqua = (int)comm.ExecuteScalar();
                sqlConnection.Close();
                return ketqua;
            }
        }
    }
}
