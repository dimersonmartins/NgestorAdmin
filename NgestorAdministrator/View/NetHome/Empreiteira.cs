using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NgestorAdministrator.View.NetHome
{
    public partial class Empreiteira : MetroFramework.Forms.MetroForm
    {
        public Empreiteira(string CONTENT)
        {
            InitializeComponent();
            _CONTENT = CONTENT;
        }
        private string _CONTENT = null;
        private void Empreiteira_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_CONTENT))
            {
                getEmpreiteiras();
            }
           
        }

        private void getEmpreiteiras()
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(_CONTENT);

            try
            {
                foreach (var row in htmlDoc.DocumentNode.SelectNodes("//table/tbody/tr [contains(@id, \"td1\")]"))
                {
                    var nodes = row.SelectNodes("td");
                    if (nodes != null)
                    {
                        var CodJDE = nodes[0].InnerText;
                        var CodSAP = nodes[1].InnerText;
                        var CodATLAS = nodes[2].InnerText;
                        var Nome = nodes[3].InnerText;
                        dataGridView1.Rows.Add(
                            CodJDE,
                            CodSAP,
                            CodATLAS,
                            Nome
                            );
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro", "Ngestor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private static List<KeyValuePair<int, string>> criarArray(HtmlAgilityPack.HtmlNodeCollection htmlNode)
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();
            int key = 0;

            foreach (var item in htmlNode)
            {
                lista.Add(new KeyValuePair<int, string>(key, item.InnerText));
                key++;
            }
            return lista;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable data = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                data.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    DataRow dRow = data.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    data.Rows.Add(dRow);
                }
            }
            if (data != null)
            {
                VNetHome.codigo_atlas = data.Rows[0][2].ToString();
                this.DialogResult = DialogResult.OK;
            }
          
        }
    }
}
