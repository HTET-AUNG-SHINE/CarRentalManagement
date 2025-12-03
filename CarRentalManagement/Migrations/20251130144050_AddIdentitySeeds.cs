using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentitySeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "93024dfc-c7f7-481e-9883-c34debf02c88", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBaHoEBfFz9bca1go9gnoNJjOPbbeA3fbTIDDO3bZKJXRcuJy0NImzueUHIlwXL9NA==", null, false, "a36b8310-e6a8-430c-a92e-4081dcda197b", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6079), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6336), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6339), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6515), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6518), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6521), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6523), new DateTime(2025, 11, 30, 22, 40, 49, 891, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
    }
}
