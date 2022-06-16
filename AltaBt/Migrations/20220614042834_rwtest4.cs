using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaBt.Migrations
{
    public partial class rwtest4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentUsernameHV",
                table: "tests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherUsernameGV",
                table: "tests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tests_StudentUsernameHV",
                table: "tests",
                column: "StudentUsernameHV");

            migrationBuilder.CreateIndex(
                name: "IX_tests_TeacherUsernameGV",
                table: "tests",
                column: "TeacherUsernameGV");

            migrationBuilder.AddForeignKey(
                name: "FK_tests_Students_StudentUsernameHV",
                table: "tests",
                column: "StudentUsernameHV",
                principalTable: "Students",
                principalColumn: "UsernameHV");

            migrationBuilder.AddForeignKey(
                name: "FK_tests_Teachers_TeacherUsernameGV",
                table: "tests",
                column: "TeacherUsernameGV",
                principalTable: "Teachers",
                principalColumn: "UsernameGV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tests_Students_StudentUsernameHV",
                table: "tests");

            migrationBuilder.DropForeignKey(
                name: "FK_tests_Teachers_TeacherUsernameGV",
                table: "tests");

            migrationBuilder.DropIndex(
                name: "IX_tests_StudentUsernameHV",
                table: "tests");

            migrationBuilder.DropIndex(
                name: "IX_tests_TeacherUsernameGV",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "StudentUsernameHV",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "TeacherUsernameGV",
                table: "tests");
        }
    }
}
