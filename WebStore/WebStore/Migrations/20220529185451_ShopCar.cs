using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class ShopCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebStoreCarItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    WebStoreCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebStoreCarItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_WebStoreCarItems_Car_carid",
                        column: x => x.carid,
                        principalTable: "Car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebStoreCarItems_carid",
                table: "WebStoreCarItems",
                column: "carid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebStoreCarItems");
        }
    }
}
