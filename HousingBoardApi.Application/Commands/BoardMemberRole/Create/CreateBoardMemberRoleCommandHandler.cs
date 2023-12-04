using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMemberRole.Create;

public class CreateBoardMemberRoleCommandHandler : IRequestHandler<CreateBoardMemberRoleCommand>
{
    private readonly IBoardMemberRoleRepository _boardMemberRoleRepository;

    public CreateBoardMemberRoleCommandHandler(IBoardMemberRoleRepository boardMemberRoleRepository)
    {
        _boardMemberRoleRepository = boardMemberRoleRepository;
    }

    Task IRequestHandler<CreateBoardMemberRoleCommand>.Handle(CreateBoardMemberRoleCommand request, CancellationToken cancellationToken)
    {
        _boardMemberRoleRepository.Add(request);
        return Task.CompletedTask;
    }
}
