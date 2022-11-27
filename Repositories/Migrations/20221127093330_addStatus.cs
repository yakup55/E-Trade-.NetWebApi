using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class addStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418aa600-cf67-431b-a3cb-774ae92c9942");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e18cfd5-e95b-4652-884a-5704ee5a9830");

            migrationBuilder.AddColumn<bool>(
                name: "ProductStatus",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CommentStatus",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CommentSubject",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4dae95e8-998f-4add-b8d6-b4f40824cb6c", "f049a7f7-1483-4c7a-806d-ce7f25b0a6b3", "MANAGER", "MANAGER" },
                    { "f45fdca6-c363-492e-aa25-b38fb994d745", "00e53d9c-7b74-4ce9-9294-d02e09211ad1", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "CommentStatus", "CommentSubject" },
                values: new object[] { true, "" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "CommentStatus", "CommentSubject" },
                values: new object[] { true, "" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                columns: new[] { "CommentStatus", "CommentSubject" },
                values: new object[] { true, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dae95e8-998f-4add-b8d6-b4f40824cb6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f45fdca6-c363-492e-aa25-b38fb994d745");

            migrationBuilder.DropColumn(
                name: "ProductStatus",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CommentStatus",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentSubject",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "418aa600-cf67-431b-a3cb-774ae92c9942", "2b204a86-2f82-4aac-925b-85b05b51abea", "MANAGER", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e18cfd5-e95b-4652-884a-5704ee5a9830", "b9d5e4d4-65d1-427c-b0c8-173f364e3d3e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
