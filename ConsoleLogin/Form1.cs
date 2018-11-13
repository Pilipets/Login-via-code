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
    public partial class Form1 : Form
    {
        BruteCore core = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                core.TestPage(txtUsername.Text, txtPassword.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveProperties_Click(object sender, EventArgs e)
        {
            LoginCore siteInfo = new LoginCore(txtIndicateString.Text, txtPostString.Text,txtPostUrl.Text,
                txtPostReferer.Text,txtNavigateUrl.Text,txtNavigateReferer.Text);
            core = new BruteCore(siteInfo);
        }
    }
}
