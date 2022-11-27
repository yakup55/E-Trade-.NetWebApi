using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class NummbersAddShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f0df937-3ffe-4855-ac2e-2385b334f0b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3b6250a-5ec9-4fc4-a357-92eca6e1f998");

            migrationBuilder.AddColumn<int>(
                name: "NumberId",
                table: "ProductDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Numbers",
                columns: table => new
                {
                    NumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoesNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.NumberId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3612b257-49e2-4e68-902b-22cc8083e1c7", "2e805b4b-125a-408d-9923-ae6b93d3568f", "MANAGER", "MANAGER" },
                    { "651b02ba-3ac2-4bc6-b7c0-797b8ca34404", "f6d7d6a5-c377-417b-b00b-70e88eff20e1", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Numbers",
                columns: new[] { "NumberId", "ShoesNumber" },
                values: new object[,]
                {
                    { 1, 32 },
                    { 2, 33 },
                    { 3, 34 },
                    { 4, 35 },
                    { 5, 36 },
                    { 6, 37 },
                    { 7, 38 },
                    { 8, 39 },
                    { 9, 40 },
                    { 10, 41 },
                    { 11, 42 },
                    { 12, 43 },
                    { 13, 44 },
                    { 14, 45 },
                    { 15, 46 }
                });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailsId",
                keyValue: 1,
                column: "NumberId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_NumberId",
                table: "ProductDetails",
                column: "NumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Numbers_NumberId",
                table: "ProductDetails",
                column: "NumberId",
                principalTable: "Numbers",
                principalColumn: "NumberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Numbers_NumberId",
                table: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Numbers");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_NumberId",
                table: "ProductDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3612b257-49e2-4e68-902b-22cc8083e1c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "651b02ba-3ac2-4bc6-b7c0-797b8ca34404");

            migrationBuilder.DropColumn(
                name: "NumberId",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f0df937-3ffe-4855-ac2e-2385b334f0b9", "2ce5ab2d-2ff8-48b1-b4d6-691f2fe078da", "MANAGER", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3b6250a-5ec9-4fc4-a357-92eca6e1f998", "72fddd4a-b0bb-44c2-9feb-69a957371ebd", "Administrator", "ADMINISTRATOR" });
        }
    }
}
