﻿// <auto-generated />
using System;
using BackEndProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEndProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEndProject.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "banner-1.png"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "banner-2.png"
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.HasIndex("UserId1");

                    b.ToTable("BasketItem");
                });

            modelBuilder.Entity("BackEndProject.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmerikanExpress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Google")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayPal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Support")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmerikanExpress = "",
                            Discover = "",
                            Email = "Faridmma@code.edu.az",
                            Facebook = "https://www.facebook.com",
                            Google = "https://www.google.com",
                            ImageUrl = "logo.png",
                            Instagram = "https://www.instagram.com",
                            Linkedin = "https://www.linkedin.com",
                            Location = "Bizim mehle Ordubad, 085 NMR AZE",
                            MasterCard = "",
                            PayPal = "",
                            Phone = "+994 50 671 99 99",
                            Support = "24/7 Support",
                            Visa = "",
                            WorkTime = "Mon-Sat 9:00pm - 5:00pm Sun:Closed"
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "category-1.jpg",
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "category-2.jpg",
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "category-3.jpg",
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "category-4.jpg",
                            Name = "Game Consoles"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "category-5.jpg",
                            Name = "Electronic"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "category-6.jpg",
                            Name = "TV"
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "category-7.jpg",
                            Name = "Audio & Video"
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "category-8.jpg",
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "category-9.jpg",
                            Name = "Meiset"
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "category-10.jpg",
                            Name = "Camera"
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "category-11.jpg",
                            Name = "Cib saati"
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "category-12.jpg",
                            Name = "AIR drop",
                            ParentId = 8
                        },
                        new
                        {
                            Id = 13,
                            Name = "Hot Categories",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 14,
                            Name = "OutherWear&Jacket",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 15,
                            Name = "Batteries",
                            ParentId = 9
                        },
                        new
                        {
                            Id = 16,
                            Name = "Chargers",
                            ParentId = 9
                        },
                        new
                        {
                            Id = 17,
                            Name = "Chargers",
                            ParentId = 9
                        },
                        new
                        {
                            Id = 18,
                            Name = "Bags & Cases",
                            ParentId = 9
                        },
                        new
                        {
                            Id = 19,
                            Name = "Electronic Cigarettes",
                            ParentId = 9
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BackEndProject.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("BackEndProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BestSeller")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DisCountPrice")
                        .HasColumnType("float");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NewArrivle")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StockCount")
                        .HasColumnType("int");

                    b.Property<double>("TaxPrecent")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BestSeller = false,
                            CategoryId = 1,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 70.0,
                            InStock = false,
                            IsFeatured = false,
                            Name = "Primitive Mens Premium Shoes",
                            NewArrivle = false,
                            Price = 80.0,
                            StockCount = 35,
                            TaxPrecent = 0.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 2,
                            BestSeller = false,
                            CategoryId = 2,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 80.0,
                            InStock = false,
                            IsFeatured = false,
                            Name = "Quickin Womans Premium Shoes",
                            NewArrivle = false,
                            Price = 90.0,
                            StockCount = 35,
                            TaxPrecent = 0.0,
                            Title = "Lorem ipsum dolor sit amet"
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("BackEndProject.Models.ProductTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("BackEndProject.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "slider-1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "slider-2.jpg"
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.SliderContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Offer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SliderId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SliderId");

                    b.ToTable("SliderContents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                            Name = "Fulldive VR.",
                            Offer = "Save $120 when you buy",
                            SliderId = 1,
                            Title = "2020 Virtual Reality"
                        },
                        new
                        {
                            Id = 2,
                            Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                            Name = "Sony Bravia.",
                            Offer = "Save $120 when you buy",
                            SliderId = 2,
                            Title = "4K HDR Smart TV 43"
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("BackEndProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BackEndProject.Models.BasketItem", b =>
                {
                    b.HasOne("BackEndProject.Models.Product", "Product")
                        .WithMany("BasketItems")
                        .HasForeignKey("ProductId1");

                    b.HasOne("BackEndProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("BackEndProject.Models.Category", b =>
                {
                    b.HasOne("BackEndProject.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("BackEndProject.Models.Order", b =>
                {
                    b.HasOne("BackEndProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("BackEndProject.Models.OrderItem", b =>
                {
                    b.HasOne("BackEndProject.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEndProject.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndProject.Models.Product", b =>
                {
                    b.HasOne("BackEndProject.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndProject.Models.ProductImage", b =>
                {
                    b.HasOne("BackEndProject.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndProject.Models.ProductTag", b =>
                {
                    b.HasOne("BackEndProject.Models.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEndProject.Models.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndProject.Models.SliderContent", b =>
                {
                    b.HasOne("BackEndProject.Models.Slider", "Slider")
                        .WithMany()
                        .HasForeignKey("SliderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
