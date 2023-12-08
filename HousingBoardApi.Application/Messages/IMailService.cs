using HousingBoardApi.Domain.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Messages
{
    public interface IMailService
    {
       
        void SendEmail(MailRequest mail);
    }
}
