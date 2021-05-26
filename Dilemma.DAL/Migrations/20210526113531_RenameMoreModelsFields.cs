using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Dilemma.DAL.Migrations
{
    public partial class RenameMoreModelsFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Statistics");

            migrationBuilder.RenameColumn(
                name: "DateStart",
                table: "Statistics",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Statistics",
                newName: "DateStart");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateEnd",
                table: "Statistics",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
