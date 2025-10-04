// --------------------
//  GlobalFunc.cs
//  Created 29/09/2024
//  Author : Uzis
//  Editors : ...
// --------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWRTL
{
    internal class GlobalFunc
    {

        public static void PopupNotFinished()
        {
            MessageBox.Show("This area of the launcher is currently not yet finished.\n\nPlease stay tuned!", "reTHAWed Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
