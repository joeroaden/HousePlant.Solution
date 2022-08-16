﻿// <auto-generated />
using HousePlant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HousePlant.Migrations
{
    [DbContext(typeof(HousePlantContext))]
    partial class HousePlantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HousePlant.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommonName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Humidity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Propagation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Soil")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sunlight")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TempMax")
                        .HasColumnType("int");

                    b.Property<int>("TempMin")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Water")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");
                });
#pragma warning restore 612, 618
        }
    }
}
