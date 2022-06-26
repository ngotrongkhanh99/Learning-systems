﻿// <auto-generated />
using System;
using AltaBt.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AltaBt.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AltaBt.Models.Baikiemtra", b =>
                {
                    b.Property<int>("IdKiemtra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdKiemtra"), 1L, 1);

                    b.Property<string>("Diem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LophocIdLophoc")
                        .HasColumnType("int");

                    b.Property<string>("TenGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenbaikiemtra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thoigian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKiemtra");

                    b.HasIndex("LophocIdLophoc");

                    b.ToTable("Baikiemtra");
                });

            modelBuilder.Entity("AltaBt.Models.Bangdiem", b =>
                {
                    b.Property<int>("IdBangdiem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBangdiem"), 1L, 1);

                    b.Property<int>("IdMonhoc")
                        .HasColumnType("int");

                    b.Property<int>("LophocIdLophoc")
                        .HasColumnType("int");

                    b.Property<int>("MonhocIdMonhoc")
                        .HasColumnType("int");

                    b.Property<string>("Nhanxet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDiem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBangdiem");

                    b.HasIndex("LophocIdLophoc");

                    b.HasIndex("MonhocIdMonhoc");

                    b.ToTable("Bangdiem");
                });

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

            modelBuilder.Entity("AltaBt.Models.Khoahoc", b =>
                {
                    b.Property<int>("IdKhoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdKhoa"), 1L, 1);

                    b.Property<int>("LophocIdLophoc")
                        .HasColumnType("int");

                    b.Property<string>("Tenkhoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaybatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayketthuc")
                        .HasColumnType("datetime2");

                    b.HasKey("IdKhoa");

                    b.HasIndex("LophocIdLophoc");

                    b.ToTable("Khoahoc");
                });

            modelBuilder.Entity("AltaBt.Models.Lophoc", b =>
                {
                    b.Property<int>("IdLophoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLophoc"), 1L, 1);

                    b.Property<string>("Giangvien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Malop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maphonghoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaybatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayketthuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("trangthai")
                        .HasColumnType("int");

                    b.HasKey("IdLophoc");

                    b.ToTable("Lophoc");
                });

            modelBuilder.Entity("AltaBt.Models.Monhoc", b =>
                {
                    b.Property<int>("IdMonhoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMonhoc"), 1L, 1);

                    b.Property<string>("Mamonhoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenmonhoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaybatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayketthuc")
                        .HasColumnType("datetime2");

                    b.HasKey("IdMonhoc");

                    b.ToTable("Monhoc");
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

                    b.Property<int>("PowerIdBangdiem")
                        .HasColumnType("int");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.HasKey("UsernameGV");

                    b.HasIndex("PowerIdBangdiem");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AltaBt.Models.User", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userid"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatkhauHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaikhoanHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AltaBt.Models.Baikiemtra", b =>
                {
                    b.HasOne("AltaBt.Models.Lophoc", "Lophoc")
                        .WithMany()
                        .HasForeignKey("LophocIdLophoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lophoc");
                });

            modelBuilder.Entity("AltaBt.Models.Bangdiem", b =>
                {
                    b.HasOne("AltaBt.Models.Lophoc", "Lophoc")
                        .WithMany()
                        .HasForeignKey("LophocIdLophoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AltaBt.Models.Monhoc", "Monhoc")
                        .WithMany()
                        .HasForeignKey("MonhocIdMonhoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lophoc");

                    b.Navigation("Monhoc");
                });

            modelBuilder.Entity("AltaBt.Models.Chat", b =>
                {
                    b.HasOne("AltaBt.Models.Lophoc", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("AltaBt.Models.Khoahoc", b =>
                {
                    b.HasOne("AltaBt.Models.Lophoc", "Lophoc")
                        .WithMany()
                        .HasForeignKey("LophocIdLophoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lophoc");
                });

            modelBuilder.Entity("AltaBt.Models.Teacher", b =>
                {
                    b.HasOne("AltaBt.Models.Bangdiem", "Power")
                        .WithMany()
                        .HasForeignKey("PowerIdBangdiem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Power");
                });
#pragma warning restore 612, 618
        }
    }
}
