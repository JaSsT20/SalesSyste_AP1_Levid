using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesSystem_AP1_Levid.Data.Migrations
{
    /// <inheritdoc />
    public partial class SellerIdNumber_ToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "Sellers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdentificationNumber",
                table: "Sellers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
