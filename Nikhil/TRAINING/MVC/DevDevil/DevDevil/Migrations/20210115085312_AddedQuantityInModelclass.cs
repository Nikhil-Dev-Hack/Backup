using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDevil.Migrations
{
    public partial class AddedQuantityInModelclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Pies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");
        }
    }
}
