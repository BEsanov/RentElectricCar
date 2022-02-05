using Microsoft.EntityFrameworkCore.Migrations;

namespace RentElectricCar.API.Migrations
{
    public partial class _2nSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "CarsForRent");

            migrationBuilder.RenameIndex(
                name: "IX_Car_LocationId",
                table: "CarsForRent",
                newName: "IX_CarsForRent_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarsForRent",
                table: "CarsForRent",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarsForRent_Locations_LocationId",
                table: "CarsForRent",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarsForRent_Locations_LocationId",
                table: "CarsForRent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarsForRent",
                table: "CarsForRent");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "CarsForRent",
                newName: "Car");

            migrationBuilder.RenameIndex(
                name: "IX_CarsForRent_LocationId",
                table: "Car",
                newName: "IX_Car_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
