using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class AddPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3612b257-49e2-4e68-902b-22cc8083e1c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "651b02ba-3ac2-4bc6-b7c0-797b8ca34404");

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
                    SDDKapasite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranCozunurlugu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İslemciNesli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İslemciTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranYenilemeHizi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkranBoyutu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BellekHızı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazAgirligi = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3612b257-49e2-4e68-902b-22cc8083e1c7", "2e805b4b-125a-408d-9923-ae6b93d3568f", "MANAGER", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "651b02ba-3ac2-4bc6-b7c0-797b8ca34404", "f6d7d6a5-c377-417b-b00b-70e88eff20e1", "Administrator", "ADMINISTRATOR" });
        }
    }
}
