﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsLetter6.Data;

#nullable disable

namespace NewsLetter6.Data.Migrations
{
    [DbContext(typeof(NewsLetterContext))]
    partial class NewsLetterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NewsLetter6.Models.NewsLetterTitle", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TitleDate")
                        .HasColumnType("TEXT");

                    b.HasKey("TitleId");

                    b.ToTable("NewsLetterTitles", (string)null);

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            IsActive = true,
                            TitleDate = new DateTime(2023, 10, 13, 23, 28, 25, 249, DateTimeKind.Local).AddTicks(7708)
                        },
                        new
                        {
                            TitleId = 2,
                            IsActive = true,
                            TitleDate = new DateTime(2023, 10, 14, 23, 28, 25, 249, DateTimeKind.Local).AddTicks(7797)
                        },
                        new
                        {
                            TitleId = 3,
                            IsActive = true,
                            TitleDate = new DateTime(2023, 10, 15, 23, 28, 25, 249, DateTimeKind.Local).AddTicks(7805)
                        });
                });

            modelBuilder.Entity("NewsLetter6.Models.NewsletterArticle", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticleIdInTheTitle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .HasColumnType("TEXT");

                    b.Property<int>("TitleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticleId");

                    b.HasIndex("TitleId");

                    b.ToTable("NewsletterArticles", (string)null);

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            ArticleIdInTheTitle = 1,
                            Description = "Although compact solar panels have been around for a while, the new foldable variety offers more convenience and flexibility. You can market foldable solar panels to various audiences, from the digital nomad hoping to get some work done on the beach to the backpacker heading into the wilderness. And consider selling them as part of a kit that includes cables, batteries, and converters—users will need these to store electricity for later use.",
                            Name = "Foldable solar panel",
                            Picture = "/img/image1.jpg",
                            TitleId = 1
                        },
                        new
                        {
                            ArticleId = 2,
                            ArticleIdInTheTitle = 2,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image2.jpg",
                            TitleId = 1
                        },
                        new
                        {
                            ArticleId = 3,
                            ArticleIdInTheTitle = 1,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image2.jpg",
                            TitleId = 2
                        },
                        new
                        {
                            ArticleId = 4,
                            ArticleIdInTheTitle = 2,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image2.jpg",
                            TitleId = 2
                        },
                        new
                        {
                            ArticleId = 5,
                            ArticleIdInTheTitle = 3,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image2.jpg",
                            TitleId = 2
                        },
                        new
                        {
                            ArticleId = 6,
                            ArticleIdInTheTitle = 1,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image2.jpg",
                            TitleId = 3
                        },
                        new
                        {
                            ArticleId = 7,
                            ArticleIdInTheTitle = 2,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image2.jpg",
                            TitleId = 3
                        },
                        new
                        {
                            ArticleId = 8,
                            ArticleIdInTheTitle = 3,
                            Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                            Name = "Reusable straws",
                            Picture = "/img/image1.jpg",
                            TitleId = 3
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NewsLetter6.Models.NewsletterArticle", b =>
                {
                    b.HasOne("NewsLetter6.Models.NewsLetterTitle", "NewsletterTitle")
                        .WithMany("Articles")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewsletterTitle");
                });

            modelBuilder.Entity("NewsLetter6.Models.NewsLetterTitle", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
