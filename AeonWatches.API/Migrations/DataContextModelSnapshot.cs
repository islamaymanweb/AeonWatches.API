﻿// <auto-generated />
using System;
using AeonWatches.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AeonWatches.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.CustomerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("OrderId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type")
                        .IsUnique();

                    b.ToTable("ItemTypes");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerDetailId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerDetailId");

                    b.HasIndex("StatusTypeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.StatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Status")
                        .IsUnique();

                    b.ToTable("StatusTypes");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.UserEntities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Calibre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Calibres");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.CaseMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Material")
                        .IsUnique();

                    b.ToTable("CaseMaterials");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Crystal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Material")
                        .IsUnique();

                    b.ToTable("Crystals");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Dial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Colour")
                        .IsUnique();

                    b.ToTable("Dials");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.MovementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type")
                        .IsUnique();

                    b.ToTable("MovementTypes");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublicId")
                        .IsUnique();

                    b.HasIndex("Url")
                        .IsUnique();

                    b.HasIndex("WatchId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.PowerReserve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Duration")
                        .IsUnique();

                    b.ToTable("PowerReserves");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.StrapBraceletMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Material")
                        .IsUnique();

                    b.ToTable("StrapBraceletMaterials");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Watch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CalibreId")
                        .HasColumnType("int");

                    b.Property<int>("CaseMaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CrystalId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateAdded")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DialId")
                        .HasColumnType("int");

                    b.Property<bool>("Lume")
                        .HasColumnType("bit");

                    b.Property<int>("MovementTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSpecifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PowerReserveId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StrapBraceletMaterialId")
                        .HasColumnType("int");

                    b.Property<int>("WatchCaseMeasurementsId")
                        .HasColumnType("int");

                    b.Property<int>("WatchTypeId")
                        .HasColumnType("int");

                    b.Property<int>("WaterResistanceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CalibreId");

                    b.HasIndex("CaseMaterialId");

                    b.HasIndex("CrystalId");

                    b.HasIndex("DialId");

                    b.HasIndex("MovementTypeId");

                    b.HasIndex("PowerReserveId");

                    b.HasIndex("Reference")
                        .IsUnique();

                    b.HasIndex("StrapBraceletMaterialId");

                    b.HasIndex("WatchCaseMeasurementsId");

                    b.HasIndex("WatchTypeId");

                    b.HasIndex("WaterResistanceId");

                    b.ToTable("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.WatchCaseMeasurements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Diameter")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<double>("LugWidth")
                        .HasColumnType("float");

                    b.Property<double>("Thickness")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Diameter", "Length", "LugWidth", "Thickness")
                        .IsUnique();

                    b.ToTable("WatchCaseMeasurements");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.WatchType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type")
                        .IsUnique();

                    b.ToTable("WatchTypes");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.WaterResistance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Resistance")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Resistance")
                        .IsUnique();

                    b.ToTable("WaterResistances");
                });

            modelBuilder.Entity("AeonWatchesPI.Entities.WatchEntities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WatchId")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.CustomerDetail", b =>
                {
                    b.HasOne("AeonWatches.API.Entities.UserEntities.AppUser", "AppUser")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.Item", b =>
                {
                    b.HasOne("AeonWatches.API.Entities.OrderEntities.ItemType", "ItemType")
                        .WithMany("Items")
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.OrderEntities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.Order", b =>
                {
                    b.HasOne("AeonWatches.API.Entities.OrderEntities.CustomerDetail", "CustomerDetail")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.OrderEntities.StatusType", "StatusType")
                        .WithMany()
                        .HasForeignKey("StatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerDetail");

                    b.Navigation("StatusType");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Photo", b =>
                {
                    b.HasOne("AeonWatches.API.Entities.WatchEntities.Watch", "Watch")
                        .WithMany("Photos")
                        .HasForeignKey("WatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Watch");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Watch", b =>
                {
                    b.HasOne("AeonWatches.API.Entities.WatchEntities.Brand", "Brand")
                        .WithMany("Watches")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.Calibre", "Calibre")
                        .WithMany("Watches")
                        .HasForeignKey("CalibreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.CaseMaterial", "CaseMaterial")
                        .WithMany("Watches")
                        .HasForeignKey("CaseMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.Crystal", "Crystal")
                        .WithMany("Watches")
                        .HasForeignKey("CrystalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.Dial", "Dial")
                        .WithMany("Watches")
                        .HasForeignKey("DialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.MovementType", "MovementType")
                        .WithMany("Watches")
                        .HasForeignKey("MovementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.PowerReserve", "PowerReserve")
                        .WithMany("Watches")
                        .HasForeignKey("PowerReserveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.StrapBraceletMaterial", "StrapBraceletMaterial")
                        .WithMany("Watches")
                        .HasForeignKey("StrapBraceletMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.WatchCaseMeasurements", "WatchCaseMeasurements")
                        .WithMany("Watches")
                        .HasForeignKey("WatchCaseMeasurementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.WatchType", "WatchType")
                        .WithMany("Watches")
                        .HasForeignKey("WatchTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AeonWatches.API.Entities.WatchEntities.WaterResistance", "WaterResistance")
                        .WithMany("Watches")
                        .HasForeignKey("WaterResistanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Calibre");

                    b.Navigation("CaseMaterial");

                    b.Navigation("Crystal");

                    b.Navigation("Dial");

                    b.Navigation("MovementType");

                    b.Navigation("PowerReserve");

                    b.Navigation("StrapBraceletMaterial");

                    b.Navigation("WatchCaseMeasurements");

                    b.Navigation("WatchType");

                    b.Navigation("WaterResistance");
                });

            modelBuilder.Entity("AeonWatchesPI.Entities.WatchEntities.Stock", b =>
                {
                    b.HasOne("AeonWatches.API.Entities.WatchEntities.Watch", "Watch")
                        .WithOne("Stock")
                        .HasForeignKey("AeonWatchesPI.Entities.WatchEntities.Stock", "WatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Watch");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.CustomerDetail", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.ItemType", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.OrderEntities.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.UserEntities.AppUser", b =>
                {
                    b.Navigation("CustomerDetails");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Brand", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Calibre", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.CaseMaterial", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Crystal", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Dial", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.MovementType", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.PowerReserve", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.StrapBraceletMaterial", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.Watch", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Stock")
                        .IsRequired();
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.WatchCaseMeasurements", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.WatchType", b =>
                {
                    b.Navigation("Watches");
                });

            modelBuilder.Entity("AeonWatches.API.Entities.WatchEntities.WaterResistance", b =>
                {
                    b.Navigation("Watches");
                });
#pragma warning restore 612, 618
        }
    }
}
