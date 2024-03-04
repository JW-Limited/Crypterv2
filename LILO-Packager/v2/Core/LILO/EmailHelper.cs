using LILO_Packager.v2.Core.Interfaces;
using System.Diagnostics;
using System.Text.RegularExpressions;
using MimeKit;
using MimeKit.Text;

namespace LILO_Packager.v2.Core.LILO
{
    public class EmailHelper : IEmailHelper
    {
        public static void SendEmail(string toEmailAddress, string subject, string body, string protocol = "mailto:")
        {
            if (!Regex.IsMatch(toEmailAddress, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"))
            {
                throw new ArgumentException("Invalid email address.", nameof(toEmailAddress));
            }

            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("JW Limited", "ceo@swapix.fun"));
            emailMessage.To.Add(new MailboxAddress("Customer",toEmailAddress));
            emailMessage.Subject = subject;
            emailMessage.Body = new MimeKit.TextPart(TextFormat.Html) { Text = body };

            string url = $"mailto:{Uri.EscapeDataString(toEmailAddress)}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }

}