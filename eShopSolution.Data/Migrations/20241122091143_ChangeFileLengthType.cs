using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFileLengthType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a78efdb7-8a2a-4d98-a93d-a58a9f4d9fab", "AQAAAAIAAYagAAAAEPKHFpHV8a5OpRJjhmRoyR4UTAeXklbG7MvkOMY3EW1MlwJVBFKrzwnnPNPBWTLoHA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 19, 23, 7, 28, 122, DateTimeKind.Utc).AddTicks(6400));
        }
    }
}
