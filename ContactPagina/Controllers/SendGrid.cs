using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace ContactPagina.Controllers
{
    public class Example
    {
        public static void Main()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            //var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient("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");
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("test@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}