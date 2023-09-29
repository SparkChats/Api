﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sparkle.DataAccess;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "ManageRoles",
                            ClaimValue = "true",
                            RoleId = new Guid("b36944ab-83e0-4447-bce4-ac699b6d3dc2")
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "ManageServer",
                            ClaimValue = "true",
                            RoleId = new Guid("b36944ab-83e0-4447-bce4-ac699b6d3dc2")
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "ManageMessages",
                            ClaimValue = "true",
                            RoleId = new Guid("b36944ab-83e0-4447-bce4-ac699b6d3dc2")
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "ManageChannels",
                            ClaimValue = "true",
                            RoleId = new Guid("b36944ab-83e0-4447-bce4-ac699b6d3dc2")
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "ManageRoles",
                            ClaimValue = "true",
                            RoleId = new Guid("ff55d9b4-b26f-47be-bf76-bdba29896ca3")
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "ManageServer",
                            ClaimValue = "true",
                            RoleId = new Guid("ff55d9b4-b26f-47be-bf76-bdba29896ca3")
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "ManageMessages",
                            ClaimValue = "true",
                            RoleId = new Guid("ff55d9b4-b26f-47be-bf76-bdba29896ca3")
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "ManageChannels",
                            ClaimValue = "true",
                            RoleId = new Guid("ff55d9b4-b26f-47be-bf76-bdba29896ca3")
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "ManageMessages",
                            ClaimValue = "true",
                            RoleId = new Guid("0b7b7f0c-fd18-4cdc-b2d1-c862c77bfdd5")
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "ChangeServerName",
                            ClaimValue = "true",
                            RoleId = new Guid("8ce979a9-c05c-4d70-bb45-6476892ced6c")
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "ChangeServerName",
                            ClaimValue = "true",
                            RoleId = new Guid("e26c471b-5418-4de1-bc35-d35310ab4ca7")
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "ManageServer",
                            ClaimValue = "true",
                            RoleId = new Guid("e26c471b-5418-4de1-bc35-d35310ab4ca7")
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "ManageRoles",
                            ClaimValue = "true",
                            RoleId = new Guid("e26c471b-5418-4de1-bc35-d35310ab4ca7")
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "ManageChannels",
                            ClaimValue = "true",
                            RoleId = new Guid("e26c471b-5418-4de1-bc35-d35310ab4ca7")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Sparkle.Application.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("ServerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b7b7f0c-fd18-4cdc-b2d1-c862c77bfdd5"),
                            Color = "#FF0000",
                            IsAdmin = false,
                            Name = "GROUP-CHAT-OWNER",
                            Priority = 1
                        },
                        new
                        {
                            Id = new Guid("ff55d9b4-b26f-47be-bf76-bdba29896ca3"),
                            Color = "#FF0000",
                            IsAdmin = false,
                            Name = "GROUP-CHAT-MEMBER",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("b36944ab-83e0-4447-bce4-ac699b6d3dc2"),
                            Color = "#FF0000",
                            IsAdmin = false,
                            Name = "PRIVATE-CHAT-MEMBER",
                            Priority = 0
                        },
                        new
                        {
                            Id = new Guid("e26c471b-5418-4de1-bc35-d35310ab4ca7"),
                            Color = "#FF0000",
                            IsAdmin = false,
                            Name = "SERVER-OWNER",
                            Priority = 100
                        },
                        new
                        {
                            Id = new Guid("8ce979a9-c05c-4d70-bb45-6476892ced6c"),
                            Color = "#FF0000",
                            IsAdmin = false,
                            Name = "SERVER-MEMBER",
                            Priority = 0
                        });
                });

            modelBuilder.Entity("Sparkle.Application.Models.RoleUserProfile", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesId", "UserProfileId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("RoleUserProfile");
                });

            modelBuilder.Entity("Sparkle.Application.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TextStatus")
                        .HasMaxLength(96)
                        .HasColumnType("nvarchar(96)");

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
                            Id = new Guid("c1ce2c28-9cf4-4ab1-bddb-b99c5408ee34"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9372f0b4-1686-4af9-8962-43ae874b7a6f",
                            DisplayName = "Grabtot",
                            Email = "dneshotkin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DNESHOTKIN@GMAIL.COM",
                            NormalizedUserName = "DNESH1",
                            PasswordHash = "AQAAAAIAAYagAAAAELLPwOPnHPJdFRtP7OCgMMQ4n7IAUrj5F7ZFbvkzbwdA1e5o1BSCxm3zf6pordQ1Ow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "YNSKJ23UUSGYIOOXJTIKUUTHF3FXW43N",
                            Status = 3,
                            TwoFactorEnabled = false,
                            UserName = "dnesh1"
                        },
                        new
                        {
                            Id = new Guid("7aef2538-e1b3-42d7-a3db-a2809a81ac91"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2075b1f-8f89-4df9-9f85-39deaec2b403",
                            Email = "dneshotkin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DNESHOTKIN@EMAIL.COM",
                            NormalizedUserName = "DNESH2",
                            PasswordHash = "AQAAAAIAAYagAAAAEDhRq1TO1+Bt5t+MWYFRaeRu7OrRR8LVhJNio81zmfnaZwdWhwUbHaEuj1vpSOngVg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "KDGJ6POASVRE527NHMQZ4FQPGL4OREWT",
                            Status = 3,
                            TwoFactorEnabled = false,
                            UserName = "dnesh2"
                        },
                        new
                        {
                            Id = new Guid("ba1ce081-e200-41da-9fb2-3d317627c9d4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "93e4df6c-20cc-410b-9082-daac577e184a",
                            DisplayName = "Grabbot",
                            Email = "dneshotkin@ebail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DNESHOTKIN@EBAIL.COM",
                            NormalizedUserName = "DNESH3",
                            PasswordHash = "AQAAAAIAAYagAAAAECIvg/r9riF/7qS+ETlEE6L+wNUWORELOOYoI78NY+hKBk2/YP4+0F9nZ12cLs57Sw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "X73JA3M4E5VMK35LG7HMINOGF5AWAM5B",
                            Status = 3,
                            TwoFactorEnabled = false,
                            UserName = "dnesh3"
                        });
                });

            modelBuilder.Entity("Sparkle.Application.Models.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfiles", (string)null);

                    b.HasDiscriminator<string>("ProfileType").HasValue("user");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Sparkle.Application.Models.ServerProfile", b =>
                {
                    b.HasBaseType("Sparkle.Application.Models.UserProfile");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("server");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Sparkle.Application.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Sparkle.Application.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Sparkle.Application.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Sparkle.Application.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sparkle.Application.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Sparkle.Application.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sparkle.Application.Models.RoleUserProfile", b =>
                {
                    b.HasOne("Sparkle.Application.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sparkle.Application.Models.UserProfile", null)
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sparkle.Application.Models.UserProfile", b =>
                {
                    b.HasOne("Sparkle.Application.Models.User", null)
                        .WithMany("UserProfiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sparkle.Application.Models.User", b =>
                {
                    b.Navigation("UserProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
