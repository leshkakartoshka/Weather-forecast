﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weather_forecast.data;

#nullable disable

namespace Weatherforecast.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221204182616_NewData")]
    partial class NewData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Weather_forecast.Models.WFModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summaries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("humidity")
                        .HasColumnType("int");

                    b.Property<int>("pressure")
                        .HasColumnType("int");

                    b.Property<int>("temperature")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WFs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Chilly",
                            humidity = 75,
                            pressure = 742,
                            temperature = 0
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 78,
                            pressure = 743,
                            temperature = -1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 82,
                            pressure = 744,
                            temperature = -3
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Freezing",
                            humidity = 79,
                            pressure = 746,
                            temperature = -5
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Freezing",
                            humidity = 82,
                            pressure = 746,
                            temperature = -7
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 84,
                            pressure = 742,
                            temperature = -3
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 86,
                            pressure = 744,
                            temperature = -2
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 83,
                            pressure = 748,
                            temperature = 0
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Chilly",
                            humidity = 85,
                            pressure = 745,
                            temperature = 1
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Chilly",
                            humidity = 87,
                            pressure = 743,
                            temperature = 2
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 78,
                            pressure = 743,
                            temperature = -1
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Chilly",
                            humidity = 75,
                            pressure = 742,
                            temperature = 0
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Freezing",
                            humidity = 82,
                            pressure = 746,
                            temperature = -7
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 84,
                            pressure = 742,
                            temperature = -3
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 82,
                            pressure = 744,
                            temperature = -3
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Freezing",
                            humidity = 79,
                            pressure = 746,
                            temperature = -5
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Chilly",
                            humidity = 85,
                            pressure = 745,
                            temperature = 1
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Chilly",
                            humidity = 87,
                            pressure = 743,
                            temperature = 2
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 86,
                            pressure = 744,
                            temperature = -2
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summaries = "Bracing",
                            humidity = 83,
                            pressure = 748,
                            temperature = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
