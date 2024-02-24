using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleAuthorID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "ArticleAuthors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleAuthorID",
                table: "Articles",
                column: "ArticleAuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleAuthors_ArticleAuthorID",
                table: "Articles",
                column: "ArticleAuthorID",
                principalTable: "ArticleAuthors",
                principalColumn: "ArticleAuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleAuthors_ArticleAuthorID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleAuthorID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleAuthorID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "ArticleAuthors");
        }
    }
}
