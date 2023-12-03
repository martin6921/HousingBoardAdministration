using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMemberRole.Create
{
    public record CreateBoardMemberRoleCommand : IRequest
    {
        public Guid RoleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } 
        public Guid BoardMemberId { get; set; }
    }
}
