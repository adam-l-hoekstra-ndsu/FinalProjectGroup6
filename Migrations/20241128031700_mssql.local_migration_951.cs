using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectGroup6.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_951 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsNeuteredSprayed",
                table: "Dog",
                newName: "IsNeuteredSpayed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsNeuteredSpayed",
                table: "Dog",
                newName: "IsNeuteredSprayed");
        }
    }
}
