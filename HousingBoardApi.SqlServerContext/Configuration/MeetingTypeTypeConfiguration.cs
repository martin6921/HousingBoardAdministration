

using HousingBoardApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HousingBoardApi.SqlServerContext.Configuration;

public class MeetingTypeTypeConfiguration : IEntityTypeConfiguration<MeetingTypeEntity>
{
    public void Configure(EntityTypeBuilder<MeetingTypeEntity> builder)
    {
        //ResourceEntity bliver mappet til tabellen Resource med skemeaet resource
        builder.ToTable("MeetingType");

        //erklære primærnøglen
        builder.HasKey(x => x.Id);
    }
}
