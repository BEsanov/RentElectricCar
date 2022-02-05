using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentElectricCar.API.Migrations
{
    public partial class SingleCarAddedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarsForRent_Location_LocationId",
                table: "CarsForRent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarsForRent",
                table: "CarsForRent");

            migrationBuilder.RenameTable(
                name: "CarsForRent",
                newName: "Car");

            migrationBuilder.RenameIndex(
                name: "IX_CarsForRent_LocationId",
                table: "Car",
                newName: "IX_Car_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "CarId");

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "ColorName", "LocationId", "MileAge", "NumberOfDoors", "NumberOfSeats", "ProductionDate", "Transmission" },
                values: new object[] { new Guid("b70385e1-11dc-4fe5-ad0a-f40000d8cde8"), "Red", new Guid("404a9219-6a83-43ef-9a2d-0f7891a6db50"), 50000, 5, 5, new DateTimeOffset(new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Automatic" });

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "CarId",
                keyValue: new Guid("b70385e1-11dc-4fe5-ad0a-f40000d8cde8"));

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "CarsForRent");

            migrationBuilder.RenameIndex(
                name: "IX_Car_LocationId",
                table: "CarsForRent",
                newName: "IX_CarsForRent_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarsForRent",
                table: "CarsForRent",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarsForRent_Location_LocationId",
                table: "CarsForRent",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
