using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizLookupApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Industry = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Hours = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Hours", "Industry", "Name", "Phone", "URL" },
                values: new object[,]
                {
                    { 1, "Newberg, Oregon", "8am-6pm, 7 days/Week", "Retail", "Blue Dolphin Wash", null, null },
                    { 2, "Tualatin, Oregon", "8am-6pm, Mon-Fri", "Food & Beverage", "Christian's Bakery", null, null },
                    { 3, "Newberg, Oregon", "24 Hours/Day, 7 days/week", "Retail", "Alaska Airlines", null, null },
                    { 4, "Wilsonville, Oregon", "8am-5pm, 7 days/Week", "Hospitality", "RV's To-Go", null, null },
                    { 5, "Wilsonville, Oregon", "8am-6pm, Mon-Thurs", "Retail", "Chanel's Hair Choppin", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
