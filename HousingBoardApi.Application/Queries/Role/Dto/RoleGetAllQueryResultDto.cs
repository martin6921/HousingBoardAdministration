using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Role.Dto
{
    public class RoleGetAllQueryResultDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
    }
}
