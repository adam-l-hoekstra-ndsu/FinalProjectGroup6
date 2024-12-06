using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectGroup6.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_717 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "AnimalShelter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AnimalShelter",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "AnimalShelter");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AnimalShelter");
        }
    }
}
