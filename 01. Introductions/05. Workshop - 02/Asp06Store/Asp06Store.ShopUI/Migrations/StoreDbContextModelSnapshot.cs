﻿// <auto-generated />
using System;
using Asp06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp06Store.ShopUI.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.1.21452.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Mobile",
                            Description = "One small reduction of the notch, one giant leap for the iPhone! That's the best description for the most minor iPhone upgrade yet - the Apple iPhone 13.",
                            Name = "Apple iPhone 13",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 2,
                            Category = "Mobile",
                            Description = "Glass front, plastic frame, plastic back 1080 x 2408 pixels, 20:9 ratio (~400 ppi density)",
                            Name = "Samsung Galaxy F42 5G",
                            Price = 25000000
                        },
                        new
                        {
                            Id = 3,
                            Category = "Mobile",
                            Description = "2021, September 30 6.53 inches, 102.9 cm2 (~81.0% screen-to-body ratio) Octa-core (4x2.3 GHz Cortex-A53 & 4x1.8 GHz Cortex-A53)",
                            Name = "Xiaomi Poco C31",
                            Price = 8000000
                        },
                        new
                        {
                            Id = 4,
                            Category = "Mobile",
                            Description = "Qualcomm SM7125 Snapdragon 720G (8 nm)  Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot",
                            Name = "Xiaomi Redmi Note 10 Lite",
                            Price = 10000000
                        },
                        new
                        {
                            Id = 5,
                            Category = "Laptop",
                            Description = "Life is brighter and clearer with Zenbook 14X OLED, the slim, light and compact laptop with a gorgeous 16:10 4K OLED HDR NanoEdge touchscreen that gives you the deepest blacks and the most vivid colours.",
                            Name = "ASUS Zenbook 14X OLED",
                            Price = 45000000
                        },
                        new
                        {
                            Id = 6,
                            Category = "Laptop",
                            Description = "ASUS ExpertBook B7 Flip is an enterprise-level, 5G-enabled premium laptop that’s designed to accelerate your business1. Working on the go is easier than ever with a lightning-fast data",
                            Name = "ASUS ExpertBook B7",
                            Price = 33000000
                        },
                        new
                        {
                            Id = 7,
                            Category = "Laptop",
                            Description = "Turn your creative vision into reality with the ProArt Studiobook 16 studio laptop: it pushes every boundary to give you the effortless creative experience you’ve always wanted, but never thought possible. With a certified color-accurate 16-inch 120 Hz 2.5K IPS",
                            Name = "ProArt Studiobook 16",
                            Price = 53000000
                        },
                        new
                        {
                            Id = 8,
                            Category = "PC",
                            Description = "Professional Monitor – 27-inch, IPS, WQHD (2560 x 1440), 100% sRGB, 100% Rec. 709, Color Accuracy ΔE < 2, Calman Verified, USB-C, DisplayPort Daisy-chaining, ProArt Preset, ProArt Palette, Ergonomic Stand",
                            Name = "ASUS ProArt Display PA278CV",
                            Price = 38000000
                        },
                        new
                        {
                            Id = 9,
                            Category = "PC",
                            Description = "With a slim 8.5 mm (0.3-inch) profile and tipping the scales at just 800g (1.76 pounds), the MB169B+ is the world’s slimmest and lightest companion display, ideal for a simple on-the-go dual-monitor setup and mobile presentations.",
                            Name = "Sleek and ultra-portable with a Zen-inspired design",
                            Price = 19000000
                        },
                        new
                        {
                            Id = 10,
                            Category = "PC",
                            Description = "ASUS Mini PC PN62 is an ultracompact computer that delivers powerful performance for a wide variety of home and business applications. Featuring the latest 10th Generation Intel® Core™ processors and support for high-speed 2666 MHz DDR4 memory, Mini PC PN62 is ready to take on demanding workloads, yet its diminutive size takes up",
                            Name = "Ultracompact mini PC ",
                            Price = 12000000
                        });
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.OrderDetail", b =>
                {
                    b.HasOne("Asp06Store.ShopUI.Models.Order", null)
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("Asp06Store.ShopUI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
