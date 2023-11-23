using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appDash.Data.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdffyugyu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
