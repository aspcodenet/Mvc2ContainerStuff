using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public class EmailSender : Microsoft.AspNetCore.Identity.UI.Services.IEmailSender
    {

        // Our private configuration variables
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;

        // Get our parameterized configuration
        public EmailSender(IOptions<SmtpServerSettings> settings)
        {
            this.host = settings.Value.Host;
            this.port = settings.Value.Port;
            this.enableSSL = settings.Value.EnableSSL;
            this.userName = settings.Value.Username;
            this.password = settings.Value.Password;
        }

        // Use our configuration to send the email by using SmtpClient
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress("Stefan", "stefan@stefan.se"));

                mimeMessage.To.Add(new MailboxAddress(email));

                mimeMessage.Subject = subject;

                mimeMessage.Body = new TextPart("html")
                {
                    Text = htmlMessage
                };

                using (var client = new SmtpClient())
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect(host, port, enableSSL);
                    if(!string.IsNullOrEmpty(userName))
                    {
                        // Note: only needed if the SMTP server requires authentication
                        client.Authenticate(userName, password);
                    }

                    client.Send(mimeMessage);

                    client.Disconnect(true);
                }
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
