using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(8798), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(8822), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9122), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9241), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9245), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9248), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9251), new DateTime(2025, 11, 28, 15, 34, 13, 451, DateTimeKind.Local).AddTicks(9252) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(805), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(822), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1040), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1042), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1111), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1113), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1115), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1117), new DateTime(2025, 11, 28, 15, 26, 17, 550, DateTimeKind.Local).AddTicks(1117) });
        }
    }
}
