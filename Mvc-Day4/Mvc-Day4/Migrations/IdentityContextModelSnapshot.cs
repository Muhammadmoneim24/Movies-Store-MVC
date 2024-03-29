﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mvc_Day4.Areas.Identity.Data;

#nullable disable

namespace Mvc_Day4.Migrations
{
    [DbContext(typeof(IdentityContext))]
    partial class IdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "8469d2da-3154-4585-ac24-16ae3f0bb915",
                            Name = "Adminstration",
                            NormalizedName = "ADMINSTRATION"
                        },
                        new
                        {
                            Id = "248619e4-e233-437e-ace7-a8a700284b3c",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "8ab6a84e-5b7c-4ac0-ba62-8994269eea92",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "c630e5e8-ded0-4b93-9903-b4b05a644287",
                            Name = "Med-Manager",
                            NormalizedName = "MED-MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "42b40f47-a696-4ef8-829e-1a24159d6b1c",
                            RoleId = "8469d2da-3154-4585-ac24-16ae3f0bb915"
                        },
                        new
                        {
                            UserId = "42b40f47-a696-4ef8-829e-1a24159d6b1c",
                            RoleId = "248619e4-e233-437e-ace7-a8a700284b3c"
                        },
                        new
                        {
                            UserId = "42b40f47-a696-4ef8-829e-1a24159d6b1c",
                            RoleId = "8ab6a84e-5b7c-4ac0-ba62-8994269eea92"
                        },
                        new
                        {
                            UserId = "42b40f47-a696-4ef8-829e-1a24159d6b1c",
                            RoleId = "c630e5e8-ded0-4b93-9903-b4b05a644287"
                        },
                        new
                        {
                            UserId = "b87885d8-1a74-4a82-806c-4e7befcd576d",
                            RoleId = "248619e4-e233-437e-ace7-a8a700284b3c"
                        },
                        new
                        {
                            UserId = "cb9f8cf3-f12f-410a-a39c-d75c34cdb103",
                            RoleId = "8ab6a84e-5b7c-4ac0-ba62-8994269eea92"
                        },
                        new
                        {
                            UserId = "0a9ca5b6-727b-4b78-be3c-5e852cf1e08e",
                            RoleId = "c630e5e8-ded0-4b93-9903-b4b05a644287"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Mvc_Day4.Areas.Identity.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "42b40f47-a696-4ef8-829e-1a24159d6b1c",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "b523be64-bc2a-4f07-8666-706b6b4d4205",
                            Email = "Mohamed.Ahmed@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mohamed",
                            LastName = "Ahmed",
                            LockoutEnabled = false,
                            NormalizedEmail = "MOHAMED.AHMED@GMAIL.COM",
                            NormalizedUserName = "MOHAMED.AHMED@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDhvhq+HSlQxHuYzmRo7SkDJ580klU3AhPp4S+k/qJFKOV39119Q4YHbupRPijzTUA==",
                            PhoneNumber = "01094456724",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d81b0f03-a733-4305-87bc-408a24a6e439",
                            TwoFactorEnabled = true,
                            UserName = "Mohamed.Ahmed@gmail.com"
                        },
                        new
                        {
                            Id = "b87885d8-1a74-4a82-806c-4e7befcd576d",
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "b4016cba-75ba-4a5d-8b1c-1f8a84a642a1",
                            Email = "Ali.Ahmed@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ali",
                            LastName = "Ahmed",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALI.AHMED@GMAIL.COM",
                            NormalizedUserName = "ALI.AHMED@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHup6uwEYSaYVmYFo73NntLlRymlruN8gOCO/Q1LjI5EIaWEvwWq4f0aBMefojBqTQ==",
                            PhoneNumber = "01194456724",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f3e647e1-9957-4a8e-ac1d-c1c8db4df54d",
                            TwoFactorEnabled = true,
                            UserName = "Ali.Ahmed@gmail.com"
                        },
                        new
                        {
                            Id = "cb9f8cf3-f12f-410a-a39c-d75c34cdb103",
                            AccessFailedCount = 0,
                            Age = 21,
                            ConcurrencyStamp = "02b90775-554f-40b2-9796-baa9c59eb164",
                            Email = "Alaa.Mohamed@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Alaa",
                            LastName = "Mohamed",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALAA.MOHAMED@GMAIL.COM",
                            NormalizedUserName = "ALAA.MOHAMED@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDDP1y914e/Nb+M8Dk976pd3OxFUrwXN+eo0gKxmIlKPVzPWScBz0SodQrSFiYcOJA==",
                            PhoneNumber = "01294456724",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "6e6294e6-21d0-4ced-b9e4-fa1680c28eef",
                            TwoFactorEnabled = true,
                            UserName = "Alaa.Mohamed@gmail.com"
                        },
                        new
                        {
                            Id = "0a9ca5b6-727b-4b78-be3c-5e852cf1e08e",
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "451422ad-2ce0-45ed-8828-ba537477f514",
                            Email = "Mona.Mohamed@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mona",
                            LastName = "Mohamed",
                            LockoutEnabled = false,
                            NormalizedEmail = "MONA.MOHAMED@GMAIL.COM",
                            NormalizedUserName = "MONA.MOHAMED@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHK1P98hMifpQk5ZVyNP4YWIQmn5Hhyu6I4HAUXJg5/pD4KBpxiayZMwuHizd1FbSg==",
                            PhoneNumber = "01095556724",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "848ee81a-e6ec-4a47-b757-daaf6f95cbda",
                            TwoFactorEnabled = true,
                            UserName = "Mona.Mohamed@gmail.com"
                        });
                });

            modelBuilder.Entity("Mvc_Day4.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MovieLength")
                        .HasColumnType("float");

                    b.Property<string>("MovieStar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishDate")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MovieTypeId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Greater than 15",
                            MovieLength = 2.1500000953674316,
                            MovieStar = "Brad Bit",
                            MovieTypeId = 1,
                            Name = "Se7en",
                            PublishDate = 1998,
                            Rate = 8.5
                        },
                        new
                        {
                            Id = 2,
                            Category = "Greater than 16",
                            MovieLength = 2.2999999523162842,
                            MovieStar = "Leonardo DeCabrio",
                            MovieTypeId = 2,
                            Name = "ShutterIsland",
                            PublishDate = 2010,
                            Rate = 8.0
                        },
                        new
                        {
                            Id = 3,
                            Category = "Public",
                            MovieLength = 2.0,
                            MovieStar = "Tom Cruise",
                            MovieTypeId = 4,
                            Name = "MissionImpossible",
                            PublishDate = 2012,
                            Rate = 8.0
                        },
                        new
                        {
                            Id = 4,
                            Category = "Public",
                            MovieLength = 3.0,
                            MovieStar = "Mathio Makonhy",
                            MovieTypeId = 3,
                            Name = "Interstellar",
                            PublishDate = 2014,
                            Rate = 9.0
                        });
                });

            modelBuilder.Entity("Mvc_Day4.Models.MovieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MovieTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Suspense"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dramatic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sciense Fiction"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Action"
                        });
                });

            modelBuilder.Entity("Mvc_Day4.Areas.Identity.Data.AppIdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.HasDiscriminator().HasValue("AppIdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Mvc_Day4.Areas.Identity.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Mvc_Day4.Areas.Identity.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mvc_Day4.Areas.Identity.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Mvc_Day4.Areas.Identity.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mvc_Day4.Models.Movie", b =>
                {
                    b.HasOne("Mvc_Day4.Models.MovieType", "MovieType")
                        .WithMany()
                        .HasForeignKey("MovieTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieType");
                });
#pragma warning restore 612, 618
        }
    }
}
