using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarReviews",
                columns: table => new
                {
                    CarReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarReviewName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarReviewRating = table.Column<int>(type: "int", nullable: false),
                    CarReviewCarid = table.Column<int>(type: "int", nullable: false),
                    CarBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarReviews", x => x.CarReviewId);
                    table.ForeignKey(
                        name: "FK_CarReviews_Cars_CarReviewCarid",
                        column: x => x.CarReviewCarid,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarReviews_CarReviewCarid",
                table: "CarReviews",
                column: "CarReviewCarid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarReviews");
        }
    }
}
