using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App7.Migrations
{
    /// <inheritdoc />
    public partial class AddUrunFiyat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Uruns",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IndirimliFiyat",
                table: "Uruns",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "IndirimliFiyat",
                table: "Uruns");
        }
    }
}
