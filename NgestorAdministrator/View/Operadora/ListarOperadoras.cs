using Newtonsoft.Json.Linq;
using NgestorAdministrator.View.Components.DefualtHeader;
using Server.Http.Operadoras;
using System;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Operadora
{
    public partial class ListarOperadoras : UserControl
    {
        public ListarOperadoras()
        {
            InitializeComponent();
        }

        private async void ListarOperadoras_Load(object sender, EventArgs e)
        {
            TopHeader topHeader = new TopHeader("Operadoras", "Operadoras");
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
            gridOperadoras.Rows.Clear();
            var jsonObject = JObject.Parse(response);

            if (jsonObject == null)
            {
                return false;
            }

            foreach (var companys in jsonObject["operadoras"])
            {
                gridOperadoras.Rows.Add(
                    companys["id"],
                    companys["name"]
                    );
            }

            return true;
        }
        private void btnNovaEmpresa_Click(object sender, EventArgs e)
        {
            Nova nova = new Nova();
            nova.ShowDialog();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
