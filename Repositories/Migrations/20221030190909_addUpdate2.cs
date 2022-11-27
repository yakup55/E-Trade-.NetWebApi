using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class addUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PcDetails_Products_ProductId",
                table: "PcDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3416a847-7028-406f-8322-c72583f14002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a8fb7c4-3571-4bf4-8892-fc2fbdd9ca60");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00098b1d-df64-4a5c-be30-2e40ba3b7e27", "b921b6fa-e30b-467c-aeaf-ef3a527343f6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4478eb2-ac6d-49ce-bfcc-cd6b811c2def", "67a554ce-18ec-4ab7-88e8-7666e6b5fa1e", "MANAGER", "MANAGER" });

            migrationBuilder.AddForeignKey(
                name: "FK_PcDetails_Products_ProductId",
                table: "PcDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PcDetails_Products_ProductId",
                table: "PcDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00098b1d-df64-4a5c-be30-2e40ba3b7e27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4478eb2-ac6d-49ce-bfcc-cd6b811c2def");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3416a847-7028-406f-8322-c72583f14002", "1f28ccdd-6731-4019-bc89-5ae45d624f98", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a8fb7c4-3571-4bf4-8892-fc2fbdd9ca60", "5195907f-2eb2-442f-883a-f8afc1c4bc85", "MANAGER", "MANAGER" });

            migrationBuilder.AddForeignKey(
                name: "FK_PcDetails_Products_ProductId",
                table: "PcDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
