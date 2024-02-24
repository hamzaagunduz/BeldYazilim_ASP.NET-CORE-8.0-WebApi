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
    [Migration("20240224173248_test9")]
    partial class test9
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

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConfirmCode")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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

                    b.Property<int>("ArticleAuthorID")
                        .HasColumnType("int");

                    b.Property<int>("ArticleCommentsArticleCommentID")
                        .HasColumnType("int");

                    b.Property<int>("ArticleImageID")
                        .HasColumnType("int");

                    b.Property<string>("BigImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClickCount")
                        .HasColumnType("int");

                    b.Property<int>("CommentID")
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

                    b.HasIndex("ArticleCommentsArticleCommentID");

                    b.HasIndex("ArticleImageID");

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

                    b.Property<int>("ArticleID")
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

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleCategory", b =>
                {
                    b.Property<int>("ArticleCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleCategoryID"));

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<int>("ArticleParentCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleCategoryID");

                    b.HasIndex("ArticleID");

                    b.HasIndex("ArticleParentCategoryID");

                    b.ToTable("ArticleCategories");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleComment", b =>
                {
                    b.Property<int>("ArticleCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleCommentID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ArticleCommentID");

                    b.ToTable("ArticleComments");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleImage", b =>
                {
                    b.Property<int>("ArticleImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleImageID"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleImageID");

                    b.ToTable("ArticleImages");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleParentCategory", b =>
                {
                    b.Property<int>("ArticleParentCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleParentCategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleParentCategoryID");

                    b.ToTable("ArticleParentCategories");
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

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BasketID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("BasketItemID");

                    b.HasIndex("BasketID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("BasketItems");
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

                    b.Property<int>("ProductImageID")
                        .HasColumnType("int");

                    b.Property<int>("ProductShopID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductImageID");

                    b.HasIndex("ProductShopID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryID"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCategoryID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductCategories");
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

                    b.HasKey("ProductImageID");

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

                    b.Property<int>("ProductShopID")
                        .HasColumnType("int");

                    b.Property<int>("Profit")
                        .HasColumnType("int");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductSellerID");

                    b.HasIndex("AppUserID")
                        .IsUnique();

                    b.HasIndex("ProductShopID")
                        .IsUnique();

                    b.ToTable("ProductSellers");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductShop", b =>
                {
                    b.Property<int>("ProductShopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductShopID"));

                    b.Property<string>("ProducyShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductShopID");

                    b.ToTable("ProductShops");
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
                    b.HasOne("BeldYazilim.Domain.Entities.ArticleAuthor", "ArticleAuthors")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleAuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.ArticleComment", "ArticleComments")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleCommentsArticleCommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.ArticleImage", "ArticleImages")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticleAuthors");

                    b.Navigation("ArticleComments");

                    b.Navigation("ArticleImages");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleAuthor", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", "AppUser")
                        .WithOne("ArticleAuthors")
                        .HasForeignKey("BeldYazilim.Domain.Entities.ArticleAuthor", "AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleCategory", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.Article", "Article")
                        .WithMany("ArticleCategorys")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.ArticleParentCategory", "ArticleParentCategory")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("ArticleParentCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("ArticleParentCategory");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Basket", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.AppUser", "AppUser")
                        .WithOne("Baskets")
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
                        .WithOne("BasketItem")
                        .HasForeignKey("BeldYazilim.Domain.Entities.BasketItem", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Product", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.ProductImage", "ProductImage")
                        .WithMany("Products")
                        .HasForeignKey("ProductImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeldYazilim.Domain.Entities.ProductShop", "ProductShop")
                        .WithMany("Products")
                        .HasForeignKey("ProductShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductImage");

                    b.Navigation("ProductShop");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("BeldYazilim.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
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

                    b.HasOne("BeldYazilim.Domain.Entities.ProductShop", "ProductShop")
                        .WithOne("ProductSeller")
                        .HasForeignKey("BeldYazilim.Domain.Entities.ProductSeller", "ProductShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("ProductShop");
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
                    b.Navigation("ArticleAuthors")
                        .IsRequired();

                    b.Navigation("Baskets")
                        .IsRequired();

                    b.Navigation("ProductSeller")
                        .IsRequired();
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Article", b =>
                {
                    b.Navigation("ArticleCategorys");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleAuthor", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleComment", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleImage", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ArticleParentCategory", b =>
                {
                    b.Navigation("ArticleCategories");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Basket", b =>
                {
                    b.Navigation("BasketItems");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.Product", b =>
                {
                    b.Navigation("BasketItem")
                        .IsRequired();

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductImage", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BeldYazilim.Domain.Entities.ProductShop", b =>
                {
                    b.Navigation("ProductSeller")
                        .IsRequired();

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
