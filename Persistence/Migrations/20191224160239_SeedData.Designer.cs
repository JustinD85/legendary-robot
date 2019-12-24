﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191224160239_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "value 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "value 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "value 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "value 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "value 5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "value 6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "value 7"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
