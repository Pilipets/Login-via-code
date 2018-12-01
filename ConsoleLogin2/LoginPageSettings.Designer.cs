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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNavigateReferer = new System.Windows.Forms.TextBox();
            this.txtNavigateUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtPostReferer = new System.Windows.Forms.TextBox();
            this.txtPostUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndicateString = new System.Windows.Forms.TextBox();
            this.txtPostString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveProperties = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataAttributesToken = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttributesToken)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 187);
            this.tabControl1.TabIndex = 18;
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
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage5.Controls.Add(this.txtPostReferer);
            this.tabPage5.Controls.Add(this.txtPostUrl);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(396, 158);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "PostUrl";
            // 
            // txtPostReferer
            // 
            this.txtPostReferer.Location = new System.Drawing.Point(79, 67);
            this.txtPostReferer.Name = "txtPostReferer";
            this.txtPostReferer.Size = new System.Drawing.Size(222, 22);
            this.txtPostReferer.TabIndex = 16;
            // 
            // txtPostUrl
            // 
            this.txtPostUrl.Location = new System.Drawing.Point(79, 23);
            this.txtPostUrl.Name = "txtPostUrl";
            this.txtPostUrl.Size = new System.Drawing.Size(222, 22);
            this.txtPostUrl.TabIndex = 15;
            this.txtPostUrl.Text = "https://www.twirpx.com/auth/login/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Referer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "URL";
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
            this.txtIndicateString.Text = "<title>Ошибка входа - Все для студента</title>\r\n";
            // 
            // txtPostString
            // 
            this.txtPostString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostString.BackColor = System.Drawing.Color.Black;
            this.txtPostString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostString.ForeColor = System.Drawing.Color.White;
            this.txtPostString.Location = new System.Drawing.Point(154, 13);
            this.txtPostString.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostString.Name = "txtPostString";
            this.txtPostString.Size = new System.Drawing.Size(649, 24);
            this.txtPostString.TabIndex = 22;
            this.txtPostString.Text = "ReturnUrl=%2F&AuthEmail=\'USER\'&AuthPassword=\'PASS\'&__SART=\'TOKEN\'%3D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "PostData:";
            // 
            // btnSaveProperties
            // 
            this.btnSaveProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProperties.Location = new System.Drawing.Point(553, 220);
            this.btnSaveProperties.Name = "btnSaveProperties";
            this.btnSaveProperties.Size = new System.Drawing.Size(175, 57);
            this.btnSaveProperties.TabIndex = 25;
            this.btnSaveProperties.Text = "SaveProperties";
            this.btnSaveProperties.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.dataAttributesToken);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 158);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "TOKEN";
            // 
            // dataAttributesToken
            // 
            this.dataAttributesToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataAttributesToken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAttributesToken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Attribute});
            this.dataAttributesToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataAttributesToken.Location = new System.Drawing.Point(7, 7);
            this.dataAttributesToken.Margin = new System.Windows.Forms.Padding(4);
            this.dataAttributesToken.Name = "dataAttributesToken";
            this.dataAttributesToken.RowHeadersVisible = false;
            this.dataAttributesToken.Size = new System.Drawing.Size(382, 144);
            this.dataAttributesToken.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Attribute
            // 
            this.Attribute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            // 
            // LoginPageSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 337);
            this.Controls.Add(this.btnSaveProperties);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIndicateString);
            this.Controls.Add(this.txtPostString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginPageSettingsForm";
            this.Text = "LoginPageSettings";
            this.Load += new System.EventHandler(this.LoginPageSettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAttributesToken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNavigateReferer;
        private System.Windows.Forms.TextBox txtNavigateUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtPostReferer;
        private System.Windows.Forms.TextBox txtPostUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndicateString;
        private System.Windows.Forms.TextBox txtPostString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveProperties;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataAttributesToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
    }
}