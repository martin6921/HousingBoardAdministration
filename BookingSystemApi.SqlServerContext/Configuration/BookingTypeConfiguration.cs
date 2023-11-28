using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BookingSystemApi.Domain.Entities;

namespace SqlServerContext.Configuration;

public class BookingTypeConfiguration : IEntityTypeConfiguration<BookingEntity>
{
    public void Configure(EntityTypeBuilder<BookingEntity> builder)
    {
        //ResourceEntity bliver mappet til tabellen Resource med skemeaet resource
        builder.ToTable("Booking");

        //erklære primærnøglen
        builder.HasKey(x => x.Id);
    }
}
