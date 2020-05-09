using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpineOMatic_cs
{
    static class Program
    {
        public static String 
            PROGRAM_NAME = "SpineOMatic", 
            PROGRAM_VER = "8.1.0",
            ABOUT_DESCRIPTION = @"
Works with Ex Libris' Alma to print spine labels, flag slips, or other 
custom labels to a variety of desktop or networked printers.
";

        //gr.DrawString("SpineOMatic", bFont, Brushes.Black, 5, 10)
        //gr.DrawString("v" & somVersion & "", sFont, Brushes.Black, 120, 20)

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
