using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesSystem_AP1_Levid.Data.Migrations
{
    /// <inheritdoc />
    public partial class SellerNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Sellers",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdentificationNumber",
                table: "Sellers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Sellers",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Sellers");
        }
    }
}
