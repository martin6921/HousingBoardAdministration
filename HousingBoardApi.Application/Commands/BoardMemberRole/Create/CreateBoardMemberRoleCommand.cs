using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMemberRole.Create
{
    public class CreateBoardMemberRoleCommand : IRequest
    {
        public string RoleName { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        public bool IsDeleted { get; set; }
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } 
        public Guid BoardMemberId { get; set; }
    }
}
