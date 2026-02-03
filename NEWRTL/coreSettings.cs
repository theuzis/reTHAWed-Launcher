// --------------------
//  coreSettings.cs
//  Created 08/10/2024
//  Author : Uzis
//  Editors : ...
//  Ported from SR2 Reloaded launcher.
// --------------------

using MadMilkman.Ini;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NEWRTL
{
    public partial class coreSettings : Form
    {
        public coreSettings()
        {
            InitializeComponent();

        }
        System.Windows.Forms.TextBox editBox = new System.Windows.Forms.TextBox();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        void Animate(PictureBox pictureBox, bool animate)
        {
            var animateMethod = typeof(PictureBox).GetMethod("Animate",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance,
            null, new Type[] { typeof(bool) }, null);
            animateMethod.Invoke(pictureBox, new object[] { animate });
        }

        private void previewImageAPI(string image)
        {
            previewImage.Show();
            previewImage.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(image);
            previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        string CurrentSection = "";
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (File.Exists(Constants.INIPath))
            {
                foreach (ListViewItem item in OptionsList.SelectedItems)
                {
                    try
                    {
                        if (item.Selected)
                        {
                            if (!(item.Group.Header.Length < 1))
                            {
                                CurrentSection = item.Group.Header;
                            }
                            OptionNameTag.Show();

                            try
                            {
                                //  previewImage.Show();
                                previewImageAPI(item.SubItems[0].Text);
                            }
                            catch (Exception ex)
                            {
                                // This check will give us an error but it does what we want it to do so who cares.
                                MessageBox.Show(ex.Message);
                            }

                            OptionNameTag.Text = item.SubItems[0].Text;
                            OptionsDesc.Text = Constants.OptionsItemDesc[item.Index];
                            blackPreviewBG.Show();
                            switch (item.Tag)
                            {

                                case "NonBoolean":
                                    OptComboBox.Visible = false;
                                    previewImage.Visible = false;
                                    Animate(previewImage, false);
                                    button2.Visible = false;
                                    break;

                                case "ResolutionNBL":
                                    OptComboBox.Visible = false;
                                    previewImage.Visible = false;
                                    Animate(previewImage, false);
                                    button2.Visible = true;

                                    break;

                                case "ComboBox":
                                    previewImage.Visible = false;
                                    button2.Visible = false;
                                    Animate(previewImage, false);
                                    // -- Flush Combo Box and re-add items depending on the option.
                                    OptComboBox.Items.Clear();
                                    OptComboBox.ResetText();
                                    if (OptionNameTag.Text == "Shadows")
                                    {
                                        OptComboBox.Items.Add("None");
                                        OptComboBox.Items.Add("Low");
                                        OptComboBox.Items.Add("High");
                                    }
                                    if (OptionNameTag.Text == "SafeArea")
                                    {
                                        OptComboBox.Items.Add("Close");
                                        OptComboBox.Items.Add("Wide");
                                    }
                                    if (OptionNameTag.Text == "Autolaunch")
                                    {
                                        OptComboBox.Items.Add("mainmenu");
                                        OptComboBox.Items.Add("freeskate");
                                    }
                                    if (OptionNameTag.Text == "Renderer")
                                    {
                                        OptComboBox.Items.Add("Direct-X 9");
                                        OptComboBox.Items.Add("DXVK (Vulkan)");
                                    }
                                    if (OptionNameTag.Text == "AutolaunchLevel")
                                    {
                                        if (Directory.Exists("./data/mod/Zones/"))
                                        {
                                            string[] dirs = Directory.GetDirectories("./data/mod/Zones/");
                                            foreach (string mapinlist in dirs)
                                            {
                                                FileInfo f = new FileInfo(mapinlist);
                                                OptComboBox.Items.Add(f.Name);
                                            }
                                        }
                                    }
                                    if (OptionNameTag.Text == "AutolaunchGame")
                                    {
                                        OptComboBox.Items.Add("singlesession");
                                        OptComboBox.Items.Add("classic");
                                    }
                                    if ((OptionNameTag.Text == "SafeArea")
                                        || (OptionNameTag.Text == "Autolaunch")
                                        || (OptionNameTag.Text == "AutolaunchLevel")
                                        || (OptionNameTag.Text == "AutolaunchGame")
                                        || (OptionNameTag.Text == "Renderer"))
                                    {
                                        int index = OptComboBox.FindStringExact(item.SubItems[1].Text);
                                        OptComboBox.SelectedIndex = index;
                                    }
                                    else
                                    {
                                        OptComboBox.SelectedIndex = (int)Convert.ToInt64(item.SubItems[1].Text);
                                    }
                                    OptComboBox.Visible = true;
                                    // ---------------
                                    break;

                                case "ComboBoxIMG":
                                    previewImage.Visible = true;
                                    button2.Visible = false;
                                    previewImageAPI(item.SubItems[0].Text);
                                    Animate(previewImage, false);
                                    // -- Flush Combo Box and re-add items depending on the option.
                                    OptComboBox.Items.Clear();
                                    OptComboBox.ResetText();
                                    if (OptionNameTag.Text == "Shadows")
                                    {
                                        OptComboBox.Items.Add("None");
                                        OptComboBox.Items.Add("Low");
                                        OptComboBox.Items.Add("High");
                                    }
                                    if (OptionNameTag.Text == "SafeArea")
                                    {
                                        OptComboBox.Items.Add("Close");
                                        OptComboBox.Items.Add("Wide");
                                    }
                                    if (OptionNameTag.Text == "Autolaunch")
                                    {
                                        OptComboBox.Items.Add("mainmenu");
                                        OptComboBox.Items.Add("freeskate");
                                    }
                                    if (OptionNameTag.Text == "Renderer")
                                    {
                                        OptComboBox.Items.Add("DirectX9");
                                        OptComboBox.Items.Add("DXVKVulkan");
                                    }
                                    if (OptionNameTag.Text == "AutolaunchLevel")
                                    {
                                        if (Directory.Exists("./data/mod/Zones/"))
                                        {
                                            string[] dirs = Directory.GetDirectories("./data/mod/Zones/");
                                            foreach (string mapinlist in dirs)
                                            {
                                                FileInfo f = new FileInfo(mapinlist);
                                                OptComboBox.Items.Add(f.Name);
                                            }
                                        }
                                    }
                                    if (OptionNameTag.Text == "AutolaunchGame")
                                    {
                                        OptComboBox.Items.Add("singlesession");
                                        OptComboBox.Items.Add("classic");
                                    }
                                    if ((OptionNameTag.Text == "SafeArea")
                                        || (OptionNameTag.Text == "Autolaunch")
                                        || (OptionNameTag.Text == "AutolaunchLevel")
                                        || (OptionNameTag.Text == "AutolaunchGame"))
                                    {
                                        int index = OptComboBox.FindStringExact(item.SubItems[1].Text);
                                        OptComboBox.SelectedIndex = index;
                                    }
                                    else
                                    {
                                        OptComboBox.SelectedIndex = (int)Convert.ToInt64(item.SubItems[1].Text);
                                    }
                                    OptComboBox.Visible = true;
                                    // ---------------
                                    break;

                                case "IMGNonBoolean":
                                    OptComboBox.Visible = false;
                                    button2.Visible = false;
                                    previewImageAPI(item.SubItems[0].Text);
                                    Animate(previewImage, false);

                                    break;

                                case "IMG":
                                    OptComboBox.Visible = false;
                                    button2.Visible = false;
                                    previewImageAPI(item.SubItems[0].Text);
                                    Animate(previewImage, false);
                                    break;

                                case "GIF":
                                    OptComboBox.Visible = false;
                                    button2.Visible = false;
                                    previewImageAPI(item.SubItems[0].Text);
                                    Animate(previewImage, true);
                                    break;

                                default:
                                    OptComboBox.Visible = false;
                                    button2.Visible = false;
                                    previewImage.Visible = false;
                                    Animate(previewImage, false);
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);    
                        Debug.WriteLine("ComboBox Items: " + OptComboBox.Items.Count.ToString());
                        Debug.WriteLine("ComboBox Text: " + OptComboBox.Text);
                        MessageBox.Show("Oops, looks like we ran into an error.\n\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("It seems you were missing \"rethawed.ini\" in your game files. We're creating one for you now.\n\nPlease try changing the option again.", "reTHAWed Launcher", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // TODO: make an algorithm to create an actual proper default ini.
                File.Create(Constants.INIPath);
            }
        }


        private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (Brush backBrush = new SolidBrush(Color.FromArgb(45, 45, 48)))
            using (Pen borderPen = new Pen(Color.FromArgb(62, 62, 66)))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
                e.Graphics.DrawRectangle(borderPen, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Header.Text, OptionsList.Font,
                    e.Bounds, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }

        private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
        }

        private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color backColor = (e.Item.Selected)
                ? Color.FromArgb(63, 63, 70) // Selected row color
                : Color.FromArgb(30, 30, 30); // Normal background

            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, OptionsList.Font,
                e.Bounds, Color.White, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        private void settingsmain_Load(object sender, EventArgs e)
        {
            editBox.Visible = false;
            editBox.BorderStyle = BorderStyle.FixedSingle;
            editBox.Leave += EditBox_Leave;
            editBox.KeyDown += EditBox_KeyDown;
            editBox.BackColor = Color.Black;
            editBox.ForeColor = Color.White;
            this.Controls.Add(editBox);
            OptionsList.DrawColumnHeader += ListView1_DrawColumnHeader;
            OptionsList.DrawItem += ListView1_DrawItem;
            OptionsList.DrawSubItem += ListView1_DrawSubItem;
            OptionsList.MouseDown += Form1_MouseDown;
            OptionsList.MouseMove += Form1_MouseMove;
            OptionsBox.MouseDown += Form1_MouseDown;
            OptionsBox.MouseMove += Form1_MouseMove;
            previewImage.MouseDown += Form1_MouseDown;
            previewImage.MouseMove += Form1_MouseMove;
            blackPreviewBG.MouseDown += Form1_MouseDown;
            blackPreviewBG.MouseMove += Form1_MouseMove;
            previewImage.Visible = false;
            OptionNameTag.Visible = false;
            OptionsList.FullRowSelect = true; // Why is this bullshit hidden
            button2.Visible = false;
            //ToggleOptionButton.Visible = false;
            //EditNonBoolValue.Visible = false;
            OptComboBox.Visible = false;
            //DistClipPanel.Location = new Point(0, -1);
            //DistClipPanel.Hide();
            // Load INI Settings into form.

            if (File.Exists(Constants.INIPath))
            {
                IniFile INI = new IniFile();
                INI.Load(Constants.INIPath);


                foreach (var section in INI.Sections)
                {
                    foreach (var key in section.Keys)
                    {
                        foreach (ListViewItem item in OptionsList.Items)
                        {
                            if (key.Name == item.SubItems[0].Text)
                            {
                                if (section.Keys.Contains(item.SubItems[0].Text))
                                {
                                    Debug.WriteLine("Setting Loaded: " + item.SubItems[0].Text + " - " + section.Keys[item.SubItems[0].Text].Value);
                                    item.SubItems[1].Text = section.Keys[item.SubItems[0].Text].Value;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ToggleOptionButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void EditNonBoolValue_TextChanged(object sender, EventArgs e)
        {
            // NonBoolean toggle
            if (File.Exists(Constants.INIPath))
            {
                IniFile INI = new IniFile();
                INI.Load(Constants.INIPath);
                foreach (var section in INI.Sections)
                {
                    foreach (ListViewItem item in OptionsList.Items)
                    {
                        if (section.Name == CurrentSection)
                        {
                            if (section.Keys.Contains(OptionNameTag.Text))
                            {
                                if (OptionNameTag.Text == item.SubItems[0].Text)
                                {
                                    section.Keys[OptionNameTag.Text].Value = item.SubItems[1].Text;
                                    INI.Save(Constants.INIPath);
                                }
                            }
                            else
                            {
                                section.Keys.Add(OptionNameTag.Text);
                                INI.Save(Constants.INIPath);
                            }
                        }
                    }
                }
            }
        }

        private void OptionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OptionsList_KeyUp(object sender, KeyEventArgs e)
        {
            // Setup a lazy hotkey so boolean toggles can just be toggled by pressing enter when hovering over.
            if (e.KeyCode == Keys.Enter)
            {
                if (!(OptionNameTag.Text == "Option Name"))
                {
                    foreach (ListViewItem item in OptionsList.Items)
                    {
                        if (item.Selected) {
                            if (item.SubItems[1].Text == "1")
                            {
                                item.SubItems[1].Text = "0";
                            }
                            else if (item.SubItems[1].Text == "0")
                            {
                                item.SubItems[1].Text = "1";
                            }
                            ApplyEdit();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OptionsList.SelectedItems.Count == 0)
                return;

            if (OptionNameTag.Text != "ResolutionX" &&
                OptionNameTag.Text != "ResolutionY")
                return;

            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            editBox.Text = (OptionNameTag.Text == "ResolutionX")
                ? screenWidth
                : screenHeight;

            editBox.Visible = true;
            editBox.Focus();
            editBox.SelectAll();
        }


        private void QualityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(Constants.INIPath))
            {
                IniFile INI = new IniFile();
                INI.Load(Constants.INIPath);
                foreach (var section in INI.Sections)
                {
                    foreach (ListViewItem item in OptionsList.Items)
                    {
                        if (section.Name == CurrentSection)
                        {
                            if (section.Keys.Contains(OptionNameTag.Text))
                            {
                                if (OptionNameTag.Text == item.SubItems[0].Text)
                                {
                                    item.SubItems[1].Text = OptComboBox.SelectedIndex.ToString();
                                    if ((OptionNameTag.Text == "SafeArea")
                                        || (OptionNameTag.Text == "Autolaunch")
                                        || (OptionNameTag.Text == "AutolaunchLevel")
                                        || (OptionNameTag.Text == "AutolaunchGame")
                                        || (OptionNameTag.Text == "Renderer"))
                                    {
                                        item.SubItems[1].Text = OptComboBox.Text.ToString();
                                    }
                                    section.Keys[OptionNameTag.Text].Value = item.SubItems[1].Text;
                                    INI.Save(Constants.INIPath);
                                }
                            }
                            else
                            {
                                section.Keys.Add(OptionNameTag.Text);
                                INI.Save(Constants.INIPath);
                            }
                            if (OptionNameTag.Text == "Renderer" && item.SubItems[1].Text == "DXVK (Vulkan)")
                            {
                                if (!File.Exists("d3d9.dll"))
                                {
                                    File.WriteAllBytes("d3d9.dll", Properties.Resources.DonorDLL);
                                }
                            }
                            else if (OptionNameTag.Text == "Renderer" && item.SubItems[1].Text == "Direct-X 9")
                            {
                                if (File.Exists("d3d9.dll"))
                                {
                                    File.Delete("d3d9.dll");
                                }
                            }
                        }
                    }
                }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private Rectangle GetSubItemBounds(ListViewItem item, int subItemIndex)
        {
            int x = item.Bounds.Left;
            for (int i = 0; i < subItemIndex; i++)
            {
                x += OptionsList.Columns[i].Width;
            }

            int width = OptionsList.Columns[subItemIndex].Width;
            return new Rectangle(x + 5, item.Bounds.Top + 5, width - 400, item.Bounds.Height);
        }

        private Rectangle GetSubItemBounds2(ListViewItem item, int subItemIndex)
        {
            int x = item.Bounds.Left;
            for (int i = 0; i < subItemIndex; i++)
            {
                x += OptionsList.Columns[i].Width;
            }

            int width = OptionsList.Columns[subItemIndex].Width;
            return new Rectangle(x - 235, item.Bounds.Top + 3, width - 400, item.Bounds.Height);
        }

        private void OptionsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = OptionsList.HitTest(e.Location);
            if (hit.Item == null || hit.Item.SubItems.Count <= 1)
                return;

            int subItemIndex = 1;
            ListViewItem item = hit.Item;
            Rectangle subItemBounds2 = GetSubItemBounds2(item, subItemIndex);
            Rectangle subItemBounds = GetSubItemBounds(item, subItemIndex);
            if (item.Tag == "ComboBoxIMG" || item.Tag == "ComboBox")
            {
                OptComboBox.Bounds = subItemBounds2;
                OptComboBox.Tag = new Tuple<ListViewItem, int>(item, subItemIndex);
                OptComboBox.BringToFront();
                OptComboBox.Focus();
                OptComboBox.SelectAll();
                if (!(item.SubItems[0].Text == "Renderer" || item.SubItems[0].Text == "SafeArea"))
                {
                    editBox.Bounds = subItemBounds;
                    editBox.Text = item.SubItems[subItemIndex].Text;
                    editBox.Tag = new Tuple<ListViewItem, int>(item, subItemIndex);
                    editBox.Visible = true;
                    editBox.BringToFront();
                    editBox.Focus();
                    editBox.SelectAll();
                }
            }
            else
            {
                editBox.Bounds = subItemBounds;
                editBox.Text = item.SubItems[subItemIndex].Text;
                editBox.Tag = new Tuple<ListViewItem, int>(item, subItemIndex);
                editBox.Visible = true;
                editBox.BringToFront();
                editBox.Focus();
                editBox.SelectAll();
            }
        }

        private void EditBox_Leave(object sender, EventArgs e)
        {
            ApplyEdit();
        }

        private void EditBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyEdit();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                editBox.Visible = false;
            }
        }

        private void ApplyEdit()
        {
            if (editBox.Tag is Tuple<ListViewItem, int> data)
            {
                data.Item1.SubItems[data.Item2].Text = editBox.Text;
            }

            if (File.Exists(Constants.INIPath))
            {
                IniFile INI = new IniFile();
                INI.Load(Constants.INIPath);
                if (!INI.Sections.Contains(CurrentSection))
                {
                    INI.Sections.Add(CurrentSection);
                }
                foreach (var section in INI.Sections)
                {
                    foreach (ListViewItem item in OptionsList.Items)
                    {
                        if (section.Name == CurrentSection)
                        {
                            if (section.Keys.Contains(OptionNameTag.Text))
                            {
                                if (OptionNameTag.Text == item.SubItems[0].Text)
                                {
                                    //if (ToggleOptionButton.Visible == true)
                                    //{
                                   //     item.SubItems[1].Text = ToggleOptionButton.Checked ? "1" : "0";
                                   // }
                                    section.Keys[OptionNameTag.Text].Value = item.SubItems[1].Text;
                                    INI.Save(Constants.INIPath);
                                }
                            }
                            else
                            {
                                section.Keys.Add(OptionNameTag.Text);
                                INI.Save(Constants.INIPath);
                            }
                            if (OptionNameTag.Text == "Renderer" && item.SubItems[1].Text == "DXVK (Vulkan)")
                            {
                                if (!File.Exists("d3d9.dll"))
                                {
                                    File.WriteAllBytes("d3d9.dll", Properties.Resources.DonorDLL);
                                }
                            }
                            else if (OptionNameTag.Text == "Renderer" && item.SubItems[1].Text == "Direct-X 9")
                            {
                                if (File.Exists("d3d9.dll"))
                                {
                                    File.Delete("d3d9.dll");
                                }
                            }
                        }
                    }
                }

                editBox.Visible = false;
            }
        }

        private void presets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OptionsList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true; // Cancel the resizing
            e.NewWidth = OptionsList.Columns[e.ColumnIndex].Width; // Set it to the current width
        }

        private void OptionsList_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
