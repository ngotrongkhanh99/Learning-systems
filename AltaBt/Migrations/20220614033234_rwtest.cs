using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaBt.Migrations
{
    public partial class rwtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testId",
                table: "Classes");
        }
    }
}
