using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "webStoreCartId",
                table: "WebStoreCarItems",
                newName: "WebStoreCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WebStoreCartId",
                table: "WebStoreCarItems",
                newName: "webStoreCartId");
        }
    }
}
