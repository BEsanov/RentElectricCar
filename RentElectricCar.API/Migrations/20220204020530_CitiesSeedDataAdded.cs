using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentElectricCar.API.Migrations
{
    public partial class CitiesSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "CityName", "RegionName" },
                values: new object[,]
                {
                    { new Guid("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"), "Lappeenranta", "South Karelia" },
                    { new Guid("6ac8b9de-17ca-4d42-90f4-fd3b5c64774c"), "Salo", "Southwest Finland" },
                    { new Guid("27a1a764-db3d-478f-bbc3-190bbf93a5e7"), "Turku", "Southwest Finland" },
                    { new Guid("fabac37b-9c3b-452d-8626-272be26bdecd"), "Lohja", "Uusimaa" },
                    { new Guid("8735b362-158f-48cc-ba5f-351a87add184"), "Porvoo", "Uusimaa" },
                    { new Guid("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"), "Vantaa", "Uusimaa" },
                    { new Guid("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"), "Espoo", "Uusimaa" },
                    { new Guid("8a603c82-7c0b-4de9-bdcd-db669cf48c06"), "Helsinki", "Uusimaa" },
                    { new Guid("65cb8f32-5444-4fd4-b816-8f57cde20e18"), "Kouvola", "Kymenlaakso" },
                    { new Guid("0179ab63-376f-47bc-a1e0-b7939aeeca26"), "Kotka", "Kymenlaakso" },
                    { new Guid("f0f3c209-1afb-4d77-a1e4-41b980bbc39c"), "Kangasala", "Pirkanmaa" },
                    { new Guid("886d8a9c-5f25-44c5-a8c8-b2921afad367"), "Nokia", "Pirkanmaa" },
                    { new Guid("8d5e3909-3785-4d7a-bde9-103aefd9f163"), "Ylöjärvi", "Pirkanmaa" },
                    { new Guid("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"), "Tampere", "Pirkanmaa" },
                    { new Guid("f90a1aaa-4360-4419-848e-47cf740cbc88"), "Laukaa", "Central Finland" },
                    { new Guid("ba22a556-afd4-4d71-a1a6-0997775308bc"), "Jämsä", "Central Finland" },
                    { new Guid("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"), "Jyväskylä", "Central Finland" },
                    { new Guid("777b5fbf-726b-46f7-83c0-fc2e1cea39ce"), "Imatra", "South Karelia" },
                    { new Guid("ae71ff9e-c117-4fa4-a431-4a3af7680a6b"), "Kaarina", "Southwest Finland" },
                    { new Guid("404a9219-6a83-43ef-9a2d-0f7891a6db50"), "Rovaniemi", "Lapland" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("0179ab63-376f-47bc-a1e0-b7939aeeca26"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("27a1a764-db3d-478f-bbc3-190bbf93a5e7"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("404a9219-6a83-43ef-9a2d-0f7891a6db50"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("65cb8f32-5444-4fd4-b816-8f57cde20e18"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("6ac8b9de-17ca-4d42-90f4-fd3b5c64774c"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("777b5fbf-726b-46f7-83c0-fc2e1cea39ce"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("8735b362-158f-48cc-ba5f-351a87add184"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("886d8a9c-5f25-44c5-a8c8-b2921afad367"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("8a603c82-7c0b-4de9-bdcd-db669cf48c06"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("8d5e3909-3785-4d7a-bde9-103aefd9f163"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("ae71ff9e-c117-4fa4-a431-4a3af7680a6b"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("ba22a556-afd4-4d71-a1a6-0997775308bc"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("f0f3c209-1afb-4d77-a1e4-41b980bbc39c"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("f90a1aaa-4360-4419-848e-47cf740cbc88"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("fabac37b-9c3b-452d-8626-272be26bdecd"));
        }
    }
}
