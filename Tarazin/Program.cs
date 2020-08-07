using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarazin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();

            Application.Run(loginForm);

            //if (loginForm.UserAuthenticated)
            //{
            //    Application.Run(new frmMain());
            //}

           
        }
    }
}
