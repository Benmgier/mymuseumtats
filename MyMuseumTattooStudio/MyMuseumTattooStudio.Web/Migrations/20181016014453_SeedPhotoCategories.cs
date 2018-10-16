using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMuseumTattooStudio.Web.Migrations
{
    public partial class SeedPhotoCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "038e7b75-2b0b-463d-acd7-b0947b9aa5f2", "0bb5d21a-3f5d-48d3-acc0-c3148991024b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d38aea63-4ffe-4e77-aefc-e6c92091c091", "5499771d-7ee1-4bc3-9e0b-f9a2542ddb32" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bd635f3-1d0e-46e3-9c5d-e0a6f0f211b3", "d93e93f8-a50d-4cf3-ab9c-cbea0436549b", "Administrator", "ADMINISTRATOR" },
                    { "01b3655c-927d-4bfe-aae2-0cddf34328d9", "a6199a9e-a5e8-4c56-bde2-b10e3a31a1e1", "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "PhotoCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ALL" },
                    { 2, "COLOR" },
                    { 3, "BLK-GRY" },
                    { 4, "PORTRAITS" },
                    { 5, "COVER-UPS" },
                    { 6, "PERMANENT-CORRECTIVE-COSMETICS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "01b3655c-927d-4bfe-aae2-0cddf34328d9", "a6199a9e-a5e8-4c56-bde2-b10e3a31a1e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3bd635f3-1d0e-46e3-9c5d-e0a6f0f211b3", "d93e93f8-a50d-4cf3-ab9c-cbea0436549b" });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d38aea63-4ffe-4e77-aefc-e6c92091c091", "5499771d-7ee1-4bc3-9e0b-f9a2542ddb32", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "038e7b75-2b0b-463d-acd7-b0947b9aa5f2", "0bb5d21a-3f5d-48d3-acc0-c3148991024b", "Artist", "ARTIST" });
        }
    }
}
