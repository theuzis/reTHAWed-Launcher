namespace NEWRTL
{
    partial class coreSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Graphics", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Misc", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Logger", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Debug", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ResolutionX",
            "1280"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ResolutionY",
            "720"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Windowed",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Borderless",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Shadows",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "SafeArea",
            "Wide"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "DistanceClipping",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "RichPresence",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "IntroMovies",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "UnlockFPSValue",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Console",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "WriteFile",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Autolaunch",
            "mainmenu"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "AutolaunchLevel",
            "z_mainmenu"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "AutolaunchGame",
            "singlesession"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "FullRange",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "DistanceFog",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "ClippingDistance",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Renderer",
            "Direct-X 9"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coreSettings));
            this.OptionsList = new System.Windows.Forms.ListView();
            this.INI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.innit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OptionsBox = new NEWRTL.BorderlessGroupBox();
            this.OptComboBox = new System.Windows.Forms.ComboBox();
            this.blackPreviewBG = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.nopreviewlabel = new System.Windows.Forms.Label();
            this.OptionNameTag = new System.Windows.Forms.Label();
            this.OptionsDesc = new System.Windows.Forms.Label();
            this.OptionsBox.SuspendLayout();
            this.blackPreviewBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsList
            // 
            this.OptionsList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.OptionsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OptionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.INI,
            this.innit});
            this.OptionsList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsList.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionsList.GridLines = true;
            listViewGroup1.Header = "Graphics";
            listViewGroup1.Name = "graphicsOptions";
            listViewGroup2.Header = "Misc";
            listViewGroup2.Name = "miscOptions";
            listViewGroup3.Header = "Logger";
            listViewGroup3.Name = "loggerOptions";
            listViewGroup4.Header = "Debug";
            listViewGroup4.Name = "debugOptions";
            this.OptionsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.OptionsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OptionsList.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "ResolutionNBL";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            listViewItem2.Tag = "ResolutionNBL";
            listViewItem3.Group = listViewGroup1;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup1;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Group = listViewGroup1;
            listViewItem5.StateImageIndex = 0;
            listViewItem5.Tag = "ComboBoxIMG";
            listViewItem6.Group = listViewGroup1;
            listViewItem6.StateImageIndex = 0;
            listViewItem6.Tag = "ComboBox";
            listViewItem7.Group = listViewGroup1;
            listViewItem7.StateImageIndex = 0;
            listViewItem7.Tag = "";
            listViewItem8.Group = listViewGroup2;
            listViewItem8.StateImageIndex = 0;
            listViewItem8.Tag = "";
            listViewItem9.Group = listViewGroup2;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Group = listViewGroup4;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.Group = listViewGroup3;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.Group = listViewGroup3;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.Group = listViewGroup4;
            listViewItem13.StateImageIndex = 0;
            listViewItem13.Tag = "ComboBox";
            listViewItem14.Group = listViewGroup4;
            listViewItem14.StateImageIndex = 0;
            listViewItem14.Tag = "ComboBox";
            listViewItem15.Group = listViewGroup4;
            listViewItem15.StateImageIndex = 0;
            listViewItem15.Tag = "ComboBox";
            listViewItem16.Group = listViewGroup1;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.Group = listViewGroup1;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.Group = listViewGroup1;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.Group = listViewGroup1;
            listViewItem19.Tag = "ComboBox";
            this.OptionsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19});
            this.OptionsList.LabelWrap = false;
            this.OptionsList.Location = new System.Drawing.Point(5, 5);
            this.OptionsList.MultiSelect = false;
            this.OptionsList.Name = "OptionsList";
            this.OptionsList.OwnerDraw = true;
            this.OptionsList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OptionsList.Size = new System.Drawing.Size(895, 709);
            this.OptionsList.TabIndex = 0;
            this.OptionsList.TileSize = new System.Drawing.Size(188, 50);
            this.OptionsList.UseCompatibleStateImageBehavior = false;
            this.OptionsList.View = System.Windows.Forms.View.Details;
            this.OptionsList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.OptionsList_ColumnWidthChanging);
            this.OptionsList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.OptionsList.SelectedIndexChanged += new System.EventHandler(this.OptionsList_SelectedIndexChanged);
            this.OptionsList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OptionsList_KeyUp);
            this.OptionsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OptionsList_MouseDoubleClick);
            // 
            // INI
            // 
            this.INI.Text = "Option";
            this.INI.Width = 151;
            // 
            // innit
            // 
            this.innit.Text = "Value";
            this.innit.Width = 500;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // OptionsBox
            // 
            this.OptionsBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionsBox.Controls.Add(this.OptComboBox);
            this.OptionsBox.Controls.Add(this.blackPreviewBG);
            this.OptionsBox.Controls.Add(this.OptionNameTag);
            this.OptionsBox.Controls.Add(this.OptionsDesc);
            this.OptionsBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsBox.Location = new System.Drawing.Point(284, 0);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(616, 720);
            this.OptionsBox.TabIndex = 1;
            this.OptionsBox.TabStop = false;
            // 
            // OptComboBox
            // 
            this.OptComboBox.BackColor = System.Drawing.Color.Black;
            this.OptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OptComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptComboBox.ForeColor = System.Drawing.Color.White;
            this.OptComboBox.FormattingEnabled = true;
            this.OptComboBox.Location = new System.Drawing.Point(94, 674);
            this.OptComboBox.Name = "OptComboBox";
            this.OptComboBox.Size = new System.Drawing.Size(121, 25);
            this.OptComboBox.TabIndex = 10;
            this.OptComboBox.SelectedIndexChanged += new System.EventHandler(this.QualityBox_SelectedIndexChanged);
            // 
            // blackPreviewBG
            // 
            this.blackPreviewBG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackPreviewBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackPreviewBG.Controls.Add(this.button1);
            this.blackPreviewBG.Controls.Add(this.previewImage);
            this.blackPreviewBG.Controls.Add(this.nopreviewlabel);
            this.blackPreviewBG.Location = new System.Drawing.Point(10, 12);
            this.blackPreviewBG.Name = "blackPreviewBG";
            this.blackPreviewBG.Size = new System.Drawing.Size(594, 329);
            this.blackPreviewBG.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(517, -1);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // previewImage
            // 
            this.previewImage.BackColor = System.Drawing.Color.Transparent;
            this.previewImage.Location = new System.Drawing.Point(-1, -1);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(594, 329);
            this.previewImage.TabIndex = 1;
            this.previewImage.TabStop = false;
            // 
            // nopreviewlabel
            // 
            this.nopreviewlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nopreviewlabel.AutoSize = true;
            this.nopreviewlabel.BackColor = System.Drawing.Color.Transparent;
            this.nopreviewlabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopreviewlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nopreviewlabel.Location = new System.Drawing.Point(232, 150);
            this.nopreviewlabel.Name = "nopreviewlabel";
            this.nopreviewlabel.Size = new System.Drawing.Size(149, 13);
            this.nopreviewlabel.TabIndex = 0;
            this.nopreviewlabel.Text = "This option has no preview.";
            // 
            // OptionNameTag
            // 
            this.OptionNameTag.AutoSize = true;
            this.OptionNameTag.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionNameTag.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionNameTag.Location = new System.Drawing.Point(14, 344);
            this.OptionNameTag.Name = "OptionNameTag";
            this.OptionNameTag.Size = new System.Drawing.Size(189, 37);
            this.OptionNameTag.TabIndex = 3;
            this.OptionNameTag.Text = "Option Name";
            // 
            // OptionsDesc
            // 
            this.OptionsDesc.AutoSize = true;
            this.OptionsDesc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionsDesc.Location = new System.Drawing.Point(6, 388);
            this.OptionsDesc.Name = "OptionsDesc";
            this.OptionsDesc.Size = new System.Drawing.Size(0, 25);
            this.OptionsDesc.TabIndex = 2;
            this.OptionsDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.OptionsDesc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // coreSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEWRTL.Properties.Resources.controls_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.OptionsBox);
            this.Controls.Add(this.OptionsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 720);
            this.Name = "coreSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "reTHAWed Settings Utility";
            this.Load += new System.EventHandler(this.settingsmain_Load);
            this.OptionsBox.ResumeLayout(false);
            this.OptionsBox.PerformLayout();
            this.blackPreviewBG.ResumeLayout(false);
            this.blackPreviewBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OptionsList;
        private BorderlessGroupBox OptionsBox;
        private System.Windows.Forms.Panel blackPreviewBG;
        private System.Windows.Forms.Label nopreviewlabel;
        private System.Windows.Forms.ComboBox OptComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox previewImage;
        private System.Windows.Forms.Label OptionNameTag;
        private System.Windows.Forms.Label OptionsDesc;
        private System.Windows.Forms.ColumnHeader INI;
        private System.Windows.Forms.ColumnHeader innit;
    }
}