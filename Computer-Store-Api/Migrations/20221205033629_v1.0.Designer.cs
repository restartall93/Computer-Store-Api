﻿// <auto-generated />
using Computer_Store_Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Computer_Store_Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221205033629_v1.0")]
    partial class v10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Computer_Store_Api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Drive")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Monitor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VGA")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPU = "Intel Core i5 11400H",
                            Description = "l",
                            Drive = "512GB SSD",
                            Image = "/product/imgHomepage/250-21734-laptop-gigabyte-gaming-g5-md-51s1123so.jpg",
                            Monitor = "15.6 inch FHD 144Hz",
                            Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                            Price = 0.0,
                            RAM = "16gb",
                            VGA = "NVIDIA RTX3050Ti 4G"
                        },
                        new
                        {
                            Id = 2,
                            CPU = "Core i5 11400H (2.6 Ghz Up to 4.4 Ghz, 12MB)",
                            Description = "l",
                            Drive = "512GB SSD / có thể Nâng cấp 1 ổ Sata 2.5'",
                            Image = "/product/imgHomepage/250-21725-laptop-gigabyte-gaming-g5-md-51s1123so.jpg",
                            Monitor = "15.6 Inch Full HD, 100% srgb",
                            Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6' FHD/RTX3050Ti 4Gb/ Win11)",
                            Price = 0.0,
                            RAM = "16GB 3200Mhz, 2 Khe, up to 32GB",
                            VGA = "NVIDIA GeForce RTX 3050 4GB GDDR6"
                        },
                        new
                        {
                            Id = 3,
                            CPU = "AMD Ryzen™ 3-5300U (2.6GHz upto 3.8GHz, 4MB)",
                            Description = "l",
                            Drive = "256GB PCIe NVMe",
                            Image = "/product/imgHomepage/250-21615-hp-14s.jpg",
                            Monitor = "14 inch HD (1366 x 768), micro-edge, BrightView, 250 nits, 45% NTSC",
                            Name = "Laptop HP 14s-fq1080AU 4K0Z7PA (Ryzen 3-5300U/ 4GB / 256GB SSD/ 14' HD/ AMD Radeon/ Win10/ Silver/ 1 Yr)",
                            Price = 0.0,
                            RAM = "4GB (1x4GB) DDR4-3200Mhz (2 khe)",
                            VGA = "Radeon Vega Graphics"
                        },
                        new
                        {
                            Id = 4,
                            CPU = "Intel Core I3-1115G4",
                            Description = "l",
                            Drive = "256GB SSD",
                            Image = "/product/imgHomepage/250-22706-msi-14.jpg",
                            Monitor = "14 inch FHD 60 Hz",
                            Name = "Laptop MSI Modern 14 B11MOU-1027VN (I3-1115G4/ 8GB RAM / 256GB SSD/ 14' FHD, 60Hz/ VGA ON/ Win11/ Grey/ 1 Yr)",
                            Price = 0.0,
                            RAM = "8GB",
                            VGA = "Intel UHD Graphics"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}