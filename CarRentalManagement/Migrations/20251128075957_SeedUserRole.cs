using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 676, DateTimeKind.Local).AddTicks(9856), new DateTime(2025, 11, 28, 15, 59, 56, 676, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 676, DateTimeKind.Local).AddTicks(9873), new DateTime(2025, 11, 28, 15, 59, 56, 676, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(7), new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(9), new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(61), new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(63), new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(64), new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(66), new DateTime(2025, 11, 28, 15, 59, 56, 677, DateTimeKind.Local).AddTicks(66) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(5961), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(5976), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6118), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6120), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6180), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6181), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6183), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6184), new DateTime(2025, 11, 28, 15, 48, 9, 898, DateTimeKind.Local).AddTicks(6185) });
        }
    }
}
