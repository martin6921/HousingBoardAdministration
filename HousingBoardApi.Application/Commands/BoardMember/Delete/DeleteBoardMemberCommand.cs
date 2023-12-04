using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.BoardMember.Delete
{
    public class DeleteBoardMemberCommand : IRequest
    {
        public Guid Id { get; set; }

    }
}
