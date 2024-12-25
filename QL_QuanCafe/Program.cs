using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCafe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_Login());
            //Application.Run(new frm_infoEmpleyee());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_Login loginForm = new frm_Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Frm_Manager(loginForm.typeaccount));
            }
        }
    }
}
