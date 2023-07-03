using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaresGacha.Migrations
{
    /// <inheritdoc />
    public partial class DarePlus18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Plus18",
                table: "Dares",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plus18",
                table: "Dares");
        }
    }
}
