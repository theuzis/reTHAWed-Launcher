namespace NEWRTL
{
    partial class KeyboardRemap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyboardRemap));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bLT = new System.Windows.Forms.TextBox();
            this.bLB = new System.Windows.Forms.TextBox();
            this.bDPADUP = new System.Windows.Forms.TextBox();
            this.bDPADLEFT = new System.Windows.Forms.TextBox();
            this.bDPADDOWN = new System.Windows.Forms.TextBox();
            this.bDPADRIGHT = new System.Windows.Forms.TextBox();
            this.bFOCUS = new System.Windows.Forms.TextBox();
            this.bLEFTSTICKUP = new System.Windows.Forms.TextBox();
            this.bLEFTSTICKLEFT = new System.Windows.Forms.TextBox();
            this.bLEFTSTICKDOWN = new System.Windows.Forms.TextBox();
            this.bLEFTSTICKRIGHT = new System.Windows.Forms.TextBox();
            this.bRIGHTSWIVELLOCK = new System.Windows.Forms.TextBox();
            this.bRIGHTSTICKUP = new System.Windows.Forms.TextBox();
            this.bRIGHTSTICKLEFT = new System.Windows.Forms.TextBox();
            this.bRIGHTSTICKDOWN = new System.Windows.Forms.TextBox();
            this.bRIGHTSTICKRIGHT = new System.Windows.Forms.TextBox();
            this.bOLLIE = new System.Windows.Forms.TextBox();
            this.bFLIP = new System.Windows.Forms.TextBox();
            this.bGRAB = new System.Windows.Forms.TextBox();
            this.bGRIND = new System.Windows.Forms.TextBox();
            this.bRB = new System.Windows.Forms.TextBox();
            this.bSpine = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCave = new System.Windows.Forms.TextBox();
            this.bQuick = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(817, 7);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "KEYBOARD BINDINGS";
            // 
            // bLT
            // 
            this.bLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bLT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bLT.ForeColor = System.Drawing.SystemColors.Info;
            this.bLT.Location = new System.Drawing.Point(157, 31);
            this.bLT.Name = "bLT";
            this.bLT.Size = new System.Drawing.Size(60, 20);
            this.bLT.TabIndex = 0;
            this.bLT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bLB
            // 
            this.bLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bLB.ForeColor = System.Drawing.SystemColors.Info;
            this.bLB.Location = new System.Drawing.Point(202, 72);
            this.bLB.Name = "bLB";
            this.bLB.Size = new System.Drawing.Size(60, 20);
            this.bLB.TabIndex = 1;
            this.bLB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bDPADUP
            // 
            this.bDPADUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bDPADUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bDPADUP.ForeColor = System.Drawing.SystemColors.Info;
            this.bDPADUP.Location = new System.Drawing.Point(211, 385);
            this.bDPADUP.Name = "bDPADUP";
            this.bDPADUP.Size = new System.Drawing.Size(60, 20);
            this.bDPADUP.TabIndex = 2;
            this.bDPADUP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bDPADLEFT
            // 
            this.bDPADLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bDPADLEFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bDPADLEFT.ForeColor = System.Drawing.SystemColors.Info;
            this.bDPADLEFT.Location = new System.Drawing.Point(224, 411);
            this.bDPADLEFT.Name = "bDPADLEFT";
            this.bDPADLEFT.Size = new System.Drawing.Size(60, 20);
            this.bDPADLEFT.TabIndex = 3;
            this.bDPADLEFT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bDPADDOWN
            // 
            this.bDPADDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bDPADDOWN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bDPADDOWN.ForeColor = System.Drawing.SystemColors.Info;
            this.bDPADDOWN.Location = new System.Drawing.Point(234, 437);
            this.bDPADDOWN.Name = "bDPADDOWN";
            this.bDPADDOWN.Size = new System.Drawing.Size(60, 20);
            this.bDPADDOWN.TabIndex = 4;
            this.bDPADDOWN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bDPADRIGHT
            // 
            this.bDPADRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bDPADRIGHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bDPADRIGHT.ForeColor = System.Drawing.SystemColors.Info;
            this.bDPADRIGHT.Location = new System.Drawing.Point(244, 463);
            this.bDPADRIGHT.Name = "bDPADRIGHT";
            this.bDPADRIGHT.Size = new System.Drawing.Size(60, 20);
            this.bDPADRIGHT.TabIndex = 5;
            this.bDPADRIGHT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bFOCUS
            // 
            this.bFOCUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bFOCUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bFOCUS.ForeColor = System.Drawing.SystemColors.Info;
            this.bFOCUS.Location = new System.Drawing.Point(424, 492);
            this.bFOCUS.Name = "bFOCUS";
            this.bFOCUS.Size = new System.Drawing.Size(60, 20);
            this.bFOCUS.TabIndex = 6;
            this.bFOCUS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bLEFTSTICKUP
            // 
            this.bLEFTSTICKUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bLEFTSTICKUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bLEFTSTICKUP.ForeColor = System.Drawing.SystemColors.Info;
            this.bLEFTSTICKUP.Location = new System.Drawing.Point(424, 529);
            this.bLEFTSTICKUP.Name = "bLEFTSTICKUP";
            this.bLEFTSTICKUP.Size = new System.Drawing.Size(60, 20);
            this.bLEFTSTICKUP.TabIndex = 7;
            this.bLEFTSTICKUP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bLEFTSTICKLEFT
            // 
            this.bLEFTSTICKLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bLEFTSTICKLEFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bLEFTSTICKLEFT.ForeColor = System.Drawing.SystemColors.Info;
            this.bLEFTSTICKLEFT.Location = new System.Drawing.Point(424, 555);
            this.bLEFTSTICKLEFT.Name = "bLEFTSTICKLEFT";
            this.bLEFTSTICKLEFT.Size = new System.Drawing.Size(60, 20);
            this.bLEFTSTICKLEFT.TabIndex = 8;
            this.bLEFTSTICKLEFT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bLEFTSTICKDOWN
            // 
            this.bLEFTSTICKDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bLEFTSTICKDOWN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bLEFTSTICKDOWN.ForeColor = System.Drawing.SystemColors.Info;
            this.bLEFTSTICKDOWN.Location = new System.Drawing.Point(424, 581);
            this.bLEFTSTICKDOWN.Name = "bLEFTSTICKDOWN";
            this.bLEFTSTICKDOWN.Size = new System.Drawing.Size(60, 20);
            this.bLEFTSTICKDOWN.TabIndex = 9;
            this.bLEFTSTICKDOWN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bLEFTSTICKRIGHT
            // 
            this.bLEFTSTICKRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bLEFTSTICKRIGHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bLEFTSTICKRIGHT.ForeColor = System.Drawing.SystemColors.Info;
            this.bLEFTSTICKRIGHT.Location = new System.Drawing.Point(424, 607);
            this.bLEFTSTICKRIGHT.Name = "bLEFTSTICKRIGHT";
            this.bLEFTSTICKRIGHT.Size = new System.Drawing.Size(60, 20);
            this.bLEFTSTICKRIGHT.TabIndex = 10;
            this.bLEFTSTICKRIGHT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bRIGHTSWIVELLOCK
            // 
            this.bRIGHTSWIVELLOCK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bRIGHTSWIVELLOCK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRIGHTSWIVELLOCK.ForeColor = System.Drawing.SystemColors.Info;
            this.bRIGHTSWIVELLOCK.Location = new System.Drawing.Point(556, 464);
            this.bRIGHTSWIVELLOCK.Name = "bRIGHTSWIVELLOCK";
            this.bRIGHTSWIVELLOCK.Size = new System.Drawing.Size(60, 20);
            this.bRIGHTSWIVELLOCK.TabIndex = 11;
            this.bRIGHTSWIVELLOCK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bRIGHTSTICKUP
            // 
            this.bRIGHTSTICKUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bRIGHTSTICKUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRIGHTSTICKUP.ForeColor = System.Drawing.SystemColors.Info;
            this.bRIGHTSTICKUP.Location = new System.Drawing.Point(556, 503);
            this.bRIGHTSTICKUP.Name = "bRIGHTSTICKUP";
            this.bRIGHTSTICKUP.Size = new System.Drawing.Size(60, 20);
            this.bRIGHTSTICKUP.TabIndex = 12;
            this.bRIGHTSTICKUP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bRIGHTSTICKLEFT
            // 
            this.bRIGHTSTICKLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bRIGHTSTICKLEFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRIGHTSTICKLEFT.ForeColor = System.Drawing.SystemColors.Info;
            this.bRIGHTSTICKLEFT.Location = new System.Drawing.Point(556, 529);
            this.bRIGHTSTICKLEFT.Name = "bRIGHTSTICKLEFT";
            this.bRIGHTSTICKLEFT.Size = new System.Drawing.Size(60, 20);
            this.bRIGHTSTICKLEFT.TabIndex = 13;
            this.bRIGHTSTICKLEFT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bRIGHTSTICKDOWN
            // 
            this.bRIGHTSTICKDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bRIGHTSTICKDOWN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRIGHTSTICKDOWN.ForeColor = System.Drawing.SystemColors.Info;
            this.bRIGHTSTICKDOWN.Location = new System.Drawing.Point(556, 555);
            this.bRIGHTSTICKDOWN.Name = "bRIGHTSTICKDOWN";
            this.bRIGHTSTICKDOWN.Size = new System.Drawing.Size(60, 20);
            this.bRIGHTSTICKDOWN.TabIndex = 14;
            this.bRIGHTSTICKDOWN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bRIGHTSTICKRIGHT
            // 
            this.bRIGHTSTICKRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bRIGHTSTICKRIGHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRIGHTSTICKRIGHT.ForeColor = System.Drawing.SystemColors.Info;
            this.bRIGHTSTICKRIGHT.Location = new System.Drawing.Point(556, 581);
            this.bRIGHTSTICKRIGHT.Name = "bRIGHTSTICKRIGHT";
            this.bRIGHTSTICKRIGHT.Size = new System.Drawing.Size(60, 20);
            this.bRIGHTSTICKRIGHT.TabIndex = 15;
            this.bRIGHTSTICKRIGHT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bOLLIE
            // 
            this.bOLLIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bOLLIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bOLLIE.ForeColor = System.Drawing.SystemColors.Info;
            this.bOLLIE.Location = new System.Drawing.Point(684, 371);
            this.bOLLIE.Name = "bOLLIE";
            this.bOLLIE.Size = new System.Drawing.Size(60, 20);
            this.bOLLIE.TabIndex = 16;
            this.bOLLIE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bFLIP
            // 
            this.bFLIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bFLIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bFLIP.ForeColor = System.Drawing.SystemColors.Info;
            this.bFLIP.Location = new System.Drawing.Point(684, 402);
            this.bFLIP.Name = "bFLIP";
            this.bFLIP.Size = new System.Drawing.Size(60, 20);
            this.bFLIP.TabIndex = 17;
            this.bFLIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bGRAB
            // 
            this.bGRAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bGRAB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bGRAB.ForeColor = System.Drawing.SystemColors.Info;
            this.bGRAB.Location = new System.Drawing.Point(704, 182);
            this.bGRAB.Name = "bGRAB";
            this.bGRAB.Size = new System.Drawing.Size(60, 20);
            this.bGRAB.TabIndex = 18;
            this.bGRAB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bGRIND
            // 
            this.bGRIND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bGRIND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bGRIND.ForeColor = System.Drawing.SystemColors.Info;
            this.bGRIND.Location = new System.Drawing.Point(684, 156);
            this.bGRIND.Name = "bGRIND";
            this.bGRIND.Size = new System.Drawing.Size(60, 20);
            this.bGRIND.TabIndex = 19;
            this.bGRIND.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bRB
            // 
            this.bRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRB.ForeColor = System.Drawing.SystemColors.Info;
            this.bRB.Location = new System.Drawing.Point(770, 72);
            this.bRB.Name = "bRB";
            this.bRB.Size = new System.Drawing.Size(60, 20);
            this.bRB.TabIndex = 20;
            this.bRB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bSpine
            // 
            this.bSpine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bSpine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bSpine.ForeColor = System.Drawing.SystemColors.Info;
            this.bSpine.Location = new System.Drawing.Point(782, 31);
            this.bSpine.Name = "bSpine";
            this.bSpine.Size = new System.Drawing.Size(60, 20);
            this.bSpine.TabIndex = 22;
            this.bSpine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::NEWRTL.Properties.Resources.xbox_helper;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bCave);
            this.panel1.Controls.Add(this.bQuick);
            this.panel1.Controls.Add(this.bSpine);
            this.panel1.Controls.Add(this.bRB);
            this.panel1.Controls.Add(this.bGRIND);
            this.panel1.Controls.Add(this.bGRAB);
            this.panel1.Controls.Add(this.bFLIP);
            this.panel1.Controls.Add(this.bOLLIE);
            this.panel1.Controls.Add(this.bRIGHTSTICKRIGHT);
            this.panel1.Controls.Add(this.bRIGHTSTICKDOWN);
            this.panel1.Controls.Add(this.bRIGHTSTICKLEFT);
            this.panel1.Controls.Add(this.bRIGHTSTICKUP);
            this.panel1.Controls.Add(this.bRIGHTSWIVELLOCK);
            this.panel1.Controls.Add(this.bLEFTSTICKRIGHT);
            this.panel1.Controls.Add(this.bLEFTSTICKDOWN);
            this.panel1.Controls.Add(this.bLEFTSTICKLEFT);
            this.panel1.Controls.Add(this.bLEFTSTICKUP);
            this.panel1.Controls.Add(this.bFOCUS);
            this.panel1.Controls.Add(this.bDPADRIGHT);
            this.panel1.Controls.Add(this.bDPADDOWN);
            this.panel1.Controls.Add(this.bDPADLEFT);
            this.panel1.Controls.Add(this.bDPADUP);
            this.panel1.Controls.Add(this.bLB);
            this.panel1.Controls.Add(this.bLT);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 659);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // bCave
            // 
            this.bCave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bCave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bCave.ForeColor = System.Drawing.SystemColors.Info;
            this.bCave.Location = new System.Drawing.Point(78, 168);
            this.bCave.Name = "bCave";
            this.bCave.Size = new System.Drawing.Size(60, 20);
            this.bCave.TabIndex = 24;
            this.bCave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // bQuick
            // 
            this.bQuick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.bQuick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bQuick.ForeColor = System.Drawing.SystemColors.Info;
            this.bQuick.Location = new System.Drawing.Point(403, 156);
            this.bQuick.Name = "bQuick";
            this.bQuick.Size = new System.Drawing.Size(60, 20);
            this.bQuick.TabIndex = 23;
            this.bQuick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CommonHandler);
            // 
            // KeyboardRemap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEWRTL.Properties.Resources.controls_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 720);
            this.MinimumSize = new System.Drawing.Size(900, 720);
            this.Name = "KeyboardRemap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeyboardRemap";
            this.Load += new System.EventHandler(this.KeyboardRemap_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bLT;
        private System.Windows.Forms.TextBox bLB;
        private System.Windows.Forms.TextBox bDPADUP;
        private System.Windows.Forms.TextBox bDPADLEFT;
        private System.Windows.Forms.TextBox bDPADDOWN;
        private System.Windows.Forms.TextBox bDPADRIGHT;
        private System.Windows.Forms.TextBox bFOCUS;
        private System.Windows.Forms.TextBox bLEFTSTICKUP;
        private System.Windows.Forms.TextBox bLEFTSTICKLEFT;
        private System.Windows.Forms.TextBox bLEFTSTICKDOWN;
        private System.Windows.Forms.TextBox bLEFTSTICKRIGHT;
        private System.Windows.Forms.TextBox bRIGHTSWIVELLOCK;
        private System.Windows.Forms.TextBox bRIGHTSTICKUP;
        private System.Windows.Forms.TextBox bRIGHTSTICKLEFT;
        private System.Windows.Forms.TextBox bRIGHTSTICKDOWN;
        private System.Windows.Forms.TextBox bRIGHTSTICKRIGHT;
        private System.Windows.Forms.TextBox bOLLIE;
        private System.Windows.Forms.TextBox bFLIP;
        private System.Windows.Forms.TextBox bGRAB;
        private System.Windows.Forms.TextBox bGRIND;
        private System.Windows.Forms.TextBox bRB;
        private System.Windows.Forms.TextBox bSpine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bCave;
        private System.Windows.Forms.TextBox bQuick;
    }
}