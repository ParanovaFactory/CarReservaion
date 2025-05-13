using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_booking4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Bookings",
                newName: "BookingCarId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingCarId",
                table: "Bookings",
                column: "BookingCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Cars_BookingCarId",
                table: "Bookings",
                column: "BookingCarId",
                principalTable: "Cars",
                principalColumn: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Cars_BookingCarId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_BookingCarId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "BookingCarId",
                table: "Bookings",
                newName: "CarId");
        }
    }
}
