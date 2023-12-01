using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMember.Create
{
    public class CreateBoardMemberCommandHandler : IRequestHandler<CreateBoardMemberCommand>
    {
        private readonly IBoardMemberRepository _boardMemberRepository;

        public CreateBoardMemberCommandHandler(IBoardMemberRepository boardMemberRepository)
        {
            _boardMemberRepository = boardMemberRepository;
        }

        Task IRequestHandler<CreateBoardMemberCommand>.Handle(CreateBoardMemberCommand request, CancellationToken cancellationToken)
        {
            _boardMemberRepository.Create(request);
            return Task.CompletedTask;
        }
    }
}
