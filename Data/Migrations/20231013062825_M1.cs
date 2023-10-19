using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewsLetter6.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetterTitles",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetterTitles", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "NewsletterArticles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleIdInTheTitle = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    Picture = table.Column<string>(type: "TEXT", nullable: true),
                    TitleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsletterArticles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_NewsletterArticles_NewsLetterTitles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "NewsLetterTitles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "NewsLetterTitles",
                columns: new[] { "TitleId", "IsActive", "TitleDate" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 13, 23, 28, 25, 249, DateTimeKind.Local).AddTicks(7708) },
                    { 2, true, new DateTime(2023, 10, 14, 23, 28, 25, 249, DateTimeKind.Local).AddTicks(7797) },
                    { 3, true, new DateTime(2023, 10, 15, 23, 28, 25, 249, DateTimeKind.Local).AddTicks(7805) }
                });

            migrationBuilder.InsertData(
                table: "NewsletterArticles",
                columns: new[] { "ArticleId", "ArticleIdInTheTitle", "Description", "Name", "Picture", "TitleId" },
                values: new object[,]
                {
                    { 1, 1, "Although compact solar panels have been around for a while, the new foldable variety offers more convenience and flexibility. You can market foldable solar panels to various audiences, from the digital nomad hoping to get some work done on the beach to the backpacker heading into the wilderness. And consider selling them as part of a kit that includes cables, batteries, and converters—users will need these to store electricity for later use.", "Foldable solar panel", "/img/image1.jpg", 1 },
                    { 2, 2, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image2.jpg", 1 },
                    { 3, 1, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image2.jpg", 2 },
                    { 4, 2, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image2.jpg", 2 },
                    { 5, 3, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image2.jpg", 2 },
                    { 6, 1, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image2.jpg", 3 },
                    { 7, 2, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image2.jpg", 3 },
                    { 8, 3, "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!", "Reusable straws", "/img/image1.jpg", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterArticles_TitleId",
                table: "NewsletterArticles",
                column: "TitleId");
        }

        /// <inheritdoc />
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
                name: "NewsletterArticles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "NewsLetterTitles");
        }
    }
}
