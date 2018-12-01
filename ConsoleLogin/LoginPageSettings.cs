using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleLogin
{
    public partial class LoginPageSettingsForm : Form
    {
        Form1 mainPage;
        public LoginPageSettingsForm()
        {
            InitializeComponent();
        }
        public LoginPageSettingsForm(Form1 mainPage) : this()
        {
            this.mainPage = mainPage;
        }

        private void LoginPageSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveProperties_Click(object sender, EventArgs e)
        {
            mainPage.AddPage(txtPageName.Text, txtPostString.Text, txtIndicateString.Text, txtNavigateUrl.Text,
                 txtNavigateReferer.Text, txtFormAction.Text);
        }
    }
}
