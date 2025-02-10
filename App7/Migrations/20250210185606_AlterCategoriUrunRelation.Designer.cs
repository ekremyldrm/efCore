﻿// <auto-generated />
using System;
using App7.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App7.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250210185606_AlterCategoriUrunRelation")]
    partial class AlterCategoriUrunRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App7.Entities.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategories");
                });

            modelBuilder.Entity("App7.Entities.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunId"));

                    b.Property<decimal?>("Fiyat")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("IndirimliFiyat")
                        .HasColumnType("money");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<short?>("Stok")
                        .HasColumnType("smallint");

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("App7.Entities.Urun", b =>
                {
                    b.HasOne("App7.Entities.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("KategoriId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("App7.Entities.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });
#pragma warning restore 612, 618
        }
    }
}
