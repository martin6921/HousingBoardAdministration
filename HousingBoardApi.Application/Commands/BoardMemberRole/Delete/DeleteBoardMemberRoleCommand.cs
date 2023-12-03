using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMemberRole.Delete;

public record DeleteBoardMemberRoleCommand : IRequest
{
    public Guid BoardMemberId { get; set; }
    public Guid RoleId { get; set; }

}
