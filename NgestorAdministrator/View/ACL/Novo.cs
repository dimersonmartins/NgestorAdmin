using Server.Http.ACL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NgestorAdministrator.View.ACL
{
    public partial class Novo : MetroFramework.Forms.MetroForm
    {
        public Novo()
        {
            InitializeComponent();
        }

        private async void LoadSelect()
        {
            Controller controller = new Controller();
            await controller.listarTipoPermission();
            controller.tipoPermission();

            if (controller.tipoPermission() != null)
            {
                selectTipoPermisson.DataSource = new BindingSource(controller.tipoPermission(), null);
                selectTipoPermisson.DisplayMember = "Key";
                selectTipoPermisson.ValueMember = "Value";
            }
            
        }

        private void Novo_Load(object sender, EventArgs e)
        {
            LoadSelect();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string id_acl_tipo = ((KeyValuePair<string, string>)selectTipoPermisson.SelectedItem).Value;

            Dictionary<string, string> body = new Dictionary<string, string>
            {
                {"name" ,             txt_name.Text},
                {"id_acl_tipo" ,       id_acl_tipo}
            };

            Controller controller = new Controller();
            string company = await controller.cadastrar(body);
            MessageBox.Show("Cadastro efetuado com sucesso!", "Negstor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
