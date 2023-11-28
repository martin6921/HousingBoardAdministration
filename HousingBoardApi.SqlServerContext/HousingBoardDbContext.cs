using HousingBoardApi.Domain.Entities;
using HousingBoardApi.SqlServerContext.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.SqlServerContext;

public class HousingBoardDbContext : DbContext
{
    public HousingBoardDbContext(DbContextOptions<HousingBoardDbContext> options) : base(options)
    {
    }

    public DbSet<BoardMemberEntity> BoardMemberEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BoardMemberTypeConfiguration());

    }
}
