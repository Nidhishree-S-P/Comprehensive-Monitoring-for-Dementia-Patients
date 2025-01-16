using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SensorMonitoring
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
            //Application.Run(new Form1());
            //Application.Run(new settings());
            //Application.Run(new LogViewer());
            Application.Run(new LoginScreen());
        }
    }
}
