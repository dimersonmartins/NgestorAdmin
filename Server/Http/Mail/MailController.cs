using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Server.Http.Mail
{
   public class MailController
    {
        public MailController(
            string From, 
            string Password, 
            string To,
            string Body,
            string Subject,
            string Attachments)
        {
            _fromemail = From;
            _password = Password;
            _emailTo = To;
            _body = Body;
            _subject = Subject;
            _attachments = Attachments;
         }
        private string _fromemail = null;
        private string _password = null;
        private string _emailTo = null;
        private string _body = null;
        private string _subject = null;
        private string _attachments = null;
        public void EnviarEmail()
        {
            try // Its a good practice to write your code in a try catch block 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Connection Object
                MailMessage message = new MailMessage(); // Email Object
                message.From = new MailAddress(_fromemail); // Sender Email
                message.To.Add(_emailTo); // Reciever emailid
                message.Body = _body; // Body of the email
                message.Subject = _subject; // Subject of the email
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Enabling secured Connection
                if (_attachments != null) // ENVIA O ARQUIVO EM ANEXO
                {
                    message.Attachments.Add(new Attachment(_attachments)); //Adding attachment
                }
                client.Credentials = new System.Net.NetworkCredential(_fromemail, _password); // Setting Credential of gmail account              
                client.Send(message); //Sending Email              
                Console.WriteLine("Completo");
                message = null; // Free the memory
            }
            catch (Exception ex) // Catching if any error occurs
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
