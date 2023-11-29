
using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Application.Queries.Meeting.Interface;

namespace HousingBoardApi.Application.Queries.Meeting.Implementation;

public class MeetingGetAllQuery : IMeetingGetAllQuery
{
    private readonly IMeetingRepository _meetingRepository;

    public MeetingGetAllQuery(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }

    IEnumerable<MeetingGetAllQueryResultDto> IMeetingGetAllQuery.GetAll()
    {
        return _meetingRepository.GetAll();
    }
}
