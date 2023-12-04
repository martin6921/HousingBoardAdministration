using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Queries.Role.Dto;
using HousingBoardApi.Application.Queries.Role.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Role.Implementation
{
    public class RoleGetAllQuery : IRoleGetAllQuery
    {
        private readonly IRoleRepository _roleRepository;

        public RoleGetAllQuery(IRoleRepository roleRepository)
        {
            this._roleRepository = roleRepository;
        }

        IEnumerable<RoleGetAllQueryResultDto> IRoleGetAllQuery.GetAll()
        {
            return _roleRepository.GetAll();
        }
    }
}
