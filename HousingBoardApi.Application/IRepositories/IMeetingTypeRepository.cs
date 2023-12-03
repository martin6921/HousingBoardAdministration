using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Application.Queries.MeetingType.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.IRepositories;

public interface IMeetingTypeRepository
{
    IEnumerable<MeetingTypeGetAllQueryResultDto> GetAll();
    MeetingTypeGetQueryResultDto Get(Guid id);
}
