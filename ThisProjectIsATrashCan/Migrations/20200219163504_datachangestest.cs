using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThisProjectIsATrashCan.Migrations
{
    public partial class datachangestest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e69dde7b-df19-48cc-a481-df9d963733dc");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customer",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDay",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsSuspended",
                table: "Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDay",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb9a3ca5-954d-468c-9130-c1f17866c382", "58043ad6-0fa2-4e0e-a887-d4164c46c870", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb9a3ca5-954d-468c-9130-c1f17866c382");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EndDay",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IsSuspended",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StartDay",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e69dde7b-df19-48cc-a481-df9d963733dc", "cbdf9b14-93e0-481f-bda0-d0f7368f53ea", "Admin", "ADMIN" });
        }
    }
}
