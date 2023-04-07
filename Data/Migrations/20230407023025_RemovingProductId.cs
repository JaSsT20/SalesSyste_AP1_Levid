using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesSystem_AP1_Levid.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovingProductId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Sales");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
