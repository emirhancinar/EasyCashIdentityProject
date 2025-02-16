using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_customer_accounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CustomerAccounts");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "CustomerAccounts",
                newName: "CustomerAccountCurrency");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerAccountCurrency",
                table: "CustomerAccounts",
                newName: "MyProperty");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CustomerAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
