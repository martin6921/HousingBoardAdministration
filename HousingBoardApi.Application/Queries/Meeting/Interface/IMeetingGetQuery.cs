
using HousingBoardApi.Application.Queries.Meeting.Dto;

namespace HousingBoardApi.Application.Queries.Meeting.Interface;

public interface IMeetingGetQuery
{
    MeetingGetQueryResultDto Get(Guid id);

}
