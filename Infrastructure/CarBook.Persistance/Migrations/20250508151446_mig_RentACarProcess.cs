using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_RentACarProcess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "RentACarProcess",
                columns: table => new
                {
                    RentACarProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentACarProcessCarId = table.Column<int>(type: "int", nullable: false),
                    RentACarProcessPickUpLocationId = table.Column<int>(type: "int", nullable: false),
                    RentACarProcessDropOffLocationId = table.Column<int>(type: "int", nullable: false),
                    RentACarProcessPickUpDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RentACarProcessDropOffDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RentACarProcessPickUpTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    RentACarProcessDropOffTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    RentACarProcessCustomerId = table.Column<int>(type: "int", nullable: false),
                    RentACarProcessPickUpDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentACarProcessDropOffDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentACarProcessTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACarProcess", x => x.RentACarProcessId);
                    table.ForeignKey(
                        name: "FK_RentACarProcess_Cars_RentACarProcessCarId",
                        column: x => x.RentACarProcessCarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACarProcess_Customer_RentACarProcessCustomerId",
                        column: x => x.RentACarProcessCustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcess_RentACarProcessCarId",
                table: "RentACarProcess",
                column: "RentACarProcessCarId");

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcess_RentACarProcessCustomerId",
                table: "RentACarProcess",
                column: "RentACarProcessCustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACarProcess");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
