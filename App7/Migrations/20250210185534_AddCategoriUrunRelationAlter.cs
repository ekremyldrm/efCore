using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App7.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriUrunRelationAlter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KategoriID",
                table: "Uruns",
                newName: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_KategoriId",
                table: "Uruns",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_Kategories_KategoriId",
                table: "Uruns",
                column: "KategoriId",
                principalTable: "Kategories",
                principalColumn: "KategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_Kategories_KategoriId",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_KategoriId",
                table: "Uruns");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Uruns",
                newName: "KategoriID");
        }
    }
}
