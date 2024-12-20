using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a21bfb25-7a4d-4e52-9dda-3f3eaf146bf9", "AQAAAAIAAYagAAAAEMgRop08mRSyWXvPpMmJyGBUI3kCXyVHZ/P2zAPFHJ2dje1Sa712/4/LMgqsYZtNfg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 9, 16, 51, 6, 707, DateTimeKind.Utc).AddTicks(5180));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb4bac7a-43ff-4322-91f1-7203e294b154", "AQAAAAIAAYagAAAAEA4URVjL03+MJCp4zjOr1+CBKxg6YQLhL2PRQLLnrdac7eD82ZUbrxxXqHeW3MZLOQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 22, 16, 11, 42, 693, DateTimeKind.Utc).AddTicks(3880));
        }
    }
}
