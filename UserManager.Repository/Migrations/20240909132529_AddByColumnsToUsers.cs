using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManager.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddByColumnsToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
           name: "Added_By",
           table: "Users",
           type: "nvarchar(max)",
           nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
            name: "Added_By",
            table: "Users");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Users");
        }
    }
}
