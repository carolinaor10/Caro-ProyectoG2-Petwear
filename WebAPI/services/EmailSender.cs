﻿using static System.Net.WebRequestMethods;
using System.Net.Mail;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace WebAPI.services
{
    public class EmailSender
    {

        public async Task SendEmail(string toEmail, string username,string message)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("aulateu@ucenfotec.ac.cr", "Petwear");
            var subject = "correo verificación";
            var to = new EmailAddress(toEmail , username);
            var plainTextContent = message;
            var htmlContent = "" ;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
