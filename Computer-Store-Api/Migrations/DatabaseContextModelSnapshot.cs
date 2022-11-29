﻿// <auto-generated />
using Computer_Store_Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Computer_Store_Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Image = "/product/test.jpg",
                            Monitor = "NVIDIA RTX3050Ti 4G",
                            Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                            Price = 0.0,
                            RAM = "16gb",
                            VGA = "NVIDIA RTX3050Ti 4G"
                        },
                        new
                        {
                            Id = 2,
                            CPU = "Intel Core i5 11400H",
                            Description = "l",
                            Drive = "512GB SSD",
                            Image = "/product/test.jpg",
                            Monitor = "NVIDIA RTX3050Ti 4G",
                            Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                            Price = 0.0,
                            RAM = "16gb",
                            VGA = "NVIDIA RTX3050Ti 4G"
                        },
                        new
                        {
                            Id = 3,
                            CPU = "Intel Core i5 11400H",
                            Description = "l",
                            Drive = "512GB SSD",
                            Image = "/product/test.jpg",
                            Monitor = "NVIDIA RTX3050Ti 4G",
                            Name = "Laptop Gigabyte Gaming G5 MD 51S1123SO ( i5-11400H/ 16GB/ 512GB SSD/ 15.6\" FHD/RTX3050Ti 4Gb/ Win11)",
                            Price = 0.0,
                            RAM = "16gb",
                            VGA = "NVIDIA RTX3050Ti 4G"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
