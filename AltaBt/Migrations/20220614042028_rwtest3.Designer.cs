﻿// <auto-generated />
using System;
using AltaBt.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AltaBt.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220614042028_rwtest3")]
    partial class rwtest3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AltaBt.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("AltaBt.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Security")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentUsernameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherUsernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsernameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("numberday")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("subjectID")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("StudentUsernameHV");

                    b.HasIndex("TeacherUsernameGV");

                    b.HasIndex("subjectID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("AltaBt.Models.Course", b =>
                {
                    b.Property<int>("Courses")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Courses"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("numberday")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_day")
                        .HasColumnType("datetime2");

                    b.HasKey("Courses");

                    b.HasIndex("ClassId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AltaBt.Models.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("AltaBt.Models.Student", b =>
                {
                    b.Property<string>("UsernameHV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.HasKey("UsernameHV");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AltaBt.Models.Subject", b =>
                {
                    b.Property<int>("subjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subjectID"), 1L, 1);

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("schedule")
                        .HasColumnType("datetime2");

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("subjectID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("AltaBt.Models.Teacher", b =>
                {
                    b.Property<string>("UsernameGV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PowerId")
                        .HasColumnType("int");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.HasKey("UsernameGV");

                    b.HasIndex("PowerId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AltaBt.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestId"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("NameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("subjectId")
                        .HasColumnType("int");

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("test")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("test_score")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("upcoming_test")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("AltaBt.Models.Chat", b =>
                {
                    b.HasOne("AltaBt.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("AltaBt.Models.Class", b =>
                {
                    b.HasOne("AltaBt.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentUsernameHV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AltaBt.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherUsernameGV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AltaBt.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("subjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AltaBt.Models.Course", b =>
                {
                    b.HasOne("AltaBt.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("AltaBt.Models.Teacher", b =>
                {
                    b.HasOne("AltaBt.Models.Power", "Power")
                        .WithMany()
                        .HasForeignKey("PowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Power");
                });
#pragma warning restore 612, 618
        }
    }
}
