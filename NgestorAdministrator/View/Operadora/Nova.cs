using Server.Http.Operadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Operadora
{
    public partial class Nova : MetroFramework.Forms.MetroForm
    {
        public Nova()
        {
            InitializeComponent();
        }

        private void Nova_Load(object sender, EventArgs e)
        {

        }
        private string active = "1";
        private async void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> body = new Dictionary<string, string>
            {
                {"name" ,   txtName.Text},
                {"active" , active}
            };

            Controller controller = new Controller();
            string company = await controller.cadastrarOperadora(body);
            MessageBox.Show("Cadastro efetuado com sucesso!", "Negstor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnActive_OnValueChange(object sender, EventArgs e)
        {
            if (active == "1")
            {
                active = "2";
            }
            else
            {
                active = "1";
            }
        }
    }
}
