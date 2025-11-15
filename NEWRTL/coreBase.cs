// --------------------
//  coreBase.cs
//  Created 28/09/2024
//  Author : Uzis
//  Editors : ...
// --------------------
using NEWRTL.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace NEWRTL
{

    public partial class coreBase : Form
    {

        bool HasCheckedSettings = false;
        public static string vNumfilePath = "version.txt";
        public static string vNumFile = Version;
        public static string VNUM = VersionToString;
        public static string Version = null;
        public static string VersionToString = null;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public static void attemptVersionString()
        {
            if (System.IO.File.Exists(vNumfilePath))
            {
                Version = File.ReadAllText(vNumfilePath);
            }
        }

        public static void attemptVersionToString()
        {
            if (System.IO.File.Exists(vNumfilePath))
            {
                VersionToString = vNumFile.ToString();
            }
        }

        public void AutoCheckForUpdate()
        {
            try //wine seems to cry over version.txt missing on linux, so we'll en-case this into a try/catch.
            {
                Console.WriteLine("Attempting to Check for Update.");
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient checkString = new WebClient();
                string checkUpdater = checkString.DownloadString("https://gitgud.io/uzis/rethawed-release-repository/-/raw/master/reTHAWed/hashlist.dat?ref_type=heads");
                // Split into lines, remove empty ones
                string[] lines = checkUpdater.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Version is line index 1
                string NetVersion = lines.Length > 1 ? lines[1].Trim() : "";

                Version vA = new Version(Version);
                Version vB = new Version(NetVersion);

                // Use it
                Console.WriteLine(NetVersion);
                //var CheckValue = Regex.Match(checkUpdater, "<div class=\"version-text\">(.*)</div>").Groups[1].Value;
                // MessageBox.Show(CheckValue);
                if (System.IO.File.Exists("version.txt"))
                {
                    try
                    {
                        Console.WriteLine("Checking for Update...");
                        if (NetVersion.Contains("<!DOCTYPE HTML>")) //Probably a bad way to check if repo is down. but alas.
                        {
                            Console.WriteLine("~~ GitGud Repository is down? ~~");
                            Console.WriteLine("CANNOT FETCH VERSION STRING FROM REPO");
                            return;
                        }
                        if (!NetVersion.Contains(Version)) //If a new version is found, tell the user.
                        {
                            if (vA > vB)
                            {
                                Console.WriteLine("User is on a future update, or dev build. Don't pop update check.");
                                label2.Text = "Latest Available Public Version: " + NetVersion.ToString();
                                label3.Text = "Current Version Installed: " + Version;
                                return;
                            }
                            Console.WriteLine("~~ Client is out of date! ~~");
                            Console.WriteLine("Update: " + NetVersion.ToString() + " was found.");
                            Console.WriteLine("Client is currently on Update: " + Version);
                            System.Media.SystemSounds.Asterisk.Play();
                            if (MessageBox.Show("A new version of reTHAWed is available!\n\n" + "Current version: " + Version + "\nLatest version: " + NetVersion.ToString() + "\n\nWould you like to update to the latest version?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (System.IO.File.Exists("Updater.exe")) //If updater exists in path, run it if the user said yes.
                                {
                                    Console.WriteLine("~~ Exiting launcher and updating reTHAWed... ~~");
                                    System.Diagnostics.Process.Start("Updater.exe");
                                    System.Windows.Forms.Application.Exit();
                                    Environment.Exit(0);
                                }
                                else //else if the file doesnt exist, tell the user that it doesn't and exit the launcher.
                                {
                                    Console.WriteLine("~~ CRITICAL: Updater.exe seems to NOT exist in the reTHAWed game folder. Has antivirus deleted it? ~~");
                                    MessageBox.Show("Cannot Update without an Updater File!!\n" + "Updater.exe does not exist in file structure.\n" + "Why?");
                                    Console.WriteLine("Exiting.");
                                    label2.Hide();
                                    label3.Text = "Unable to check for update.";
                                }
                            }
                            else //If user said no, skip the updater and change labels to show that there is a new update available..
                            {
                                Console.WriteLine("User chose not to update, skipping.");
                                label2.Text = "New Version Available: " + NetVersion.ToString();
                                label3.Text = "Current Version Installed: " + Version;
                            }
                        }
                        else //If Version.txt matches that of the repo, the user doesn't need updating.
                        {
                            Console.WriteLine("Client doesn't need to update, skipping.");
                            if (Version == null || Version == "")
                            {
                                Console.WriteLine("~~ Client VERSION file is empty? ~~");
                                Console.WriteLine("WARNING: Auto-Update Notification is disabled due to VERSION.TXT being empty.");
                                label2.Hide();
                                label3.Text = "Unable to check for update.";
                            }
                            else
                            {
                                label3.Text = "Current Version Installed: " + Version;
                                label2.Text = "Version installed is up-to-date!";
                                label2.ForeColor = Color.Beige;
                            }
                        }

                    }
                    catch (Exception Ex)//If we catch an error, throw exception.
                    {
                        MessageBox.Show("Ran into an error, Couldn't Check for Update!\n\n" + Ex.Message, "reTHAWed");
                        Console.WriteLine("Client had an error, attempting to skip.");
                        label2.Hide();
                        label3.Text = "Unable to check for update.";
                        //MessageBox.Show(Ex.Message);
                    }
                }
                else // if version.txt doesn't exist in users files, tell them.
                {
                    Console.WriteLine("VERSION.TXT DOES NOT EXIST IN USERS FILES, CREATING");
                    string path = @"version.txt";
                    File.AppendAllText(path, NetVersion);
                    label2.Hide();
                    label3.Text = "Unable to check for update.";
                    // Console.WriteLine("THIS ALSO ISN'T A FATAL ERROR");
                }
            }
            catch (Exception ex) // if caught another exception not handled in this function, tell the user.
            {
                Console.WriteLine("There was an error, can't check for update\n\n" + ex.Message);
                label2.Hide();
                label3.Text = "Unable to check for update.";
                //MessageBox.Show("Oops!, ran into an error, We cannot check for update.\n\n" + ex.Message + "\n\nShow this to a developer.", "reTHAWed");
            }
        }
        public coreBase()
        {
            InitializeComponent();
        }

        private void SetupWindow()
        {
            panel1.Hide();
        }

        private void Startup_coreBase(object sender, EventArgs e)
        { // -- This is where we'll put all of our things that we absolutely need to run on startup.
            try
            {
                attemptVersionString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!System.IO.File.Exists(Constants.INIPath)) // INI Doesn't exist!!! ABORT!!! ABORT!!!
            {
                INIHandler.generateINI();
            }
            AutoCheckForUpdate();

            SetupWindow();
            var dtn = DateTime.Now;
            var day = dtn.Day;
            var month = dtn.Month;

            //label2.Text = day + " " + month;
            if (day == 1 && month == 4) // Make april fools button visible on april fools.
            {
                button10.Visible = true;
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
        // ---------------------------------

        private void button5_Click(object sender, EventArgs e)
        { // Exit the app.
            Environment.Exit(0);
            System.Windows.Forms.Application.Exit();
        }

        // Fancy Button Highlight Stuff.
        private void button1_MouseEnter(object sender, EventArgs e) {
            var But = sender as Button;
            if (But.Text == "RESET ALL SETTINGS")
            {
                But.ForeColor = Color.Red;
            }
            else
            {
                But.ForeColor = Color.HotPink;
            }

        }
        private void button1_MouseLeave(object sender, EventArgs e) {
            var But = sender as Button;
            if (But.Text == "RESET ALL SETTINGS")
            {
                But.ForeColor = Color.IndianRed;
            }
            else if (But.Text == "ITEM SHOP")
            { // Make sure Apr Fools button stays green on leave.
                But.ForeColor = Color.Green;
            }
            else
            {
                But.ForeColor = Color.White;
            }
           
        }
        // ----------------------------------
        private void button3_Click(object sender, EventArgs e)
        { // Determine whether or not the Settings Window should be shown, and change the settings button BG.
            if (HasCheckedSettings == false)
            {
                button2.BackgroundImage = NEWRTL.Properties.Resources.ntrl_button_selected;
                panel1.Show();
                HasCheckedSettings = true;
            }
            else
            {
                button2.BackgroundImage = NEWRTL.Properties.Resources.ntrl_button_test;
                panel1.Hide();
                HasCheckedSettings = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var z = new coreSettings();
            z.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("reTHAWed.exe"))
            {
                System.Diagnostics.Process.Start("reTHAWed.exe");
                System.Windows.Forms.Application.Exit();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Cannot locate reTHAWed.exe\n\nPlease run the updater to repair your mod installation.\nOr move your launcher to the game directory if it is not in there."
                    , "reTHAWed"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=o-YBDTqX_ZU");
            button10.Visible = false;
            rickRoll.Visible = true;

            Bitmap bmp = new Bitmap(Resources.nrtl_bg_aprfool);
            this.BackgroundImage = bmp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var z = new KeyboardRemap();
            z.ShowDialog(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("Updater.exe"))
            {
                System.Diagnostics.Process.Start("Updater.exe");
                System.Windows.Forms.Application.Exit();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("The launcher cannot locate the updater executable file.\n\nPlease make sure the launcher and the updater are both located in the reTHAWed installation folder."
                    , "reTHAWed Launcher"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

            }
        }

        public static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("OrTMM.exe"))
            {
                if (IsProcessRunning("OrTMM") == false)
                {
                    System.Diagnostics.Process.Start("OrTMM.exe");
                }
                else
                {
                    MessageBox.Show("Cannot open two instances of Outcast's Mod Manager at once!"
                    , "reTHAWed Launcher"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The launcher cannot locate the Mod Manager executable file.\n\nPlease make sure the launcher and the Mod Manager are both located in the reTHAWed installation folder.\n\nIf you cannot locate it, re-download Outcast's Mod Manager from the reTHAWed Mod Depository or Check for Update on reTHAWed."
                    , "reTHAWed Launcher"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            if (MessageBox.Show("Are you sure you would like to reset ALL settings?\n\nThis will even wipe any settings changes you have made in-game, such as hud options, sound options, etc.", "reTHAWed Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                INIHandler.generateINI();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Navigates to the Official Discord Server.
            MessageBox.Show("Now Navigating to the Official reTHAWed Discord Invite through your Default Browser.", "reTHAWed Launcher",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://discord.gg/rethawed");
        }
    }
}
