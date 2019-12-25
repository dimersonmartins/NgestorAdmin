using Newtonsoft.Json.Linq;
using NgestorAdministrator.App;
using Server.Http.Auth;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Login
{
    public partial class FrmLogin :Form
    {
        private Dashboard form_dashbord = null;
        public FrmLogin(Form callingForm)
        {
            form_dashbord = callingForm as Dashboard;
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ManterData manter = new ManterData();
            if (manter.servers() != null)
            {
                selectServer.DataSource = new BindingSource(manter.servers(), null);
                selectServer.DisplayMember = "Key";
                selectServer.ValueMember = "Value";
            }
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
           
            string server = ((KeyValuePair<string, string>)selectServer.SelectedItem).Value;
            Config.ngestor_server = server;
            logar();
        }

        private async void logar()
        {
            SystemAuth auth = new SystemAuth(Config.ngestor_server,txtUser.Text, txtPassword.Text);
            await auth.execute();
            this.form_dashbord.closeLogin();
        }
       
    }
}
