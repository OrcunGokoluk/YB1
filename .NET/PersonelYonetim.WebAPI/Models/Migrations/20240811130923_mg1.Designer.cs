﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelYonetim.WebAPI.Context;

#nullable disable

namespace PersonelYonetim.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240811130923_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonelYonetim.WebAPI.Models.Personel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.Property<DateOnly>("StartingDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
