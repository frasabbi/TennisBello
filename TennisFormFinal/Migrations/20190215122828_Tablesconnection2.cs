using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisFormFinal.Migrations
{
    public partial class Tablesconnection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourtType",
                table: "TReservations");

            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "TReservations");

            migrationBuilder.AddColumn<int>(
                name: "CourtId",
                table: "TReservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TReservations_CourtId",
                table: "TReservations",
                column: "CourtId");

            migrationBuilder.AddForeignKey(
                name: "FK_TReservations_TCourts_CourtId",
                table: "TReservations",
                column: "CourtId",
                principalTable: "TCourts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TReservations_TCourts_CourtId",
                table: "TReservations");

            migrationBuilder.DropIndex(
                name: "IX_TReservations_CourtId",
                table: "TReservations");

            migrationBuilder.DropColumn(
                name: "CourtId",
                table: "TReservations");

            migrationBuilder.AddColumn<string>(
                name: "CourtType",
                table: "TReservations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "TReservations",
                nullable: true);
        }
    }
}
