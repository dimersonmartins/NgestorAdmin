using NgestorAdministrator.App;
using NgestorAdministrator.View.Components.PesquisaCompany;
using Server.Http.Company;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Companys.Hosts
{
    public partial class NovoHost : MetroFramework.Forms.MetroForm
    {
        public NovoHost()
        {
            InitializeComponent();
        }
        public static string company_name = null;
        public static string company_id = null;
        private string timeZoneValue = null;
        private string idOperadora = null;
        private string idOperadoraServidor = null;
        private void setValues()
        {
            timeZoneValue = ((KeyValuePair<string, string>)SelectTimerZone.SelectedItem).Value;
            idOperadora = ((KeyValuePair<string, string>)selectOperadora.SelectedItem).Value;
            idOperadoraServidor = ((KeyValuePair<string, string>)selectOperadoraServidor.SelectedItem).Value;  
        }

        private async void LoadSelects()
        {
            ManterData manter = new ManterData();
            bool isSucess = await manter.manter();
            if (isSucess)
            {
                if (manter.timerZone() != null)
                {
                    SelectTimerZone.DataSource = new BindingSource(manter.timerZone(), null);
                    SelectTimerZone.DisplayMember = "Key";
                    SelectTimerZone.ValueMember = "Value";
                }

                if (manter.operadoras() != null)
                {
                    selectOperadora.DataSource = new BindingSource(manter.operadoras(), null);
                    selectOperadora.DisplayMember = "Key";
                    selectOperadora.ValueMember = "Value";
                }

                if (manter.operadoras_servidores() != null)
                {
                    selectOperadoraServidor.DataSource = new BindingSource(manter.operadoras_servidores(), null);
                    selectOperadoraServidor.DisplayMember = "Key";
                    selectOperadoraServidor.ValueMember = "Value";
                }

            }
            else
            {
                MessageBox.Show("Erro na Conexão!", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NovoHost_Load(object sender, EventArgs e)
        {
            LoadSelects();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            lbl_status.Text = "Criando base de dados";
            setValues();

            Dictionary<string, string> body = new Dictionary<string, string>
                {
                    {"id_fieldservice_operadora" ,  idOperadora},
                    {"timezone" ,                   timeZoneValue},
                    {"id_tenant_company" ,          company_id},
                    {"id_operadora_servidor" ,      idOperadoraServidor},
                    {"local_estado" ,               txtUFH.Text},
                    {"local_cidade" ,               txtCidadeH.Text},
                    {"codigo_parceira" ,            txtCodigoParceira.Text},
                    {"hostname" ,                   txtHostName.Text}
                };

            Controller novoHost = new Controller();
            bool company = await novoHost.cadastrarHost(body);
            if (company)
            {
                var isResultOK =  MessageBox.Show("Cadastro efetuado com sucesso!", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isResultOK == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                lbl_status.Text = "Ocorreu um erro durante o processo!";
            }
            btnSalvar.Enabled = false;
        }

        private void btnPesquisaCompany_Click(object sender, EventArgs e)
        {
            PesquisaCompany pesquisaCompany = new PesquisaCompany();
            var result = pesquisaCompany.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] sugestao_url = company_name.Split(' ');
                txtHostName.Text = sugestao_url[0].ToLower();
            }
        }
    }
}
