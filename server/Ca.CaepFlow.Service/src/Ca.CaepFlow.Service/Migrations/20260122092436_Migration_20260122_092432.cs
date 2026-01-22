using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ca.CaepFlow.Service.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20260122_092432 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestiamoDiNuovo4S",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestiamoDiNuovo4S");
        }
    }
}
