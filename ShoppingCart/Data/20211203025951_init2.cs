using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Items",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
