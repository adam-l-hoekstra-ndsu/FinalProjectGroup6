﻿// <auto-generated />
using System;
using FinalProjectGroup6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProjectGroup6.Migrations
{
    [DbContext(typeof(FinalProjectGroup6Context))]
    [Migration("20241206035916_mssql.local_migration_493")]
    partial class mssqllocal_migration_493
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProjectGroup6.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Activities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CanProvideCare")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DogID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HrsLeftAlone")
                        .HasColumnType("int");

                    b.Property<bool>("Inside")
                        .HasColumnType("bit");

                    b.Property<int>("NumPetsOwned")
                        .HasColumnType("int");

                    b.Property<string>("RejectReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("ReviewDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("SubmitDate")
                        .HasColumnType("date");

                    b.Property<string>("WhyHaveDog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });
#pragma warning restore 612, 618
        }
    }
}
