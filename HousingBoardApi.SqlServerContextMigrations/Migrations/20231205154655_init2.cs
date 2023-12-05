using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingBoardApi.SqlServerContextMigrations.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BoardMemberRole_BoardMemberId",
                table: "BoardMemberRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BoardMemberRole_BoardMemberId",
                table: "BoardMemberRole",
                column: "BoardMemberId",
                unique: true);
        }
    }
}
