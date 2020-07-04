using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
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
            //<<<<<<< HEAD
            //            Application.Run(new frmFuction());
            //=======
            //            Application.Run(new FrmSale());
            //>>>>>>> f71822bad9db7fcd445c073b8b21cec2ab8ee825
            Application.Run(new frmFuction());
        }
    }
}
