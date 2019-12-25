using Newtonsoft.Json.Linq;
using NgestorAdministrator.View.Components.DefualtHeader;
using Server.Http.OperadorasServidores;
using System;
using System.Windows.Forms;

namespace NgestorAdministrator.View.OperadoraServidores
{
    public partial class ListarOperadorasServidores : UserControl
    {
        public ListarOperadorasServidores()
        {
            InitializeComponent();
        }

        private async void ListarOperadorasServidores_Load(object sender, EventArgs e)
        {
            TopHeader topHeader = new TopHeader("Operadoras", "Servidores");
            topHeader.Dock = DockStyle.Fill;
            painelTopHeader.Controls.Add(topHeader);

            Controller controller = new Controller();
            string response = await controller.listar();
            if (!string.IsNullOrWhiteSpace(response))
            {
                listarGridView(response);
            }
        }
        private bool listarGridView(string response)
        {
            gridServidores.Rows.Clear();
            var jsonObject = JObject.Parse(response);

            if (jsonObject == null)
            {
                return false;
            }

            foreach (var companys in jsonObject["servidores"])
            {
                gridServidores.Rows.Add(
                    companys["id"],
                    companys["name"],
                    companys["uri"]
                    );
            }

            return true;
        }
        private void btnNovaEmpresa_Click(object sender, EventArgs e)
        {
            Novo novo = new Novo();
            novo.ShowDialog();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
