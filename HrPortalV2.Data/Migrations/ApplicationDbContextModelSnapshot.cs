﻿// <auto-generated />
using System;
using HrPortalV2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HrPortalV2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrPortalV2.Models.City", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryId")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = "97888a3c-7f58-45b6-8a7f-35bd1de4235e", CountryId = "7eb890e8-3c99-4482-bc26-7b00bcfc451b", CreateDate = new DateTime(2018, 7, 28, 0, 31, 54, 732, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "İstanbul", UpdateDate = new DateTime(2018, 7, 28, 0, 31, 54, 732, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.Company", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(4000);

                    b.Property<string>("CityId")
                        .IsRequired();

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("CountryId")
                        .IsRequired();

                    b.Property<string>("CountyId")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("Logo")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SectorId")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Website")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CountyId");

                    b.HasIndex("SectorId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HrPortalV2.Models.Country", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = "7eb890e8-3c99-4482-bc26-7b00bcfc451b", CreateDate = new DateTime(2018, 7, 28, 0, 31, 54, 731, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Türkiye", UpdateDate = new DateTime(2018, 7, 28, 0, 31, 54, 731, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.County", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityId")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("County");

                    b.HasData(
                        new { Id = "1f5092b0-ff41-4df6-9fb5-ce4e028d2ba7", CityId = "97888a3c-7f58-45b6-8a7f-35bd1de4235e", CreateDate = new DateTime(2018, 7, 28, 0, 31, 54, 732, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Kadıköy", UpdateDate = new DateTime(2018, 7, 28, 0, 31, 54, 732, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.Job", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsFeatured");

                    b.Property<int>("Position");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("HrPortalV2.Models.JobApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Description");

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("JobId")
                        .IsRequired();

                    b.Property<string>("ResumeId")
                        .IsRequired();

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("ResumeId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("HrPortalV2.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("From")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("FromName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsRead");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("To")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ToName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HrPortalV2.Models.Occupation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Occupations");

                    b.HasData(
                        new { Id = "e1541cd1-6de8-42ad-ab63-fd361de6f66a", CreateDate = new DateTime(2018, 7, 28, 0, 31, 54, 733, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Yazılım Uzmanı", UpdateDate = new DateTime(2018, 7, 28, 0, 31, 54, 733, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.Resume", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressId");

                    b.Property<string>("Behance")
                        .HasMaxLength(100);

                    b.Property<string>("Blog")
                        .HasMaxLength(100);

                    b.Property<string>("CityId")
                        .IsRequired();

                    b.Property<string>("CountryId")
                        .IsRequired();

                    b.Property<string>("CountyId")
                        .IsRequired();

                    b.Property<string>("Courses");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Dribbble")
                        .HasMaxLength(100);

                    b.Property<string>("DrivingLicense")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Facebook")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ForeignLanguages")
                        .HasMaxLength(200);

                    b.Property<int>("Gender");

                    b.Property<string>("GitHub")
                        .HasMaxLength(100);

                    b.Property<int?>("GraduationYear");

                    b.Property<string>("Hobbies")
                        .HasMaxLength(4000);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Instagram")
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsCurrentlyWorking");

                    b.Property<bool>("IsDisabled");

                    b.Property<bool>("IsSeekingJob");

                    b.Property<bool>("IsSubsidized");

                    b.Property<bool>("IsTravelDisabled");

                    b.Property<string>("LastCompany")
                        .HasMaxLength(200);

                    b.Property<string>("LastDepartment")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("LastEducation")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastPosition")
                        .HasMaxLength(200);

                    b.Property<string>("LinkedIn")
                        .HasMaxLength(100);

                    b.Property<int>("MaritalStatus");

                    b.Property<int?>("MilitaryStatus");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Objective")
                        .HasMaxLength(4000);

                    b.Property<string>("OccupationId")
                        .IsRequired();

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<string>("Projects");

                    b.Property<string>("ResumeName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Skills");

                    b.Property<int>("TotalExperience");

                    b.Property<string>("Twitter")
                        .HasMaxLength(100);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<bool>("UsingCigarette");

                    b.Property<string>("Youtube")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CountyId");

                    b.HasIndex("OccupationId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("HrPortalV2.Models.ResumeFile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("File")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("ResumeId")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeFiles");
                });

            modelBuilder.Entity("HrPortalV2.Models.Sector", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Sectors");

                    b.HasData(
                        new { Id = "1", CreateDate = new DateTime(2018, 7, 28, 0, 31, 54, 729, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Eğitim", UpdateDate = new DateTime(2018, 7, 28, 0, 31, 54, 730, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
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

                    b.HasData(
                        new { Id = "b550db4c-a2b5-4095-aaaf-d27dde5c225b", ConcurrencyStamp = "Admin", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = "d8a5481f-98f4-49c6-ac22-ebe88d73042f", ConcurrencyStamp = "Company", Name = "Company", NormalizedName = "COMPANY" },
                        new { Id = "18d37314-12ac-4d84-b2a4-e8bfd3a8edec", ConcurrencyStamp = "Candidate", Name = "Candidate", NormalizedName = "CANDIDATE" }
                    );
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.HasData(
                        new { Id = "4c8069f8-706d-4822-b3d4-96042bc4bf15", AccessFailedCount = 0, ConcurrencyStamp = "1", Email = "admin@bilisimegitim.com", EmailConfirmed = true, LockoutEnabled = true, NormalizedEmail = "ADMIN@BILISIMEGITIM.COM", NormalizedUserName = "ADMIN@BILISIMEGITIM.COM", PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", PhoneNumberConfirmed = false, SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", TwoFactorEnabled = false, UserName = "admin@bilisimegitim.com" },
                        new { Id = "da4db732-aa6f-42bb-a0d3-4bba6574f285", AccessFailedCount = 0, ConcurrencyStamp = "1", Email = "firma@bilisimegitim.com", EmailConfirmed = true, LockoutEnabled = true, NormalizedEmail = "FIRMA@BILISIMEGITIM.COM", NormalizedUserName = "FIRMA@BILISIMEGITIM.COM", PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", PhoneNumberConfirmed = false, SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", TwoFactorEnabled = false, UserName = "firma@bilisimegitim.com" },
                        new { Id = "0714b929-460a-4ee4-b51b-797dc60760d9", AccessFailedCount = 0, ConcurrencyStamp = "1", Email = "aday@bilisimegitim.com", EmailConfirmed = true, LockoutEnabled = true, NormalizedEmail = "ADAY@BILISIMEGITIM.COM", NormalizedUserName = "ADAY@BILISIMEGITIM.COM", PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", PhoneNumberConfirmed = false, SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", TwoFactorEnabled = false, UserName = "aday@bilisimegitim.com" }
                    );
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

                    b.HasData(
                        new { UserId = "4c8069f8-706d-4822-b3d4-96042bc4bf15", RoleId = "b550db4c-a2b5-4095-aaaf-d27dde5c225b" },
                        new { UserId = "da4db732-aa6f-42bb-a0d3-4bba6574f285", RoleId = "d8a5481f-98f4-49c6-ac22-ebe88d73042f" },
                        new { UserId = "0714b929-460a-4ee4-b51b-797dc60760d9", RoleId = "18d37314-12ac-4d84-b2a4-e8bfd3a8edec" }
                    );
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

            modelBuilder.Entity("HrPortalV2.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasMaxLength(200);

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("HrPortalV2.Models.City", b =>
                {
                    b.HasOne("HrPortalV2.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPortalV2.Models.Company", b =>
                {
                    b.HasOne("HrPortalV2.Models.City", "City")
                        .WithMany("Companies")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortalV2.Models.Country", "Country")
                        .WithMany("Companies")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortalV2.Models.County", "County")
                        .WithMany("Companies")
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortalV2.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPortalV2.Models.County", b =>
                {
                    b.HasOne("HrPortalV2.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPortalV2.Models.Job", b =>
                {
                    b.HasOne("HrPortalV2.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPortalV2.Models.JobApplication", b =>
                {
                    b.HasOne("HrPortalV2.Models.Job", "Job")
                        .WithMany("JobApplications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPortalV2.Models.Resume", "Resume")
                        .WithMany("JobApplications")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPortalV2.Models.Resume", b =>
                {
                    b.HasOne("HrPortalV2.Models.City", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("HrPortalV2.Models.City", "City")
                        .WithMany("Resumes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortalV2.Models.Country", "Country")
                        .WithMany("Resumes")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortalV2.Models.County", "County")
                        .WithMany("Resumes")
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortalV2.Models.Occupation", "Occupation")
                        .WithMany()
                        .HasForeignKey("OccupationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPortalV2.Models.ResumeFile", b =>
                {
                    b.HasOne("HrPortalV2.Models.Resume", "Resume")
                        .WithMany("ResumeFiles")
                        .HasForeignKey("ResumeId")
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
