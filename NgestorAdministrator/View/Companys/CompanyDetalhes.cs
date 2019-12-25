using Newtonsoft.Json.Linq;
using System;

namespace NgestorAdministrator.View.Companys
{
    public partial class CompanyDetalhes : MetroFramework.Forms.MetroForm
    {
        public CompanyDetalhes(JObject json)
        {
            InitializeComponent();
            _JSON = json;
        }
        private JObject _JSON = null;
        private void CompanyDetalhes_Load(object sender, EventArgs e)
        {
            if (_JSON.HasValues)
            {        
                txt_razao_social.Text   = _JSON["company"][0]["razao_social"].ToString();
                txt_nome_fantasia.Text  =  _JSON["company"][0]["nome_fantasia"].ToString();
                txt_insc_estadual.Text  =  _JSON["company"][0]["inscricao_estadual"].ToString();
                txt_cpf.Text            =  _JSON["company"][0]["cpf"].ToString();
                txt_cnpj.Text           =  _JSON["company"][0]["cnpj"].ToString();
                txt_email.Text          = _JSON["company"][0]["email"].ToString();
                txt_fone1.Text          = _JSON["company"][0]["telefone1"].ToString();
                txt_fone2.Text          =  _JSON["company"][0]["telefone2"].ToString();
                txt_fone3.Text          =  _JSON["company"][0]["telefone3"].ToString();
                txt_endereco.Text       =  _JSON["company"][0]["endereco"].ToString();
                txt_numero.Text         =  _JSON["company"][0]["numero"].ToString();
                txt_bairro.Text         =  _JSON["company"][0]["bairro"].ToString();
                txt_cep.Text            =  _JSON["company"][0]["cep"].ToString();
                txt_cidade.Text         =  _JSON["company"][0]["cidade"].ToString();
                txt_uf.Text             =  _JSON["company"][0]["uf"].ToString();
                txt_complemento.Text    =  _JSON["company"][0]["complemento"].ToString();
            }
        }
    }
}
