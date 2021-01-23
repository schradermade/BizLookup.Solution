using Microsoft.EntityFrameworkCore.Migrations;

namespace BizLookupApi.Migrations
{
    public partial class AddURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Businesses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Businesses");
        }
    }
}
