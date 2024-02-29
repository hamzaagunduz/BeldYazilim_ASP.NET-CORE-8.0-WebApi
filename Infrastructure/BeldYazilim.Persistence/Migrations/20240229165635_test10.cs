using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleComments_ArticleCommentsArticleCommentID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleCommentsArticleCommentID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleCommentsArticleCommentID",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "CommentID",
                table: "Articles",
                newName: "ArticleCommentID");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryName",
                table: "ArticleCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserInterest",
                columns: table => new
                {
                    UserInterestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserInterestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserInterestImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInterest", x => x.UserInterestID);
                    table.ForeignKey(
                        name: "FK_UserInterest_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCommentID",
                table: "Articles",
                column: "ArticleCommentID");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterest_AppUserID",
                table: "UserInterest",
                column: "AppUserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleComments_ArticleCommentID",
                table: "Articles",
                column: "ArticleCommentID",
                principalTable: "ArticleComments",
                principalColumn: "ArticleCommentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleComments_ArticleCommentID",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "UserInterest");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleCommentID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "ArticleCategories");

            migrationBuilder.RenameColumn(
                name: "ArticleCommentID",
                table: "Articles",
                newName: "CommentID");

            migrationBuilder.AddColumn<int>(
                name: "ArticleCommentsArticleCommentID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCommentsArticleCommentID",
                table: "Articles",
                column: "ArticleCommentsArticleCommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleComments_ArticleCommentsArticleCommentID",
                table: "Articles",
                column: "ArticleCommentsArticleCommentID",
                principalTable: "ArticleComments",
                principalColumn: "ArticleCommentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
