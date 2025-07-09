using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeonWatches.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calibres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crystals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crystals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colour = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerReserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerReserves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StrapBraceletMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrapBraceletMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WatchCaseMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diameter = table.Column<double>(type: "float", nullable: false),
                    Thickness = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    LugWidth = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchCaseMeasurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WatchTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterResistances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resistance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterResistances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CalibreId = table.Column<int>(type: "int", nullable: false),
                    CaseMaterialId = table.Column<int>(type: "int", nullable: false),
                    CrystalId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DialId = table.Column<int>(type: "int", nullable: false),
                    Lume = table.Column<bool>(type: "bit", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovementTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PowerReserveId = table.Column<int>(type: "int", nullable: false),
                    StrapBraceletMaterialId = table.Column<int>(type: "int", nullable: false),
                    WatchCaseMeasurementsId = table.Column<int>(type: "int", nullable: false),
                    WatchTypeId = table.Column<int>(type: "int", nullable: false),
                    WaterResistanceId = table.Column<int>(type: "int", nullable: false),
                    OtherSpecifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateAdded = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Watches_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_Calibres_CalibreId",
                        column: x => x.CalibreId,
                        principalTable: "Calibres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_CaseMaterials_CaseMaterialId",
                        column: x => x.CaseMaterialId,
                        principalTable: "CaseMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_Crystals_CrystalId",
                        column: x => x.CrystalId,
                        principalTable: "Crystals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_Dials_DialId",
                        column: x => x.DialId,
                        principalTable: "Dials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_MovementTypes_MovementTypeId",
                        column: x => x.MovementTypeId,
                        principalTable: "MovementTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_PowerReserves_PowerReserveId",
                        column: x => x.PowerReserveId,
                        principalTable: "PowerReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_StrapBraceletMaterials_StrapBraceletMaterialId",
                        column: x => x.StrapBraceletMaterialId,
                        principalTable: "StrapBraceletMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_WatchCaseMeasurements_WatchCaseMeasurementsId",
                        column: x => x.WatchCaseMeasurementsId,
                        principalTable: "WatchCaseMeasurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_WatchTypes_WatchTypeId",
                        column: x => x.WatchTypeId,
                        principalTable: "WatchTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_WaterResistances_WaterResistanceId",
                        column: x => x.WaterResistanceId,
                        principalTable: "WaterResistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerDetailId = table.Column<int>(type: "int", nullable: false),
                    StatusTypeId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_CustomerDetails_CustomerDetailId",
                        column: x => x.CustomerDetailId,
                        principalTable: "CustomerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_StatusTypes_StatusTypeId",
                        column: x => x.StatusTypeId,
                        principalTable: "StatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    WatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_UserName",
                table: "AppUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Name",
                table: "Brands",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calibres_Name",
                table: "Calibres",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CaseMaterials_Material",
                table: "CaseMaterials",
                column: "Material",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Crystals_Material",
                table: "Crystals",
                column: "Material",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_AppUserId",
                table: "CustomerDetails",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dials_Colour",
                table: "Dials",
                column: "Colour",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_Type",
                table: "ItemTypes",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovementTypes_Type",
                table: "MovementTypes",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerDetailId",
                table: "Orders",
                column: "CustomerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusTypeId",
                table: "Orders",
                column: "StatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PublicId",
                table: "Photos",
                column: "PublicId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_Url",
                table: "Photos",
                column: "Url",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_WatchId",
                table: "Photos",
                column: "WatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerReserves_Duration",
                table: "PowerReserves",
                column: "Duration",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatusTypes_Status",
                table: "StatusTypes",
                column: "Status",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_WatchId",
                table: "Stocks",
                column: "WatchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StrapBraceletMaterials_Material",
                table: "StrapBraceletMaterials",
                column: "Material",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WatchCaseMeasurements_Diameter_Length_LugWidth_Thickness",
                table: "WatchCaseMeasurements",
                columns: new[] { "Diameter", "Length", "LugWidth", "Thickness" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Watches_BrandId",
                table: "Watches",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_CalibreId",
                table: "Watches",
                column: "CalibreId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_CaseMaterialId",
                table: "Watches",
                column: "CaseMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_CrystalId",
                table: "Watches",
                column: "CrystalId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_DialId",
                table: "Watches",
                column: "DialId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_MovementTypeId",
                table: "Watches",
                column: "MovementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_PowerReserveId",
                table: "Watches",
                column: "PowerReserveId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_Reference",
                table: "Watches",
                column: "Reference",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Watches_StrapBraceletMaterialId",
                table: "Watches",
                column: "StrapBraceletMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_WatchCaseMeasurementsId",
                table: "Watches",
                column: "WatchCaseMeasurementsId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_WatchTypeId",
                table: "Watches",
                column: "WatchTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_WaterResistanceId",
                table: "Watches",
                column: "WaterResistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchTypes_Type",
                table: "WatchTypes",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterResistances_Resistance",
                table: "WaterResistances",
                column: "Resistance",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Watches");

            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.DropTable(
                name: "StatusTypes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Calibres");

            migrationBuilder.DropTable(
                name: "CaseMaterials");

            migrationBuilder.DropTable(
                name: "Crystals");

            migrationBuilder.DropTable(
                name: "Dials");

            migrationBuilder.DropTable(
                name: "MovementTypes");

            migrationBuilder.DropTable(
                name: "PowerReserves");

            migrationBuilder.DropTable(
                name: "StrapBraceletMaterials");

            migrationBuilder.DropTable(
                name: "WatchCaseMeasurements");

            migrationBuilder.DropTable(
                name: "WatchTypes");

            migrationBuilder.DropTable(
                name: "WaterResistances");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
