using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_RentACarProcess2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Cars_RentACarProcessCarId",
                table: "RentACarProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Customer_RentACarProcessCustomerId",
                table: "RentACarProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "RentACarProcess",
                newName: "RentACarProcesses");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_RentACarProcessCustomerId",
                table: "RentACarProcesses",
                newName: "IX_RentACarProcesses_RentACarProcessCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_RentACarProcessCarId",
                table: "RentACarProcesses",
                newName: "IX_RentACarProcesses_RentACarProcessCarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcesses",
                table: "RentACarProcesses",
                column: "RentACarProcessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Cars_RentACarProcessCarId",
                table: "RentACarProcesses",
                column: "RentACarProcessCarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Customers_RentACarProcessCustomerId",
                table: "RentACarProcesses",
                column: "RentACarProcessCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Cars_RentACarProcessCarId",
                table: "RentACarProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Customers_RentACarProcessCustomerId",
                table: "RentACarProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcesses",
                table: "RentACarProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "RentACarProcesses",
                newName: "RentACarProcess");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcesses_RentACarProcessCustomerId",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_RentACarProcessCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcesses_RentACarProcessCarId",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_RentACarProcessCarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess",
                column: "RentACarProcessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Cars_RentACarProcessCarId",
                table: "RentACarProcess",
                column: "RentACarProcessCarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Customer_RentACarProcessCustomerId",
                table: "RentACarProcess",
                column: "RentACarProcessCustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
