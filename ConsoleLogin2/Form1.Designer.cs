namespace ConsoleLogin
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.frequencySeconds = new System.Windows.Forms.NumericUpDown();
            this.btnStopSendFromFile = new System.Windows.Forms.Button();
            this.btnStartSendFromFile = new System.Windows.Forms.Button();
            this.btnSendFilePath = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.listBoxFoundPass = new System.Windows.Forms.ListBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewLoginPage = new System.Windows.Forms.Button();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listBoxErrors = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxProgress = new System.Windows.Forms.ListBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.btnClearProxyList = new System.Windows.Forms.Button();
            this.lblProxyPath = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProxyFilePath = new System.Windows.Forms.Button();
            this.ChangeTimeProxyMins = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewProxy = new System.Windows.Forms.DataGridView();
            this.ProxyIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetFreeProxList = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelErrorCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorkerLogin = new System.ComponentModel.BackgroundWorker();
            this.txtBProxy = new System.Windows.Forms.TextBox();
            this.checkBoxProxyAuto = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxWithProxy = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtBruteUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySeconds)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeTimeProxyMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(543, 114);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(613, 134);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(605, 104);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Test the Page";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(588, 96);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Username && Password Login";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(129, 23);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username : ";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(389, 53);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(179, 39);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test the page";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(129, 55);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password : ";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.lblFilePath);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.frequencySeconds);
            this.tabPage4.Controls.Add(this.btnStopSendFromFile);
            this.tabPage4.Controls.Add(this.btnStartSendFromFile);
            this.tabPage4.Controls.Add(this.btnSendFilePath);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(605, 104);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Send Password from file";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.Color.White;
            this.lblFilePath.Location = new System.Drawing.Point(163, 25);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(32, 17);
            this.lblFilePath.TabIndex = 15;
            this.lblFilePath.Text = "? : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Frequency (Secs): ";
            // 
            // frequencySeconds
            // 
            this.frequencySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencySeconds.Location = new System.Drawing.Point(167, 57);
            this.frequencySeconds.Margin = new System.Windows.Forms.Padding(4);
            this.frequencySeconds.Name = "frequencySeconds";
            this.frequencySeconds.Size = new System.Drawing.Size(69, 23);
            this.frequencySeconds.TabIndex = 14;
            // 
            // btnStopSendFromFile
            // 
            this.btnStopSendFromFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStopSendFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopSendFromFile.Enabled = false;
            this.btnStopSendFromFile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnStopSendFromFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnStopSendFromFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStopSendFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSendFromFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopSendFromFile.ForeColor = System.Drawing.Color.White;
            this.btnStopSendFromFile.Location = new System.Drawing.Point(261, 53);
            this.btnStopSendFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopSendFromFile.Name = "btnStopSendFromFile";
            this.btnStopSendFromFile.Size = new System.Drawing.Size(149, 42);
            this.btnStopSendFromFile.TabIndex = 13;
            this.btnStopSendFromFile.Text = "Stop Sending";
            this.btnStopSendFromFile.UseVisualStyleBackColor = false;
            this.btnStopSendFromFile.Click += new System.EventHandler(this.btnStopSendFromFile_Click);
            // 
            // btnStartSendFromFile
            // 
            this.btnStartSendFromFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStartSendFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartSendFromFile.Enabled = false;
            this.btnStartSendFromFile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnStartSendFromFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnStartSendFromFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStartSendFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSendFromFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSendFromFile.ForeColor = System.Drawing.Color.White;
            this.btnStartSendFromFile.Location = new System.Drawing.Point(432, 53);
            this.btnStartSendFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartSendFromFile.Name = "btnStartSendFromFile";
            this.btnStartSendFromFile.Size = new System.Drawing.Size(131, 42);
            this.btnStartSendFromFile.TabIndex = 12;
            this.btnStartSendFromFile.Text = "Start Sending";
            this.btnStartSendFromFile.UseVisualStyleBackColor = false;
            this.btnStartSendFromFile.Click += new System.EventHandler(this.btnStartSendFromFile_Click);
            // 
            // btnSendFilePath
            // 
            this.btnSendFilePath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendFilePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendFilePath.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSendFilePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSendFilePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSendFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFilePath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFilePath.ForeColor = System.Drawing.Color.White;
            this.btnSendFilePath.Location = new System.Drawing.Point(4, 18);
            this.btnSendFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendFilePath.Name = "btnSendFilePath";
            this.btnSendFilePath.Size = new System.Drawing.Size(151, 28);
            this.btnSendFilePath.TabIndex = 11;
            this.btnSendFilePath.Text = "Passwords File";
            this.btnSendFilePath.UseVisualStyleBackColor = false;
            this.btnSendFilePath.Click += new System.EventHandler(this.btnSendFilePath_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Black;
            this.tabPage8.Controls.Add(this.listBoxFoundPass);
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(605, 104);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Found Passwords";
            // 
            // listBoxFoundPass
            // 
            this.listBoxFoundPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFoundPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFoundPass.FormattingEnabled = true;
            this.listBoxFoundPass.ItemHeight = 18;
            this.listBoxFoundPass.Location = new System.Drawing.Point(8, 2);
            this.listBoxFoundPass.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFoundPass.Name = "listBoxFoundPass";
            this.listBoxFoundPass.Size = new System.Drawing.Size(585, 94);
            this.listBoxFoundPass.TabIndex = 0;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage13);
            this.tabControl3.Location = new System.Drawing.Point(47, 255);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1109, 380);
            this.tabControl3.TabIndex = 21;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Controls.Add(this.btnAddNewLoginPage);
            this.tabPage7.Controls.Add(this.listBoxPages);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1101, 351);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "LoginPages";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(688, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear Pages List";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddNewLoginPage
            // 
            this.btnAddNewLoginPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewLoginPage.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddNewLoginPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAddNewLoginPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLoginPage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLoginPage.ForeColor = System.Drawing.Color.White;
            this.btnAddNewLoginPage.Location = new System.Drawing.Point(688, 122);
            this.btnAddNewLoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewLoginPage.Name = "btnAddNewLoginPage";
            this.btnAddNewLoginPage.Size = new System.Drawing.Size(217, 42);
            this.btnAddNewLoginPage.TabIndex = 7;
            this.btnAddNewLoginPage.Text = "Add new page";
            this.btnAddNewLoginPage.UseVisualStyleBackColor = false;
            this.btnAddNewLoginPage.Click += new System.EventHandler(this.btnAddNewLoginPage_Click);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(24, 20);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(533, 308);
            this.listBoxPages.TabIndex = 0;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listBoxErrors);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1101, 351);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "List of Errors";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listBoxErrors
            // 
            this.listBoxErrors.FormattingEnabled = true;
            this.listBoxErrors.ItemHeight = 16;
            this.listBoxErrors.Location = new System.Drawing.Point(27, 24);
            this.listBoxErrors.Name = "listBoxErrors";
            this.listBoxErrors.Size = new System.Drawing.Size(634, 308);
            this.listBoxErrors.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxProgress);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1101, 351);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "ProgressStatus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxProgress
            // 
            this.listBoxProgress.FormattingEnabled = true;
            this.listBoxProgress.ItemHeight = 16;
            this.listBoxProgress.Location = new System.Drawing.Point(6, 8);
            this.listBoxProgress.Name = "listBoxProgress";
            this.listBoxProgress.Size = new System.Drawing.Size(911, 340);
            this.listBoxProgress.TabIndex = 0;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.btnClearProxyList);
            this.tabPage13.Controls.Add(this.lblProxyPath);
            this.tabPage13.Controls.Add(this.label10);
            this.tabPage13.Controls.Add(this.btnProxyFilePath);
            this.tabPage13.Controls.Add(this.ChangeTimeProxyMins);
            this.tabPage13.Controls.Add(this.dataGridViewProxy);
            this.tabPage13.Controls.Add(this.btnGetFreeProxList);
            this.tabPage13.Location = new System.Drawing.Point(4, 25);
            this.tabPage13.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage13.Size = new System.Drawing.Size(1101, 351);
            this.tabPage13.TabIndex = 8;
            this.tabPage13.Text = "Proxy List";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // btnClearProxyList
            // 
            this.btnClearProxyList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearProxyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearProxyList.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnClearProxyList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearProxyList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClearProxyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProxyList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProxyList.ForeColor = System.Drawing.Color.White;
            this.btnClearProxyList.Location = new System.Drawing.Point(468, 107);
            this.btnClearProxyList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearProxyList.Name = "btnClearProxyList";
            this.btnClearProxyList.Size = new System.Drawing.Size(151, 28);
            this.btnClearProxyList.TabIndex = 20;
            this.btnClearProxyList.Text = "Cleal Proxy List";
            this.btnClearProxyList.UseVisualStyleBackColor = false;
            this.btnClearProxyList.Click += new System.EventHandler(this.btnClearProxyList_Click);
            // 
            // lblProxyPath
            // 
            this.lblProxyPath.AutoSize = true;
            this.lblProxyPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxyPath.ForeColor = System.Drawing.Color.Black;
            this.lblProxyPath.Location = new System.Drawing.Point(627, 71);
            this.lblProxyPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyPath.Name = "lblProxyPath";
            this.lblProxyPath.Size = new System.Drawing.Size(32, 17);
            this.lblProxyPath.TabIndex = 17;
            this.lblProxyPath.Text = "? : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Proxy Change Time (Mins): ";
            // 
            // btnProxyFilePath
            // 
            this.btnProxyFilePath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProxyFilePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProxyFilePath.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnProxyFilePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnProxyFilePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProxyFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxyFilePath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxyFilePath.ForeColor = System.Drawing.Color.White;
            this.btnProxyFilePath.Location = new System.Drawing.Point(468, 64);
            this.btnProxyFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnProxyFilePath.Name = "btnProxyFilePath";
            this.btnProxyFilePath.Size = new System.Drawing.Size(151, 28);
            this.btnProxyFilePath.TabIndex = 16;
            this.btnProxyFilePath.Text = "Read from File";
            this.btnProxyFilePath.UseVisualStyleBackColor = false;
            this.btnProxyFilePath.Click += new System.EventHandler(this.btnProxyFilePath_Click);
            // 
            // ChangeTimeProxyMins
            // 
            this.ChangeTimeProxyMins.Location = new System.Drawing.Point(287, 32);
            this.ChangeTimeProxyMins.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTimeProxyMins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChangeTimeProxyMins.Name = "ChangeTimeProxyMins";
            this.ChangeTimeProxyMins.Size = new System.Drawing.Size(69, 22);
            this.ChangeTimeProxyMins.TabIndex = 18;
            this.ChangeTimeProxyMins.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dataGridViewProxy
            // 
            this.dataGridViewProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewProxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProxy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProxyIP,
            this.ProxyPort});
            this.dataGridViewProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewProxy.Location = new System.Drawing.Point(8, 73);
            this.dataGridViewProxy.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProxy.Name = "dataGridViewProxy";
            this.dataGridViewProxy.RowHeadersVisible = false;
            this.dataGridViewProxy.Size = new System.Drawing.Size(452, 269);
            this.dataGridViewProxy.TabIndex = 0;
            // 
            // ProxyIP
            // 
            this.ProxyIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProxyIP.HeaderText = "Proxy I.P";
            this.ProxyIP.Name = "ProxyIP";
            // 
            // ProxyPort
            // 
            this.ProxyPort.HeaderText = "ProxyPort";
            this.ProxyPort.Name = "ProxyPort";
            // 
            // btnGetFreeProxList
            // 
            this.btnGetFreeProxList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetFreeProxList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetFreeProxList.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGetFreeProxList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnGetFreeProxList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGetFreeProxList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFreeProxList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFreeProxList.ForeColor = System.Drawing.Color.White;
            this.btnGetFreeProxList.Location = new System.Drawing.Point(630, 100);
            this.btnGetFreeProxList.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFreeProxList.Name = "btnGetFreeProxList";
            this.btnGetFreeProxList.Size = new System.Drawing.Size(356, 42);
            this.btnGetFreeProxList.TabIndex = 6;
            this.btnGetFreeProxList.Text = "Get A Free Proxy List Online";
            this.btnGetFreeProxList.UseVisualStyleBackColor = false;
            this.btnGetFreeProxList.Click += new System.EventHandler(this.btnGetFreeProxList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelErrorCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1182, 25);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel2.Text = "       |       ";
            // 
            // toolStripStatusLabelErrorCount
            // 
            this.toolStripStatusLabelErrorCount.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelErrorCount.Name = "toolStripStatusLabelErrorCount";
            this.toolStripStatusLabelErrorCount.Size = new System.Drawing.Size(166, 20);
            this.toolStripStatusLabelErrorCount.Text = "List of Errors Counter : 0";
            // 
            // backgroundWorkerLogin
            // 
            this.backgroundWorkerLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLogin_DoWork);
            // 
            // txtBProxy
            // 
            this.txtBProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBProxy.BackColor = System.Drawing.Color.Black;
            this.txtBProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBProxy.ForeColor = System.Drawing.Color.White;
            this.txtBProxy.Location = new System.Drawing.Point(635, 75);
            this.txtBProxy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBProxy.Name = "txtBProxy";
            this.txtBProxy.Size = new System.Drawing.Size(191, 24);
            this.txtBProxy.TabIndex = 26;
            this.txtBProxy.Text = "51.38.71.101:8080";
            // 
            // checkBoxProxyAuto
            // 
            this.checkBoxProxyAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxProxyAuto.AutoSize = true;
            this.checkBoxProxyAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxProxyAuto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProxyAuto.ForeColor = System.Drawing.Color.White;
            this.checkBoxProxyAuto.Location = new System.Drawing.Point(991, 77);
            this.checkBoxProxyAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxProxyAuto.Name = "checkBoxProxyAuto";
            this.checkBoxProxyAuto.Size = new System.Drawing.Size(165, 22);
            this.checkBoxProxyAuto.TabIndex = 25;
            this.checkBoxProxyAuto.Text = "Auto Change Proxy";
            this.checkBoxProxyAuto.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(551, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Proxy : ";
            // 
            // checkBoxWithProxy
            // 
            this.checkBoxWithProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWithProxy.AutoSize = true;
            this.checkBoxWithProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxWithProxy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWithProxy.ForeColor = System.Drawing.Color.White;
            this.checkBoxWithProxy.Location = new System.Drawing.Point(850, 78);
            this.checkBoxWithProxy.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWithProxy.Name = "checkBoxWithProxy";
            this.checkBoxWithProxy.Size = new System.Drawing.Size(130, 22);
            this.checkBoxWithProxy.TabIndex = 27;
            this.checkBoxWithProxy.Text = "Go With Proxy";
            this.checkBoxWithProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxWithProxy.UseVisualStyleBackColor = true;
            this.checkBoxWithProxy.CheckedChanged += new System.EventHandler(this.checkBoxWithProxy_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtBruteUsername
            // 
            this.txtBruteUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBruteUsername.BackColor = System.Drawing.Color.Black;
            this.txtBruteUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBruteUsername.ForeColor = System.Drawing.Color.White;
            this.txtBruteUsername.Location = new System.Drawing.Point(278, 26);
            this.txtBruteUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBruteUsername.Name = "txtBruteUsername";
            this.txtBruteUsername.Size = new System.Drawing.Size(649, 24);
            this.txtBruteUsername.TabIndex = 29;
            this.txtBruteUsername.Text = "Enter username you would like to brute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 675);
            this.Controls.Add(this.txtBruteUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxWithProxy);
            this.Controls.Add(this.txtBProxy);
            this.Controls.Add(this.checkBoxProxyAuto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySeconds)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeTimeProxyMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown frequencySeconds;
        private System.Windows.Forms.Button btnStopSendFromFile;
        private System.Windows.Forms.Button btnStartSendFromFile;
        private System.Windows.Forms.Button btnSendFilePath;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelErrorCount;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBoxErrors;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxProgress;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ChangeTimeProxyMins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyPort;
        private System.Windows.Forms.Button btnGetFreeProxList;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ListBox listBoxFoundPass;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLogin;
        private System.Windows.Forms.TextBox txtBProxy;
        private System.Windows.Forms.CheckBox checkBoxProxyAuto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProxyPath;
        private System.Windows.Forms.Button btnProxyFilePath;
        private System.Windows.Forms.DataGridView dataGridViewProxy;
        private System.Windows.Forms.Button btnClearProxyList;
        private System.Windows.Forms.CheckBox checkBoxWithProxy;
        private System.Windows.Forms.Button btnAddNewLoginPage;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBruteUsername;
        private System.Windows.Forms.Label label3;
    }
}

