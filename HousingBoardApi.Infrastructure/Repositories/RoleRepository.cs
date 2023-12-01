using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Application.Queries.Role.Dto;
using HousingBoardApi.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly HousingBoardDbContext _context;

        public RoleRepository(HousingBoardDbContext context)
        {
            this._context = context;
        }


        RoleGetQueryResultDto IRoleRepository.Get(Guid id)
        {
            var model = _context.RoleEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (model == null) throw new Exception("No Boardmember Role Found");
            return new RoleGetQueryResultDto
            {
                Id = model.Id,
                RowVersion = model.RowVersion,
                IsDeleted = model.IsDeleted,
                RoleName = model.RoleName,
            };
        }

        IEnumerable<RoleGetAllQueryResultDto> IRoleRepository.GetAll()
        {
            foreach (var model in _context.RoleEntities.AsNoTracking().ToList())
            {
                yield return new RoleGetAllQueryResultDto { Id = model.Id, RoleName = model.RoleName, RowVersion = model.RowVersion };
            }
        }
    }
}

