using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ca.CaepFlow.Service.Migrations.NewService12Data
{
    /// <inheritdoc />
    public partial class Initial_20260122_165306 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestiamoDiNuovo7S",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestiamoDiNuovo7S", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestiamoDiNuovo7S");
        }
    }
}
