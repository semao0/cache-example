using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CacheProject.Api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sku = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "Sku", "StockQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 1", 100.99m, "SKU-00001", 1000 },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 2", 101.99m, "SKU-00002", 1000 },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 3", 102.99m, "SKU-00003", 1000 },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 4", 103.99m, "SKU-00004", 1000 },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 5", 104.99m, "SKU-00005", 1000 },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 6", 105.99m, "SKU-00006", 1000 },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 7", 106.99m, "SKU-00007", 1000 },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 8", 107.99m, "SKU-00008", 1000 },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 9", 108.99m, "SKU-00009", 1000 },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 10", 109.99m, "SKU-00010", 1000 },
                    { 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 11", 110.99m, "SKU-00011", 1000 },
                    { 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 12", 111.99m, "SKU-00012", 1000 },
                    { 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 13", 112.99m, "SKU-00013", 1000 },
                    { 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 14", 113.99m, "SKU-00014", 1000 },
                    { 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 15", 114.99m, "SKU-00015", 1000 },
                    { 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 16", 115.99m, "SKU-00016", 1000 },
                    { 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 17", 116.99m, "SKU-00017", 1000 },
                    { 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 18", 117.99m, "SKU-00018", 1000 },
                    { 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 19", 118.99m, "SKU-00019", 1000 },
                    { 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 20", 119.99m, "SKU-00020", 1000 },
                    { 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 21", 120.99m, "SKU-00021", 1000 },
                    { 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 22", 121.99m, "SKU-00022", 1000 },
                    { 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 23", 122.99m, "SKU-00023", 1000 },
                    { 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 24", 123.99m, "SKU-00024", 1000 },
                    { 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 25", 124.99m, "SKU-00025", 1000 },
                    { 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 26", 125.99m, "SKU-00026", 1000 },
                    { 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 27", 126.99m, "SKU-00027", 1000 },
                    { 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 28", 127.99m, "SKU-00028", 1000 },
                    { 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 29", 128.99m, "SKU-00029", 1000 },
                    { 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 30", 129.99m, "SKU-00030", 1000 },
                    { 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 31", 130.99m, "SKU-00031", 1000 },
                    { 32, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 32", 131.99m, "SKU-00032", 1000 },
                    { 33, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 33", 132.99m, "SKU-00033", 1000 },
                    { 34, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 34", 133.99m, "SKU-00034", 1000 },
                    { 35, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 35", 134.99m, "SKU-00035", 1000 },
                    { 36, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 36", 135.99m, "SKU-00036", 1000 },
                    { 37, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 37", 136.99m, "SKU-00037", 1000 },
                    { 38, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 38", 137.99m, "SKU-00038", 1000 },
                    { 39, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 39", 138.99m, "SKU-00039", 1000 },
                    { 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 40", 139.99m, "SKU-00040", 1000 },
                    { 41, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 41", 140.99m, "SKU-00041", 1000 },
                    { 42, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 42", 141.99m, "SKU-00042", 1000 },
                    { 43, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 43", 142.99m, "SKU-00043", 1000 },
                    { 44, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 44", 143.99m, "SKU-00044", 1000 },
                    { 45, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 45", 144.99m, "SKU-00045", 1000 },
                    { 46, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 46", 145.99m, "SKU-00046", 1000 },
                    { 47, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 47", 146.99m, "SKU-00047", 1000 },
                    { 48, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 48", 147.99m, "SKU-00048", 1000 },
                    { 49, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 49", 148.99m, "SKU-00049", 1000 },
                    { 50, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 50", 149.99m, "SKU-00050", 1000 },
                    { 51, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 51", 150.99m, "SKU-00051", 1000 },
                    { 52, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 52", 151.99m, "SKU-00052", 1000 },
                    { 53, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 53", 152.99m, "SKU-00053", 1000 },
                    { 54, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 54", 153.99m, "SKU-00054", 1000 },
                    { 55, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 55", 154.99m, "SKU-00055", 1000 },
                    { 56, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 56", 155.99m, "SKU-00056", 1000 },
                    { 57, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 57", 156.99m, "SKU-00057", 1000 },
                    { 58, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 58", 157.99m, "SKU-00058", 1000 },
                    { 59, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 59", 158.99m, "SKU-00059", 1000 },
                    { 60, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 60", 159.99m, "SKU-00060", 1000 },
                    { 61, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 61", 160.99m, "SKU-00061", 1000 },
                    { 62, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 62", 161.99m, "SKU-00062", 1000 },
                    { 63, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 63", 162.99m, "SKU-00063", 1000 },
                    { 64, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 64", 163.99m, "SKU-00064", 1000 },
                    { 65, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 65", 164.99m, "SKU-00065", 1000 },
                    { 66, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 66", 165.99m, "SKU-00066", 1000 },
                    { 67, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 67", 166.99m, "SKU-00067", 1000 },
                    { 68, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 68", 167.99m, "SKU-00068", 1000 },
                    { 69, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 69", 168.99m, "SKU-00069", 1000 },
                    { 70, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 70", 169.99m, "SKU-00070", 1000 },
                    { 71, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 71", 170.99m, "SKU-00071", 1000 },
                    { 72, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 72", 171.99m, "SKU-00072", 1000 },
                    { 73, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 73", 172.99m, "SKU-00073", 1000 },
                    { 74, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 74", 173.99m, "SKU-00074", 1000 },
                    { 75, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 75", 174.99m, "SKU-00075", 1000 },
                    { 76, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 76", 175.99m, "SKU-00076", 1000 },
                    { 77, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 77", 176.99m, "SKU-00077", 1000 },
                    { 78, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 78", 177.99m, "SKU-00078", 1000 },
                    { 79, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 79", 178.99m, "SKU-00079", 1000 },
                    { 80, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 80", 179.99m, "SKU-00080", 1000 },
                    { 81, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 81", 180.99m, "SKU-00081", 1000 },
                    { 82, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 82", 181.99m, "SKU-00082", 1000 },
                    { 83, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 83", 182.99m, "SKU-00083", 1000 },
                    { 84, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 84", 183.99m, "SKU-00084", 1000 },
                    { 85, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 85", 184.99m, "SKU-00085", 1000 },
                    { 86, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 86", 185.99m, "SKU-00086", 1000 },
                    { 87, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 87", 186.99m, "SKU-00087", 1000 },
                    { 88, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 88", 187.99m, "SKU-00088", 1000 },
                    { 89, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 89", 188.99m, "SKU-00089", 1000 },
                    { 90, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 90", 189.99m, "SKU-00090", 1000 },
                    { 91, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 91", 190.99m, "SKU-00091", 1000 },
                    { 92, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 92", 191.99m, "SKU-00092", 1000 },
                    { 93, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 93", 192.99m, "SKU-00093", 1000 },
                    { 94, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 94", 193.99m, "SKU-00094", 1000 },
                    { 95, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 95", 194.99m, "SKU-00095", 1000 },
                    { 96, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 96", 195.99m, "SKU-00096", 1000 },
                    { 97, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 97", 196.99m, "SKU-00097", 1000 },
                    { 98, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 98", 197.99m, "SKU-00098", 1000 },
                    { 99, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 99", 198.99m, "SKU-00099", 1000 },
                    { 100, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Demo Product 100", 199.99m, "SKU-00100", 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Sku",
                table: "Products",
                column: "Sku",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
