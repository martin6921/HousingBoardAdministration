using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMember.Edit
{
    public class EditBoardMemberCommandHandler : IRequestHandler<EditBoardMemberCommand>
    {
        private readonly IBoardMemberRepository _boardMemberRepository;


        public EditBoardMemberCommandHandler(IBoardMemberRepository boardMemberRepository)
        {
            _boardMemberRepository = boardMemberRepository;
        }

        Task IRequestHandler<EditBoardMemberCommand>.Handle(EditBoardMemberCommand request, CancellationToken cancellationToken)
        {

            //read
            var model = _boardMemberRepository.Load(request.Id);
           
            //doit 
            model.Edit(request.UserName, request.FirstName, request.LastName, request.ResidentAddress, request.RowVersion);
            //save
            _boardMemberRepository.Update(model);
        }
    }
}
