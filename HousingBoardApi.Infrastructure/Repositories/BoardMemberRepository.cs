using HousingBoardApi.Application.Commands.BoardMember.Create;
using HousingBoardApi.Application.Commands.BoardMember.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Infrastructure.Repositories
{
    public class BoardMemberRepository : IBoardMemberRepository
    {
        private readonly HousingBoardDbContext _context;

        public BoardMemberRepository(HousingBoardDbContext context)
        {
            this._context = context;
        }

        void IBoardMemberRepository.Create(CreateBoardMemberCommand request)
        {
            var role = _context.RoleEntities.FirstOrDefault(x => x.Id == request.RoleTypeId);
            var model = new BoardMemberEntity
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                ResidentAddress = request.ResidentAddress,
                IsDeleted = false,
                Role = role
            };

            _context.SaveChanges();
        }

        void IBoardMemberRepository.Delete(DeleteBoardMemberCommand request)
        {
            _context.Remove(_context.BoardMemberEntities.AsNoTracking().FirstOrDefault(x => x.Id == request.Id));
            _context.SaveChanges();
        }

        BoardMemberEntity IBoardMemberRepository.Load(Guid id)
        {
            var model = _context.BoardMemberEntities.FirstOrDefault(x => x.Id == id);

            return model == null ? throw new Exception("intet Bestyrelsesmedlem fundet i databasen") : model;
        }

        void IBoardMemberRepository.Update(BoardMemberEntity request)
        {
            _context.Update(request);
            _context.SaveChanges();
        }
    }
}
