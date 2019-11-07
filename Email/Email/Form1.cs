using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//
using System.Net.Mail;//

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFrase_Click(object sender, EventArgs e)
        {
            //Enviar E-mail pelo C#
            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //CONFIGURAÇÕES DO CLIENTE
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //DEFINIT ACESSO E-MAIL
            credenciais.UserName = "baianofotografia.keven";
            credenciais.Password = "12345678kel";

            //CREDENCIAIS NO CLIENTE
            cliente.Credentials = credenciais;

            //MENSAGEM
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("baianofotografia.keven@gmail.com");
            mensagem.Subject = "Títullo da mensagem";
            mensagem.Body = "Essa é a mensagem que estou enviando";
            mensagem.To.Add("keven.barauna@solutis.com.br");

            //ENVIAR
            cliente.Send(mensagem);
            MessageBox.Show("OK");

        }

        private void BtnHtml_Click(object sender, EventArgs e)
        {
            //Enviar E-mail pelo C#
            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //CONFIGURAÇÕES DO CLIENTE
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //DEFINIT ACESSO E-MAIL
            credenciais.UserName = "baianofotografia.keven";
            credenciais.Password = "12345678kel";

            //CREDENCIAIS NO CLIENTE
            cliente.Credentials = credenciais;

            //MENSAGEM
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("baianofotografia.keven@gmail.com");
            mensagem.Subject = "Mensagem em HTML";
            mensagem.IsBodyHtml = true;

            String texto;
            Template template = new Template();
            texto = template.GetMensagem();

            mensagem.Body = texto;

            //mensagem.Body = "<strong>Essa</strong> mensagem <br><br>é uma mensagem de teste!";
            mensagem.To.Add("keven.barauna@solutis.com.br");

            //ENVIAR
            cliente.Send(mensagem);
            MessageBox.Show("OK");

        }
    }
}
