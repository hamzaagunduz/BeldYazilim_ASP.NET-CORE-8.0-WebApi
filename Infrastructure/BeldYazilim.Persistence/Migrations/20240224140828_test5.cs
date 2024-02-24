using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "ArticleImages");

            migrationBuilder.AddColumn<int>(
                name: "ArticleImageID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "ArticleCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleImageID",
                table: "Articles",
                column: "ArticleImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_CategoryID",
                table: "ArticleCategories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleCategories_Categories_CategoryID",
                table: "ArticleCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleImages_ArticleImageID",
                table: "Articles",
                column: "ArticleImageID",
                principalTable: "ArticleImages",
                principalColumn: "ArticleImageID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleCategories_Categories_CategoryID",
                table: "ArticleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleImages_ArticleImageID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleImageID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_ArticleCategories_CategoryID",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "ArticleImageID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "ArticleCategories");

            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "ArticleImages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
