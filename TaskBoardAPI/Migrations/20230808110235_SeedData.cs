using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskBoardAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkTasks",
                columns: new[] { "Id", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8427), "Description for Task 1", 1, "Task 1", new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8429) },
                    { 2, new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8430), "Description for Task 2", 2, "Task 2", new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8431) },
                    { 3, new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8432), "Description for Task 3", 0, "Task 3", new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8433) },
                    { 4, new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8434), "Description for Task 4", 1, "Task 4", new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8434) },
                    { 5, new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8435), "Description for Task 5", 2, "Task 5", new DateTime(2023, 8, 8, 11, 2, 35, 912, DateTimeKind.Utc).AddTicks(8436) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
