using HousingBoardApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.SqlServerContext.Configuration
{

    public class BoardMemberRoleTypeConfiguration : IEntityTypeConfiguration<BoardMemberRoleEntity>
    {
        public void Configure(EntityTypeBuilder<BoardMemberRoleEntity> builder)
        {
            //ResourceEntity bliver mappet til tabellen Resource med skemeaet resource
            builder.ToTable("BoardMemberRole");


            //erklære primærnøglen
            builder.HasKey(x => new { x.BoardMemberId, x.RoleId });
        }
    }
}
