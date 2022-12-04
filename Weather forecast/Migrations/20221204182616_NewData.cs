using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Weatherforecast.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "humidity", "pressure", "temperature" },
                values: new object[] { 82, 746, -7 });

            migrationBuilder.InsertData(
                table: "WFs",
                columns: new[] { "Id", "Date", "Summaries", "humidity", "pressure", "temperature" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 84, 742, -3 },
                    { 7, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 86, 744, -2 },
                    { 8, new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 83, 748, 0 },
                    { 9, new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 85, 745, 1 },
                    { 10, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 87, 743, 2 },
                    { 11, new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 78, 743, -1 },
                    { 12, new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 75, 742, 0 },
                    { 13, new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freezing", 82, 746, -7 },
                    { 14, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 84, 742, -3 },
                    { 15, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 82, 744, -3 },
                    { 16, new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freezing", 79, 746, -5 },
                    { 17, new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 85, 745, 1 },
                    { 18, new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 87, 743, 2 },
                    { 19, new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 86, 744, -2 },
                    { 20, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 83, 748, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "humidity", "pressure", "temperature" },
                values: new object[] { 83, 745, -4 });
        }
    }
}
