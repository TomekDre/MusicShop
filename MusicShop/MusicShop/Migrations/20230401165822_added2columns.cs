using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShop.Migrations
{
    public partial class added2columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Music",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Music",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Music");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Music");
        }
    }
}
