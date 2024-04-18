using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBoxManager.OK = "Tamam";
            MessageBoxManager.Cancel = "İptal";
            MessageBoxManager.Yes = "Evet";
            MessageBoxManager.No = "Hayır";
            MessageBoxManager.Register();
            Application.Run(new MainPage());
        }
    }
}
