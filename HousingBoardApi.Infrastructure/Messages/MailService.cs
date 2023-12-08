using HousingBoardApi.Application.Messages;
using HousingBoardApi.Domain.Mail;
using HousingBoardApi.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace HousingBoardApi.Infrastructure.Messages
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        void IMailService.SendEmail(MailRequest mail)
        {
            var smtpClient = new SmtpClient(_mailSettings.HostUrl)
            {
                Port = _mailSettings.Port,
                Credentials = new NetworkCredential(_mailSettings.Username, _mailSettings.Password),
                EnableSsl = true,
            };
            
            foreach(string emailAddress in mail.RecipientEmailAddresses)
            {
                smtpClient.Send(_mailSettings.Sender, emailAddress, mail.Subject, mail.Body);
            }

        }
    }
}
