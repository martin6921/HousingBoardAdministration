using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Meeting.GetMeeting;

public class GetMeetingQueryHandler : IRequestHandler<GetMeetingQuery, GetMeetingQueryResult>
{
    private readonly IMeetingRepository _meetingRepository;

    public GetMeetingQueryHandler(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }

    Task<GetMeetingQueryResult> IRequestHandler<GetMeetingQuery, GetMeetingQueryResult>.Handle(GetMeetingQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_meetingRepository.Get(request));
    }
}
