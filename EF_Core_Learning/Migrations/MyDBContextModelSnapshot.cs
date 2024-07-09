﻿// <auto-generated />
using EF_Core_Learning.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Core_Learning.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Core_Learning.Model.UserDetails", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "Rahul.mehra@gmail.com",
                            UserName = "Rahul"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Ashwani@gmail.com",
                            UserName = "Ashwani"
                        });
                });

            modelBuilder.Entity("EF_Core_Learning.Model.UserHobbies", b =>
                {
                    b.Property<int>("HobbiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbiesId"));

                    b.Property<string>("HobbiesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbiesId");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            HobbiesId = 1,
                            HobbiesName = "Reading books"
                        },
                        new
                        {
                            HobbiesId = 2,
                            HobbiesName = "Playing football"
                        },
                        new
                        {
                            HobbiesId = 3,
                            HobbiesName = "Travelling"
                        });
                });

            modelBuilder.Entity("EF_Core_Learning.Model.UserPasswords", b =>
                {
                    b.Property<int>("PasswordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PasswordId"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PasswordId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Passwords");

                    b.HasData(
                        new
                        {
                            PasswordId = 1,
                            Password = "o*RE0ESV@8wewWt1",
                            UserId = 1
                        },
                        new
                        {
                            PasswordId = 2,
                            Password = "YjoTimXu&Bg8F4Oj",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EF_Core_Learning.Model.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "PMO",
                            UserId = 1
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "PO",
                            UserId = 2
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "User",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EF_Core_Learning.Model.UserPasswords", b =>
                {
                    b.HasOne("EF_Core_Learning.Model.UserDetails", "Details")
                        .WithOne("Passwords")
                        .HasForeignKey("EF_Core_Learning.Model.UserPasswords", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Details");
                });

            modelBuilder.Entity("EF_Core_Learning.Model.UserRole", b =>
                {
                    b.HasOne("EF_Core_Learning.Model.UserDetails", "Details")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Details");
                });

            modelBuilder.Entity("EF_Core_Learning.Model.UserDetails", b =>
                {
                    b.Navigation("Passwords")
                        .IsRequired();

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
