using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisFormFinal.Migrations
{
    public partial class tablerename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "TReservations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TReservations",
                table: "TReservations",
                column: "ReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TReservations",
                table: "TReservations");

            migrationBuilder.RenameTable(
                name: "TReservations",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "ReservationId");
        }
    }
}
