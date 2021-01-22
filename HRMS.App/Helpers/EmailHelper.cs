using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.CL.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace HRMS.App.Helpers
{
    public class EmailHelper
    {
        public static async Task SendEmailNotificationAsync(EmployeeModel model, string leaveType, DateTime leaveFrom, DateTime leaveTo)
        {
            var stringBuilder = new StringBuilder();
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(@"FILAMER CHRISTIAN UNIVERSITY DEVELOPMENT TEAM", "agurokeendavid@gmail.com"));
            message.To.Add(new MailboxAddress(model.EmailAddress, model.EmailAddress));
            message.Subject = "Email Notification | FCU HUMAN RESOURCE MANAGEMENT SYSTEM";
            stringBuilder.Append(@"<DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>");
            stringBuilder.Append(@"<html xmlns='http://www.w3.org/1999/xhtml'>");
            stringBuilder.Append(@"<head>");
            stringBuilder.Append(@"<meta http-equiv='Content-Type' content='text/html;charset=UTF-8' />");
            stringBuilder.Append(@"<title>Email Notification | FCU HUMAN RESOURCE MANAGEMENT SYSTEM</title>");
            stringBuilder.Append(@"<meta name='viewport' content='width=device-width, initial-scale=1.0' />");
            stringBuilder.Append(@"</head>");
            stringBuilder.Append(@"<body style='margin: 0; padding: 0;'>");
            stringBuilder.Append(@"<table align='center' border='0' cellpadding='0' cellspacing='0' width='600' style='border: 1px solid #ccc;'>");
            stringBuilder.Append(@"<tr>");
            stringBuilder.Append(@"<td bgcolor='#fafafa' style='padding: 40px 30px 40px 30px;'>");
            stringBuilder.Append(@"<table border='0' cellpadding='0' cellspacing='0' width='100%'>");
            stringBuilder.Append(@"<tr>");
            stringBuilder.Append(@"<td style='color: #153643; font-family: Arial, sans-serif; font-size: 24px;'>");
            stringBuilder.Append(@"<b>Email Notification | FCU HUMAN RESOURCE MANAGEMENT SYSTEM</b>");
            stringBuilder.Append(@"</td>");
            stringBuilder.Append(@"</tr>");
            stringBuilder.Append(@"<tr>");
            stringBuilder.Append(@"<td style='padding: 20px 0 30px 0; color: #153643; font-family: Arial, sans-serif; font-size: 16px; line-height: 20px;'>");
            stringBuilder.Append($@"<p>Hi {model.FirstName} {model.LastName},</p>");
            stringBuilder.Append($@"<p>Your applied leave [{leaveType}] from [{leaveFrom.ToString("D", CultureInfo.InvariantCulture)}] to [{leaveTo.ToString("D", CultureInfo.InvariantCulture)}] has been successfully approved.</p>");
            stringBuilder.Append(@"<p>NOTE: This is a system generated message, do not reply or send to this address.</p>");
            stringBuilder.Append(@"<p><strong>FILAMER CHRISTIAN UNIVERSITY DEVELOPMENT TEAM</strong></p>");
            stringBuilder.Append(@"</td>");
            stringBuilder.Append(@"</tr>");
            stringBuilder.Append(@"</table>");
            stringBuilder.Append(@"</td>");
            stringBuilder.Append(@"</tr>");
            stringBuilder.Append(@"<tr>");
            stringBuilder.Append(@"<td bgcolor='#ee4c50' style='padding: 30px 30px 30px 30px;'>");
            stringBuilder.Append(@"<table border='0' cellpadding='0' cellspacing='0' width='100%'>");
            stringBuilder.Append(@"<tr>");
            stringBuilder.Append(@"<td width='75%' style='font-family: Arial, sans-serif; font-size: 14px;'>");
            stringBuilder.Append($@"<a href='{"https://www.filamer.edu.ph/"}'><font color='#fff'>&copy; FILAMER CHRISTIAN UNIVERSITY 2021.</font></a>");
            stringBuilder.Append(@"</td>");
            stringBuilder.Append(@"</tr>");
            stringBuilder.Append(@"</table>");
            stringBuilder.Append(@"</td>");
            stringBuilder.Append(@"</tr>");
            stringBuilder.Append(@"</table>");
            stringBuilder.Append(@"</table>");
            stringBuilder.Append(@"</body>");
            stringBuilder.Append(@"</html>");
            message.Body = new TextPart("html")
            {
                Text = stringBuilder.ToString()
            };
            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await client.ConnectAsync("smtp.gmail.com", 465);
                await client.AuthenticateAsync("mariaczarinaaguro@gmail.com", "0601MCAguro");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
