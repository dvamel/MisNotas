using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisNotas
{
    public partial class EnvioDeCorreo : Form
    {
        public EnvioDeCorreo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarCorreo(richMensaje.Text, DateTime.Now, txtDe.Text.Trim(), txtPara.Text.Trim(), txtAsunto.Text.Trim());
        }

        public void EnviarCorreo(string Mensaje, DateTime FechaEnvio, string De, string Para, string Asunto)
        {

            try
            {
                //Mensaje.Append(Environment.NewLine);
                //Mensaje.Append(String.Format("correo enviado ", FechaEnvio));
                //Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body=Mensaje.ToString();
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port=465;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("devammel@gmail.com","1017235249Mao");
                smtp.EnableSsl = false;
                smtp.Send(mail);
            }
            catch (Exception e ) {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
