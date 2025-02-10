using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App7.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriUrunRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Uruns",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Uruns");
        }
    }
}
