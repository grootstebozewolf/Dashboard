using System;
using System.Configuration;
using System.Windows.Forms;

namespace HelpdeskKPI
{
    public partial class frmLogin : Form
    {
        private string strConnectionName;
        public frmLogin()
        {
            InitializeComponent();
            if (ConfigurationManager.ConnectionStrings.Count == 1)
            {
                cboConnection.Visible = false;
                lblConnection.Visible = false;
            }
            strConnectionName = ConfigurationManager.ConnectionStrings[0].Name;
            foreach (ConnectionStringSettings objConnectionStringSettings in ConfigurationManager.ConnectionStrings)
            {
                cboConnection.Items.Add(objConnectionStringSettings.Name);
            }
        }

        public object Username
        {
            get { return txtUsername.Text; }
        }

        public object Password
        {
            get { return txtPassword.Text; }
        }

        public string ConnectionName
        {
            get { return strConnectionName; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void cboConnection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            strConnectionName = cboConnection.SelectedItem.ToString();
        }
    }
}
