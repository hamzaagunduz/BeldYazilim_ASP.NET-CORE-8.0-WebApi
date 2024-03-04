using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeldYazilim.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductSellerID",
                table: "ProductShops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "ProductSellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductShops_ProductSellerID",
                table: "ProductShops",
                column: "ProductSellerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSellers_AppUserID",
                table: "ProductSellers",
                column: "AppUserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSellers_AppUsers_AppUserID",
                table: "ProductSellers",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductShops_ProductSellers_ProductSellerID",
                table: "ProductShops",
                column: "ProductSellerID",
                principalTable: "ProductSellers",
                principalColumn: "ProductSellerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSellers_AppUsers_AppUserID",
                table: "ProductSellers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductShops_ProductSellers_ProductSellerID",
                table: "ProductShops");

            migrationBuilder.DropIndex(
                name: "IX_ProductShops_ProductSellerID",
                table: "ProductShops");

            migrationBuilder.DropIndex(
                name: "IX_ProductSellers_AppUserID",
                table: "ProductSellers");

            migrationBuilder.DropColumn(
                name: "ProductSellerID",
                table: "ProductShops");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "ProductSellers");
        }
    }
}
