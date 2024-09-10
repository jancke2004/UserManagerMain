using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManager.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ModifyAddedByAndUpdatedByColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                   name: "Added_By",
                   table: "Users",
                   type: "nvarchar(max)",
                   nullable: false, 
                   defaultValue: "System", 
                   oldClrType: typeof(string),
                   oldType: "nvarchar(max)",
                   oldNullable: true);

           
            migrationBuilder.AlterColumn<string>(
                name: "Updated_By",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false, 
                defaultValue: "System", 
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Added_By",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true, // Revert to nullable
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: false,
                oldDefaultValue: "System");

            migrationBuilder.AlterColumn<string>(
                name: "Updated_By",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true, // Revert to nullable
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: false,
                oldDefaultValue: "System");
        }
    }
}
