using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingBoardApi.SqlServerContextMigrations.Migrations
{
    /// <inheritdoc />
    public partial class EditedBoardMemberEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "BoardMember");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "BoardMember",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
