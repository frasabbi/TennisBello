using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisFormFinal.Migrations
{
    public partial class priceadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "TCourts",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "TCourts");
        }
    }
}
