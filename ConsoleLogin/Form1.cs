using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleLogin
{
    delegate void Status(string message);
    public partial class Form1 : Form
    {
        BruteCore core = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            core = new BruteCore(DisplayError);
            await Task.Run(() => 
            core.ReadPagesFromFile(@"E:\Programming\C#\Practice\Login-via-code\ConsoleLogin\LoginPages\LoginPages.txt"));
            
            listBoxPages.DataSource = core.pages;
            listBoxPages.DisplayMember = "Name";
        }

        public void DisplayError(string message)
        {
            Invoke((MethodInvoker)delegate
            {
                listBoxErrors.Items.Add(message);
            });
            
        }
        private async void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = await Task.Run(() => 
                core.TestPageAsync(txtUsername.Text, txtPassword.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveProperties_Click(object sender, EventArgs e)
        {
            LoginCore siteInfo = new LoginCore(DisplayError,"default",txtIndicateString.Text, txtPostString.Text,txtPostUrl.Text,
                txtPostReferer.Text,txtNavigateUrl.Text,txtNavigateReferer.Text);
            core.AddPage(siteInfo);
        }

        private void btnSendFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = ofd.FileName;
                btnStartSendFromFile.Enabled = true;
            }
        }

        private async void btnStartSendFromFile_Click(object sender, EventArgs e)
        {
            if(core != null)
            {
                btnStartSendFromFile.Enabled = false;
                btnStopSendFromFile.Enabled = true;
                btnSendFilePath.Enabled = false;

                await Task.Run(() => core.StartBruteAsync((int)frequencySeconds.Value,
                    lblFilePath.Text));
                btnSendFilePath.Enabled = true;
                btnStopSendFromFile.Enabled = false;
                btnStartSendFromFile.Enabled = true;
            }
            else
            {
                MessageBox.Show("You need to add login page first");
            }
        }

        private void btnStopSendFromFile_Click(object sender, EventArgs e)
        {
            core.StopBrute();
            btnSendFilePath.Enabled = true;
            btnStopSendFromFile.Enabled = false;
            btnStartSendFromFile.Enabled = true;
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxPages.SelectedIndex;
            if (index > -1)
                core.SetCurrentPage(core.pages[index]);
        }
    }
}
