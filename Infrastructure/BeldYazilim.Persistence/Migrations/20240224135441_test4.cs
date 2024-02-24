using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_AppUserID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AppUserID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "ArticleAuthors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ArticleAuthors_AppUserID",
                table: "ArticleAuthors",
                column: "AppUserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleAuthors_AspNetUsers_AppUserID",
                table: "ArticleAuthors",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleAuthors_AspNetUsers_AppUserID",
                table: "ArticleAuthors");

            migrationBuilder.DropIndex(
                name: "IX_ArticleAuthors_AppUserID",
                table: "ArticleAuthors");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "ArticleAuthors");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AppUserID",
                table: "Articles",
                column: "AppUserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AppUserID",
                table: "Articles",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
