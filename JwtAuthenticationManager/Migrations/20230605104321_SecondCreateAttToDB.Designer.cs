﻿// <auto-generated />
using JwtAuthenticationManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtAuthenticationManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230605104321_SecondCreateAttToDB")]
    partial class SecondCreateAttToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JwtAuthenticationManager.Models.UserAccount", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identifiant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "email@email.com",
                            FirstName = "Azer",
                            Identifiant = "012345",
                            LastName = "Engazzou",
                            Password = "00000000",
                            Role = "Doctor",
                            UserName = "azerDoctor"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "email@email.com",
                            FirstName = "Azer",
                            Identifiant = "012345",
                            LastName = "Engazzou",
                            Password = "00000000",
                            Role = "Administrator",
                            UserName = "azerAdministrator"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "email@email.com",
                            FirstName = "Azer",
                            Identifiant = "012345",
                            LastName = "Engazzou",
                            Password = "00000000",
                            Role = "Support",
                            UserName = "azerDoctor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
