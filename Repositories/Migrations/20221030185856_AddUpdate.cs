using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class AddUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Pc_PcId",
                table: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Pc");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_PcId",
                table: "ProductDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37705d5f-9735-438d-99c8-a0d8dc701659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c7adfea-4d05-4d82-9a7b-7d69c6d784b2");

            migrationBuilder.DropColumn(
                name: "PcId",
                table: "ProductDetails");

            migrationBuilder.CreateTable(
                name: "PcDetails",
                columns: table => new
                {
                    PcDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SDDKapasite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranCozunurlugu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İslemciNesli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İslemciTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranYenilemeHizi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranBoyutu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BellekHızı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazAgirligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcDetails", x => x.PcDetailsId);
                    table.ForeignKey(
                        name: "FK_PcDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3416a847-7028-406f-8322-c72583f14002", "1f28ccdd-6731-4019-bc89-5ae45d624f98", "Administrator", "ADMINISTRATOR" },
                    { "3a8fb7c4-3571-4bf4-8892-fc2fbdd9ca60", "5195907f-2eb2-442f-883a-f8afc1c4bc85", "MANAGER", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "PcDetails",
                columns: new[] { "PcDetailsId", "BellekHızı", "CihazAgirligi", "EkranBoyutu", "EkranCozunurlugu", "EkranYenilemeHizi", "ProductId", "Ram", "RamTipi", "SDDKapasite", "İslemciNesli", "İslemciTipi" },
                values: new object[,]
                {
                    { 1, "", "", "", "", "", null, "", "", "", "", "" },
                    { 2, "", "", "", "", "", null, "", "", "", "", "" },
                    { 3, "", "", "", "", "", null, "", "", "", "", "" },
                    { 4, "", "", "", "", "", null, "", "", "", "", "" },
                    { 5, "", "", "", "", "", null, "", "", "", "", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PcDetails_ProductId",
                table: "PcDetails",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PcDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3416a847-7028-406f-8322-c72583f14002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a8fb7c4-3571-4bf4-8892-fc2fbdd9ca60");

            migrationBuilder.AddColumn<int>(
                name: "PcId",
                table: "ProductDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pc",
                columns: table => new
                {
                    PcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BellekHızı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazAgirligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranBoyutu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranCozunurlugu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranYenilemeHizi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDDKapasite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İslemciNesli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İslemciTipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pc", x => x.PcId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37705d5f-9735-438d-99c8-a0d8dc701659", "d20527ef-f87e-464b-9149-bc21eb556010", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c7adfea-4d05-4d82-9a7b-7d69c6d784b2", "56d2e6d5-aa2c-43bf-83c3-97ebb8cac463", "MANAGER", "MANAGER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_PcId",
                table: "ProductDetails",
                column: "PcId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Pc_PcId",
                table: "ProductDetails",
                column: "PcId",
                principalTable: "Pc",
                principalColumn: "PcId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
