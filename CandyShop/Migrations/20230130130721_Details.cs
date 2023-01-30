﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCartId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_CustomerCartId",
                        column: x => x.CustomerCartId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candies",
                columns: table => new
                {
                    CandyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandyCategoryId = table.Column<int>(type: "int", nullable: false),
                    CandyPrice = table.Column<double>(type: "float", nullable: false),
                    CandyQuantity = table.Column<int>(type: "int", nullable: false),
                    CandyImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candies", x => x.CandyId);
                    table.ForeignKey(
                        name: "FK_Candies_Categories_CandyCategoryId",
                        column: x => x.CandyCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemOrders",
                columns: table => new
                {
                    ItemOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandyId = table.Column<int>(type: "int", nullable: false),
                    CandyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrders", x => x.ItemOrderId);
                    table.ForeignKey(
                        name: "FK_ItemOrders_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c56233d-2178-4d45-a26b-2d840d5a2581", "8a616052-4d0d-4e5b-b506-4088ce3ccf35", "Admin", "ADMIN" },
                    { "82b58570-a134-486d-9d31-391ca6f639e8", "68bea74f-5f61-43a8-8904-e5045559fc2b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerFName", "CustomerLName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4d5fb0de-5f46-4d6a-a244-cf59790fd376", 0, "f3516bd2-4755-48a0-9e7c-2fefa2b0eb01", "User", "Usersson", "user@gmail.com", false, false, null, "USER@GMAIL:COM", "user@gmail.com", "AQAAAAEAACcQAAAAEHUt3+lddCzZ4luwyeWNi0zP8Y2yO+//009FcJkn+/9182gA49qgA21UMnlaFvfyNw==", "0737555555", false, "d633038e-d02d-487f-8576-a273b3c01f3f", false, "user@gmail.com" },
                    { "c6095346-c0f7-4d5e-94c6-234098988b09", 0, "34515740-e9af-4911-baaa-20e8265d138f", "Admin", "Adminsson", "admin@gmail.com", false, false, null, "ADMIN@GMAIL:COM", "admin@gmail.com", "AQAAAAEAACcQAAAAEKZhfddCCMQtv8caDtBxEfQw1r3vTJZCWNKTU8X0sJfcusfHvGyvwhcFnm74mpxJPA==", "0737555555", false, "0ac0d8ce-b7b3-4c8e-a4ac-0ad21fefe839", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[,]
                {
                    { 1, "category1", "Caramels" },
                    { 2, "category2", "Chocolate" },
                    { 3, "category3", "Gummies" },
                    { 4, "category4", "Combination" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "82b58570-a134-486d-9d31-391ca6f639e8", "4d5fb0de-5f46-4d6a-a244-cf59790fd376" },
                    { "3c56233d-2178-4d45-a26b-2d840d5a2581", "c6095346-c0f7-4d5e-94c6-234098988b09" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CandyCategoryId", "CandyDescription", "CandyImage", "CandyName", "CandyPrice", "CandyQuantity" },
                values: new object[,]
                {
                    { 1, 1, "Caramels made by cooking sugar and water together", "candy1", "Coffee Rio", 5.0, 50 },
                    { 2, 1, "A tasty Caramel and sugary Crunch", "candy2", "Caramel Crunch", 15.0, 50 },
                    { 3, 1, "The Vanila taste with the sweet of caramel", "candy3", "Vanilla Caramel", 10.0, 50 },
                    { 4, 1, "The Vanilla taste with the sweet of caramel", "candy4", "Caramel Square", 10.0, 50 },
                    { 5, 1, "Combination of nuts and the sweet of caramel", "candy5", "Nut Caramel", 15.0, 40 },
                    { 6, 2, "Tastey colorful chocolate", "candy6", "M&Ms", 15.0, 40 },
                    { 7, 2, "A mini full of flavor chocolate", "candy7", "Kit Kat", 11.0, 45 },
                    { 8, 2, "Combination of Almond and chocolate", "candy8", "Almond Joy", 16.0, 40 },
                    { 9, 2, "Combination of Cherries flavor and chocolate", "candy9", "Chocolate Cherry", 15.0, 50 },
                    { 10, 2, "Biscute Coverd of chocolate", "candy10", "Krackle", 11.0, 50 },
                    { 11, 2, "Combination of nuts and the sweet of chocolate", "candy11", "Snickers", 15.0, 40 },
                    { 12, 3, "Gummies are gelatin based chewy candies", "candy12", "Gummi Cherry", 18.0, 55 },
                    { 13, 3, "Chewy candies With different flavors", "candy13", "Gummi worms", 5.0, 60 },
                    { 14, 3, "Chewy candies With cola flavor", "candy14", "Gummi cola bottles", 5.0, 60 },
                    { 15, 3, "Chewy candies With stawberry flavor", "candy15", "Gummi strawberry", 5.0, 60 },
                    { 16, 3, "Chewy candies With banana flavor", "candy16", "Gummi banana", 5.0, 60 },
                    { 17, 4, "Licorice is a semi-soft candy", "candy17", "Red Vines", 20.0, 50 },
                    { 18, 4, "Licorice is a semi-soft candy with cherry flavor", "candy18", "Twizzler", 20.0, 50 },
                    { 19, 4, "A hard sweet candy", "candy19", "Chupa Chups", 15.0, 40 },
                    { 20, 4, "A sour candy", "candy20", "Sour Punch", 13.0, 30 },
                    { 21, 4, "A sour candy", "candy21", "Warheads", 15.0, 40 },
                    { 22, 4, "Chewy sweet candy", "candy22", "Abba-Zaba", 10.0, 70 },
                    { 23, 4, "Chewy sweet candy", "candy23", "Sky Bar", 5.0, 60 },
                    { 24, 4, "Chewy with peach flavor candy", "candy24", "Peach Blossoms", 10.0, 50 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "CustomerCartId" },
                values: new object[,]
                {
                    { 1, "c6095346-c0f7-4d5e-94c6-234098988b09" },
                    { 2, "4d5fb0de-5f46-4d6a-a244-cf59790fd376" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Candies_CandyCategoryId",
                table: "Candies",
                column: "CandyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerCartId",
                table: "Carts",
                column: "CustomerCartId",
                unique: true,
                filter: "[CustomerCartId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrders_CartId",
                table: "ItemOrders",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrders_OrderId",
                table: "ItemOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Candies");

            migrationBuilder.DropTable(
                name: "ItemOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}