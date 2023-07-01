using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaresGacha.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Dares",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Skipped",
                table: "Dares",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Dares");

            migrationBuilder.DropColumn(
                name: "Skipped",
                table: "Dares");
        }
    }
}
