using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Resource_Management
{
    public partial class Forgetpassword : Form
    {
        public Forgetpassword()
        {
            InitializeComponent();
        }
        string randomcode;

        private void sendotp_btn_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody, to;
            Random random = new Random();
            randomcode = (random.Next(999999).ToString());
            MailMessage mailMessage = new MailMessage();
            to = (fgt_regemail_tbl.Text).ToString();
            from = "m.sudharshan777@gmail.com";
            pass = "otjt jznd zrcv xehk";
            messagebody = "Your OTP Verification Code :" + randomcode;
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messagebody;
            mailMessage.Subject = "Employee Management VErification";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("OTP Sent Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void verotp_btn_Click(object sender, EventArgs e)
        {
            if (randomcode == (fgt_entotp_tbl.Text).ToString())
            {
                MessageBox.Show("OTP Verified Successfully");
                Updatepassword up = new Updatepassword();
                up.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid OTP");

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
