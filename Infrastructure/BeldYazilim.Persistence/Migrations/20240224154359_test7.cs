using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleCategories_Categories_CategoryID",
                table: "ArticleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Comments_CommentID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductImage_ProductImageID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductShop_ProductShopID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductID",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSeller_AspNetUsers_AppUserID",
                table: "ProductSeller");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSeller_ProductShop_ProductShopID",
                table: "ProductSeller");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CommentID",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductShop",
                table: "ProductShop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSeller",
                table: "ProductSeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ProductShop",
                newName: "ProductShops");

            migrationBuilder.RenameTable(
                name: "ProductSeller",
                newName: "ProductSellers");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "ArticleParentCategoryID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "ArticleCategories",
                newName: "ArticleParentCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleCategories_CategoryID",
                table: "ArticleCategories",
                newName: "IX_ArticleCategories_ArticleParentCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSeller_ProductShopID",
                table: "ProductSellers",
                newName: "IX_ProductSellers_ProductShopID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSeller_AppUserID",
                table: "ProductSellers",
                newName: "IX_ProductSellers_AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_ProductID",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductShopID",
                table: "Products",
                newName: "IX_Products_ProductShopID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductImageID",
                table: "Products",
                newName: "IX_Products_ProductImageID");

            migrationBuilder.AddColumn<int>(
                name: "ArticleCommentsArticleCommentID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductShops",
                table: "ProductShops",
                column: "ProductShopID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSellers",
                table: "ProductSellers",
                column: "ProductSellerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "ProductImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "ProductCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");

            migrationBuilder.CreateTable(
                name: "ArticleComments",
                columns: table => new
                {
                    ArticleCommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComments", x => x.ArticleCommentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCommentsArticleCommentID",
                table: "Articles",
                column: "ArticleCommentsArticleCommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleCategories_Categories_ArticleParentCategoryID",
                table: "ArticleCategories",
                column: "ArticleParentCategoryID",
                principalTable: "Categories",
                principalColumn: "ArticleParentCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleComments_ArticleCommentsArticleCommentID",
                table: "Articles",
                column: "ArticleCommentsArticleCommentID",
                principalTable: "ArticleComments",
                principalColumn: "ArticleCommentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductImages_ProductImageID",
                table: "Products",
                column: "ProductImageID",
                principalTable: "ProductImages",
                principalColumn: "ProductImageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductShops_ProductShopID",
                table: "Products",
                column: "ProductShopID",
                principalTable: "ProductShops",
                principalColumn: "ProductShopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSellers_AspNetUsers_AppUserID",
                table: "ProductSellers",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSellers_ProductShops_ProductShopID",
                table: "ProductSellers",
                column: "ProductShopID",
                principalTable: "ProductShops",
                principalColumn: "ProductShopID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleCategories_Categories_ArticleParentCategoryID",
                table: "ArticleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleComments_ArticleCommentsArticleCommentID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductImages_ProductImageID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductShops_ProductShopID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSellers_AspNetUsers_AppUserID",
                table: "ProductSellers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSellers_ProductShops_ProductShopID",
                table: "ProductSellers");

            migrationBuilder.DropTable(
                name: "ArticleComments");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleCommentsArticleCommentID",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductShops",
                table: "ProductShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSellers",
                table: "ProductSellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ArticleCommentsArticleCommentID",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "ProductShops",
                newName: "ProductShop");

            migrationBuilder.RenameTable(
                name: "ProductSellers",
                newName: "ProductSeller");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "ArticleParentCategoryID",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "ArticleParentCategoryID",
                table: "ArticleCategories",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleCategories_ArticleParentCategoryID",
                table: "ArticleCategories",
                newName: "IX_ArticleCategories_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSellers_ProductShopID",
                table: "ProductSeller",
                newName: "IX_ProductSeller_ProductShopID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSellers_AppUserID",
                table: "ProductSeller",
                newName: "IX_ProductSeller_AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductShopID",
                table: "Product",
                newName: "IX_Product_ProductShopID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductImageID",
                table: "Product",
                newName: "IX_Product_ProductImageID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ProductID",
                table: "ProductCategory",
                newName: "IX_ProductCategory_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductShop",
                table: "ProductShop",
                column: "ProductShopID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSeller",
                table: "ProductSeller",
                column: "ProductSellerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "ProductImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "ProductCategoryID");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CommentID",
                table: "Articles",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleCategories_Categories_CategoryID",
                table: "ArticleCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Comments_CommentID",
                table: "Articles",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "CommentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductImage_ProductImageID",
                table: "Product",
                column: "ProductImageID",
                principalTable: "ProductImage",
                principalColumn: "ProductImageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductShop_ProductShopID",
                table: "Product",
                column: "ProductShopID",
                principalTable: "ProductShop",
                principalColumn: "ProductShopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductID",
                table: "ProductCategory",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSeller_AspNetUsers_AppUserID",
                table: "ProductSeller",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSeller_ProductShop_ProductShopID",
                table: "ProductSeller",
                column: "ProductShopID",
                principalTable: "ProductShop",
                principalColumn: "ProductShopID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
