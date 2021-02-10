using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purchase_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Order_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Salesman_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_no);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersOrder_no = table.Column<int>(type: "int", nullable: true),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salesman_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_id);
                    table.ForeignKey(
                        name: "FK_Customers_Orders_OrdersOrder_no",
                        column: x => x.OrdersOrder_no,
                        principalTable: "Orders",
                        principalColumn: "Order_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salesman",
                columns: table => new
                {
                    Salesman_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersOrder_no = table.Column<int>(type: "int", nullable: true),
                    Customer_id = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commision = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salesman", x => x.Salesman_id);
                    table.ForeignKey(
                        name: "FK_Salesman_Customers_Customer_id",
                        column: x => x.Customer_id,
                        principalTable: "Customers",
                        principalColumn: "Customer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salesman_Orders_OrdersOrder_no",
                        column: x => x.OrdersOrder_no,
                        principalTable: "Orders",
                        principalColumn: "Order_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrdersOrder_no",
                table: "Customers",
                column: "OrdersOrder_no");

            migrationBuilder.CreateIndex(
                name: "IX_Salesman_Customer_id",
                table: "Salesman",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Salesman_OrdersOrder_no",
                table: "Salesman",
                column: "OrdersOrder_no");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salesman");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
