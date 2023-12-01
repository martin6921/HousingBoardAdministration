using HousingBoardApi.Application.Commands.BoardMember.Create;
using HousingBoardApi.Application.Commands.BoardMember.Delete;
using HousingBoardApi.Application.Commands.Meeting.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.IRepositories
{
    public interface IBoardMemberRepository
    {
        void Delete(DeleteBoardMemberCommand request);
        void Create(CreateBoardMemberCommand request);

        BoardMemberEntity Load(Guid id);

        void Update(BoardMemberEntity request);
        
    }
}
