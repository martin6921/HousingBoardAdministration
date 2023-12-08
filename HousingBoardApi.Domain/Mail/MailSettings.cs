using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Domain.Mail
{
    public class MailSettings
    {
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string HostUrl { get; set; }
    }
}
