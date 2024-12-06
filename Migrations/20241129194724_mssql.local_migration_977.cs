using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectGroup6.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_977 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrivelageLevel",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "PrivelageLevel",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
