using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConectPg.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_product_productid",
                table: "order");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "order",
                newName: "Productid");

            migrationBuilder.RenameIndex(
                name: "IX_order_productid",
                table: "order",
                newName: "IX_order_Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_order_product_Productid",
                table: "order",
                column: "Productid",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_product_Productid",
                table: "order");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "order",
                newName: "productid");

            migrationBuilder.RenameIndex(
                name: "IX_order_Productid",
                table: "order",
                newName: "IX_order_productid");

            migrationBuilder.AddForeignKey(
                name: "FK_order_product_productid",
                table: "order",
                column: "productid",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
