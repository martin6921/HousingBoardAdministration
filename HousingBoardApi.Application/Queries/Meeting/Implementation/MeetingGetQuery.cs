using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Application.Queries.Meeting.Interface;

namespace HousingBoardApi.Application.Queries.Meeting.Implementation;

public class MeetingGetQuery : IMeetingGetQuery
{
    private readonly IMeetingRepository _meetingRepository;

    public MeetingGetQuery(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }
    MeetingGetQueryResultDto IMeetingGetQuery.Get(Guid id)
    {
        return _meetingRepository.Get(id);
    }
}
