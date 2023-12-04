using HousingBoardApi.Application.Commands.BoardMemberRole.Create;
using HousingBoardApi.Application.Commands.BoardMemberRole.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Infrastructure.Repositories
{
    public class BoardMemberRoleRepository : IBoardMemberRoleRepository
    {
        private readonly HousingBoardDbContext _context;

        public BoardMemberRoleRepository(HousingBoardDbContext context)
        {
            _context = context;
        }

        void IBoardMemberRoleRepository.Add(CreateBoardMemberRoleCommand request)
        {
            var model = new BoardMemberRoleEntity 
            {
                  RoleId = request.RoleId,
                  BoardMemberId = request.BoardMemberId,
                  StartDate = DateTime.Now,
                  EndDate = null
            };

            _context.BoardMemberRoleEntities.Add(model);

        }

        void IBoardMemberRoleRepository.Delete(DeleteBoardMemberRoleCommand request)
        {
            _context.Remove(_context.BoardMemberRoleEntities.AsNoTracking().FirstOrDefault(x => (x.BoardMemberId == request.BoardMemberId) && x.RoleId == request.RoleId));
            _context.SaveChanges();
        }
    }
}
