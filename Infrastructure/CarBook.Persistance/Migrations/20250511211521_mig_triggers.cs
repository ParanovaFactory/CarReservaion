using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_triggers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE TRIGGER trg_InsertCar_AddDefaultFeatures
        ON Cars
        AFTER INSERT
        AS
        BEGIN
            INSERT INTO CarFeatures (CarFeatureCarId, CarFeatureFeatureId, CarFeatureAvaileble)
            SELECT i.CarId, f.FeatureId, 0
            FROM inserted i
            CROSS JOIN Features f
        END
    ");

            migrationBuilder.Sql(@"
        CREATE TRIGGER trg_InsertFeature_AddToAllCars
        ON Features
        AFTER INSERT
        AS
        BEGIN
            INSERT INTO CarFeatures (CarFeatureCarId, CarFeatureFeatureId, CarFeatureAvaileble)
            SELECT c.CarId, i.FeatureId, 0
            FROM inserted i
            CROSS JOIN Cars c
        END
    ");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
