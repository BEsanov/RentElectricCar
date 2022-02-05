using Microsoft.EntityFrameworkCore;
using RentElectricCar.API.Entities;
using System;

namespace RentElectricCar.API.Contexts
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<Car> CarsForRent { get; set; }
        public DbSet<Location> Locations { get; set; }

        public RentACarDbContext(DbContextOptions<RentACarDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    LocationId = Guid.Parse("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"),
                    CityName = "Lappeenranta",
                    RegionName = "South Karelia"

                },
                new Location
                {
                    LocationId = Guid.Parse("777b5fbf-726b-46f7-83c0-fc2e1cea39ce"),
                    CityName = "Imatra",
                    RegionName = "South Karelia"
                },
                new Location
                {
                    LocationId = Guid.Parse("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"),
                    CityName = "Jyväskylä",
                    RegionName = "Central Finland"
                },
               new Location
               {
                   LocationId = Guid.Parse("ba22a556-afd4-4d71-a1a6-0997775308bc"),
                   CityName = "Jämsä",
                   RegionName = "Central Finland"
               },
              new Location
              {
                  LocationId = Guid.Parse("f90a1aaa-4360-4419-848e-47cf740cbc88"),
                  CityName = "Laukaa",
                  RegionName = "Central Finland"
              },
              new Location
              {
                  LocationId = Guid.Parse("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"),
                  CityName = "Tampere",
                  RegionName = "Pirkanmaa"
              },
              new Location
              {
                  LocationId = Guid.Parse("8d5e3909-3785-4d7a-bde9-103aefd9f163"),
                  CityName = "Ylöjärvi",
                  RegionName = "Pirkanmaa"
              },
              new Location
              {
                  LocationId = Guid.Parse("886d8a9c-5f25-44c5-a8c8-b2921afad367"),
                  CityName = "Nokia",
                  RegionName = "Pirkanmaa"
              },
               new Location
               {
                   LocationId = Guid.Parse("f0f3c209-1afb-4d77-a1e4-41b980bbc39c"),
                   CityName = "Kangasala",
                   RegionName = "Pirkanmaa"
               },
               new Location
               {
                   LocationId = Guid.Parse("0179ab63-376f-47bc-a1e0-b7939aeeca26"),
                   CityName = "Kotka",
                   RegionName = "Kymenlaakso"
               },
               new Location
               {
                   LocationId = Guid.Parse("65cb8f32-5444-4fd4-b816-8f57cde20e18"),
                   CityName = "Kouvola",
                   RegionName = "Kymenlaakso"
               },
               new Location
               {
                   LocationId = Guid.Parse("8a603c82-7c0b-4de9-bdcd-db669cf48c06"),
                   CityName = "Helsinki",
                   RegionName = "Uusimaa"
               },
               new Location
               {
                   LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                   CityName = "Espoo",
                   RegionName = "Uusimaa"
               },
               new Location
               {
                   LocationId = Guid.Parse("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"),
                   CityName = "Vantaa",
                   RegionName = "Uusimaa"
               },
               new Location
               {
                   LocationId = Guid.Parse("8735b362-158f-48cc-ba5f-351a87add184"),
                   CityName = "Porvoo",
                   RegionName = "Uusimaa"
               },
               new Location
               {
                   LocationId = Guid.Parse("fabac37b-9c3b-452d-8626-272be26bdecd"),
                   CityName = "Lohja",
                   RegionName = "Uusimaa"
               },
               new Location
               {
                   LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                   CityName = "Turku",
                   RegionName = "Southwest Finland"
               },
               new Location
               {
                   LocationId = Guid.Parse("6ac8b9de-17ca-4d42-90f4-fd3b5c64774c"),
                   CityName = "Salo",
                   RegionName = "Southwest Finland"
               },
               new Location
               {
                   LocationId = Guid.Parse("ae71ff9e-c117-4fa4-a431-4a3af7680a6b"),
                   CityName = "Kaarina",
                   RegionName = "Southwest Finland"
               },
               new Location
               {
                   LocationId = Guid.Parse("404a9219-6a83-43ef-9a2d-0f7891a6db50"),
                   CityName = "Rovaniemi",
                   RegionName = "Lapland"
               });

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    CarBrandName = "Tesla",
                    LocationId = Guid.Parse("404a9219-6a83-43ef-9a2d-0f7891a6db50"),
                    CarId = Guid.Parse("b70385e1-11dc-4fe5-ad0a-f40000d8cde8"),
                    ColorName = "Pearl White",
                    MileAge = 50_000,
                    NumberOfDoors = 5,
                    NumberOfSeats = 5,
                    ProductionDate = new DateTime(2020, 12, 20), //1690, 11, 23
                    
                },
              new Car
              {
                  CarBrandName = "Hyundai",
                  LocationId = Guid.Parse("404a9219-6a83-43ef-9a2d-0f7891a6db50"),
                  CarId = Guid.Parse("3da18906-b85d-4460-bcef-42da4bffdb35"),
                  ColorName = "Solid Black",
                  MileAge = 86_000,
                  NumberOfDoors = 3,
                  NumberOfSeats = 2,
                  ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                  
              }, //fdsfdsfdsfdsf
               new Car
               {
                   CarBrandName = "Mercedes-Benz",
                   LocationId = Guid.Parse("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"),
                   CarId = Guid.Parse("e8078e7c-2cf4-4f51-9061-5208686e221c"),
                   ColorName = "Midnight Silver metallic",
                   MileAge = 86_000,
                   NumberOfDoors = 3,
                   NumberOfSeats = 2,
                   ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                   
               },
                new Car
                {
                    CarBrandName = "BMW",
                    LocationId = Guid.Parse("777b5fbf-726b-46f7-83c0-fc2e1cea39ce"),
                    CarId = Guid.Parse("343f6f78-2a8f-43d7-abc9-9e9b5770e9c4"),
                    ColorName = "Pearl White",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                 new Car
                 {
                     CarBrandName = "Hyundai",
                     LocationId = Guid.Parse("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"),
                     CarId = Guid.Parse("fc9e4cf3-5e29-499e-b295-16f763a8007d"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                  new Car
                  {
                      CarBrandName = "Tesla",
                      LocationId = Guid.Parse("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"),
                      CarId = Guid.Parse("5edacdd9-5016-4b21-bcf2-d16723cd8a67"),
                      ColorName = "Midnight Silver metallic",
                      MileAge = 86_000,
                      NumberOfDoors = 3,
                      NumberOfSeats = 2,
                      ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                      
                  },
                 new Car
                 {
                     CarBrandName = "Hyundai",
                     LocationId = Guid.Parse("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"),
                     CarId = Guid.Parse("3df9d369-2055-4340-92d9-cf69a554474c"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                  new Car
                  {
                      CarBrandName = "BMW",
                      LocationId = Guid.Parse("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"),
                      CarId = Guid.Parse("4c2b1a41-8b3f-4e9c-a582-61a978a56559"),
                      ColorName = "Pearl White",
                      MileAge = 86_000,
                      NumberOfDoors = 3,
                      NumberOfSeats = 2,
                      ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                      
                  },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("737fe335-bbcc-42b3-b43a-1ac4ca446ef1"),
                     CarId = Guid.Parse("a75e94b7-94dc-4805-bfd0-a88edd2aee33"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Audi",
                     LocationId = Guid.Parse("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"),
                     CarId = Guid.Parse("9f6a4609-27b3-446f-886c-2280677217b7"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("07f456ff-0e3e-4d4c-a82c-a5ffb58d2835"),
                     CarId = Guid.Parse("d9cbf395-9a6c-4e95-a823-7ecaf8c6f044"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Audi",
                     LocationId = Guid.Parse("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"),
                     CarId = Guid.Parse("3f977feb-7832-4153-bc1a-c1f0ba6a9d62"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"),
                     CarId = Guid.Parse("0efbfce9-72cb-40a5-b9e6-8a8f5d6e68a9"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Hyundai",
                     LocationId = Guid.Parse("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"),
                     CarId = Guid.Parse("65ceb99b-ebc8-45fa-a940-f22240db9a2d"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"),
                     CarId = Guid.Parse("42d021c4-5234-438d-a32f-c322614b0bd1"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("ba22a556-afd4-4d71-a1a6-0997775308bc"),
                     CarId = Guid.Parse("0b38b8c2-4396-4e6f-aebe-3189f2392d76"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Audi",
                     LocationId = Guid.Parse("ba22a556-afd4-4d71-a1a6-0997775308bc"),
                     CarId = Guid.Parse("b54af349-0df6-4a3c-8cea-359ee837a93c"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("f90a1aaa-4360-4419-848e-47cf740cbc88"),
                     CarId = Guid.Parse("5d71036f-fe63-4dd1-bfa0-efbebd16d076"),
                     ColorName = "Deep Blue metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("d224be3e-e9c1-44a6-a262-a2e422ecdf5a"),
                     CarId = Guid.Parse("cd94eecf-ab12-43e9-929b-d91f25a01e7b"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Hyundai",
                     LocationId = Guid.Parse("8d5e3909-3785-4d7a-bde9-103aefd9f163"),
                     CarId = Guid.Parse("f8e70fe1-fa05-436c-86b6-0687b8fbdc9b"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("886d8a9c-5f25-44c5-a8c8-b2921afad367"),
                     CarId = Guid.Parse("42089e62-f387-4f49-a6a9-e77703d3da2e"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("886d8a9c-5f25-44c5-a8c8-b2921afad367"),
                     CarId = Guid.Parse("bc5f4c8d-15bc-41c6-b4b6-d70fcb6cfef8"),
                     ColorName = "Deep Blue metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Audi",
                     LocationId = Guid.Parse("f0f3c209-1afb-4d77-a1e4-41b980bbc39c"),
                     CarId = Guid.Parse("1ada923e-3301-4701-9114-60c01e8b9aaa"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("0179ab63-376f-47bc-a1e0-b7939aeeca26"),
                     CarId = Guid.Parse("7972dbd1-c454-4d5d-b82a-0457212fde65"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("0179ab63-376f-47bc-a1e0-b7939aeeca26"),
                     CarId = Guid.Parse("80ec6757-b48d-40b0-9084-e97e5922e34f"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Audi",
                     LocationId = Guid.Parse("65cb8f32-5444-4fd4-b816-8f57cde20e18"),
                     CarId = Guid.Parse("eeb58d0d-9660-43e1-a6b2-985ee824b237"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("8a603c82-7c0b-4de9-bdcd-db669cf48c06"),
                     CarId = Guid.Parse("daa0dabb-9393-4fd4-9aef-7de5771e6713"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("8a603c82-7c0b-4de9-bdcd-db669cf48c06"),
                     CarId = Guid.Parse("2974486c-389e-4ae0-a214-aecc587aa260"),
                     ColorName = "Deep Blue metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Mercedes-Benz",
                     LocationId = Guid.Parse("8a603c82-7c0b-4de9-bdcd-db669cf48c06"),
                     CarId = Guid.Parse("76c472d8-996a-477f-b1f3-e736ef5a0220"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("8a603c82-7c0b-4de9-bdcd-db669cf48c06"),
                     CarId = Guid.Parse("cbeee778-bb1e-4cbc-9709-81924db54ba7"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("8a603c82-7c0b-4de9-bdcd-db669cf48c06"),
                     CarId = Guid.Parse("447601c1-ee69-44bd-850d-4d1507e773f0"),
                     ColorName = "Red multicoat",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Audi",
                     LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                     CarId = Guid.Parse("7045b787-a166-437a-b823-9dc98ab7c8f8"),
                     ColorName = "Deep Blue metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                     CarId = Guid.Parse("bb30470f-499e-435c-a581-c56fbbf211c6"),
                     ColorName = "Red multicoat",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                     CarId = Guid.Parse("9abd8ad5-1a74-471c-a7fc-38ac79211ac3"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Mercedes-Benz",
                     LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                     CarId = Guid.Parse("20a74c41-24f0-4ead-b8b2-b451f08c5395"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                     CarId = Guid.Parse("7f8c99fc-a33a-4bc8-b6b9-628e19ba4d92"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("f4a9d00d-d7d2-46f5-a53a-b5a5e250244b"),
                     CarId = Guid.Parse("8c715de0-3acf-4411-bec5-d4b26646b75a"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                  /////////////
                  new Car
                  {
                      CarBrandName = "Hyundai",
                      LocationId = Guid.Parse("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"),
                      CarId = Guid.Parse("c8630eb7-b18a-49d1-b465-14d72cd6fc78"),
                      ColorName = "Red multicoat",
                      MileAge = 86_000,
                      NumberOfDoors = 3,
                      NumberOfSeats = 2,
                      ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                      
                  },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"),
                     CarId = Guid.Parse("f9324aff-8e36-463c-99cb-f675e2b278de"),
                     ColorName = "Midnight Silver metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Tesla",
                     LocationId = Guid.Parse("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"),
                     CarId = Guid.Parse("635f8aaa-7ff9-4c6c-85c6-bed990651756"),
                     ColorName = "Deep Blue metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                  new Car
                  {
                      CarBrandName = "Tesla",
                      LocationId = Guid.Parse("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"),
                      CarId = Guid.Parse("f413bc87-dba6-4b6f-a1be-11db04ba486b"),
                      ColorName = "Pearl White",
                      MileAge = 86_000,
                      NumberOfDoors = 3,
                      NumberOfSeats = 2,
                      ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                      
                  },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("1b05e9f4-eacf-4edd-aea0-3b1ab0efe524"),
                     CarId = Guid.Parse("9228fe18-c4e5-41ff-856a-72e10a2bb660"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                 new Car
                 {
                     CarBrandName = "Mercedes-Benz",
                     LocationId = Guid.Parse("8735b362-158f-48cc-ba5f-351a87add184"),
                     CarId = Guid.Parse("7b8d50c0-3c05-486b-95dc-ed2a86d45b32"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                  new Car
                  {
                      CarBrandName = "Audi",
                      LocationId = Guid.Parse("8735b362-158f-48cc-ba5f-351a87add184"),
                      CarId = Guid.Parse("bffeb255-364f-4aef-a064-65948310e41a"),
                      ColorName = "Red multicoat",
                      MileAge = 86_000,
                      NumberOfDoors = 3,
                      NumberOfSeats = 2,
                      ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                      
                  },
                new Car
                {
                    CarBrandName = "Tesla",
                    LocationId = Guid.Parse("8735b362-158f-48cc-ba5f-351a87add184"),
                    CarId = Guid.Parse("fcfdf941-6040-48d1-bc0d-d2c161a2fca7"),
                    ColorName = "Pearl White",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                new Car
                {
                    CarBrandName = "Tesla",
                    LocationId = Guid.Parse("fabac37b-9c3b-452d-8626-272be26bdecd"),
                    CarId = Guid.Parse("7fbd52e5-5552-4256-bd7c-e91561645360"),
                    ColorName = "Midnight Silver metallic",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                 new Car
                 {
                     CarBrandName = "Hyundai",
                     LocationId = Guid.Parse("fabac37b-9c3b-452d-8626-272be26bdecd"),
                     CarId = Guid.Parse("58a34157-6a7d-4910-8f57-a22cbb89fa04"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                new Car
                {
                    CarBrandName = "Audi",
                    LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                    CarId = Guid.Parse("87ffb445-c2c7-4959-96e4-2f76b71e47ae"),
                    ColorName = "Solid Black",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                new Car
                {
                    CarBrandName = "Audi",
                    LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                    CarId = Guid.Parse("6c578e04-8695-412e-b6c5-45441849e813"),
                    ColorName = "Midnight Silver metallic",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                 new Car
                 {
                     CarBrandName = "Mercedes-Benz",
                     LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                     CarId = Guid.Parse("8259c931-f342-4357-8075-022426ce6d0a"),
                     ColorName = "Pearl White",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                new Car
                {
                    CarBrandName = "BMW",
                    LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                    CarId = Guid.Parse("e58fd46c-7fe6-42f4-b95b-65de84f19621"),
                    ColorName = "Solid Black",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },

                 new Car
                 {
                     CarBrandName = "Hyundai",
                     LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                     CarId = Guid.Parse("ca75441a-6c47-4bfd-9e4f-723b9e0628cb"),
                     ColorName = "Deep Blue metallic",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                new Car
                {
                    CarBrandName = "Mercedes-Benz",
                    LocationId = Guid.Parse("27a1a764-db3d-478f-bbc3-190bbf93a5e7"),
                    CarId = Guid.Parse("e9dc0145-80a4-4d17-a076-c6cbe308ec1e"),
                    ColorName = "Midnight Silver metallic",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                 //*********

                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("6ac8b9de-17ca-4d42-90f4-fd3b5c64774c"),
                     CarId = Guid.Parse("db2bc9f2-dc58-4f17-b30c-4f8ba79b572e"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                new Car
                {
                    CarBrandName = "Tesla",
                    LocationId = Guid.Parse("6ac8b9de-17ca-4d42-90f4-fd3b5c64774c"),
                    CarId = Guid.Parse("f7c8bbf7-92bc-437d-a27a-d60dd6c95f05"),
                    ColorName = "Red multicoat",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                },
                 new Car
                 {
                     CarBrandName = "BMW",
                     LocationId = Guid.Parse("ae71ff9e-c117-4fa4-a431-4a3af7680a6b"),
                     CarId = Guid.Parse("75ad0206-5023-4a07-8744-af0def953ea6"),
                     ColorName = "Solid Black",
                     MileAge = 86_000,
                     NumberOfDoors = 3,
                     NumberOfSeats = 2,
                     ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                     
                 },
                new Car
                {
                    CarBrandName = "Tesla",
                    LocationId = Guid.Parse("6ac8b9de-17ca-4d42-90f4-fd3b5c64774c"),
                    CarId = Guid.Parse("181d0d91-debc-45ae-86df-796f4f6f2338"),
                    ColorName = "Solid Black",
                    MileAge = 86_000,
                    NumberOfDoors = 3,
                    NumberOfSeats = 2,
                    ProductionDate = new DateTime(2018, 02, 17), //1690, 11, 23
                    
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
