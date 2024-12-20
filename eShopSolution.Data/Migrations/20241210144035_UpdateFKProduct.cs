using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFKProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11f75456-3c91-4627-b7ff-6e3c9333f491", "AQAAAAIAAYagAAAAEJCCOM7yx080BnNZ6jUs7/AZrFTM1A2r+ZcOkayGFlwDfT7y/cKL0Ta/oK6VGEc7tA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 10, 21, 40, 34, 894, DateTimeKind.Utc).AddTicks(2590));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
