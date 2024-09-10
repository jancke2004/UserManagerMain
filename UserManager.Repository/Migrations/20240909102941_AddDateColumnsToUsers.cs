using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManager.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddDateColumnsToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
           name: "Date_Created",
           table: "Users",
           type: "datetime2",
           nullable: false,
           defaultValue: DateTime.Now);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Updated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
             name: "Date_Created",
             table: "Users");

            migrationBuilder.DropColumn(
                name: "Date_Updated",
                table: "Users");
        }
    }
}
