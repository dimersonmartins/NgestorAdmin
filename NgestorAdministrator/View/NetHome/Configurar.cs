using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgestorAdministrator.View.NetHome
{
    public partial class Configurar : MetroFramework.Forms.MetroForm
    {
        public Configurar(string website_id, string hostName)
        {
            InitializeComponent();
            _hostName = hostName;
            _website_id = website_id;
        }

        private string _hostName = null;
        private string _website_id = null;

        private string base_operadora = null;
        private string tipo_filtro_operadora = null;
        private string codigo_operacao = null;
        private string codigo_localizacao = null;
        private string descricao = null;

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
        private void Configurar_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_hostName))
            {
                this.Text = "Host Name " + _hostName;
            }

            LoadSelect();
            
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            setValues();
            Dictionary<string, string> body = new Dictionary<string, string>
                {
                    {"login" ,                 txtUser.Text},
                    {"password" ,              txtPassword.Text},
                    {"base_operadora" ,        base_operadora},
                    {"codigo_atlas" ,          txt_condigo_atlas.Text},
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
            base_operadora = ((KeyValuePair<string, string>)selectBaseOperadora.SelectedItem).Key;
            tipo_filtro_operadora = ((KeyValuePair<string, string>)selectTipoFiltro.SelectedItem).Key;
            codigo_operacao = ((KeyValuePair<string, string>)selectOperacao.SelectedItem).Key;
            descricao = ((KeyValuePair<string, string>)selectOperacao.SelectedItem).Value;
            codigo_localizacao = ((KeyValuePair<string, string>)selectLocalizacao.SelectedItem).Key;
        }
    }
}
