using System.Net.Mail;
using System.Net;

namespace FinalProjectGroup6.Services
{
    
    public class EmailService
    {
        // Method to send an email to a specified address with a given subject and body content
        public static void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                // Create a new instance of the SmtpClient to configure SMTP settings

                using var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, 
                    Credentials = new NetworkCredential("fureverfriends627@gmail.com", "cooj ckpx hhlb nkge"),
                    EnableSsl = true, 
                };

                // Create a new MailMessage object to configure the email details
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("fureverfriends627@gmail.com"), 
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true, 
                };

                // Add the recipient's email address
                mailMessage.To.Add(toEmail);

                // Send the email via the SMTP client
                smtpClient.Send(mailMessage);
                Console.WriteLine($"Email sent successfully to {toEmail}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email. Error: {ex.Message}");
            }
        }
    }
    
}
