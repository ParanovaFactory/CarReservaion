using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_booking3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Locations_DropOffLocationId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Locations_PickUpLocationId",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_PickUpLocationId",
                table: "Bookings",
                newName: "IX_Bookings_PickUpLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_DropOffLocationId",
                table: "Bookings",
                newName: "IX_Bookings_DropOffLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Locations_DropOffLocationId",
                table: "Bookings",
                column: "DropOffLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Locations_PickUpLocationId",
                table: "Bookings",
                column: "PickUpLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Locations_DropOffLocationId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Locations_PickUpLocationId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_PickUpLocationId",
                table: "Booking",
                newName: "IX_Booking_PickUpLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_DropOffLocationId",
                table: "Booking",
                newName: "IX_Booking_DropOffLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Locations_DropOffLocationId",
                table: "Booking",
                column: "DropOffLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Locations_PickUpLocationId",
                table: "Booking",
                column: "PickUpLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }
    }
}
