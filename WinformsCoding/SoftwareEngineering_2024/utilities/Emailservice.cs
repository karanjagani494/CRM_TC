using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Mail;
using SoftwareEngineering_2024.utilities;


namespace SoftwareEngineering_2024.utilities
{
    using System;
    using System.Net;
    using System.Net.Mail;

    public class EmailService
    {

        public void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("karanjagani20@gmail.com", "itep rwzb wfgh aper"), // Replace with your email and app password
                    EnableSsl = true,
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("karanjagani20@gmail.com", "CRM Team"), // Sender details
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false,
                };

                mail.To.Add(toEmail); // Recipient's email address

                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }

}
