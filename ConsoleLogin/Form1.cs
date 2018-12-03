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
    partial class Form1 : Form
    {
        
        BruteCore core = null;
        int ErrorsNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            core = new BruteCore(ChangeUI);
            try
            {//"E:\\Programming\\C#\\Practice\\Login-via-code\\ConsoleLogin\\bin\\Debug"
                var path = Environment.CurrentDirectory;

                path = path.Substring(0,path.LastIndexOf(@"\bin"));
                await Task.Run(() => core.ReadPagesFromFile(path + @"\Data\LoginPages\LoginPages.txt"));
            }
            catch(Exception ex)
            {
                ChangeUI(ex.Source, new LoginEventArgs(EventType.Error,
                    ex.Message));
            }
            backgroundWorkerLogin.RunWorkerAsync();
        }

        public void AddPage(LoginCore editingPage, string pageName, string postString, 
            string indicateString, string navigateUrl, string navigateReferer, string formAction)
        {
            LoginCore page = new LoginCore(ChangeUI, pageName, postString, indicateString, 
                navigateUrl, navigateReferer, formAction);
            if(editingPage != null)
            {
                int index = core.pages.IndexOf(editingPage);
                core.pages.RemoveAt(index);
                core.AddPage(page, index);
            }
            else
                core.AddPage(page);
        }

        private void ChangeUI(object sender, LoginEventArgs e)
        {
            string _message = string.Format("{0}  {1}", DateTime.Now.ToShortTimeString(), 
                e.Message);
            ListBox component = null;
            if (e.Type == EventType.Error)
            {
                component = listBoxErrors;
                ErrorsNumber++;
                toolStripStatusLabelErrorCount.Text =
                    string.Format("List of Errors Counter: {0}", ErrorsNumber);
            }
            else if (e.Type == EventType.Progress)
                component = listBoxProgress;
            else if (e.Type == EventType.Credentials)
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
                await Task.Run(() => core.TestPageAsync(txtUsername.Text, txtPassword.Text));
            }
            catch(Exception ex)
            {
                ChangeUI(null, new LoginEventArgs(EventType.Error,
                    ex.Message));
            }
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
            try
            {
                btnStartSendFromFile.Enabled = false;
                btnStopSendFromFile.Enabled = true;
                btnSendFilePath.Enabled = false;

                await Task.Run(() => core.StartBruteAsync((int)frequencySeconds.Value,
                    txtBruteUsername.Text, lblFilePath.Text));
                btnSendFilePath.Enabled = true;
                btnStopSendFromFile.Enabled = false;
                btnStartSendFromFile.Enabled = true;
            }
            catch(Exception ex)
            {
                ChangeUI(null, new LoginEventArgs(EventType.Error,
                    ex.Message));
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
            });
            
        }

        private async void btnProxyFilePath_Click(object sender, EventArgs e)
        {
            btnClearProxyList_Click(null,null);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblProxyPath.Text = ofd.FileName;
                try
                {
                    await Task.Run(() => core.ReadProxyFromFileAsync(ofd.FileName));
                }
                catch(Exception ex)
                {
                    ChangeUI(null, new LoginEventArgs(EventType.Error,
                        ex.Message));
                }

                dataGridViewProxy.AutoGenerateColumns = false;
                dataGridViewProxy.DataSource = core.proxyList;
                dataGridViewProxy.Columns[0].DataPropertyName = "Item1";
                dataGridViewProxy.Columns[1].DataPropertyName = "Item2";
            }
        }

        private void btnClearProxyList_Click(object sender, EventArgs e)
        {
            dataGridViewProxy.DataSource = null;
            core.proxyList.Clear();
            lblProxyPath.Text = "";
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Proxy list has been succesfully cleared"));
        }

        private void btnAddNewLoginPage_Click(object sender, EventArgs e)
        {
            var pageForm = new LoginPageSettingsForm(this);
            pageForm.ShowDialog();
        }

        private void btnClearPagesList_Click(object sender, EventArgs e)
        {
            core.pages.Clear();
            core.page = null;
            ChangeUI(this, new LoginEventArgs(EventType.Progress, "Login pages list has" +
                "been succesfullu cleared"));
        }

        private void btnEditLoginPage_Click(object sender, EventArgs e)
        {
            var pageForm = new LoginPageSettingsForm(this);
            pageForm.SetPage(core.page);
            pageForm.ShowDialog();
        }


        private void btnRemoveLoginPage_Click(object sender, EventArgs e)
        {
            core.DeleteCurrentPage();
        }
        private void checkBoxProxy_Click(object sender, EventArgs e)
        {
            if (sender == checkBoxWithProxy)
            {
                if (checkBoxWithProxy.Checked)
                {
                    checkBoxProxyAuto.Checked = false;
                    core.autoChangeProxy = false;
                    core.goWithProxy = true;
                    core.SetCertainProxy(txtBProxy.Text);
                    ChangeUI(this, new LoginEventArgs(EventType.Progress,
                        "You will login with proxy " + txtBProxy.Text));
                }
                else if (checkBoxProxyAuto.Checked)
                {
                    core.goWithProxy = false;
                    core.autoChangeProxy = true;
                    ChangeUI(this, new LoginEventArgs(EventType.Progress,
                        "Proxy will be changed after each " + ChangeTimeProxyMins.Value + "mins"));
                }
                else
                {
                    core.autoChangeProxy = false;
                    core.goWithProxy = false;
                    ChangeUI(this, new LoginEventArgs(EventType.Progress,
                        "You will login without proxy settings"));
                }
            }
            else if (sender == checkBoxProxyAuto)
            {
                if (checkBoxProxyAuto.Checked == true)
                {
                    checkBoxWithProxy.Checked = false;
                    core.goWithProxy = false;
                    core.autoChangeProxy = true;
                    ChangeUI(this, new LoginEventArgs(EventType.Progress,
                        "Proxy will be changed after each " + ChangeTimeProxyMins.Value + "mins"));
                }
                else if (checkBoxWithProxy.Checked == true)
                {
                    core.goWithProxy = true;
                    core.autoChangeProxy = false;
                    core.SetCertainProxy(txtBProxy.Text);
                    ChangeUI(this, new LoginEventArgs(EventType.Progress,
                        "You will login with proxy " + txtBProxy.Text));
                }
                else
                {
                    core.autoChangeProxy = false;
                    core.goWithProxy = false;
                    ChangeUI(this, new LoginEventArgs(EventType.Progress,
                        "You will login without proxy settings"));
                }
            }
        }
    }
}
