using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App8.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderKargoRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Siparis_TasiyanId",
                table: "Siparis",
                column: "TasiyanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparis_Kargos_TasiyanId",
                table: "Siparis",
                column: "TasiyanId",
                principalTable: "Kargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparis_Kargos_TasiyanId",
                table: "Siparis");

            migrationBuilder.DropIndex(
                name: "IX_Siparis_TasiyanId",
                table: "Siparis");
        }
    }
}
