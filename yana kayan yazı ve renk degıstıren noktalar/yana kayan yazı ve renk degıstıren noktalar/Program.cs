using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace yana_kayan_yazı_ve_renk_degıstıren_noktalar
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
            Application.Run(new Form1());
        }
    }
}
