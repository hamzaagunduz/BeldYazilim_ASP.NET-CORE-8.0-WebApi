﻿// <auto-generated />
using System;
using BeldYazilim.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    [DbContext(typeof(BeldYazilimContext))]
    [Migration("20240311223020_FirstName")]
    partial class FirstName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeldYazilim.Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConfirmCode")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
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
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleID"));

                    b.Property<int?>("ArticleAuthorID")
                        .HasColumnType("int");

                    b.Property<string>("BigImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClickCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleID");

                    b.HasIndex("ArticleAuthorID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleAuthor", b =>
                {
                    b.Property<int>("ArticleAuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleAuthorID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleAuthorID");

                    b.HasIndex("AppUserID")
                        .IsUnique();

                    b.ToTable("ArticleAuthors");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleCategoryLink", b =>
                {
                    b.Property<int>("ArticleCategoryLinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleCategoryLinkID"));

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<int>("MainCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoryID")
                        .HasColumnType("int");

                    b.HasKey("ArticleCategoryLinkID");

                    b.HasIndex("ArticleID");

                    b.HasIndex("MainCategoryID");

                    b.HasIndex("SubcategoryID");

                    b.ToTable("ArticleCategoryLinks");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleComment", b =>
                {
                    b.Property<int>("ArticleCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleCommentID"));

                    b.Property<int?>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleCommentID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("ArticleID");

                    b.ToTable("ArticleComments");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleImage", b =>
                {
                    b.Property<int>("ArticleImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleImageID"));

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleImageID");

                    b.HasIndex("ArticleID");

                    b.ToTable("ArticleImages");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Basket", b =>
                {
                    b.Property<int>("BasketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.HasKey("BasketID");

                    b.HasIndex("AppUserID")
                        .IsUnique();

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.BasketItem", b =>
                {
                    b.Property<int>("BasketItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketItemID"));

                    b.Property<int>("BasketID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BasketItemID");

                    b.HasIndex("BasketID");

                    b.HasIndex("ProductID");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.MainCategory", b =>
                {
                    b.Property<int>("MainCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainCategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainCategoryID");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("BigImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductShopID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductShopID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCategoryID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductCategoryLink", b =>
                {
                    b.Property<int>("ProductCategoryLinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryLinkID"));

                    b.Property<int>("ProductCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ProductCategoryLinkID");

                    b.HasIndex("ProductCategoryID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductCategoryLinks");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductImage", b =>
                {
                    b.Property<int>("ProductImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImageID"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ProductImageID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductSeller", b =>
                {
                    b.Property<int>("ProductSellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductSellerID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("Profit")
                        .HasColumnType("int");

                    b.Property<int>("TaxNumber")
                        .HasColumnType("int");

                    b.HasKey("ProductSellerID");

                    b.HasIndex("AppUserID")
                        .IsUnique();

                    b.ToTable("ProductSellers");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductShop", b =>
                {
                    b.Property<int>("ProductShopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductShopID"));

                    b.Property<int>("ProductSellerID")
                        .HasColumnType("int");

                    b.Property<string>("ProducyShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductShopID");

                    b.HasIndex("ProductSellerID")
                        .IsUnique();

                    b.ToTable("ProductShops");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Subcategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryID"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("MainCategoryID");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Article", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.ArticleAuthor", "ArticleAuthor")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleAuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ArticleAuthor");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleAuthor", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", "AppUser")
                        .WithOne("ArticleAuthor")
                        .HasForeignKey("BeldYazilim.Domain.Entities.ArticleAuthor", "AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleCategoryLink", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.Article", "Article")
                        .WithMany("ArticleCategoryLinks")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.MainCategory", "MainCategory")
                        .WithMany("ArticleCategoryLinks")
                        .HasForeignKey("MainCategoryID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.Subcategory", "Subcategory")
                        .WithMany("ArticleCategoryLinks")
                        .HasForeignKey("SubcategoryID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("MainCategory");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleComment", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", "CommentedBy")
                        .WithMany("Comments")
                        .HasForeignKey("AppUserID");

                    b.HasOne("BeldYazilim.Domain.Entities.Article", "Article")
                        .WithMany("ArticleComments")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("CommentedBy");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleImage", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.Article", "Article")
                        .WithMany("Images")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Basket", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", "AppUser")
                        .WithOne("Basket")
                        .HasForeignKey("BeldYazilim.Domain.Entities.Basket", "AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.BasketItem", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.Basket", "Basket")
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.Product", "Product")
                        .WithMany("BasketItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Product", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.ProductShop", "ProductShop")
                        .WithMany("Products")
                        .HasForeignKey("ProductShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductShop");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductCategoryLink", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("ProductCategoryLinks")
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategoryLinks")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductImage", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductSeller", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", "AppUser")
                        .WithOne("ProductSeller")
                        .HasForeignKey("BeldYazilim.Domain.Entities.ProductSeller", "AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductShop", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.ProductSeller", "ProductSeller")
                        .WithOne("ProductShop")
                        .HasForeignKey("BeldYazilim.Domain.Entities.ProductShop", "ProductSellerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductSeller");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Subcategory", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("ArticleAuthor")
                        .IsRequired();

                    b.Navigation("Basket")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("ProductSeller")
                        .IsRequired();
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Article", b =>
                {
                    b.Navigation("ArticleCategoryLinks");

                    b.Navigation("ArticleComments");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleAuthor", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Basket", b =>
                {
                    b.Navigation("BasketItems");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.MainCategory", b =>
                {
                    b.Navigation("ArticleCategoryLinks");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Product", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("ProductCategoryLinks");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("ProductCategoryLinks");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductSeller", b =>
                {
                    b.Navigation("ProductShop")
                        .IsRequired();
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductShop", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Subcategory", b =>
                {
                    b.Navigation("ArticleCategoryLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
