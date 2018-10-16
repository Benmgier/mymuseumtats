using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMuseumTattooStudio.Web.Migrations
{
    public partial class RemovingAllCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ed14aa7c-e4b7-4e2b-8a4b-58d718c3e944", "5c18e6bf-6be4-40ac-8bff-7213414ed97f", "Administrator", "ADMINISTRATOR" },
                    { "d4072732-6c17-4d98-bd3b-dfd82ca5da2f", "d3be5045-7011-4b79-aada-23163579ec2e", "Artist", "ARTIST" }
                });

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "COLOR");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "BLK-GRY");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "PORTRAITS");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "COVER-UPS");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "PERMANENT-CORRECTIVE-COSMETICS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d4072732-6c17-4d98-bd3b-dfd82ca5da2f", "d3be5045-7011-4b79-aada-23163579ec2e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ed14aa7c-e4b7-4e2b-8a4b-58d718c3e944", "5c18e6bf-6be4-40ac-8bff-7213414ed97f" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bd635f3-1d0e-46e3-9c5d-e0a6f0f211b3", "d93e93f8-a50d-4cf3-ab9c-cbea0436549b", "Administrator", "ADMINISTRATOR" },
                    { "01b3655c-927d-4bfe-aae2-0cddf34328d9", "a6199a9e-a5e8-4c56-bde2-b10e3a31a1e1", "Artist", "ARTIST" }
                });

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "ALL");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "COLOR");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "BLK-GRY");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "PORTRAITS");

            migrationBuilder.UpdateData(
                table: "PhotoCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "COVER-UPS");

            migrationBuilder.InsertData(
                table: "PhotoCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "PERMANENT-CORRECTIVE-COSMETICS" });
        }
    }
}
