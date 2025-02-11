using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App8.Migrations
{
    /// <inheritdoc />
    public partial class AddKullaniciTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciDetays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciDetays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciDetays_Kullanicis_Id",
                        column: x => x.Id,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciDetays");

            migrationBuilder.DropTable(
                name: "Kullanicis");
        }
    }
}
