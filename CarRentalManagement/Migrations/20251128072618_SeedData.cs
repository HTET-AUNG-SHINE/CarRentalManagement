using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(805), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(820), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(822), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(822), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1040), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1041), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1042), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1043), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1111), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1111), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1113), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1113), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1115), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1115), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1117), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1117), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
