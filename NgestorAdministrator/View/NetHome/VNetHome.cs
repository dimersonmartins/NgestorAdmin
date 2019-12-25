using NgestorAdministrator.View.NetHome.App;
using NgestorAdministrator.View.NetHome.Auth;
using NgestorAdministrator.View.NetHome.Http;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NgestorAdministrator.View.NetHome
{
    public partial class VNetHome : MetroFramework.Forms.MetroForm
    {
        public VNetHome(string website_id, string hostName)
        {
            InitializeComponent();
            _hostName   = hostName;
            _website_id = website_id;
        }
        private string _hostName             = null;
        private string _website_id           = null;

        private string base_operadora        = null;
        private string tipo_filtro_operadora = null;
        private string codigo_operacao       = null;
        private string codigo_localizacao    = null;
        private string descricao             = null;
        public static string codigo_atlas    = null;


        private void LoadSelect()
        {
            DATA _DATA = new DATA();
            if (_DATA.TipoFiltros() != null)
            {
                selectTipoFiltro.DataSource = new BindingSource(_DATA.TipoFiltros(), null);
                selectTipoFiltro.DisplayMember = "Value";
                selectTipoFiltro.ValueMember = "Key";
            }

            if (_DATA.Operadora() != null)
            {
                selectBaseOperadora.DataSource = new BindingSource(_DATA.Operadora(), null);
                selectBaseOperadora.DisplayMember = "Value";
                selectBaseOperadora.ValueMember = "Key";
            }

            if (_DATA.Localizacao() != null)
            {
                selectLocalizacao.DataSource = new BindingSource(_DATA.Localizacao(), null);
                selectLocalizacao.DisplayMember = "Value";
                selectLocalizacao.ValueMember = "Key";
            }

            if (_DATA.Operacao() != null)
            {
                selectOperacao.DataSource = new BindingSource(_DATA.Operacao(), null);
                selectOperacao.DisplayMember = "Value";
                selectOperacao.ValueMember = "Key";
            }
        }

        private void VNetHome_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_hostName))
            {
                this.Text = "Host Name " + _hostName;
            }

            LoadSelect();

            advancedWizard1.NextButtonEnabled   = false;
            advancedWizard1.FinishButtonEnabled = false;
        }
      
        private async void btnValidate_Click(object sender, EventArgs e)
        {
            btnValidate.ButtonText = "Aguarde...";
            btnValidate.Enabled     = false;
            base_operadora = ((KeyValuePair<string, string>)selectBaseOperadora.SelectedItem).Key;
            AuthNetHome http = new AuthNetHome();

            if (!await http.execute(base_operadora, txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show("Usuário ou senha invalido!", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnValidate.ButtonText              = "Validar";
                btnValidate.Enabled                 = true;
                advancedWizard1.NextButtonEnabled   = true;
                advancedWizard1.FinishButtonEnabled = false;
            }
           
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            btnPesquisaEmpreiteira.ButtonText = "Aguarde...";
            btnPesquisaEmpreiteira.Enabled = false;
            setValues();

            if (!string.IsNullOrWhiteSpace(Config.AUTHCOOKIE))
            {
                RequestCondigoAtlas requestCondigoAtlas = new RequestCondigoAtlas();
                string CONTENT = await requestCondigoAtlas.getCodigoAtlas(
                    txtNameEmpreiteira.Text,
                    descricao,
                    codigo_operacao,
                    codigo_localizacao);

                Empreiteira empreiteira = new Empreiteira(CONTENT);
                if (empreiteira.ShowDialog() == DialogResult.OK)
                {
                    advancedWizard1.FinishButtonEnabled = true;
                }
                btnPesquisaEmpreiteira.ButtonText = "Localizar";
                btnPesquisaEmpreiteira.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usuario não esta logado!", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPesquisaEmpreiteira.ButtonText = "Localizar";
                btnPesquisaEmpreiteira.Enabled = true;
                advancedWizard1.FinishButtonEnabled = false;
            }
        }

        private async void advancedWizard1_Finish(object sender, EventArgs e)
        {
            setValues();
            Dictionary<string, string> body = new Dictionary<string, string>
                {
                    {"login" ,                 txtUser.Text},
                    {"password" ,              txtPassword.Text},
                    {"base_operadora" ,        base_operadora},
                    {"codigo_atlas" ,          codigo_atlas},
                    {"codigo_operacao" ,       codigo_operacao},
                    {"codigo_localizacao" ,    codigo_localizacao},
                    {"tipo_filtro_operadora" , tipo_filtro_operadora},
                    {"website_id" ,           _website_id},
                    {"active" ,                "1"}
                };

            Server.Http.NetHome.Controller controller = new Server.Http.NetHome.Controller();
            bool response = await controller.cadastrar(body);
            if (response)
            {         
                MessageBox.Show("Cadastro efetuado com sucesso!", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void setValues()
        {
            base_operadora           = ((KeyValuePair<string, string>)selectBaseOperadora.SelectedItem).Key;
            tipo_filtro_operadora    = ((KeyValuePair<string, string>)selectTipoFiltro.SelectedItem).Key;
            codigo_operacao          = ((KeyValuePair<string, string>)selectOperacao.SelectedItem).Key;
            descricao                = ((KeyValuePair<string, string>)selectOperacao.SelectedItem).Value;
            codigo_localizacao       = ((KeyValuePair<string, string>)selectLocalizacao.SelectedItem).Key;        
        }
    }
}
