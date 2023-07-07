using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3.Home;
using Group3.NewFolder1;
namespace Group3
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
            //NewFolder1.Form1 h=new NewFolder1.Form1();
            Home.Home h = new Home.Home();
            Application.Run(h);
        }
    }
}
