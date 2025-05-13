using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_review3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarReviews_Cars_CarReviewCarid",
                table: "CarReviews");

            migrationBuilder.RenameColumn(
                name: "CarReviewCarid",
                table: "CarReviews",
                newName: "CarReviewCarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarReviews_CarReviewCarid",
                table: "CarReviews",
                newName: "IX_CarReviews_CarReviewCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarReviews_Cars_CarReviewCarId",
                table: "CarReviews",
                column: "CarReviewCarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarReviews_Cars_CarReviewCarId",
                table: "CarReviews");

            migrationBuilder.RenameColumn(
                name: "CarReviewCarId",
                table: "CarReviews",
                newName: "CarReviewCarid");

            migrationBuilder.RenameIndex(
                name: "IX_CarReviews_CarReviewCarId",
                table: "CarReviews",
                newName: "IX_CarReviews_CarReviewCarid");

            migrationBuilder.AddForeignKey(
                name: "FK_CarReviews_Cars_CarReviewCarid",
                table: "CarReviews",
                column: "CarReviewCarid",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
