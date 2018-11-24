using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleLogin
{
    delegate void UIInvoker(Action method);
    public partial class Form1 : Form
    {
        
        BruteCore core = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            core = new BruteCore(ChangeUI);

            await Task.Run(() => core.ReadPagesFromFile
            (@"E:\Programming\C#\Practice\Login-via-code\ConsoleLogin\Data\LoginPages\LoginPages.txt"));

            backgroundWorkerLogin.RunWorkerAsync();
        }

        private void UpdateData(Action method)
        {
            method.Invoke();
        }
        private void ChangeUI(object sender, LoginEventArgs e)
        {
            string _message = string.Format("{0}  {1}", DateTime.Now.ToShortTimeString(), 
                e.Message);
            ListBox component = null;
            if (e.Type == EventType.Error)
                component = listBoxErrors;
            else if (e.Type == EventType.Progress)
                component = listBoxProgress;
            else
                component = listBoxFoundPass;
            Invoke((MethodInvoker)delegate
            {
                component.Items.Add(_message);
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
            LoginCore siteInfo = new LoginCore(ChangeUI,"default",
                txtIndicateString.Text, txtPostString.Text,txtPostUrl.Text,
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
                    txtUsername.Text, lblFilePath.Text));
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

        private void btnGetFreeProxList_Click(object sender, EventArgs e)
        {
            Process.Start("https://free-proxy-list.net/");
        }

        private void backgroundWorkerLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            //core.ReadProxyFromFile();
            Invoke((MethodInvoker)delegate
            {
                listBoxPages.DataSource = core.pages;
                listBoxPages.DisplayMember = "Name";
                dataGridViewProxy.AutoGenerateColumns = false;
                dataGridViewProxy.DataSource = core.proxyList;
                dataGridViewProxy.Columns[0].DataPropertyName = "Item1";
                dataGridViewProxy.Columns[1].DataPropertyName = "Item2";
            });
            
        }

        private void btnProxyFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblProxyPath.Text = ofd.FileName;
                Task.Run(() => core.ReadProxyFromFileAsync(ofd.FileName));
            }
        }
    }
}
