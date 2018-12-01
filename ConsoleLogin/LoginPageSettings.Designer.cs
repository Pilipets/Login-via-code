namespace ConsoleLogin
{
    partial class LoginPageSettingsForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndicateString = new System.Windows.Forms.TextBox();
            this.txtPostString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveProperties = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNavigateReferer = new System.Windows.Forms.TextBox();
            this.txtNavigateUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFormAction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormMethod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPageName = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "IndicateString:";
            // 
            // txtIndicateString
            // 
            this.txtIndicateString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndicateString.BackColor = System.Drawing.Color.Black;
            this.txtIndicateString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndicateString.ForeColor = System.Drawing.Color.White;
            this.txtIndicateString.Location = new System.Drawing.Point(154, 47);
            this.txtIndicateString.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndicateString.Name = "txtIndicateString";
            this.txtIndicateString.Size = new System.Drawing.Size(649, 24);
            this.txtIndicateString.TabIndex = 23;
            this.txtIndicateString.Text = "Message when credentials are invalid";
            // 
            // txtPostString
            // 
            this.txtPostString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostString.BackColor = System.Drawing.Color.Black;
            this.txtPostString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostString.ForeColor = System.Drawing.Color.White;
            this.txtPostString.Location = new System.Drawing.Point(154, 15);
            this.txtPostString.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostString.Name = "txtPostString";
            this.txtPostString.Size = new System.Drawing.Size(649, 24);
            this.txtPostString.TabIndex = 22;
            this.txtPostString.Text = "username=\'USER\'&password=\'PASS\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "PostData:";
            // 
            // btnSaveProperties
            // 
            this.btnSaveProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProperties.Location = new System.Drawing.Point(565, 201);
            this.btnSaveProperties.Name = "btnSaveProperties";
            this.btnSaveProperties.Size = new System.Drawing.Size(175, 57);
            this.btnSaveProperties.TabIndex = 25;
            this.btnSaveProperties.Text = "SaveProperties";
            this.btnSaveProperties.UseVisualStyleBackColor = true;
            this.btnSaveProperties.Click += new System.EventHandler(this.btnSaveProperties_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.txtNavigateReferer);
            this.tabPage1.Controls.Add(this.txtNavigateUrl);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NavigateUrl";
            // 
            // txtNavigateReferer
            // 
            this.txtNavigateReferer.Location = new System.Drawing.Point(79, 67);
            this.txtNavigateReferer.Name = "txtNavigateReferer";
            this.txtNavigateReferer.Size = new System.Drawing.Size(222, 22);
            this.txtNavigateReferer.TabIndex = 16;
            // 
            // txtNavigateUrl
            // 
            this.txtNavigateUrl.Location = new System.Drawing.Point(79, 23);
            this.txtNavigateUrl.Name = "txtNavigateUrl";
            this.txtNavigateUrl.Size = new System.Drawing.Size(222, 22);
            this.txtNavigateUrl.TabIndex = 15;
            this.txtNavigateUrl.Text = "https://www.twirpx.com/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Referer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "URL";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 187);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.txtFormAction);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtFormMethod);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 158);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type";
            // 
            // txtFormAction
            // 
            this.txtFormAction.Location = new System.Drawing.Point(102, 70);
            this.txtFormAction.Name = "txtFormAction";
            this.txtFormAction.Size = new System.Drawing.Size(222, 22);
            this.txtFormAction.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Form Action";
            // 
            // txtFormMethod
            // 
            this.txtFormMethod.Location = new System.Drawing.Point(102, 30);
            this.txtFormMethod.Name = "txtFormMethod";
            this.txtFormMethod.Size = new System.Drawing.Size(222, 22);
            this.txtFormMethod.TabIndex = 17;
            this.txtFormMethod.Text = "POST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Name:";
            // 
            // txtPageName
            // 
            this.txtPageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageName.BackColor = System.Drawing.Color.Black;
            this.txtPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageName.ForeColor = System.Drawing.Color.White;
            this.txtPageName.Location = new System.Drawing.Point(154, 79);
            this.txtPageName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.Size = new System.Drawing.Size(649, 24);
            this.txtPageName.TabIndex = 26;
            this.txtPageName.Text = "Enter here a page name";
            // 
            // LoginPageSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPageName);
            this.Controls.Add(this.btnSaveProperties);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIndicateString);
            this.Controls.Add(this.txtPostString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginPageSettingsForm";
            this.Text = "LoginPageSettings";
            this.Load += new System.EventHandler(this.LoginPageSettingsForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndicateString;
        private System.Windows.Forms.TextBox txtPostString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveProperties;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNavigateReferer;
        private System.Windows.Forms.TextBox txtNavigateUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFormAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPageName;
    }
}