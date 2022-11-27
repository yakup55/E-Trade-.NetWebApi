using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class add10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00098b1d-df64-4a5c-be30-2e40ba3b7e27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4478eb2-ac6d-49ce-bfcc-cd6b811c2def");

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 6);

            migrationBuilder.AddColumn<string>(
                name: "BellekHizi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CihazAgirligi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EkranBoyutu",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EkranCozunurlugu",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EkranYenilemeHizi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ram",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RamTipi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SDDKapasite",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "İslemciNesli",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "İslemciTipi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cdce2b3-f202-41b3-8123-65ca8efb1cf0", "6c59c48a-6dbb-47d0-bc24-90f989a3679c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd632823-d7c4-47ee-a8a1-a666d917fd17", "4ba96a6b-c285-4fdf-9980-d1b68bf31a98", "MANAGER", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 1,
                columns: new[] { "BellekHizi", "CihazAgirligi", "EkranBoyutu", "EkranCozunurlugu", "EkranYenilemeHizi", "Ram", "RamTipi", "SDDKapasite", "İslemciNesli", "İslemciTipi" },
                values: new object[] { "", "", "", "", "", "", "", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdce2b3-f202-41b3-8123-65ca8efb1cf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd632823-d7c4-47ee-a8a1-a666d917fd17");

            migrationBuilder.DropColumn(
                name: "BellekHizi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "CihazAgirligi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "EkranBoyutu",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "EkranCozunurlugu",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "EkranYenilemeHizi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "RamTipi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "SDDKapasite",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "İslemciNesli",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "İslemciTipi",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00098b1d-df64-4a5c-be30-2e40ba3b7e27", "b921b6fa-e30b-467c-aeaf-ef3a527343f6", "Administrator", "ADMINISTRATOR" },
                    { "a4478eb2-ac6d-49ce-bfcc-cd6b811c2def", "67a554ce-18ec-4ab7-88e8-7666e6b5fa1e", "MANAGER", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailsId", "ColorId", "NumberId", "ProductExplanation", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 2, 2, null, "ddd", null, 2 },
                    { 3, 3, null, "ddd", null, 3 },
                    { 4, 4, null, "ddd", null, 4 },
                    { 5, 4, null, "ddd", null, 1 },
                    { 6, 5, null, "ddd", null, 3 }
                });
        }
    }
}
