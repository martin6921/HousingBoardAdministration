using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Meeting.GetMeeting;

public record GetMeetingQuery : IRequest<GetMeetingQueryResult>
{
    public Guid Id { get; set; }
}
