using HousingBoardApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HousingBoardApi.SqlServerContext.Configuration;

public class DocumentTypeTypeConfiguration : IEntityTypeConfiguration<DocumentTypeEntity>
{
    public void Configure(EntityTypeBuilder<DocumentTypeEntity> builder)
    {
        //ResourceEntity bliver mappet til tabellen Resource med skemeaet resource
        builder.ToTable("DocumentType");

        //erklære primærnøglen
        builder.HasKey(x => x.Id);
    }
}
