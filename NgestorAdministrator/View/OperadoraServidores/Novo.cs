using NgestorAdministrator.App;
using Server.Http.OperadorasServidores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NgestorAdministrator.View.OperadoraServidores
{
    public partial class Novo : MetroFramework.Forms.MetroForm
    {
        public Novo()
        {
            InitializeComponent();
        }

        private async void LoadSelect()
        {
            ManterData manter = new ManterData();
            bool isSucess = await manter.manter();
            if (isSucess)
            {
                if (manter.operadoras() != null)
                {
                    selectOperadora.DataSource = new BindingSource(manter.operadoras(), null);
                    selectOperadora.DisplayMember = "Key";
                    selectOperadora.ValueMember = "Value";
                }
            }
        }

        private void Novo_Load(object sender, EventArgs e)
        {
            LoadSelect();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string idOperadora = ((KeyValuePair<string, string>)selectOperadora.SelectedItem).Value;

            Dictionary<string, string> body = new Dictionary<string, string>
            {
                {"uri" ,                            txt_uri.Text},
                {"name" ,                            txt_name.Text},
                {"id_fieldservice_operadora" ,       idOperadora}
            };

            Controller controller = new Controller();
            string company = await controller.cadastrarServidor(body);
            MessageBox.Show("Cadastro efetuado com sucesso!", "Negstor", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
    }
}
