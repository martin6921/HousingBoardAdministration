using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.BoardMember;

public record BoardMemberRoleDto
{
    public RoleDto Role { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

}
