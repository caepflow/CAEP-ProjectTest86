using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ca.CaepFlow.Service.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260122_095444 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestiamoDiNuovo4S");

            migrationBuilder.CreateTable(
                name: "TestiamoDiNuovo5S",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestiamoDiNuovo5S", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestiamoDiNuovo5S");

            migrationBuilder.CreateTable(
                name: "TestiamoDiNuovo4S",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestiamoDiNuovo4S", x => x.Id);
                });
        }
    }
}
