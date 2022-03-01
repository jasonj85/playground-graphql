﻿// <auto-generated />
using GraphQLExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLExample.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220228222021_InitalData")]
    partial class InitalData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GraphQLExample.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Designation = "IT consultant",
                            Name = "Jason"
                        },
                        new
                        {
                            Id = 2,
                            Designation = "Store Assistant",
                            Name = "Henry"
                        },
                        new
                        {
                            Id = 3,
                            Designation = "Football Coach",
                            Name = "Susan"
                        },
                        new
                        {
                            Id = 4,
                            Designation = "School Teacher",
                            Name = "Terri"
                        },
                        new
                        {
                            Id = 5,
                            Designation = "Navy Officer",
                            Name = "Aaron"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}