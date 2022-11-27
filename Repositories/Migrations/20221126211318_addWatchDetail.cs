using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class addWatchDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ddb206-e664-4b20-ad54-a8832c4519e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1143461-4b1f-443e-9269-f06db792ce3d");

            migrationBuilder.AddColumn<string>(
                name: "AdımSayar",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GPS",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KalpRitmiOlcme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kamera",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SesliGorusme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuGecirme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UykuTakibi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UyumluMarka",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da251b87-3555-4428-9d77-639a179dcf39", "ffdca403-8a32-4036-bdcf-e88e76e243bd", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df0f76f8-4cd1-490d-a359-3aca7dd58a42", "a612fa6b-a2e2-4c00-98f6-f7a0058f12c1", "MANAGER", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da251b87-3555-4428-9d77-639a179dcf39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df0f76f8-4cd1-490d-a359-3aca7dd58a42");

            migrationBuilder.DropColumn(
                name: "AdımSayar",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "GPS",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "KalpRitmiOlcme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Kamera",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "SesliGorusme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "SuGecirme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "UykuTakibi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "UyumluMarka",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73ddb206-e664-4b20-ad54-a8832c4519e4", "657b98d0-c8a3-41a0-9dcb-e82b6a7db7cc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1143461-4b1f-443e-9269-f06db792ce3d", "235537b8-e27b-4fe0-8f46-9cc74080a1e9", "MANAGER", "MANAGER" });
        }
    }
}
