using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreelancerApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("f0d07917-0677-41d3-be54-121a080a6120"),
                column: "date",
                value: new DateTime(2024, 9, 17, 16, 43, 24, 819, DateTimeKind.Local).AddTicks(7275));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("f0d07917-0677-41d3-be54-121a080a6120"),
                column: "date",
                value: new DateTime(2024, 9, 10, 15, 38, 42, 0, DateTimeKind.Local).AddTicks(1332));
        }
    }
}
