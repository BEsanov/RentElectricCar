using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentElectricCar.API.Migrations
{
    public partial class BrandNamesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarBrandName",
                table: "CarsForRent",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("0b38b8c2-4396-4e6f-aebe-3189f2392d76"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("0efbfce9-72cb-40a5-b9e6-8a8f5d6e68a9"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("181d0d91-debc-45ae-86df-796f4f6f2338"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("1ada923e-3301-4701-9114-60c01e8b9aaa"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("20a74c41-24f0-4ead-b8b2-b451f08c5395"),
                column: "CarBrandName",
                value: "Mercedes-Benz");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("2974486c-389e-4ae0-a214-aecc587aa260"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("343f6f78-2a8f-43d7-abc9-9e9b5770e9c4"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("3da18906-b85d-4460-bcef-42da4bffdb35"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("3df9d369-2055-4340-92d9-cf69a554474c"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("3f977feb-7832-4153-bc1a-c1f0ba6a9d62"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("42089e62-f387-4f49-a6a9-e77703d3da2e"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("42d021c4-5234-438d-a32f-c322614b0bd1"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("447601c1-ee69-44bd-850d-4d1507e773f0"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("4c2b1a41-8b3f-4e9c-a582-61a978a56559"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("58a34157-6a7d-4910-8f57-a22cbb89fa04"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("5d71036f-fe63-4dd1-bfa0-efbebd16d076"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("5edacdd9-5016-4b21-bcf2-d16723cd8a67"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("635f8aaa-7ff9-4c6c-85c6-bed990651756"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("65ceb99b-ebc8-45fa-a940-f22240db9a2d"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("6c578e04-8695-412e-b6c5-45441849e813"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("7045b787-a166-437a-b823-9dc98ab7c8f8"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("75ad0206-5023-4a07-8744-af0def953ea6"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("76c472d8-996a-477f-b1f3-e736ef5a0220"),
                column: "CarBrandName",
                value: "Mercedes-Benz");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("7972dbd1-c454-4d5d-b82a-0457212fde65"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("7b8d50c0-3c05-486b-95dc-ed2a86d45b32"),
                column: "CarBrandName",
                value: "Mercedes-Benz");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("7f8c99fc-a33a-4bc8-b6b9-628e19ba4d92"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("7fbd52e5-5552-4256-bd7c-e91561645360"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("80ec6757-b48d-40b0-9084-e97e5922e34f"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("8259c931-f342-4357-8075-022426ce6d0a"),
                column: "CarBrandName",
                value: "Mercedes-Benz");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("87ffb445-c2c7-4959-96e4-2f76b71e47ae"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("8c715de0-3acf-4411-bec5-d4b26646b75a"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("9228fe18-c4e5-41ff-856a-72e10a2bb660"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("9abd8ad5-1a74-471c-a7fc-38ac79211ac3"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("9f6a4609-27b3-446f-886c-2280677217b7"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("a75e94b7-94dc-4805-bfd0-a88edd2aee33"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("b54af349-0df6-4a3c-8cea-359ee837a93c"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("b70385e1-11dc-4fe5-ad0a-f40000d8cde8"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("bb30470f-499e-435c-a581-c56fbbf211c6"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("bc5f4c8d-15bc-41c6-b4b6-d70fcb6cfef8"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("bffeb255-364f-4aef-a064-65948310e41a"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("c8630eb7-b18a-49d1-b465-14d72cd6fc78"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("ca75441a-6c47-4bfd-9e4f-723b9e0628cb"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("cbeee778-bb1e-4cbc-9709-81924db54ba7"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("cd94eecf-ab12-43e9-929b-d91f25a01e7b"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("d9cbf395-9a6c-4e95-a823-7ecaf8c6f044"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("daa0dabb-9393-4fd4-9aef-7de5771e6713"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("db2bc9f2-dc58-4f17-b30c-4f8ba79b572e"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("e58fd46c-7fe6-42f4-b95b-65de84f19621"),
                column: "CarBrandName",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("e8078e7c-2cf4-4f51-9061-5208686e221c"),
                column: "CarBrandName",
                value: "Mercedes-Benz");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("e9dc0145-80a4-4d17-a076-c6cbe308ec1e"),
                column: "CarBrandName",
                value: "Mercedes-Benz");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("eeb58d0d-9660-43e1-a6b2-985ee824b237"),
                column: "CarBrandName",
                value: "Audi");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("f413bc87-dba6-4b6f-a1be-11db04ba486b"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("f7c8bbf7-92bc-437d-a27a-d60dd6c95f05"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("f8e70fe1-fa05-436c-86b6-0687b8fbdc9b"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("f9324aff-8e36-463c-99cb-f675e2b278de"),
                column: "CarBrandName",
                value: "Tesla");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("fc9e4cf3-5e29-499e-b295-16f763a8007d"),
                column: "CarBrandName",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "CarsForRent",
                keyColumn: "CarId",
                keyValue: new Guid("fcfdf941-6040-48d1-bc0d-d2c161a2fca7"),
                column: "CarBrandName",
                value: "Tesla");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarBrandName",
                table: "CarsForRent");
        }
    }
}
