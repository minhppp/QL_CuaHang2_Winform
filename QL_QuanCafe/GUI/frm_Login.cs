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

namespace QL_QuanCafe
{
    public partial class frm_Login : Form
    {
        public int typeaccount { get; private set; } // Vai trò người dùng

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ giao diện
                string username = txt_Username.Text.Trim();
                string password = txt_Password.Text;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi phương thức Login và lấy vai trò
                int typeaccount = AccountBLL.Instance.Login(username, password);

                if (typeaccount >= 0)
                {
                    // Gán vai trò cho thuộc tính UserRole
                    typeaccount = typeaccount;

                    // Mở giao diện chính
                    Frm_Manager frmManager = new Frm_Manager(typeaccount);
                    this.Hide(); // Ẩn form đăng nhập
                    frmManager.ShowDialog(); // Hiển thị form quản lý

                    // Hiển thị lại form đăng nhập nếu form quản lý bị đóng
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát ứng dụng
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true; // Hủy việc đóng form
            }
        }
    }
}
