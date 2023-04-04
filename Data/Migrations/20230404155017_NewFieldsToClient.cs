using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesSystem_AP1_Levid.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewFieldsToClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdentificationNumber",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Clients",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Clients");
        }
    }
}
