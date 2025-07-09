﻿using AeonWatches.API.Entities.WatchEntities;
using AeonWatchesPI.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;


namespace AeonWatches.API.Data.SeedData.Watch;


public static class WatchSeedData
{
    private const string Des1 = "Crafted with precision and a dedication to timeless design, our watches embody the " +
                                "essence of luxury. The perfect balance of classic aesthetics and modern innovation, " +
                                "each timepiece is a testament to our commitment to quality and craftsmanship.";

    private const string Des2 = "Experience unparalleled accuracy with our expertly engineered watches. Designed for " +
                                "those who value precision, our timepieces blend cutting-edge technology with " +
                                "sophisticated style, ensuring you always make a statement, no matter the occasion.";

    private const string Des3 = "Where heritage meets innovation, our watches embody the perfect fusion of past and " +
                                "future. Inspired by iconic designs and reimagined with modern technology, these " +
                                "timepieces offer a unique blend of tradition and cutting-edge functionality.";

    public static List<Entities.WatchEntities.Watch> GetWatchSeedData()
    {
        return new List<Entities.WatchEntities.Watch>
        {
            new()
            {
                Name = "TestWatch1",
                BrandId = 1,
                CalibreId = 1,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des1 + " " + Des2 + " " + Des3,
                DialId = 1,
                Lume = true,
                Reference = "SKX101",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch1.png",
                        IsMain = true,
                        PublicId = "TestWatch1"
                    }
                },
                Price = 999.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 1 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 1,
                WaterResistanceId = 1,
                OtherSpecifications = "Limited edition test watch 1",
                Cost = 250m,
                DateAdded = new DateOnly(2024, 07, 10)
            },
            new()
            {
                Name = "TestWatch2",
                BrandId = 1,
                CalibreId = 1,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des2 + " " + Des3 + " " + Des1,
                DialId = 1,
                Lume = true,
                Reference = "SKX102",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch2.png",
                        IsMain = true,
                        PublicId = "TestWatch2"
                    }
                },
                Price = 399.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 2 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 2,
                WaterResistanceId = 1,
                OtherSpecifications = "Limited edition test watch 2",
                Cost = 150m,
                DateAdded = new DateOnly(2024, 06, 26)
            },
            new()
            {
                Name = "TestWatch3",
                BrandId = 2,
                CalibreId = 1,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des1 + " " + Des3 + " " + Des2,
                DialId = 1,
                Lume = true,
                Reference = "SKX103",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch3.png",
                        IsMain = true,
                        PublicId = "TestWatch3"
                    }
                },
                Price = 499.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 3 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 1,
                WaterResistanceId = 2,
                OtherSpecifications = "Limited edition test watch 3",
                Cost = 100m,
                DateAdded = new DateOnly(2023, 09, 10)
            },
            new()
            {
                Name = "TestWatch4",
                BrandId = 1,
                CalibreId = 1,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des1 + " " + Des3 + " " + Des2,
                DialId = 1,
                Lume = true,
                Reference = "SKX104",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch4.png",
                        IsMain = true,
                        PublicId = "TestWatch4"
                    }
                },
                Price = 199.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 4 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 1,
                WaterResistanceId = 1,
                OtherSpecifications = "Limited edition test watch 4",
                Cost = 50m,
                DateAdded = new DateOnly(2024, 06, 10)
            },
            new()
            {
                Name = "TestWatch5",
                BrandId = 3,
                CalibreId = 3,
                CaseMaterialId = 4,
                CrystalId = 2,
                Description = Des2 + " " + Des1 + " " + Des3,
                DialId = 1,
                Lume = true,
                Reference = "SKX105",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch5.png",
                        IsMain = true,
                        PublicId = "TestWatch5"
                    }
                },
                Price = 399.99m,
                PowerReserveId = 3,
                Stock = new Stock { Quantity = 5 },
                StrapBraceletMaterialId = 8,
                WatchCaseMeasurementsId = 2,
                WatchTypeId = 2,
                WaterResistanceId = 4,
                OtherSpecifications = "Limited edition test watch 5",
                Cost = 75.00m,
                DateAdded = new DateOnly(2022, 09, 10)
            },
            new()
            {
                Name = "TestWatch6",
                BrandId = 4,
                CalibreId = 3,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des2 + " " + Des1 + " " + Des3,
                DialId = 1,
                Lume = true,
                Reference = "SKX106",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch6.png",
                        IsMain = true,
                        PublicId = "TestWatch6"
                    }
                },
                Price = 1500.00m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 6 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 3,
                WaterResistanceId = 4,
                OtherSpecifications = "Limited edition test watch 6",
                Cost = 750.00m
            },
            new()
            {
                Name = "TestWatch7",
                BrandId = 4,
                CalibreId = 2,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des2 + " " + Des3 + " " + Des1,
                DialId = 1,
                Lume = true,
                Reference = "SKX107",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch7.png",
                        IsMain = true,
                        PublicId = "TestWatch7"
                    }
                },
                Price = 999.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 7 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 3,
                WaterResistanceId = 3,
                OtherSpecifications = "Limited edition test watch 7",
                Cost = 499.99m,
                DateAdded = new DateOnly(2024, 04, 04)
            },
            new()
            {
                Name = "TestWatch8",
                BrandId = 5,
                CalibreId = 2,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des2 + " " + Des1 + " " + Des3,
                DialId = 1,
                Lume = true,
                Reference = "SKX108",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch8.png",
                        IsMain = true,
                        PublicId = "TestWatch8"
                    }
                },
                Price = 1999.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 8 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 4,
                WaterResistanceId = 3,
                OtherSpecifications = "Limited edition test watch 8",
                Cost = 1000.00m,
                DateAdded = new DateOnly(2023, 05, 10)
            },
            new()
            {
                Name = "TestWatch9",
                BrandId = 1,
                CalibreId = 2,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des3 + " " + Des2 + " " + Des1,
                DialId = 1,
                Lume = true,
                Reference = "SKX109",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch9.png",
                        IsMain = true,
                        PublicId = "TestWatch9"
                    }
                },
                Price = 499.99m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 9 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 5,
                WaterResistanceId = 3,
                OtherSpecifications = "Limited edition test watch 9",
                Cost = 350.00m,
                DateAdded = new DateOnly(2024, 02, 10)
            },
            new()
            {
                Name = "TestWatch10",
                BrandId = 5,
                CalibreId = 1,
                CaseMaterialId = 3,
                CrystalId = 2,
                Description = Des3 + " " + Des2 + " " + Des1,
                DialId = 1,
                Lume = true,
                Reference = "SKX110",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch10.png",
                        IsMain = true,
                        PublicId = "TestWatch10"
                    }
                },
                Price = 1750.00m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 10 },
                StrapBraceletMaterialId = 3,
                WatchCaseMeasurementsId = 3,
                WatchTypeId = 6,
                WaterResistanceId = 2,
                OtherSpecifications = "Limited edition test watch 10",
                Cost = 1250.00m,
                DateAdded = new DateOnly(2023, 10, 10)
            },
            new()
            {
                Name = "TestWatch11",
                BrandId = 5,
                CalibreId = 2,
                CaseMaterialId = 6,
                CrystalId = 3,
                Description = Des3 + " " + Des1 + " " + Des2,
                DialId = 4,
                Lume = true,
                Reference = "SKX111",
                MovementTypeId = 3,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch11.png",
                        IsMain = true,
                        PublicId = "TestWatch11"
                    }
                },
                Price = 750.00m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 0 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 7,
                WaterResistanceId = 4,
                OtherSpecifications = "Limited edition test watch 11",
                Cost = 500.00m,
                DateAdded = new DateOnly(2022, 09, 10)
            },
            new()
            {
                Name = "TestWatch12",
                BrandId = 1,
                CalibreId = 3,
                CaseMaterialId = 1,
                CrystalId = 1,
                Description = Des3 + " " + Des1 + " " + Des2,
                DialId = 1,
                Lume = true,
                Reference = "SKX112",
                MovementTypeId = 1,
                Photos = new List<Photo>()
                {
                    new()
                    {
                        Url = "./assets/Watch12.png",
                        IsMain = true,
                        PublicId = "TestWatch12"
                    }
                },
                Price = 120.00m,
                PowerReserveId = 1,
                Stock = new Stock { Quantity = 12 },
                StrapBraceletMaterialId = 1,
                WatchCaseMeasurementsId = 1,
                WatchTypeId = 7,
                WaterResistanceId = 1,
                OtherSpecifications = "Limited edition test watch 12",
                Cost = 45.00m,
                DateAdded = new DateOnly(2023, 09, 10)
            }
        };
    }
};