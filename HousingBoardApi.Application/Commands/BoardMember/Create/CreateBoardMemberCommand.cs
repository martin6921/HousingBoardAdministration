using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMember.Create
{
    public class CreateBoardMemberCommand : IRequest
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResidentAddress { get; set; }
        public Guid RoleId { get; set; }

        //public Guid RoleTypeId { get; set; }
    }
}
