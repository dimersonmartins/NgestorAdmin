using NgestorAdministrator.View.Companys;
using NgestorAdministrator.View.Companys.Hosts;
using NgestorAdministrator.View.Login;
using NgestorAdministrator.View.Operadora;
using NgestorAdministrator.View.OperadoraServidores;
using NgestorAdministrator.View.Servicos.CodigosDeBaixa;
using NgestorAdministrator.View.Servicos.SituacaoOperadora;
using NgestorAdministrator.View.Servicos.Situacao;
using NgestorAdministrator.View.Servicos.TiposDeServicos;
using System;
using System.Drawing;
using System.Windows.Forms;
using NgestorAdministrator.View.Home;
using NgestorAdministrator.View.ACL;

namespace NgestorAdministrator
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private Form _objectForm;
        private void callLogin()
        {
            _objectForm?.Close();

            _objectForm = new FrmLogin(this)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
            };
            panelCallLogin.Controls.Add(_objectForm);
            _objectForm.Show();
        }

        public void closeLogin()
        {
            Home home = new Home();
            home.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(home);
            menu.Visible = true;
            panelCallLogin.Visible = false;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            callLogin(); 
        }
  
        private void painelCentral_Resize(object sender, EventArgs e)
        {
            int x = (painelCentral.Size.Width - panelCallLogin.Width) / 2;
            int y = (painelCentral.Size.Height - panelCallLogin.Height) / 2;
            panelCallLogin.Location = new Point(x, y);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarEmpresas listarEmpresas = new ListarEmpresas();
            listarEmpresas.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(listarEmpresas);
        }

        private void hostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarHosts listarhosts = new ListarHosts();
            listarhosts.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(listarhosts);
        }

        private void operadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void opServidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void codigosDeBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarServicoCodigoBaixa codigosBaixa = new ListarServicoCodigoBaixa();
            codigosBaixa.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(codigosBaixa);
        }
        private void situacaoOperadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarSituacaoOperadora situacaoOperadora = new ListarSituacaoOperadora();
            situacaoOperadora.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(situacaoOperadora);
        }

        private void situacaoOperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarTiposServicos tiposServicos = new ListarTiposServicos();
            tiposServicos.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(tiposServicos);
        }

        private void servicoTipoDeBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarSituacao svSituacao = new ListarSituacao();
            svSituacao.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(svSituacao);
        }

        private void operadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarOperadoras operadoras = new ListarOperadoras();
            operadoras.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(operadoras);
        }

        private void opServidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarOperadorasServidores servidores = new ListarOperadorasServidores();
            servidores.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(servidores);
        }

        private void aCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelCentral.Controls.Clear();
            ListarAcls acl = new ListarAcls();
            acl.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(acl);
        }
    }
}
