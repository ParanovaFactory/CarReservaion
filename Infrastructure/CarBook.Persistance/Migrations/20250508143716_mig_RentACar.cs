using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_RentACar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LodationName",
                table: "Locations",
                newName: "LocationName");

            migrationBuilder.RenameColumn(
                name: "LodationId",
                table: "Locations",
                newName: "LocationId");

            migrationBuilder.CreateTable(
                name: "RentACars",
                columns: table => new
                {
                    RentACarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickUpLocationId = table.Column<int>(type: "int", nullable: false),
                    RentACarCarId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACars", x => x.RentACarId);
                    table.ForeignKey(
                        name: "FK_RentACars_Cars_RentACarCarId",
                        column: x => x.RentACarCarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACars_Locations_PickUpLocationId",
                        column: x => x.PickUpLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_PickUpLocationId",
                table: "RentACars",
                column: "PickUpLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_RentACarCarId",
                table: "RentACars",
                column: "RentACarCarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACars");

            migrationBuilder.RenameColumn(
                name: "LocationName",
                table: "Locations",
                newName: "LodationName");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Locations",
                newName: "LodationId");
        }
    }
}
