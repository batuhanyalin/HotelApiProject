using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApiProject.DataAccessLayer.Migrations
{
    public partial class mig26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationStatusId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationStatuses_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId",
                principalTable: "ReservationStatuses",
                principalColumn: "ReservationStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationStatuses_ReservationStatusId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationStatusId",
                table: "Reservations");
        }
    }
}
