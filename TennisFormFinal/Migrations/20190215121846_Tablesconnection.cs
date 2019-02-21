using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisFormFinal.Migrations
{
    public partial class Tablesconnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourtType",
                table: "TReservations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourtType",
                table: "TReservations");
        }
    }
}
