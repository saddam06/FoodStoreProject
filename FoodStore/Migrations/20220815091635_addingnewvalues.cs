using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodStore.Migrations
{
    public partial class addingnewvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Products",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "Products",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "Products");
        }
    }
}
