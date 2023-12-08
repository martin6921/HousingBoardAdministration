using HousingBoardApi.Application.Commands.Meeting.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Messages.Events
{
    public class CreateMeetingEmailEvent : INotification
    {
        public string Title { get; set; }
        public string AddressLocation { get; set; }
        public DateTime MeetingTime { get; set; }

    }
}
