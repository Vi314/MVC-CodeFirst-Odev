using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Layout.Migrations
{
    public partial class AddedUsernamePropertyOnAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Accounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Accounts");
        }
    }
}
