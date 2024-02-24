using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AppUserID",
                table: "Articles",
                column: "AppUserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CommentID",
                table: "Articles",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AppUserID",
                table: "Articles",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Comments_CommentID",
                table: "Articles",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "CommentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_AppUserID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Comments_CommentID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AppUserID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CommentID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
