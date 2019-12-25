using Newtonsoft.Json.Linq;
using NgestorAdministrator.View.Components.DefualtHeader;
using NgestorAdministrator.View.NetHome;
using Server.Http.Company;
using System;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Companys.Hosts
{
    public partial class ListarHosts : UserControl
    {
        public ListarHosts()
        {
            InitializeComponent();
        }
        private string responseJSON = null;
        private string currentPAGE  = null;
        private string lastPAGE     = null;
        private string totalPAGE    = null;
        private int rowSelected     = 0;
        private string website_id   = null;
        private string hosName      = null;
        private void btnNovaEmpresa_Click(object sender, EventArgs e)
        {
            NovoHost novoHost = new NovoHost();
            novoHost.ShowDialog();
        }

        private async void ListarHosts_Load(object sender, EventArgs e)
        {
            TopHeader topHeader = new TopHeader("Hosts", "Hosts");
            topHeader.Dock = DockStyle.Fill;
            painelTopHeader.Controls.Add(topHeader);

            Controller listar = new Controller();
            responseJSON = await listar.listarHosts();
            if (!string.IsNullOrWhiteSpace(responseJSON))
            {
                listarGridView();
            }
        }
        private bool listarGridView()
        {
            companysGrid.Rows.Clear();
            if (string.IsNullOrWhiteSpace(responseJSON))
            {
                return false;
            }
            var jsonObject = JObject.Parse(responseJSON);

            if (jsonObject == null)
            {
                return false;
            }

            currentPAGE = jsonObject["current_page"].ToString();
            lastPAGE    = jsonObject["last_page"].ToString();
            totalPAGE   = jsonObject["total"].ToString();

            foreach (var companys in jsonObject["data"])
            {
                companysGrid.Rows.Add(
                    companys["id"],      
                    companys["fqdn"],
                     companys["website_id"]
                    );
            }

            return true;
        }
        private async void btnPesquisa_Click(object sender, EventArgs e)
        {
            Controller pesquisaHost = new Controller();
            responseJSON = await pesquisaHost.pesquisaHost(txtPesquisa.Text);
            if (!string.IsNullOrWhiteSpace(responseJSON))
            {
                listarGridView();
            }
        }

        private void configNetHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(website_id) && !string.IsNullOrWhiteSpace(hosName))
            {
                Configurar netHome = new Configurar(website_id, hosName);
                netHome.ShowDialog();
            }
           
        }

        private void companysGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.companysGrid.ClearSelection();
                    this.companysGrid.Rows[rowSelected].Selected = true;
                }

                if (companysGrid.SelectedRows.Count > 0)
                {
                    hosName = companysGrid.Rows[rowSelected].Cells[1].Value.ToString();
                    website_id = companysGrid.Rows[rowSelected].Cells[2].Value.ToString();
                }
            }
            catch { }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
