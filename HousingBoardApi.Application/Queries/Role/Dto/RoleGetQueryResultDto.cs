﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Role.Dto
{
    public class RoleGetQueryResultDto
    {
        public Guid Id { get; set; }

        //[Timestamp]
        //public byte[] RowVersion { get; set; }
        //public bool IsDeleted { get; set; }
        public string RoleName { get; set; }
    }
}
