using Microsoft.EntityFrameworkCore.Migrations;

namespace ThisProjectIsATrashCan.Data.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3f6c11-53a8-424b-b82e-f8d8f996fecf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41d5937f-5005-464e-9c66-0ef1f6b42c0b", "6b2f509d-673f-4113-852a-d158f727f18c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41d5937f-5005-464e-9c66-0ef1f6b42c0b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d3f6c11-53a8-424b-b82e-f8d8f996fecf", "38bad1b4-bf86-48a1-903b-6a130e9ff9cb", "Admin", "ADMIN" });
        }
    }
}
