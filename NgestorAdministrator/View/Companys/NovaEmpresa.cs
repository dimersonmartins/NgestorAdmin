using Newtonsoft.Json.Linq;
using Server.Http.Company;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Companys
{
    public partial class NovaEmpresa : MetroFramework.Forms.MetroForm
    {
        public NovaEmpresa()
        {
            InitializeComponent();
        }

        private void NovaEmpresa_Load(object sender, EventArgs e)
        {

        }
       
        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> body = new Dictionary<string, string>
                {
                    {"tipo_pessoa" ,        selectTipoPessoa.Text},
                    {"razao_social" ,       txtRazaoSocial.Text},
                    {"nome_fantasia" ,      txtNomeFantasia.Text},
                    {"inscricao_estadual" , txt_inscricao_estadual.Text},
                    {"cpf" ,                txtCPF.Text},
                    {"cnpj" ,               txtCNPJ.Text},
                    {"email" ,              txtEmail.Text},
                    {"telefone1" ,          txtFone1.Text},
                    {"telefone2" ,          txtFone2.Text},
                    {"telefone3" ,          txtFone3.Text},
                    {"endereco" ,           txtEndereco.Text},
                    {"numero" ,             txtNumero.Text},
                    {"bairro" ,             txtBairro.Text},
                    {"cep" ,                txtCep.Text},
                    {"cidade" ,             txtCidade.Text},
                    {"uf" ,                 txtUF.Text},
                    {"complemento" ,        txtComplemento.Text},
                };

                Controller Company = new Controller();
                string company = await Company.cadastrarCompany(body);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Negstor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clearCampos();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void clearCampos()
        {
            txtRazaoSocial.Text         = "";
            txtRazaoSocial.Text         = "";
            txtNomeFantasia.Text        = "";
            txt_inscricao_estadual.Text = "";
            txtCPF.Text                 = "";
            txtCNPJ.Text                = "";
            txtEmail.Text               = "";
            txtFone1.Text               = "";
            txtFone2.Text               = "";
            txtFone3.Text               = "";
            txtEndereco.Text            = "";
            txtNumero.Text              = "";
            txtBairro.Text              = "";
            txtCep.Text                 = "";
            txtCidade.Text              = "";
            txtUF.Text                  = "";
            txtComplemento.Text         = "";
        }

        private void txtCep_TextChange(object sender, EventArgs e)
        {
            if (txtCep.Text.Length == 8)
            {
                WebClient web = new WebClient();
                string baseJs =  web.DownloadString("http://cep.republicavirtual.com.br/web_cep.php?cep="+txtCep.Text+"&formato=json");

                if (!string.IsNullOrWhiteSpace(baseJs))
                {
                    var JSON = JObject.Parse(baseJs);
                    if (JSON != null)
                    {
                        txtEndereco.Text = JSON["tipo_logradouro"].ToString()+" "+ JSON["logradouro"].ToString();
                        txtBairro.Text = JSON["bairro"].ToString();
                        txtCidade.Text = JSON["cidade"].ToString();
                        txtNumero.Focus();
                    }
                  
                }
               
            }
        }
    }
}
