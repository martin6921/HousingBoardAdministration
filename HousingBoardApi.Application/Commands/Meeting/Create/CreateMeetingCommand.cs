using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Meeting.Create;

public record class CreateMeetingCommand : IRequest
{
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime MeetingTime { get; set; }
    public string AddressLocation { get; set; }

    public Guid MeetingTypeId { get; set; }

    public Guid MeetingOwnerId { get; set; }
}
