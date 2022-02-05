using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentElectricCar.API.Migrations
{
    public partial class SecondCarAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "ColorName", "LocationId", "MileAge", "NumberOfDoors", "NumberOfSeats", "ProductionDate", "Transmission" },
                values: new object[] { new Guid("3da18906-b85d-4460-bcef-42da4bffdb35"), "White", new Guid("404a9219-6a83-43ef-9a2d-0f7891a6db50"), 86000, 3, 2, new DateTimeOffset(new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Manual" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "CarId",
                keyValue: new Guid("3da18906-b85d-4460-bcef-42da4bffdb35"));
        }
    }
}
