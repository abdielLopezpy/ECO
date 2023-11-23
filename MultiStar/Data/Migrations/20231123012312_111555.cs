using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appDash.Data.Migrations
{
    /// <inheritdoc />
    public partial class _111555 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Products_ProductId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_ProductId",
                table: "Purchase");

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "Purchase",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Purchase");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ProductId",
                table: "Purchase",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Products_ProductId",
                table: "Purchase",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
