using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCafe
{
    public partial class frm_Info_employee : Form
    {
        public frm_Info_employee()
        {
            InitializeComponent();
        }

        private void frm_Info_employee_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
