
using HousingBoardApi.Application.Queries.Meeting.Dto;

namespace HousingBoardApi.Application.Queries.Meeting.Interface;

public interface IMeetingGetAllQuery
{
    IEnumerable<MeetingGetAllQueryResultDto> GetAll();

}
