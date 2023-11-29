using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingBoardApi.SqlServerContextMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddedSoftDeletion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Role",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "MeetingType",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Meeting",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "DocumentType",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Document",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "BoardMember",
                type: "datetimeoffset",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "MeetingType");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DocumentType");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BoardMember");
        }
    }
}
