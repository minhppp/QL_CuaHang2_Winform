using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_QuanCafe.BLL;
using QL_QuanCafe.DAL;

namespace QL_QuanCafe
{
    public partial class Frm_Manager : Form
    {
        private int typeaccount; // Loại tài khoản: 0 = Admin, 1 = Nhân viên
        private float total = 0; // Tổng tiền hóa đơn

        public Frm_Manager(int typeaccount)
        {
            InitializeComponent();
            this.typeaccount = typeaccount;

            ConfigureMenu(); // Cấu hình menu theo quyền
            LoadTable(); // Tải danh sách bàn
        }

        // Cấu hình menu theo quyền tài khoản
        private void ConfigureMenu()
        {
            if (typeaccount == 1) // Nhân viên
            {
                quảnLýToolStripMenuItem.Enabled = false; // Ẩn mục quản lý
            }
            else if (typeaccount == 0) // Admin
            {
                quảnLýToolStripMenuItem.Enabled = true; // Hiển thị đầy đủ
            }
        }

        // Xử lý khi nhấn nút Đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Xử lý khi nhấn nút Quản lý
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (typeaccount == 0) // Chỉ Admin mới có quyền
            {
                frm_Admin frmAdmin = new frm_Admin();
                this.Hide();
                frmAdmin.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hiển thị danh sách bàn
        private void LoadTable()
        {
            List<TableDAL> tableList = TTableBLL.Instance.loadTTable();
            foreach (TableDAL table in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableDAL.tableWith,
                    Height = TableDAL.tableHeigh,
                    Text = $"{table.name}{Environment.NewLine}Trạng thái: {(table.Statustable == "0" ? "Trống" : "Đang sử dụng")}",
                    BackColor = table.Statustable == "0" ? Color.White : Color.Red,
                    Tag = table
                };

                btn.Click += btn_ClickTable;
                fLPanel1.Controls.Add(btn);
            }
        }

        // Hiển thị hóa đơn cho bàn được chọn
        private void ShowBill(string tableId)
        {
            lv_TTable.Items.Clear();
            total = 0;

            List<MenuDAL> listBillInfo = MenuBLL.Instance.GetListMenubyTable(tableId);

            foreach (MenuDAL item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Namefood.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString("C"));
                lvItem.SubItems.Add(item.Totalprice.ToString("C"));

                total += item.Totalprice;
                lv_TTable.Items.Add(lvItem);
            }

            txt_total.Text = total.ToString("C");
        }

        // Sự kiện khi nhấn nút trên danh sách bàn
        private void btn_ClickTable(object sender, EventArgs e)
        {
            string tableId = ((sender as Button).Tag as TableDAL).iD;
            ShowBill(tableId);
        }

        // Sự kiện khi nhấn nút thanh toán hóa đơn
        private void btn_Pay_Bill_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                MessageBox.Show($"Hóa đơn đã được thanh toán. Tổng tiền: {total:C}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_total.Text = "0";
                total = 0;
            }
            else
            {
                MessageBox.Show("Không có hóa đơn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Làm mới tổng tiền
        private void btn_Resfesh_Click(object sender, EventArgs e)
        {
            txt_total.Text = "0";
            total = 0;
        }

        // Sự kiện khi đóng form
        private void Frm_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Info_employee frm_Info_Employee = new frm_Info_employee();
            this.Hide();
            frm_Info_Employee.ShowDialog(this);
            this.Show();
        }

        private void cb_select_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_select_category.SelectedItem != null)
            {
                var selectedCategory = (CategoryDAL)cb_select_category.SelectedItem;

                // Lấy danh sách món theo danh mục
                List<FoodDAL> foods = FoodBLL.Instance.GetcomboFooDALs(selectedCategory.Id);

                // Cập nhật ComboBox món ăn
                cb_select_food.DataSource = foods;
                cb_select_food.DisplayMember = "Namefood"; // Tên món
                cb_select_food.ValueMember = "ID"; // ID món
            }
        }

        private void cb_select_food_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_food_Click(object sender, EventArgs e)
        {
           /* TableDAL table = lv_TTable.Tag as TableDAL;

            // Lấy ID hóa đơn của bàn hiện tại
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill =BillBLL.Instance.getBillidByTTableid(table.iD);
            int foodID = (cb_Food.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            // Update the table status to "Đã sử dụng" (used)
            TableDAL.Instance.UpdateTableStatus(table.ID, "Đã sử dụng");

            ShowBill(table.ID);

            LoadTable();*/
        }
        public void AddFoodToBill(int foodId, int quantity)
        {
            // Lấy hóa đơn hiện tại
            /*BillDAL currentBill = GetCurrentBillDAL();

            if (currentBill == null)
            {
                throw new InvalidOperationException("Hóa đơn hiện tại không tồn tại!");
            }

            // Kiểm tra xem món ăn đã có trong hóa đơn chưa
            var billInfo = currentBill.BillInfos.FirstOrDefault(b => b.FoodId == foodId);

            if (billInfo != null)
            {
                // Nếu số lượng là -1, xóa món
                if (quantity == -1 || billInfo.Quantity + quantity <= 0)
                {
                    currentBill.BillInfos.Remove(billInfo);
                }
                else
                {
                    billInfo.Quantity += quantity;
                }
            }
            else if (quantity > 0)
            {
                // Thêm món mới nếu chưa tồn tại
                currentBill.BillInfos.Add(new BillInfoDAL
                {
                    FoodId = foodId,
                    Quantity = quantity
                });
            }*/
        }

        
    }
}

