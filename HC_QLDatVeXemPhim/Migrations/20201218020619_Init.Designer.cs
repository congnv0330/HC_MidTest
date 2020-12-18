﻿// <auto-generated />
using System;
using HC_QLDatVeXemPhim.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HC_QLDatVeXemPhim.Migrations
{
    [DbContext(typeof(DatVeContext))]
    [Migration("20201218020619_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HC_QLDatVeXemPhim.Entities.DatVe", b =>
                {
                    b.Property<int>("MaDatVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaLichChieuPhim")
                        .HasColumnType("int");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGianDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("MaDatVe");

                    b.HasIndex("MaLichChieuPhim");

                    b.ToTable("DatVes");
                });

            modelBuilder.Entity("HC_QLDatVeXemPhim.Entities.LichChieuPhim", b =>
                {
                    b.Property<int>("MaLichChieuPhim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaPhim")
                        .HasColumnType("int");

                    b.Property<int>("MaRap")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianChieu")
                        .HasColumnType("datetime2");

                    b.HasKey("MaLichChieuPhim");

                    b.HasIndex("MaPhim");

                    b.HasIndex("MaRap");

                    b.ToTable("LichChieuPhims");
                });

            modelBuilder.Entity("HC_QLDatVeXemPhim.Entities.Phim", b =>
                {
                    b.Property<int>("MaPhim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.HasKey("MaPhim");

                    b.ToTable("Phims");
                });

            modelBuilder.Entity("HC_QLDatVeXemPhim.Entities.Rap", b =>
                {
                    b.Property<int>("MaRap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoChoTrong")
                        .HasColumnType("int");

                    b.Property<string>("TenRap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaRap");

                    b.ToTable("Raps");
                });

            modelBuilder.Entity("HC_QLDatVeXemPhim.Entities.DatVe", b =>
                {
                    b.HasOne("HC_QLDatVeXemPhim.Entities.LichChieuPhim", "LichChieuPhim")
                        .WithMany("DatVes")
                        .HasForeignKey("MaLichChieuPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HC_QLDatVeXemPhim.Entities.LichChieuPhim", b =>
                {
                    b.HasOne("HC_QLDatVeXemPhim.Entities.Phim", "Phim")
                        .WithMany("LichChieuPhims")
                        .HasForeignKey("MaPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HC_QLDatVeXemPhim.Entities.Rap", "Rap")
                        .WithMany("LichChieuPhims")
                        .HasForeignKey("MaRap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
