using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystemApi.SqlServerContextMigrations.Migrations
{
    /// <inheritdoc />
    public partial class BookingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Resident");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
