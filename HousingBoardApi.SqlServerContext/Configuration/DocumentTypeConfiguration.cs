using HousingBoardApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace HousingBoardApi.SqlServerContext.Configuration;

public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentEntity>
{
    public void Configure(EntityTypeBuilder<DocumentEntity> builder)
    {
        //ResourceEntity bliver mappet til tabellen Resource med skemeaet resource
        builder.ToTable("Document");

        builder.HasOne(d => d.DocumentOwner)
        .WithMany(m => m.Documents)
        .OnDelete(DeleteBehavior.Restrict);

        //erklære primærnøglen
        builder.HasKey(x => x.Id);
    }
}
