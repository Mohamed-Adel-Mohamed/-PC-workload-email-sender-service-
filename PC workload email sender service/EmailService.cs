using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace Q1_WindowsService;

public sealed class EmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(IOptions<EmailSettings> emailOptions)
    {
        _emailSettings = emailOptions.Value;
    }

    public void SendEmail(string filePath)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(_emailSettings.FromName, _emailSettings.FromAddress));
        message.To.Add(new MailboxAddress(_emailSettings.ToName, _emailSettings.ToAddress));

        message.Subject = "PC Workload";
        //  BodyBuilder() to construct the body ( probably the easiest way)

        var bodyBuilder = new BodyBuilder();
        bodyBuilder.HtmlBody = @"
                                <h1 >PC Workload for " + DateTime.Now + @"</h1>
                                
                                <p style='font-size: 16px;'>
                                     find the attached file for my pc.
                                </p>
                                
                                ";

        var attachment = bodyBuilder.LinkedResources.Add(filePath);
        attachment.ContentId = Path.GetFileName(filePath);
        //attachment and give it a ContentId like it was implemented


        message.Body = bodyBuilder.ToMessageBody();
        //ToMessageBody() to convert BodyBuilder to a MimeEntity (pretty much what's the lib doc says)

        using var client = new SmtpClient();
        client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        client.Authenticate(_emailSettings.GmailUsername, _emailSettings.GmailPassword);

        client.Send(message);
        client.Disconnect(true);
    }
}
