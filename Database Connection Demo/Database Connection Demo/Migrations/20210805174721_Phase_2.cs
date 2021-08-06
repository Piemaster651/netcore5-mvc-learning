using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database_Connection_Demo.Migrations
{
    public partial class Phase_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 5, 12, 47, 21, 211, DateTimeKind.Local).AddTicks(4187));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Customer");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 5, 11, 34, 35, 685, DateTimeKind.Local).AddTicks(3295));
        }
    }
}
