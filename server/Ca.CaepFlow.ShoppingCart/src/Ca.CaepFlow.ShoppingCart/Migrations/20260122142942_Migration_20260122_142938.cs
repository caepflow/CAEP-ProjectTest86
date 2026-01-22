using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ca.CaepFlow.ShoppingCart.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260122_142938 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utente2S");

            migrationBuilder.CreateTable(
                name: "Utente3S",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qualcosa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utente3S", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utente3S");

            migrationBuilder.CreateTable(
                name: "Utente2S",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qualcosa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utente2S", x => x.Id);
                });
        }
    }
}
