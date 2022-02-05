using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentElectricCar.API.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "CarsForRent",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarsForRent_LocationId",
                table: "CarsForRent",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarsForRent_Location_LocationId",
                table: "CarsForRent",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarsForRent_Location_LocationId",
                table: "CarsForRent");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_CarsForRent_LocationId",
                table: "CarsForRent");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "CarsForRent");
        }
    }
}
