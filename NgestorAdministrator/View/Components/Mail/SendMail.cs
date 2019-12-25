using Server.Http.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Components.Mail
{
    public partial class SendMail : MetroFramework.Forms.MetroForm
    {
        public SendMail(string emailTo)
        {
            InitializeComponent();
            _emailTo = emailTo;
        }
        private string _emailTo = null;
        private void SendMail_Load(object sender, EventArgs e)
        {
            txtEmailTo.Text = _emailTo;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MailController mailController = new MailController(
                "dimerson.daniel@gmail.com", 
                "dimy167167",
                 txtEmailTo.Text, 
                txtBody.Text, 
                txtAssunto.Text, 
                txtAnexo.Text
                );
            mailController.EnviarEmail();
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAnexo.Text = openFileDialog.FileName;
            }
        }
    }
}
