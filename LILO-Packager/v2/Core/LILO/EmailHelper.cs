using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Shared;
using System.Diagnostics;

namespace LILO_Packager.v2.Core.LILO
{
    public class EmailHelper : IEmailHelper
    {
        public static void OpenDefaultEmailClient(string emailAddress, string subject, string body, params string[] attachments)
        {
            string uri = $"mailto:{Uri.EscapeDataString(emailAddress)}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

            if (attachments != null && attachments.Length > 0)
            {
                string attachmentList = string.Join(",", attachments);
                uri += $"&attachment={attachmentList}";
            }

            try
            {
                Process.Start(uri);
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor($"An error occurred: {ex.Message}", ConsoleColor.DarkRed);
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}