using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWRTL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            bool isNewInstance;

            // Use a named mutex to prevent multiple instances
            using (Mutex mutex = new Mutex(true, "reTHAWedLauncher", out isNewInstance))
            {
                if (!isNewInstance)
                {
                    MessageBox.Show("An instance of the reTHAWed Launcher is already running!\n\nCannot run two instances at once.", "reTHAWed Launcher", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }
                //isNewInstance = true;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new coreBase());
            }
        }
    }
}
