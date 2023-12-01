using HousingBoardApi.Application.Queries.Role.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Role.Interface
{
    public interface IRoleGetAllQuery
    {
        IEnumerable<RoleGetAllQueryResultDto> GetAll();
    }
}
