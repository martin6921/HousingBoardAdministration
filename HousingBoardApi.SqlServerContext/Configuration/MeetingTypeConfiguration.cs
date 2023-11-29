
using HousingBoardApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HousingBoardApi.SqlServerContext.Configuration;


public class MeetingTypeConfiguration : IEntityTypeConfiguration<MeetingEntity>
{
    public void Configure(EntityTypeBuilder<MeetingEntity> builder)
    {
        //ResourceEntity bliver mappet til tabellen Resource med skemeaet resource
        builder.ToTable("Meeting");

        builder.HasQueryFilter(x => x.IsDeleted == false);

        //erklære primærnøglen
        builder.HasKey(x => x.Id);
    }
}
