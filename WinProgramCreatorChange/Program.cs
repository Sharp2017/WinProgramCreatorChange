using System;
using System.Collections.Generic; 
using System.Windows.Forms;
using System.Configuration;

namespace WinProgramCreatorChange
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globals.X1Connection = ConfigurationManager.AppSettings["X1Connection"];
            Application.Run(new FrmMain());
        }
    }
}
