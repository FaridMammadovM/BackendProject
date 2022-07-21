﻿// <auto-generated />
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

            modelBuilder.Entity("BackEndProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mens"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Womens"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fabric"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Leather"
                        });
                });

            modelBuilder.Entity("BackEndProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DisCountPrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            CategoryId = 1,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 70.0,
                            ImageUrl = "product-1.jpg",
                            Name = "Primitive Mens Premium Shoes",
                            Price = 80.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 2,
                            Availability = true,
                            CategoryId = 2,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 80.0,
                            ImageUrl = "product-2.jpg",
                            Name = "Quickin Womans Premium Shoes",
                            Price = 90.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            CategoryId = 3,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 40.0,
                            ImageUrl = "product-3.jpg",
                            Name = "Rexpo Sports Premium Shoes",
                            Price = 50.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 4,
                            Availability = true,
                            CategoryId = 4,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 70.0,
                            ImageUrl = "product-4.jpg",
                            Name = "Primitive Fabric Premium Shoes",
                            Price = 75.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            CategoryId = 5,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 30.0,
                            ImageUrl = "product-5.jpg",
                            Name = "Primitive Leather slipper",
                            Price = 40.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 6,
                            Availability = true,
                            CategoryId = 1,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 80.0,
                            ImageUrl = "product-6.jpg",
                            Name = "Primitive Mens Premium Shoes",
                            Price = 90.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            CategoryId = 2,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 40.0,
                            ImageUrl = "product-7.jpg",
                            Name = "Primitive Womans Premium Shoes",
                            Price = 50.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 8,
                            Availability = true,
                            CategoryId = 3,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 70.0,
                            ImageUrl = "product-8.jpg",
                            Name = "Primitive Sports Premium Shoes",
                            Price = 75.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            CategoryId = 4,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 30.0,
                            ImageUrl = "product-9.jpg",
                            Name = "Primitive Fabric Premium Shoes",
                            Price = 40.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 10,
                            Availability = true,
                            CategoryId = 5,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 80.0,
                            ImageUrl = "product-10.jpg",
                            Name = "Primitive Leather Premium Shoes",
                            Price = 90.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            CategoryId = 2,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 40.0,
                            ImageUrl = "product-11.jpg",
                            Name = "Primitive Womans Premium Shoes",
                            Price = 50.0,
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 12,
                            Availability = true,
                            CategoryId = 3,
                            Count = 35,
                            Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                            DisCountPrice = 70.0,
                            ImageUrl = "product-12.jpg",
                            Name = "Primitive Sports Premium Shoes",
                            Price = 75.0,
                            Title = "Lorem ipsum dolor sit amet"
                        });
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

            modelBuilder.Entity("BackEndProject.Models.Product", b =>
                {
                    b.HasOne("BackEndProject.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
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
