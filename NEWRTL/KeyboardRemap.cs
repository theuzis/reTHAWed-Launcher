using MadMilkman.Ini;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NEWRTL
{
    public partial class KeyboardRemap : Form
    {
        public KeyboardRemap()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                // Prevent Tab from changing focus
                return true; // true = key is handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys key);

        string bind_localTextBuf = "";
        public void KeyHandler(int KeyVal, string KeySetting, string KeyCode)
        {
            bind_localTextBuf = "";
            if (!(Constants.KeyboardBindBlacklist.Contains(KeyCode)))
            {
                Constants.KeyCodeBuffer = KeyVal;
                Constants.ConvertedKeyCode = Convert.ToString(SDLHandler.ConvertToSDL((Keys)Constants.KeyCodeBuffer));

                bind_localTextBuf = KeyCode;
                string StoredKeyCode = Constants.ConvertedKeyCode;

                if (Convert.ToBoolean(GetAsyncKeyState(Keys.RShiftKey)))
                {
                    bind_localTextBuf = "RShiftKey";
                    StoredKeyCode = Convert.ToString(SDLHandler.ConvertToSDL((Keys)161));
                }
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.LShiftKey)))
                {
                    bind_localTextBuf = "LShiftKey";
                    StoredKeyCode = Convert.ToString(SDLHandler.ConvertToSDL((Keys)160));
                }
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.LControlKey)))
                {
                    bind_localTextBuf = "LControlKey";
                    StoredKeyCode = Convert.ToString(SDLHandler.ConvertToSDL((Keys)162));
                }
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.RControlKey)))
                {
                    bind_localTextBuf = "RControlKey";
                    StoredKeyCode = Convert.ToString(SDLHandler.ConvertToSDL((Keys)163));
                }

                INIHandler.Save("Keybinds", KeySetting, StoredKeyCode);
            }
            else
            {
                MessageBox.Show("Cannot bind action to " + KeyCode + "!", "reTHAWed Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Make it so you can drag the window.
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private readonly Dictionary<string, string> controlNameMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
          { "bRT", "Revert" },
          { "bLT", "Nollie" },
          { "bRB", "SpinRight" },
          { "bLB", "SpinLeft" },
          { "bGRIND", "Grind" },
          { "bGRAB", "Grab" },
          { "bOLLIE", "Ollie" },
          { "bDPADUP", "ItemUp" },
          { "bDPADLEFT", "ItemLeft" },
          { "bDPADDOWN", "ItemDown" },
          { "bDPADRIGHT", "ItemRight" },
          { "bFOCUS", "Focus" },
          { "bRIGHTSWIVELLOCK", "SwivelLock" },
          { "bLEFTSTICKUP", "Forward" },
          { "bLEFTSTICKLEFT", "Left" },
          { "bLEFTSTICKDOWN", "Backward" },
          { "bLEFTSTICKRIGHT", "Right" },
          { "bRIGHTSTICKUP", "CameraUp" },
          { "bRIGHTSTICKLEFT", "CameraLeft" },
          { "bRIGHTSTICKDOWN", "CameraDown" },
          { "bRIGHTSTICKRIGHT", "CameraRight" },
          { "bSpine", "SpineTransfer"},
          { "bFLIP", "Flip" },
          { "bCave", "Caveman"},
          { "bQuick", "ViewToggle"}
        };


        private void TextBox_CommonHandler(object sender, KeyEventArgs e)
        {

            if (sender is TextBox textBox)
            {
                if (textBox != null)
                {
                    e.SuppressKeyPress = true;
                    string controlName = textBox.Name;

                    if (controlNameMap.TryGetValue(controlName, out string mappedValue))
                    {
                        textBox.Text = "";
                        KeyHandler(e.KeyValue, mappedValue, e.KeyCode.ToString());
                        textBox.Text = bind_localTextBuf;
                        Debug.Print($"You typed in: {mappedValue}");
                    }
                    else
                    {
                        Debug.Print($"Unknown control: {controlName}");
                    }
                }
            }
        }

        public void LoadINIValues(Control.ControlCollection controls)
        {
            //Load the ini and parse its info into the program on form load.
            if (System.IO.File.Exists(Constants.INIPath))
            {
                IniFile file = new IniFile(new IniOptions());
                file.Load(Constants.INIPath);
                foreach (var key in file.Sections["Keybinds"].Keys)
                {
                    foreach (Control control in controls)
                    {
                        if (control is TextBox textBox)
                        {
                            //MessageBox.Show(textBox.Name);
                            //textBox.Text = $"This is {textBox.Name}";
                            string controlName = textBox.Name;

                            if (controlNameMap.TryGetValue(controlName, out string mappedValue))
                            {
                                if (mappedValue == key.Name)
                                {
                                    int toSDL = int.Parse(key.Value);
                                    textBox.Text = SDLHandler.ConvertFromSDL(toSDL);
                                }
                            }
                        }
                        // Recursively check nested controls (e.g., inside Panels, GroupBoxes)
                        if (control.HasChildren)
                        {
                            LoadINIValues(control.Controls);
                        }
                    }
                }
            }
        }

        private void KeyboardRemap_Load(object sender, EventArgs e)
        {
            LoadINIValues(this.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
