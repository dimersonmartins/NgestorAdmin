using Newtonsoft.Json.Linq;
using NgestorAdministrator.View.Components.DefualtHeader;
using Server.Http.ACL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NgestorAdministrator.View.ACL
{
    public partial class ListarAcls : UserControl
    {
        public ListarAcls()
        {
            InitializeComponent();
        }
        private int current_page = 1;
        private int last_page    = 0;
        private int total_pages  = 0;
        private void ListarOperadorasServidores_Load(object sender, EventArgs e)
        {
            TopHeader topHeader = new TopHeader("Sistema", "ACL");
            topHeader.Dock = DockStyle.Fill;
            painelTopHeader.Controls.Add(topHeader);
            navegate();
        }

        private async void navegate()
        {
            Controller controller = new Controller();
            string response = await controller.listar(current_page);
            if (!string.IsNullOrWhiteSpace(response))
            {
                listarGridView(response);
            }
        }

        private bool listarGridView(string response)
        {
            gridACL.Rows.Clear();
            var jsonObject = JObject.Parse(response);

            if (jsonObject == null)
            {
                return false;
            }
            current_page    = int.Parse(jsonObject["permissons"]["current_page"].ToString());
            last_page       = int.Parse(jsonObject["permissons"]["last_page"].ToString());
            total_pages     = int.Parse(jsonObject["permissons"]["total"].ToString());

            btn_pages.Text = current_page.ToString() + "/" + last_page.ToString();

            foreach (var companys in jsonObject["permissons"]["data"])
            {
                gridACL.Rows.Add(
                companys["id"],
                companys["permission_tipo"]["name"],
                companys["name"]
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (last_page > current_page)
            {
                current_page = current_page + 1;
                navegate();
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (current_page != 1)
            {
                current_page = current_page - 1;
                navegate();
            }
        }
    }
}
