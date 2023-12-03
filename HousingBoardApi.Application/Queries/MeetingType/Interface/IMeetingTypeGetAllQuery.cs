
using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Application.Queries.MeetingType.Dto;

namespace HousingBoardApi.Application.Queries.MeetingType.Interface;

public interface IMeetingTypeGetAllQuery
{
    IEnumerable<MeetingTypeGetAllQueryResultDto> GetAll();

}
