using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a038daf-7dfe-45ab-b021-b1122fb49d7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d752124c-70bd-4b90-8755-924fecedfeea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a404455-b8a8-479f-8daa-5039598600d0", "b5af37da-c175-4813-99cd-2f9b6762b2ef", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23d079a8-e721-4182-beea-0b0cc64f7fb3", "6b073e5b-03f5-4848-8409-a2ff46d455b0", "MANAGER", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a404455-b8a8-479f-8daa-5039598600d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23d079a8-e721-4182-beea-0b0cc64f7fb3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a038daf-7dfe-45ab-b021-b1122fb49d7d", "d959cdbe-bbb3-47f3-80cb-459fa27db772", "MANAGER", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d752124c-70bd-4b90-8755-924fecedfeea", "c014ba2e-14d7-4a0f-b0ae-4ec0fa2708bb", "Administrator", "ADMINISTRATOR" });
        }
    }
}
