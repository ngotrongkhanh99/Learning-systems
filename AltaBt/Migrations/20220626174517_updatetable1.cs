using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaBt.Migrations
{
    public partial class updatetable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonhocIdMonhoc",
                table: "Bangdiem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bangdiem_MonhocIdMonhoc",
                table: "Bangdiem",
                column: "MonhocIdMonhoc");

            migrationBuilder.AddForeignKey(
                name: "FK_Bangdiem_Monhoc_MonhocIdMonhoc",
                table: "Bangdiem",
                column: "MonhocIdMonhoc",
                principalTable: "Monhoc",
                principalColumn: "IdMonhoc",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bangdiem_Monhoc_MonhocIdMonhoc",
                table: "Bangdiem");

            migrationBuilder.DropIndex(
                name: "IX_Bangdiem_MonhocIdMonhoc",
                table: "Bangdiem");

            migrationBuilder.DropColumn(
                name: "MonhocIdMonhoc",
                table: "Bangdiem");
        }
    }
}
