using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfoAPI.Migrations
{
    public partial class addedtopointofintrest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PointOfIntrests",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PointOfIntrests");
        }
    }
}
