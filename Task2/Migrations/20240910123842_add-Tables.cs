using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task2.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Freelancer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skillSet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hourlyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    freelancerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_clientId",
                        column: x => x.clientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Freelancer_freelancerId",
                        column: x => x.freelancerId,
                        principalTable: "Freelancer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    freelancerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Freelancer_freelancerId",
                        column: x => x.freelancerId,
                        principalTable: "Freelancer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Projects_projectId",
                        column: x => x.projectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "email", "name" },
                values: new object[] { new Guid("c70806dc-ebd7-4d9e-b2ff-497a78d5e4f1"), "ahmad@gmail.com", "Ahmad" });

            migrationBuilder.InsertData(
                table: "Freelancer",
                columns: new[] { "Id", "email", "hourlyRate", "name", "skillSet" },
                values: new object[] { new Guid("21817b57-34dd-436c-a9ee-225dfe69a964"), "ManarFuqha@gmail.com", 50m, "Manar", "C#, ASP.NET, Java, SQL" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "clientId", "description", "freelancerId", "title" },
                values: new object[] { new Guid("c411dae6-2ca6-4ea7-9f1a-b366f9f518d5"), new Guid("c70806dc-ebd7-4d9e-b2ff-497a78d5e4f1"), "Build a corporate website", null, "Website Development" });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "amount", "date", "freelancerId", "projectId" },
                values: new object[] { new Guid("f0d07917-0677-41d3-be54-121a080a6120"), 300m, new DateTime(2024, 9, 10, 15, 38, 42, 0, DateTimeKind.Local).AddTicks(1332), new Guid("21817b57-34dd-436c-a9ee-225dfe69a964"), new Guid("c411dae6-2ca6-4ea7-9f1a-b366f9f518d5") });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_freelancerId",
                table: "Payment",
                column: "freelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_projectId",
                table: "Payment",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_clientId",
                table: "Projects",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_freelancerId",
                table: "Projects",
                column: "freelancerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Freelancer");
        }
    }
}
