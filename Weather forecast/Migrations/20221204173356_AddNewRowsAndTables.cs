using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Weatherforecast.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRowsAndTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "WFs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WFs",
                newName: "Summaries");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WFs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "humidity",
                table: "WFs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pressure",
                table: "WFs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "temperature",
                table: "WFs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "WFs",
                columns: new[] { "Id", "Date", "Summaries", "humidity", "pressure", "temperature" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 75, 742, 0 },
                    { 2, new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 78, 743, -1 },
                    { 3, new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 82, 744, -3 },
                    { 4, new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freezing", 79, 746, -5 },
                    { 5, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freezing", 83, 745, -4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WFs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WFs");

            migrationBuilder.DropColumn(
                name: "humidity",
                table: "WFs");

            migrationBuilder.DropColumn(
                name: "pressure",
                table: "WFs");

            migrationBuilder.DropColumn(
                name: "temperature",
                table: "WFs");

            migrationBuilder.RenameColumn(
                name: "Summaries",
                table: "WFs",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WFs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
