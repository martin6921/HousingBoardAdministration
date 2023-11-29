using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.Commands.Meeting.Delete;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Domain.Entities;


namespace HousingBoardApi.Application.IRepositories;

public interface IMeetingRepository
{
    //void Add(ResourceCreateRequestDto resource);
    MeetingEntity Load(Guid id);
    IEnumerable<MeetingGetAllQueryResultDto> GetAll();
    void Update(MeetingEntity model);

    MeetingGetQueryResultDto Get(Guid id);
    void Delete(DeleteMeetingCommand request);
    void Add(CreateMeetingCommand request);
}
