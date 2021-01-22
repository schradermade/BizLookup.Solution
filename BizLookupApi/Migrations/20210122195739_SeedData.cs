using Microsoft.EntityFrameworkCore.Migrations;

namespace BizLookupApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Businesses",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Hours", "Industry", "Name" },
                values: new object[,]
                {
                    { 1, "Newberg, Oregon", "8am-6pm, 7 days/Week", "Retail", "Blue Dolphin Wash" },
                    { 2, "Tualatin, Oregon", "8am-6pm, Mon-Fri", "Food & Beverage", "Christian's Bakery" },
                    { 3, "Newberg, Oregon", "24 Hours/Day, 7 days/week", "Retail", "Alaska Airlines" },
                    { 4, "Wilsonville, Oregon", "8am-5pm, 7 days/Week", "Hospitality", "RV's To-Go" },
                    { 5, "Wilsonville, Oregon", "8am-6pm, Mon-Thurs", "Retail", "Chanel's Hair Choppin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Businesses",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
