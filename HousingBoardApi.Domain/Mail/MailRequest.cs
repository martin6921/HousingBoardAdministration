using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Domain.Mail
{
    public class MailRequest
    {
        public List<String> RecipientEmailAddresses {  get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}
