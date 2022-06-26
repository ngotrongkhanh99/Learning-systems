using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaBt.Migrations
{
    public partial class updatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Classes_ClassId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Powers_PowerId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Powers");

            migrationBuilder.DropTable(
                name: "tests");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.RenameColumn(
                name: "PowerId",
                table: "Teachers",
                newName: "PowerIdBangdiem");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_PowerId",
                table: "Teachers",
                newName: "IX_Teachers_PowerIdBangdiem");

            migrationBuilder.CreateTable(
                name: "Lophoc",
                columns: table => new
                {
                    IdLophoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Malop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaybatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayketthuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trangthai = table.Column<int>(type: "int", nullable: false),
                    Maphonghoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giangvien = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lophoc", x => x.IdLophoc);
                });

            migrationBuilder.CreateTable(
                name: "Monhoc",
                columns: table => new
                {
                    IdMonhoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenmonhoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mamonhoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaybatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayketthuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monhoc", x => x.IdMonhoc);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaikhoanHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatkhauHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "Baikiemtra",
                columns: table => new
                {
                    IdKiemtra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LophocIdLophoc = table.Column<int>(type: "int", nullable: false),
                    TenGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thoigian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenbaikiemtra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baikiemtra", x => x.IdKiemtra);
                    table.ForeignKey(
                        name: "FK_Baikiemtra_Lophoc_LophocIdLophoc",
                        column: x => x.LophocIdLophoc,
                        principalTable: "Lophoc",
                        principalColumn: "IdLophoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bangdiem",
                columns: table => new
                {
                    IdBangdiem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nhanxet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LophocIdLophoc = table.Column<int>(type: "int", nullable: false),
                    IdMonhoc = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenHV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bangdiem", x => x.IdBangdiem);
                    table.ForeignKey(
                        name: "FK_Bangdiem_Lophoc_LophocIdLophoc",
                        column: x => x.LophocIdLophoc,
                        principalTable: "Lophoc",
                        principalColumn: "IdLophoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khoahoc",
                columns: table => new
                {
                    IdKhoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LophocIdLophoc = table.Column<int>(type: "int", nullable: false),
                    Tenkhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaybatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayketthuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoahoc", x => x.IdKhoa);
                    table.ForeignKey(
                        name: "FK_Khoahoc_Lophoc_LophocIdLophoc",
                        column: x => x.LophocIdLophoc,
                        principalTable: "Lophoc",
                        principalColumn: "IdLophoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baikiemtra_LophocIdLophoc",
                table: "Baikiemtra",
                column: "LophocIdLophoc");

            migrationBuilder.CreateIndex(
                name: "IX_Bangdiem_LophocIdLophoc",
                table: "Bangdiem",
                column: "LophocIdLophoc");

            migrationBuilder.CreateIndex(
                name: "IX_Khoahoc_LophocIdLophoc",
                table: "Khoahoc",
                column: "LophocIdLophoc");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Lophoc_ClassId",
                table: "Chats",
                column: "ClassId",
                principalTable: "Lophoc",
                principalColumn: "IdLophoc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Bangdiem_PowerIdBangdiem",
                table: "Teachers",
                column: "PowerIdBangdiem",
                principalTable: "Bangdiem",
                principalColumn: "IdBangdiem",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Lophoc_ClassId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Bangdiem_PowerIdBangdiem",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Baikiemtra");

            migrationBuilder.DropTable(
                name: "Bangdiem");

            migrationBuilder.DropTable(
                name: "Khoahoc");

            migrationBuilder.DropTable(
                name: "Monhoc");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Lophoc");

            migrationBuilder.RenameColumn(
                name: "PowerIdBangdiem",
                table: "Teachers",
                newName: "PowerId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_PowerIdBangdiem",
                table: "Teachers",
                newName: "IX_Teachers_PowerId");

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    UsernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.UsernameHV);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    subjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.subjectID);
                });

            migrationBuilder.CreateTable(
                name: "tests",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentUsernameHV = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TeacherUsernameGV = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    NameGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    subjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    test = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    test_score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upcoming_test = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tests", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_tests_Students_StudentUsernameHV",
                        column: x => x.StudentUsernameHV,
                        principalTable: "Students",
                        principalColumn: "UsernameHV");
                    table.ForeignKey(
                        name: "FK_tests_Teachers_TeacherUsernameGV",
                        column: x => x.TeacherUsernameGV,
                        principalTable: "Teachers",
                        principalColumn: "UsernameGV");
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentUsernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subjectID = table.Column<int>(type: "int", nullable: false),
                    TeacherUsernameGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Security = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsernameGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsernameHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numberday = table.Column<int>(type: "int", nullable: false),
                    start_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Classes_Students_StudentUsernameHV",
                        column: x => x.StudentUsernameHV,
                        principalTable: "Students",
                        principalColumn: "UsernameHV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_subjectID",
                        column: x => x.subjectID,
                        principalTable: "Subjects",
                        principalColumn: "subjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherUsernameGV",
                        column: x => x.TeacherUsernameGV,
                        principalTable: "Teachers",
                        principalColumn: "UsernameGV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Courses = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numberday = table.Column<int>(type: "int", nullable: false),
                    start_day = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Courses);
                    table.ForeignKey(
                        name: "FK_Courses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_StudentUsernameHV",
                table: "Classes",
                column: "StudentUsernameHV");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_subjectID",
                table: "Classes",
                column: "subjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherUsernameGV",
                table: "Classes",
                column: "TeacherUsernameGV");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassId",
                table: "Courses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tests_StudentUsernameHV",
                table: "tests",
                column: "StudentUsernameHV");

            migrationBuilder.CreateIndex(
                name: "IX_tests_TeacherUsernameGV",
                table: "tests",
                column: "TeacherUsernameGV");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Classes_ClassId",
                table: "Chats",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Powers_PowerId",
                table: "Teachers",
                column: "PowerId",
                principalTable: "Powers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
