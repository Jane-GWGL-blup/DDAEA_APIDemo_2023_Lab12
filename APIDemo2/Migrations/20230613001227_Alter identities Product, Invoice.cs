using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDemo2.Migrations
{
    public partial class AlteridentitiesProductInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Subtotal",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Invoices");
        }
    }
}
