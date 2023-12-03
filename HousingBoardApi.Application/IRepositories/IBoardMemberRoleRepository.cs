using HousingBoardApi.Application.Commands.BoardMemberRole.Create;
using HousingBoardApi.Application.Commands.BoardMemberRole.Delete;
using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.Commands.Meeting.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.IRepositories;

public interface IBoardMemberRoleRepository
{
    void Delete(DeleteBoardMemberRoleCommand request);
    void Add(CreateBoardMemberRoleCommand request);
}
