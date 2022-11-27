using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class Adddeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdce2b3-f202-41b3-8123-65ca8efb1cf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd632823-d7c4-47ee-a8a1-a666d917fd17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73ddb206-e664-4b20-ad54-a8832c4519e4", "657b98d0-c8a3-41a0-9dcb-e82b6a7db7cc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1143461-4b1f-443e-9269-f06db792ce3d", "235537b8-e27b-4fe0-8f46-9cc74080a1e9", "MANAGER", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ddb206-e664-4b20-ad54-a8832c4519e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1143461-4b1f-443e-9269-f06db792ce3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cdce2b3-f202-41b3-8123-65ca8efb1cf0", "6c59c48a-6dbb-47d0-bc24-90f989a3679c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd632823-d7c4-47ee-a8a1-a666d917fd17", "4ba96a6b-c285-4fdf-9980-d1b68bf31a98", "MANAGER", "MANAGER" });
        }
    }
}
