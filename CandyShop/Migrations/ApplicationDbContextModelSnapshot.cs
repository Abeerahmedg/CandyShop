﻿// <auto-generated />
using System;
using CandyShop.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CandyShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CandyShop.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6c690538-d619-4b4c-8201-a3a7030a3796",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dc24ff5f-e69a-47ef-9e47-0994094c1569",
                            CustomerFName = "Admin",
                            CustomerLName = "Adminsson",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL:COM",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEBtQTLr23BBt8U/Q6ZXFJZlSpS3qewnltDlJr0IQ98q8sGqmo7zVWulUWpHJzgS8mw==",
                            PhoneNumber = "0737555555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6cf9ddd7-36b3-4de1-a0c9-48e77abd5a07",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "fe72e58e-9e6c-45ac-a909-bc30fb2e4640",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "872be3cb-1015-4672-8d9c-9f700fa74b7f",
                            CustomerFName = "User",
                            CustomerLName = "Usersson",
                            Email = "user@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@GMAIL:COM",
                            NormalizedUserName = "user@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEG0G3Jm/nr06P2tvsYYPn+85vVbRHN9xrrkD7r5qEC+JUwCTuH3vUebRy4lW+nxWhg==",
                            PhoneNumber = "0737555555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1525d85-fa15-4cd1-804a-860ab9e11689",
                            TwoFactorEnabled = false,
                            UserName = "user@gmail.com"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandyId"), 1L, 1);

                    b.Property<int>("CandyCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CandyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandyImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CandyPrice")
                        .HasColumnType("float");

                    b.Property<int>("CandyQuantity")
                        .HasColumnType("int");

                    b.HasKey("CandyId");

                    b.HasIndex("CandyCategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CandyCategoryId = 1,
                            CandyDescription = "Caramels are made by cooking sugar and water together",
                            CandyImage = "Choklad1.jpg",
                            CandyName = "Coffee Rio",
                            CandyPrice = 5.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 2,
                            CandyCategoryId = 1,
                            CandyDescription = "A tasty Caramel and sugary Crunch",
                            CandyImage = "Choklad2.png",
                            CandyName = "Caramel Crunch",
                            CandyPrice = 15.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 3,
                            CandyCategoryId = 1,
                            CandyDescription = "The Vanila taste with the sweet of caramel",
                            CandyImage = "Choklad3.jpg",
                            CandyName = "Vanilla Caramel",
                            CandyPrice = 10.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 4,
                            CandyCategoryId = 1,
                            CandyDescription = "The Vanilla taste with the sweet of caramel",
                            CandyImage = "Choklad4.jpg",
                            CandyName = "Caramel Squares",
                            CandyPrice = 10.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 5,
                            CandyCategoryId = 1,
                            CandyDescription = "Combination of nuts and the sweet of caramel",
                            CandyImage = "Choklad5.jpg",
                            CandyName = "Nut Caramel",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 6,
                            CandyCategoryId = 2,
                            CandyDescription = "Tastey colorful chocolate",
                            CandyImage = "Gele1.jpg",
                            CandyName = "M&Ms",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 7,
                            CandyCategoryId = 2,
                            CandyDescription = "A mini full of flavor chocolate",
                            CandyImage = "Gele2.jpg",
                            CandyName = "Kit Kat",
                            CandyPrice = 11.0,
                            CandyQuantity = 45
                        },
                        new
                        {
                            CandyId = 8,
                            CandyCategoryId = 2,
                            CandyDescription = "Combination of Almond and the sweet of chocolate",
                            CandyImage = "Gele3.jpg",
                            CandyName = "Almond Joy",
                            CandyPrice = 16.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 9,
                            CandyCategoryId = 2,
                            CandyDescription = "Combination of Cherries flavor and the sweet of chocolate",
                            CandyImage = "Gele4.jpg",
                            CandyName = "Chocolate Cherries",
                            CandyPrice = 15.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 10,
                            CandyCategoryId = 2,
                            CandyDescription = "Biscute Coverd of chocolate",
                            CandyImage = "Gele5.jpg",
                            CandyName = "Krackle",
                            CandyPrice = 11.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 11,
                            CandyCategoryId = 2,
                            CandyDescription = "Combination of nuts and the sweet of chocolate",
                            CandyImage = "Gele2.jpg",
                            CandyName = "Snickers",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 12,
                            CandyCategoryId = 3,
                            CandyDescription = "Gummies are gelatin based chewy candies",
                            CandyImage = "Karamell1.jpg",
                            CandyName = "Gummi Cheries",
                            CandyPrice = 18.0,
                            CandyQuantity = 55
                        },
                        new
                        {
                            CandyId = 13,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With different flavors",
                            CandyImage = "Karamell2.jpg",
                            CandyName = "Gummi worms",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 14,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With cola flavor",
                            CandyImage = "Karamell3.jpg",
                            CandyName = "Gummi cola bottles",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 15,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With stawberry flavor",
                            CandyImage = "Karamell4.jpg",
                            CandyName = "Gummi strawberry",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 16,
                            CandyCategoryId = 3,
                            CandyDescription = "Chewy candies With banana flavor",
                            CandyImage = "Karamell5.jpg",
                            CandyName = "Gummi banana",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 17,
                            CandyCategoryId = 4,
                            CandyDescription = "Licorice is a semi-soft candy",
                            CandyImage = "Klubba1.jpg",
                            CandyName = "Red Vines",
                            CandyPrice = 20.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 18,
                            CandyCategoryId = 4,
                            CandyDescription = "Licorice is a semi-soft candy with cherry flavor",
                            CandyImage = "Klubba2.jpg",
                            CandyName = "Twizzler",
                            CandyPrice = 20.0,
                            CandyQuantity = 50
                        },
                        new
                        {
                            CandyId = 19,
                            CandyCategoryId = 4,
                            CandyDescription = "A hard sweet candy",
                            CandyImage = "Klubba3.jpg",
                            CandyName = "Chupa Chups",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 20,
                            CandyCategoryId = 4,
                            CandyDescription = "A sour candy",
                            CandyImage = "Klubba4.jpg",
                            CandyName = "Sour Punch",
                            CandyPrice = 13.0,
                            CandyQuantity = 30
                        },
                        new
                        {
                            CandyId = 21,
                            CandyCategoryId = 4,
                            CandyDescription = "A sour candy",
                            CandyImage = "Klubba5.jpg",
                            CandyName = "Warheads",
                            CandyPrice = 15.0,
                            CandyQuantity = 40
                        },
                        new
                        {
                            CandyId = 22,
                            CandyCategoryId = 4,
                            CandyDescription = "Chewy sweet candy",
                            CandyImage = "Klubba6.jpg",
                            CandyName = "Abba-Zaba",
                            CandyPrice = 10.0,
                            CandyQuantity = 70
                        },
                        new
                        {
                            CandyId = 23,
                            CandyCategoryId = 4,
                            CandyDescription = "Chewy sweet candy",
                            CandyImage = "Klubba7.jpg",
                            CandyName = "Sky Bar",
                            CandyPrice = 5.0,
                            CandyQuantity = 60
                        },
                        new
                        {
                            CandyId = 24,
                            CandyCategoryId = 4,
                            CandyDescription = "Chewy with peach flavor candy",
                            CandyImage = "Klubba8.jpg",
                            CandyName = "Peach Blossoms",
                            CandyPrice = 10.0,
                            CandyQuantity = 50
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<string>("CustomerCartId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerCartId")
                        .IsUnique()
                        .HasFilter("[CustomerCartId] IS NOT NULL");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            CartId = 1,
                            CustomerCartId = "6c690538-d619-4b4c-8201-a3a7030a3796"
                        },
                        new
                        {
                            CartId = 2,
                            CustomerCartId = "fe72e58e-9e6c-45ac-a909-bc30fb2e4640"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryImage = "category1",
                            CategoryName = "Chocolate"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryImage = "category2",
                            CategoryName = "Gummies"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryImage = "category3",
                            CategoryName = "Hard Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryImage = "category4",
                            CategoryName = "Lollipops"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.ItemOrder", b =>
                {
                    b.Property<int>("ItemOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemOrderId"), 1L, 1);

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("CandyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandyPrice")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemOrderId");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.ToTable("ItemOrders");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e7c3605b-0233-4cd7-9a04-4238353e39b1",
                            ConcurrencyStamp = "8f604b0c-6002-4f3e-b83c-9f4907dc205a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c71ca0b5-fafd-48ff-94d4-d57e78f0548b",
                            ConcurrencyStamp = "e7653901-dc09-4e76-96d0-d2126e2cf529",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "6c690538-d619-4b4c-8201-a3a7030a3796",
                            RoleId = "e7c3605b-0233-4cd7-9a04-4238353e39b1"
                        },
                        new
                        {
                            UserId = "fe72e58e-9e6c-45ac-a909-bc30fb2e4640",
                            RoleId = "c71ca0b5-fafd-48ff-94d4-d57e78f0548b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CandyCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CandyShop.Models.Cart", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("CandyShop.Models.Cart", "CustomerCartId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CandyShop.Models.ItemOrder", b =>
                {
                    b.HasOne("CandyShop.Models.Cart", "Cart")
                        .WithMany("ItemOrders")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CandyShop.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CandyShop.Models.Cart", b =>
                {
                    b.Navigation("ItemOrders");
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Navigation("Candies");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
