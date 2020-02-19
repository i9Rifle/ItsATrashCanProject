using Microsoft.EntityFrameworkCore.Migrations;

namespace ThisProjectIsATrashCan.Migrations
{
    public partial class Idrolenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb9a3ca5-954d-468c-9130-c1f17866c382");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0866be33-35b3-452d-ab7c-12d068a47b76", "e93edde9-6457-4a66-bc68-2e5c5275021e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09df7ddb-9dc3-4694-a2f9-cba7b1c6eb30", "b8f486b3-caad-480f-bf27-94dd676099ad", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0866be33-35b3-452d-ab7c-12d068a47b76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09df7ddb-9dc3-4694-a2f9-cba7b1c6eb30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb9a3ca5-954d-468c-9130-c1f17866c382", "58043ad6-0fa2-4e0e-a887-d4164c46c870", "Admin", "ADMIN" });
        }
    }
}
