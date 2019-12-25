using Newtonsoft.Json.Linq;
using NgestorAdministrator.View.Companys.Hosts;
using Server.Http.Company;
using System;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Components.PesquisaCompany
{
    public partial class PesquisaCompany : MetroFramework.Forms.MetroForm
    {
        public PesquisaCompany()
        {
            InitializeComponent();
        }

        private int rowSelected = 0;

        private void PesquisaCompany_Load(object sender, EventArgs e)
        {

        }

        private async void btnPesquisa_Click(object sender, EventArgs e)
        {
            Controller pesquisaCompany = new Controller();
            string responseJSON = await pesquisaCompany.pesquisaCompany(txtComanyName.Text);
            listarGridView(responseJSON);
        }

        private void listarGridView(string responseJSON)
        {
            companysGrid.Rows.Clear();
            var jsonObject = JObject.Parse(responseJSON);

            foreach (var companys in jsonObject["data"])
            {
                companysGrid.Rows.Add(
                    companys["id"],
                    companys["nome_fantasia"]
                    );
            }
        }

        private void companysGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            if (e.RowIndex != -1)
            {
                this.companysGrid.ClearSelection();
                this.companysGrid.Rows[rowSelected].Selected = true;
            }

            if (companysGrid.SelectedRows.Count > 0)
            {
                NovoHost.company_id = companysGrid.Rows[rowSelected].Cells[0].Value.ToString();
                NovoHost.company_name = companysGrid.Rows[rowSelected].Cells[1].Value.ToString();              
            }

            this.DialogResult = DialogResult.OK;
        }
       
        private void companysGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.companysGrid.ClearSelection();
                    this.companysGrid.Rows[rowSelected].Selected = true;
                }
            }
        }
    }
}
