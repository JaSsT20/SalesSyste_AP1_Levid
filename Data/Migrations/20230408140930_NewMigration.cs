using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesSystem_AP1_Levid.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalProductsSold",
                table: "Sellers");

            migrationBuilder.AddColumn<float>(
                name: "TotalSold",
                table: "Sellers",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "Sales",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSold",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "TotalProductsSold",
                table: "Sellers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
