using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class addProductManWomenDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a404455-b8a8-479f-8daa-5039598600d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23d079a8-e721-4182-beea-0b0cc64f7fb3");

            migrationBuilder.AddColumn<string>(
                name: "AdımSayar",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AyakkabiTipi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GPS",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KalpRitmiOlcme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kamera",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Malzeme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SesliGorusme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuGecirme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tipi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UykuTakibi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UyumluMarka",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YakaStili",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bluetooth",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cifthat",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dahilihafiza",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "kameracözünürlügü",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "parmakizi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pilgücü",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "yüztanıma",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "418aa600-cf67-431b-a3cb-774ae92c9942", "2b204a86-2f82-4aac-925b-85b05b51abea", "MANAGER", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e18cfd5-e95b-4652-884a-5704ee5a9830", "b9d5e4d4-65d1-427c-b0c8-173f364e3d3e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 1,
                columns: new[] { "AdımSayar", "AyakkabiTipi", "Cinsiyet", "GPS", "KalpRitmiOlcme", "Kamera", "Malzeme", "SesliGorusme", "SuGecirme", "Tipi", "UykuTakibi", "UyumluMarka", "YakaStili", "bluetooth", "cifthat", "dahilihafiza", "kameracözünürlügü", "parmakizi", "pilgücü", "yüztanıma" },
                values: new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418aa600-cf67-431b-a3cb-774ae92c9942");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e18cfd5-e95b-4652-884a-5704ee5a9830");

            migrationBuilder.DropColumn(
                name: "AdımSayar",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "AyakkabiTipi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
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
                name: "Malzeme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "SesliGorusme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "SuGecirme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Tipi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "UykuTakibi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "UyumluMarka",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "YakaStili",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "bluetooth",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "cifthat",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "dahilihafiza",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "kameracözünürlügü",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "parmakizi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "pilgücü",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "yüztanıma",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a404455-b8a8-479f-8daa-5039598600d0", "b5af37da-c175-4813-99cd-2f9b6762b2ef", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23d079a8-e721-4182-beea-0b0cc64f7fb3", "6b073e5b-03f5-4848-8409-a2ff46d455b0", "MANAGER", "MANAGER" });
        }
    }
}
