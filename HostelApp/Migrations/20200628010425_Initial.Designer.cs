﻿// <auto-generated />
using System;
using HostelApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HostelApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200628010425_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HostelApp.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FatherName")
                        .IsRequired();

                    b.Property<int>("GroupId");

                    b.Property<string>("IDCardNumber")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("StudentTicketNumber");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HostelApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryName = "Deluxe" },
                        new { Id = 2, CategoryName = "Super Deluxe" },
                        new { Id = 3, CategoryName = "Single" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Facilty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Context")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Facilties");

                    b.HasData(
                        new { ID = 1, Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum.", Title = "24-hour reseption" },
                        new { ID = 2, Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum.", Title = "Room service" },
                        new { ID = 3, Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum.", Title = "Car hire" },
                        new { ID = 4, Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum.", Title = "Wake-up call" },
                        new { ID = 5, Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum.", Title = "Coffe and tea" },
                        new { ID = 6, Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum.", Title = "Free wifi" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Faculty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyName")
                        .IsRequired();

                    b.Property<int>("UniversityId");

                    b.HasKey("ID");

                    b.HasIndex("UniversityId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new { ID = 1, FacultyName = "ITT", UniversityId = 1 },
                        new { ID = 2, FacultyName = "XTT", UniversityId = 1 }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyId");

                    b.Property<string>("GroupName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("FacultyId");

                    b.ToTable("Groups");

                    b.HasData(
                        new { ID = 1, FacultyId = 1, GroupName = "686a2" },
                        new { ID = 2, FacultyId = 1, GroupName = "686a1" },
                        new { ID = 3, FacultyId = 2, GroupName = "676a2" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Hostel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Context")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Hostels");

                    b.HasData(
                        new { ID = 1, Context = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", Title = "About our hostel" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.News", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Context")
                        .IsRequired();

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("News");

                    b.HasData(
                        new { ID = 1, Context = "Nostram virtutem poterimus quoddam praesertim legendos libero exhorrescere saluti...", PublishDate = new DateTime(2020, 6, 27, 18, 4, 24, 758, DateTimeKind.Local), Title = "A Standard Blog Post" },
                        new { ID = 2, Context = "Nostram virtutem poterimus quoddam praesertim legendos libero exhorrescere saluti...", PublishDate = new DateTime(2020, 6, 27, 18, 4, 24, 761, DateTimeKind.Local), Title = "A Standard Blog Post" },
                        new { ID = 3, Context = "Nostram virtutem poterimus quoddam praesertim legendos libero exhorrescere saluti...", PublishDate = new DateTime(2020, 6, 27, 18, 4, 24, 761, DateTimeKind.Local), Title = "A Standard Blog Post" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("FreeBedCount");

                    b.Property<bool>("IsReserved");

                    b.Property<int>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("RoomId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HostelApp.Models.Partner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Partners");

                    b.HasData(
                        new { ID = 1, Logo = "part-logo-1.png", Name = "Vintage" },
                        new { ID = 2, Logo = "part-logo-2.png", Name = "Vintage" },
                        new { ID = 3, Logo = "part-logo-3.png", Name = "Cahmpagne" },
                        new { ID = 4, Logo = "part-logo-1.png", Name = "Deligous" },
                        new { ID = 5, Logo = "part-logo-2.png", Name = "Vintage2" },
                        new { ID = 6, Logo = "part-logo-3.png", Name = "Champagne" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BedCount");

                    b.Property<bool>("Breakfast");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsReserved");

                    b.Property<decimal>("Price");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("WiFi");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new { ID = 1, BedCount = 2, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 399m, RoomNumber = 0, WiFi = true },
                        new { ID = 2, BedCount = 4, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 299m, RoomNumber = 0, WiFi = true },
                        new { ID = 3, BedCount = 4, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 299m, RoomNumber = 0, WiFi = true },
                        new { ID = 4, BedCount = 2, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 289m, RoomNumber = 0, WiFi = true },
                        new { ID = 5, BedCount = 4, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 299m, RoomNumber = 0, WiFi = true },
                        new { ID = 6, BedCount = 4, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 279m, RoomNumber = 0, WiFi = true },
                        new { ID = 7, BedCount = 2, Breakfast = true, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ", IsReserved = false, Price = 259m, RoomNumber = 0, WiFi = true }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.RoomImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<int>("RoomId");

                    b.HasKey("ID");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomImages");

                    b.HasData(
                        new { ID = 1, Image = "room-1.png", RoomId = 1 },
                        new { ID = 2, Image = "room-2.png", RoomId = 2 },
                        new { ID = 3, Image = "room-3.png", RoomId = 2 },
                        new { ID = 4, Image = "room-4.png", RoomId = 2 },
                        new { ID = 5, Image = "room-5.png", RoomId = 3 },
                        new { ID = 6, Image = "room-6.png", RoomId = 3 },
                        new { ID = 7, Image = "room-7.png", RoomId = 4 },
                        new { ID = 8, Image = "room-8.png", RoomId = 4 },
                        new { ID = 9, Image = "room-1.png", RoomId = 5 },
                        new { ID = 10, Image = "room-2.png", RoomId = 5 },
                        new { ID = 11, Image = "room-3.png", RoomId = 6 },
                        new { ID = 12, Image = "room-4.png", RoomId = 6 },
                        new { ID = 13, Image = "room-5.png", RoomId = 7 },
                        new { ID = 14, Image = "room-6.png", RoomId = 7 },
                        new { ID = 15, Image = "room-7.png", RoomId = 1 },
                        new { ID = 16, Image = "room-8.png", RoomId = 5 }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.Slider", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Sliders");

                    b.HasData(
                        new { ID = 1, Content = "Cogitavisse erant puerilis utrum efficiantur adhuc expeteretur.", Image = "slide-4.png", Title = "Welcome to mega hotel" },
                        new { ID = 2, Content = "Cogitavisse erant puerilis utrum efficiantur adhuc expeteretur.", Image = "slide-2.png", Title = "Feel like your home" },
                        new { ID = 3, Content = "Cogitavisse erant puerilis utrum efficiantur adhuc expeteretur.", Image = "slide-3.png", Title = "Perfect palace for dining" }
                    );
                });

            modelBuilder.Entity("HostelApp.Models.University", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Universities");

                    b.HasData(
                        new { ID = 1, Name = "Azerbaijan Technical University" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HostelApp.Models.AppUser", b =>
                {
                    b.HasOne("HostelApp.Models.Group", "Group")
                        .WithMany("AppUsers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HostelApp.Models.Faculty", b =>
                {
                    b.HasOne("HostelApp.Models.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HostelApp.Models.Group", b =>
                {
                    b.HasOne("HostelApp.Models.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HostelApp.Models.Order", b =>
                {
                    b.HasOne("HostelApp.Models.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HostelApp.Models.Room", "Room")
                        .WithMany("Orders")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HostelApp.Models.Room", b =>
                {
                    b.HasOne("HostelApp.Models.Category", "Category")
                        .WithMany("Rooms")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HostelApp.Models.RoomImage", b =>
                {
                    b.HasOne("HostelApp.Models.Room", "Room")
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HostelApp.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HostelApp.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HostelApp.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HostelApp.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
