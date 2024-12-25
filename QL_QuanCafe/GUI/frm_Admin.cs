using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_QuanCafe.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QL_QuanCafe
{
    public partial class frm_Admin : Form
    {


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tp_Food_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dụng?", "Notify", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK) // messageBox thoát chương trình
            {
                e.Cancel = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// bắt đầu code
        /// </summary>
        public frm_Admin()
        {

            InitializeComponent();
            //LoadListBox_food();
            LoadCombo_category();
            loadDataGrid_Employee();
            loadDataGrid_Food();
            loadDataGrid_Category();
            loadDataGrid_TTable();
            //LoadListBox_food();
            LoadCombo_category();
            loadDataGrid_Food();




        }
        //---------------employee   
        void loadDataGrid_Employee() //loaddatagrid
        {
            string query = @"
            SELECT 
            dbo.ACCOUNT.id as [ID tài khoản], dbo.ACCOUNT.namedisplay as [Tên hiển thị], dbo.ACCOUNT.username as [Tài khoản], dbo.ACCOUNT.pass as [Password], dbo.ACCOUNT.typeaccount as [Phân quyền], 
            dbo.EMPLOYEE.fullname as [Họ Tên], dbo.EMPLOYEE.sex as [Giới tính],dbo.EMPLOYEE.numberphone as [Số điện thoại],dbo.EMPLOYEE.birthday as [Sinh nhật],dbo.EMPLOYEE.pay as [Lương],dbo.EMPLOYEE.payroll as [Lương nhận]
            FROM dbo.ACCOUNT
            INNER JOIN dbo.EMPLOYEE ON dbo.ACCOUNT.id = dbo.EMPLOYEE.idAccount
            WHERE dbo.ACCOUNT.id = dbo.EMPLOYEE.idAccount;";
            //câu truy vấn
            dataGridView_Employee.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void dataGridView_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Employee.Text = dataGridView_Employee.CurrentRow.Cells["ID tài khoản"].Value.ToString();
            txt_FullName_Employee.Text = dataGridView_Employee.CurrentRow.Cells["Họ Tên"].Value.ToString();
            txt_UserName_Employee.Text = dataGridView_Employee.CurrentRow.Cells["Tài khoản"].Value.ToString();
            txt_Password_Employee.Text = dataGridView_Employee.CurrentRow.Cells["Password"].Value.ToString();
            txt_Sex_Employee.Text = dataGridView_Employee.CurrentRow.Cells["Giới tính"].Value.ToString();
            txt_Birthday_Employee.Text = dataGridView_Employee.CurrentRow.Cells["Sinh nhật"].Value.ToString();
            txt_NumberPhone_Eployee.Text = dataGridView_Employee.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            txt_Pay_Employee.Text = dataGridView_Employee.CurrentRow.Cells["Lương"].Value.ToString();
        }


        void loadDataGrid_TTable()
        {
            string query = @"SELECT * FROM dbo.TTABLE";
            dataGridView_TTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        //---------food
        void loadDataGrid_Food()
        {
            string query = @"SELECT * FROM dbo.FOOD";
            dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        //public void LoadListBox_food()
        //{
        //    string query = "select id, statusfood from food";
        //    lb_food.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //    lb_food.DisplayMember = "statusfood";
        //    lb_food.ValueMember = "id";
        //}
        private void btn_Add_NewFood_Click(object sender, EventArgs e)
        {
            string query = @"insert into dbo.FOOD values('" + txt_ID_Food.Text + "',N'" + txt_Name_Food.Text + "','" + cb_Category_Food.SelectedValue + "','" + txt_Price.Text + "','" + txt_statusfood.Text + "')";
            dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_Food();
        }

        private void btn_Search_Food_Click(object sender, EventArgs e)
        {
            string query = @"select * from FOOD where namefood like '%" + txt_Search_Food.Text + "%'";
            dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btn_Delete_Food_Click(object sender, EventArgs e)
        {
            string query = "delete FOOD where id = '" + txt_ID_Food.Text + "'";
            dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_Food();
        }
        int tim = 0;
        private void dataGridView_Food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Food.Text = dataGridView_Food.CurrentRow.Cells["id"].Value.ToString();
            txt_Name_Food.Text = dataGridView_Food.CurrentRow.Cells["namefood"].Value.ToString();
            txt_Price.Text = dataGridView_Food.CurrentRow.Cells["price"].Value.ToString();
            tim = 1;
            cb_Category_Food.SelectedValue = dataGridView_Food.CurrentRow.Cells["idFoodcategory"].Value.ToString();
            //tim = 1;
            //lb_food.SelectedValue = dataGridView_Food.CurrentRow.Cells["stastusfood"].Value.ToString();
            txt_statusfood.Text = dataGridView_Food.CurrentRow.Cells["statusfood"].Value.ToString();
        }

        private void txt_Search_Food_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_Search_Food;
        }

        private void cb_Category_Food_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                string idcategoryFood = cb_Category_Food.SelectedValue.ToString();
                string query = "select * from FOOD where idFoodcategory = '" + idcategoryFood + "'";
                dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            tim = 0;
        }

        private void btn_Resfesh_Food_Click(object sender, EventArgs e)
        {
            loadDataGrid_Food();
        }

        private void btn_Fix_Food_Click(object sender, EventArgs e)
        {
            string query = @"update FOOD set id= '" + txt_ID_Food.Text + "', namefood= N'" + txt_Name_Food.Text + "', idFoodcategory = '" + cb_Category_Food.SelectedValue + "', price='" + txt_Price.Text + "' ,statusfood='" + txt_statusfood.Text + "' WHERE id= '" + txt_ID_Food.Text + "' ";
            dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_Food();
        }

        private void btn_count_SlFOOD_Click(object sender, EventArgs e)
        {
            string sqlDem = "select count (*) from FOOd";
            int kq = (int)DataProvider.Instance.ExecuteScalar(sqlDem);
            txt_count_SLFOOD.Text = kq.ToString();
        }

        //private void lb_food_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tim == 0)
        //    {
        //        string status = lb_food.SelectedValue.ToString();
        //        string query = "select * from FOOD where statusfood = '" + status + "'";
        //        dataGridView_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //    }
        //    tim = 0;
        //}


        //------category
        void loadDataGrid_Category()
        {
            string query = @"SELECT * FROM dbo.FOODCATEGORY";
            dataGridView_Category.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void LoadCombo_category()
        {
            string query = "select * from FOODCATEGORY";
            cb_Category_Food.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cb_Category_Food.DisplayMember = "namecategory";
            cb_Category_Food.ValueMember = "id";
        }
        private void dataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name_Category.Text = dataGridView_Category.CurrentRow.Cells["namecategory"].Value.ToString();
            txt_ID_Category.Text = dataGridView_Category.CurrentRow.Cells["id"].Value.ToString();
        }

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            string query = @"insert into dbo.FOODCATEGORY values('" + txt_ID_Category.Text + "',N'" + txt_Name_Category.Text + "')";
            dataGridView_Category.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_Category();
        }

        private void btn_Fix_Category_Click(object sender, EventArgs e)
        {
            string query = @"update FOODCATEGORY set id= '" + txt_ID_Category.Text + "', namecategory= N'" + txt_Name_Category.Text + "'";
            dataGridView_Category.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_Category();
        }

        private void btn_Delete_Category_Click(object sender, EventArgs e)
        {
            string query = "delete FOODCATEGORY where id = '" + txt_ID_Category.Text + "'";
            dataGridView_Category.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_Category();
        }

        private void btn_Resfesh_Category_Click(object sender, EventArgs e)
        {
            loadDataGrid_Category();
        }

        //-----table
        private void dataGridView_TTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name_TTable.Text = dataGridView_TTable.CurrentRow.Cells["nametable"].Value.ToString();
            txt_ID_TTable.Text = dataGridView_TTable.CurrentRow.Cells["id"].Value.ToString();
            txt_Stattus_TTable.Text = dataGridView_TTable.CurrentRow.Cells["statustable"].Value.ToString();
        }

        private void btn_AddNew_TTable_Click(object sender, EventArgs e)
        {
            string query = @"insert into dbo.TTABLE values('" + txt_ID_TTable.Text + "',N'" + txt_Name_TTable.Text + "','"+txt_Stattus_TTable.Text+"')";
            dataGridView_TTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_TTable();
        }

        private void btn_Fix_TTable_Click(object sender, EventArgs e)
        {
            string query = @"update TTABLE set id= '" + txt_ID_TTable.Text + "', nametable= N'" + txt_Name_TTable.Text + "', statustable= '"+txt_Stattus_TTable.Text+"'";
            dataGridView_TTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_TTable();
        }

        private void btn_Delete_TTable_Click(object sender, EventArgs e)
        {
            string query = "delete TTABLE where id = '" + txt_ID_TTable.Text + "'";
            dataGridView_TTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadDataGrid_TTable();
        }

        private void btn_Resfesh_TTable_Click(object sender, EventArgs e)
        {
            loadDataGrid_TTable();
        }

        private void btn_Count_TTable_Click(object sender, EventArgs e)
        {
            string sqlDem = "select count (*) from TTable";
            int kq = (int)DataProvider.Instance.ExecuteScalar(sqlDem);
            txt_CountTable.Text = kq.ToString();
        }
    }
}
