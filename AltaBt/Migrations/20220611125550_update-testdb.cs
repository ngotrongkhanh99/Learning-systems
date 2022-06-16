using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaBt.Migrations
{
    public partial class updatetestdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
           name: "TestId",
           table: "Classes",
           schema: "dbo");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testId",
                table: "Classes");
        }
    }
}
