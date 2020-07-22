namespace PrinterControler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageOrientationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landsacpeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portraitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPrinterPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFillSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblCOM = new System.Windows.Forms.Label();
            this.lblPrintingStatus = new System.Windows.Forms.Label();
            this.lblPrinetStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnCnclPrint = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPrintToolStripMenuItem,
            this.openPrintToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPrintToolStripMenuItem
            // 
            this.newPrintToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.newPrintToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newPrintToolStripMenuItem.Name = "newPrintToolStripMenuItem";
            this.newPrintToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newPrintToolStripMenuItem.Text = "New Print";
            // 
            // openPrintToolStripMenuItem
            // 
            this.openPrintToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.openPrintToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openPrintToolStripMenuItem.Name = "openPrintToolStripMenuItem";
            this.openPrintToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openPrintToolStripMenuItem.Text = "Open Print";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.importToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPortToolStripMenuItem,
            this.pageOrientationToolStripMenuItem,
            this.resetPrinterPositionToolStripMenuItem,
            this.changeFillSettingToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cOMPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCOMPortToolStripMenuItem});
            this.cOMPortToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            // 
            // changeCOMPortToolStripMenuItem
            // 
            this.changeCOMPortToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.changeCOMPortToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeCOMPortToolStripMenuItem.Name = "changeCOMPortToolStripMenuItem";
            this.changeCOMPortToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changeCOMPortToolStripMenuItem.Text = "Change COM Port";
            this.changeCOMPortToolStripMenuItem.Click += new System.EventHandler(this.changeCOMPortToolStripMenuItem_Click);
            // 
            // pageOrientationToolStripMenuItem
            // 
            this.pageOrientationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pageOrientationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.landsacpeToolStripMenuItem,
            this.portraitToolStripMenuItem});
            this.pageOrientationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pageOrientationToolStripMenuItem.Name = "pageOrientationToolStripMenuItem";
            this.pageOrientationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pageOrientationToolStripMenuItem.Text = "Page Orientation";
            // 
            // landsacpeToolStripMenuItem
            // 
            this.landsacpeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.landsacpeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.landsacpeToolStripMenuItem.Name = "landsacpeToolStripMenuItem";
            this.landsacpeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.landsacpeToolStripMenuItem.Text = "Landsacpe";
            this.landsacpeToolStripMenuItem.Click += new System.EventHandler(this.landsacpeToolStripMenuItem_Click);
            // 
            // portraitToolStripMenuItem
            // 
            this.portraitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.portraitToolStripMenuItem.Checked = true;
            this.portraitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.portraitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.portraitToolStripMenuItem.Name = "portraitToolStripMenuItem";
            this.portraitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.portraitToolStripMenuItem.Text = "Portrait";
            this.portraitToolStripMenuItem.Click += new System.EventHandler(this.portraitToolStripMenuItem_Click);
            // 
            // resetPrinterPositionToolStripMenuItem
            // 
            this.resetPrinterPositionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.resetPrinterPositionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetPrinterPositionToolStripMenuItem.Name = "resetPrinterPositionToolStripMenuItem";
            this.resetPrinterPositionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetPrinterPositionToolStripMenuItem.Text = "Reset Printer Position";
            this.resetPrinterPositionToolStripMenuItem.Click += new System.EventHandler(this.resetPrinterPositionToolStripMenuItem_Click);
            // 
            // changeFillSettingToolStripMenuItem
            // 
            this.changeFillSettingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.changeFillSettingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeFillSettingToolStripMenuItem.Name = "changeFillSettingToolStripMenuItem";
            this.changeFillSettingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.changeFillSettingToolStripMenuItem.Text = "Change Fill Setting";
            this.changeFillSettingToolStripMenuItem.Click += new System.EventHandler(this.changeFillSettingToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPos);
            this.panel1.Controls.Add(this.lblCOM);
            this.panel1.Controls.Add(this.lblPrintingStatus);
            this.panel1.Controls.Add(this.lblPrinetStatus);
            this.panel1.Location = new System.Drawing.Point(11, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 210);
            this.panel1.TabIndex = 1;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPos.Location = new System.Drawing.Point(12, 159);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(100, 18);
            this.lblPos.TabIndex = 6;
            this.lblPos.Text = "Pen Position: ";
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCOM.Location = new System.Drawing.Point(12, 124);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(80, 18);
            this.lblCOM.TabIndex = 5;
            this.lblCOM.Text = "COM Port:";
            // 
            // lblPrintingStatus
            // 
            this.lblPrintingStatus.AutoSize = true;
            this.lblPrintingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintingStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrintingStatus.Location = new System.Drawing.Point(12, 90);
            this.lblPrintingStatus.Name = "lblPrintingStatus";
            this.lblPrintingStatus.Size = new System.Drawing.Size(188, 18);
            this.lblPrintingStatus.TabIndex = 2;
            this.lblPrintingStatus.Text = "Printing Status: Not Printing";
            // 
            // lblPrinetStatus
            // 
            this.lblPrinetStatus.AutoSize = true;
            this.lblPrinetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinetStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrinetStatus.Location = new System.Drawing.Point(12, 55);
            this.lblPrinetStatus.Name = "lblPrinetStatus";
            this.lblPrinetStatus.Size = new System.Drawing.Size(147, 18);
            this.lblPrinetStatus.TabIndex = 1;
            this.lblPrinetStatus.Text = "Printer Status: Offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Printer Information:";
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.BtnConnect.FlatAppearance.BorderSize = 0;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConnect.Location = new System.Drawing.Point(56, 21);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(102, 40);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.BtnDisconnect.FlatAppearance.BorderSize = 0;
            this.BtnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisconnect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDisconnect.Location = new System.Drawing.Point(56, 76);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(102, 40);
            this.BtnDisconnect.TabIndex = 4;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = false;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.BtnPrint.FlatAppearance.BorderSize = 0;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnPrint.Location = new System.Drawing.Point(56, 255);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(102, 40);
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnCnclPrint
            // 
            this.BtnCnclPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCnclPrint.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.BtnCnclPrint.FlatAppearance.BorderSize = 0;
            this.BtnCnclPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCnclPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCnclPrint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCnclPrint.Location = new System.Drawing.Point(56, 310);
            this.BtnCnclPrint.Name = "BtnCnclPrint";
            this.BtnCnclPrint.Size = new System.Drawing.Size(102, 40);
            this.BtnCnclPrint.TabIndex = 6;
            this.BtnCnclPrint.Text = "Cancel Print";
            this.BtnCnclPrint.UseVisualStyleBackColor = false;
            this.BtnCnclPrint.Click += new System.EventHandler(this.BtnCnclPrint_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG Images (*.png)|*.png";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(322, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 560);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // BtnScan
            // 
            this.BtnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnScan.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.BtnScan.FlatAppearance.BorderSize = 0;
            this.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnScan.Location = new System.Drawing.Point(56, 163);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(102, 40);
            this.BtnScan.TabIndex = 12;
            this.BtnScan.Text = "Scan";
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(49, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Printer Controls:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnConnect);
            this.panel3.Controls.Add(this.BtnDisconnect);
            this.panel3.Controls.Add(this.BtnPrint);
            this.panel3.Controls.Add(this.BtnCnclPrint);
            this.panel3.Controls.Add(this.BtnScan);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(12, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 365);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(301, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 653);
            this.panel4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 691);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Console.Location = new System.Drawing.Point(3, 3);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(1274, 80);
            this.Console.TabIndex = 17;
            this.Console.Text = "";
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.Console);
            this.panel5.Location = new System.Drawing.Point(27, 709);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1280, 86);
            this.panel5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1380, 807);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageOrientationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landsacpeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portraitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.Label lblPrintingStatus;
        private System.Windows.Forms.Label lblPrinetStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnCnclPrint;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem resetPrinterPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFillSettingToolStripMenuItem;
    }
}

