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
            try {
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
            credenciais.UserName = "";//AQUI VOCÊ COLOCA SEU E-MAIL
            credenciais.Password = "";//AQUI VOCÊ COLOCA SUA SENHA

            //CREDENCIAIS NO CLIENTE
            cliente.Credentials = credenciais;

            //MENSAGEM
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("");//SEU E-MAIL AQUI
            mensagem.Subject = "Meu teste";

            String texto;
            Template template = new Template();
            texto = template.GetMensagem();

            mensagem.Body = texto;
            mensagem.To.Add("");//E-MAIL DO DESTINATARIO

            //ENVIAR
            cliente.Send(mensagem);
            MessageBox.Show("Sucesso! verifique sua caixa de entrada");
            }
            catch (Exception erro) {
            MessageBox.Show("Erro! :/ " + erro.Message);
            }

        }

        private void BtnHtml_Click(object sender, EventArgs e)
        {
            try
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
                credenciais.UserName = "";//AQUI VOCÊ COLOCA SEU E-MAIL
                credenciais.Password = "";//AQUI VOCÊ COLOCA SUA SENHA

                //CREDENCIAIS NO CLIENTE
                cliente.Credentials = credenciais;

                //MENSAGEM
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("");//SEU E-MAIL AQUI
                mensagem.Subject = "Meu teste";

                String texto;
                Template template = new Template();
                texto = template.GetMensagemHtml();

                mensagem.Body = texto;
                mensagem.To.Add("");//E-MAIL DO DESTINATARIO

                //ENVIAR
                cliente.Send(mensagem);
                MessageBox.Show("Sucesso! verifique sua caixa de entrada");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro! :/ " + erro.Message);
            }

        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            try
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
                credenciais.UserName = txtEmailPessoal.Text;//AQUI VOCÊ COLOCA SEU E-MAIL
                credenciais.Password = txtConfSenha.Text;//AQUI VOCÊ COLOCA SUA SENHA

                //CREDENCIAIS NO CLIENTE
                cliente.Credentials = credenciais;

                //MENSAGEM
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(txtEmailPessoal.Text);//SEU E-MAIL AQUI
                mensagem.Subject = txtTitulo.Text;

                String texto;
                Template template = new Template();
                texto = template.GetMensagemHtml();
                mensagem.Body = txtMensagem.Text;//MENSAGEM
                mensagem.To.Add(txtDestinatatio.Text);//E-MAIL DO DESTINATARIO

                //ENVIAR
                cliente.Send(mensagem);
                MessageBox.Show("Sucesso! verifique sua caixa de entrada");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro! :/ " + erro.Message);
            }
        }
    }
}
