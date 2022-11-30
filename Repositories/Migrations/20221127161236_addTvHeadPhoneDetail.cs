using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class addTvHeadPhoneDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90068563-1347-4078-8d6d-2c2637a67b7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc94d246-650e-4475-a43e-88075cf15e18");

            migrationBuilder.AddColumn<string>(
                name: "BluetoothVersiyon",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CiftTelefonDestegi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DahiliUyduAlici",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EkranEbati",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EkranFormati",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GurultuOnleme",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HdmiGirisleri",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KullanimTipi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kurulum",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PcBaglantisi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuyaTereDayanikli",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Wifi",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0efea45c-0cdc-424f-b337-985e7ef708ac", "f93d81a6-1ba6-4cc5-b5c2-00c1b5fa3fa1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65120875-4e9d-4130-b8d3-ab98893d95d6", "6c6d14cf-5775-42e4-b65f-ef11279aa8c8", "MANAGER", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 1,
                columns: new[] { "BluetoothVersiyon", "CiftTelefonDestegi", "DahiliUyduAlici", "EkranEbati", "EkranFormati", "GurultuOnleme", "HdmiGirisleri", "KullanimTipi", "Kurulum", "PcBaglantisi", "SuyaTereDayanikli", "Wifi" },
                values: new object[] { "", "", "", "", "", "", "", "", "", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0efea45c-0cdc-424f-b337-985e7ef708ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65120875-4e9d-4130-b8d3-ab98893d95d6");

            migrationBuilder.DropColumn(
                name: "BluetoothVersiyon",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "CiftTelefonDestegi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "DahiliUyduAlici",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "EkranEbati",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "EkranFormati",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "GurultuOnleme",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "HdmiGirisleri",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "KullanimTipi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Kurulum",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "PcBaglantisi",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "SuyaTereDayanikli",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Wifi",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90068563-1347-4078-8d6d-2c2637a67b7d", "4437d3c5-fd19-49be-915a-97d67714d1fe", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc94d246-650e-4475-a43e-88075cf15e18", "770e2eda-82c2-4afd-bede-a73cda626210", "MANAGER", "MANAGER" });
        }
    }
}
