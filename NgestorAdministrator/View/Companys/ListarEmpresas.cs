using Newtonsoft.Json.Linq;
using NgestorAdministrator.View.Components.DefualtHeader;
using NgestorAdministrator.View.Components.Mail;
using NgestorAdministrator.View.Debug;
using Server.Http.Company;
using System;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Companys
{
    public partial class ListarEmpresas : UserControl
    {
        public ListarEmpresas()
        {
            InitializeComponent();
        }
        private string responseJSON = null;
        private string currentPAGE  = null;
        private string lastPAGE     = null;
        private string totalPAGE    = null;
        private string _emailTo     = null;
        private string _content     = null;
        private int rowSelected     = 0;
        private async void ListarEmpresas_Load(object sender, EventArgs e)
        {
            TopHeader topHeader = new TopHeader("Empresas", "Empresas");
            topHeader.Dock = DockStyle.Fill;
            painelTopHeader.Controls.Add(topHeader);
            try
            {
                Controller listar = new Controller();
                responseJSON = await listar.listarCompanys();
                listarGridView();
            }
            catch { }
          
        }

        private void listarGridView()
        {
            companysGrid.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(responseJSON))
            {
                var jsonObject = JObject.Parse(responseJSON);
                if (jsonObject.HasValues)
                {
                    currentPAGE = jsonObject["current_page"].ToString();
                    lastPAGE = jsonObject["last_page"].ToString();
                    totalPAGE = jsonObject["total"].ToString();

                    foreach (var companys in jsonObject["data"])
                    {
                        string json = "{\"company\":[" + companys + "]}";
                        companysGrid.Rows.Add(
                            companys["id"],
                            companys["nome_fantasia"],
                            companys["endereco"],
                            companys["email"],
                            json
                            );
                    }
                }
            }

        }

        private async void btnPesquisa_Click(object sender, EventArgs e)
        {
            Controller pesquisaName = new Controller();
            responseJSON =  await pesquisaName.pesquisaCompany(txtPesquisa.Text);           
            listarGridView();
        }

        private void btnNovaEmpresa_Click(object sender, EventArgs e)
        {
            NovaEmpresa novaEmpresa = new NovaEmpresa();
            novaEmpresa.ShowDialog();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail(_emailTo);
            sendMail.ShowDialog();
        }
       

        private void companysGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowSelected = e.RowIndex;
            if (e.RowIndex != -1)
            {
                this.companysGrid.ClearSelection();
                this.companysGrid.Rows[rowSelected].Selected = true;
            }

            if (companysGrid.SelectedRows.Count > 0)
            {
                _emailTo = companysGrid.Rows[rowSelected].Cells[3].Value.ToString();
                _content = companysGrid.Rows[rowSelected].Cells[4].Value.ToString();
            }
        }

        private void detalheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_content))
            {
                var jsonObject = JObject.Parse(_content);
                CompanyDetalhes detalhes = new CompanyDetalhes(jsonObject);
                detalhes.ShowDialog();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
