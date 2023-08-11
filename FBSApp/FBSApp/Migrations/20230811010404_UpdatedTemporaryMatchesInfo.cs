using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTemporaryMatchesInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2L, 15L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2L, 18L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2L, 22L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 1L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 3L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 4L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 5L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 6L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 8L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 9L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 10L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 11L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 12L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 13L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 14L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 16L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 17L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 19L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 20L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 21L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 3L, 23L });

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Date",
                value: new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Date",
                value: new DateTime(2019, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Date",
                value: new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Date",
                value: new DateTime(2019, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Date",
                value: new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Date",
                value: new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Date",
                value: new DateTime(2019, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Date",
                value: new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Date",
                value: new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Date",
                value: new DateTime(2018, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Date",
                value: new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Date",
                value: new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Date",
                value: new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Date",
                value: new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Date",
                value: new DateTime(2018, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Date",
                value: new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Date",
                value: new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Date",
                value: new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Date",
                value: new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Date",
                value: new DateTime(2018, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Date",
                value: new DateTime(2018, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Date",
                value: new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Date",
                value: new DateTime(2019, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Date",
                value: new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Date",
                value: new DateTime(2018, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Date",
                value: new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Date",
                value: new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Date",
                value: new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Date",
                value: new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Date",
                value: new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "Year" },
                values: new object[] { new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2018/19" });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "Year" },
                values: new object[] { new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "2019/20" });

            migrationBuilder.InsertData(
                table: "TeamSeason",
                columns: new[] { "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 1L, 3L },
                    { 1L, 7L },
                    { 1L, 10L },
                    { 1L, 12L },
                    { 1L, 13L },
                    { 1L, 14L },
                    { 1L, 15L },
                    { 1L, 16L },
                    { 1L, 17L },
                    { 1L, 18L },
                    { 1L, 19L },
                    { 1L, 20L },
                    { 1L, 21L },
                    { 1L, 22L },
                    { 2L, 8L },
                    { 2L, 11L },
                    { 2L, 23L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "32BB1F434CCAB0927051C7E713D0E487FD30DAA1B0E923FA50A397648D17DD2387553FD01A3628441E3EE28A153C654A9D060C29801AF22964A219A353F36A7C", new byte[] { 34, 26, 99, 91, 248, 182, 187, 184, 245, 175, 6, 217, 77, 130, 215, 94, 62, 251, 231, 169, 58, 2, 206, 17, 215, 102, 209, 43, 240, 20, 43, 139, 35, 230, 3, 178, 85, 50, 104, 49, 153, 232, 226, 39, 15, 57, 208, 138, 21, 139, 147, 91, 191, 126, 116, 28, 41, 190, 1, 236, 232, 236, 170, 125 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 7L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 10L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 12L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 13L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 14L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 15L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 16L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 17L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 18L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 19L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 20L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 21L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1L, 22L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2L, 8L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2L, 11L });

            migrationBuilder.DeleteData(
                table: "TeamSeason",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2L, 23L });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Date",
                value: new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Date",
                value: new DateTime(2018, 12, 1, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Date",
                value: new DateTime(2018, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Date",
                value: new DateTime(2018, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Date",
                value: new DateTime(2018, 12, 8, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Date",
                value: new DateTime(2018, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Date",
                value: new DateTime(2018, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Date",
                value: new DateTime(2018, 12, 15, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Date",
                value: new DateTime(2018, 12, 16, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Date",
                value: new DateTime(2018, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Date",
                value: new DateTime(2018, 12, 22, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Date",
                value: new DateTime(2018, 12, 23, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Date",
                value: new DateTime(2018, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Date",
                value: new DateTime(2018, 12, 29, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Date",
                value: new DateTime(2018, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Date",
                value: new DateTime(2019, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Date",
                value: new DateTime(2019, 1, 5, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Date",
                value: new DateTime(2019, 1, 6, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Date",
                value: new DateTime(2019, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Date",
                value: new DateTime(2019, 1, 12, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Date",
                value: new DateTime(2019, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Date",
                value: new DateTime(2019, 1, 19, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Date",
                value: new DateTime(2019, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Date",
                value: new DateTime(2019, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Date",
                value: new DateTime(2019, 1, 26, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Date",
                value: new DateTime(2019, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Date",
                value: new DateTime(2019, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Date",
                value: new DateTime(2019, 2, 2, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Date",
                value: new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate", "Year" },
                values: new object[] { new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2018/19 Big6Only" });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate", "Year" },
                values: new object[] { new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2018/19" });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "LeagueId", "StartDate", "Year" },
                values: new object[] { 3L, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2019/20" });

            migrationBuilder.InsertData(
                table: "TeamSeason",
                columns: new[] { "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 2L, 15L },
                    { 2L, 18L },
                    { 2L, 22L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "14192D9429E30D731D79F1CE6DEEC6192F36B749E9AB94E5809107E40535867665979BC90DDAB40EE7AAB9D71F97903713BA9D5A8961D2339C8F9E6C10880C34", new byte[] { 64, 104, 94, 64, 146, 151, 149, 204, 247, 89, 208, 57, 202, 7, 237, 45, 248, 124, 121, 160, 150, 133, 84, 29, 166, 79, 133, 132, 25, 95, 196, 50, 215, 67, 48, 198, 157, 116, 211, 229, 247, 154, 74, 169, 240, 62, 110, 24, 88, 2, 163, 42, 113, 95, 78, 126, 172, 252, 110, 215, 81, 141, 246, 77 } });

            migrationBuilder.InsertData(
                table: "TeamSeason",
                columns: new[] { "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 3L, 1L },
                    { 3L, 2L },
                    { 3L, 3L },
                    { 3L, 4L },
                    { 3L, 5L },
                    { 3L, 6L },
                    { 3L, 7L },
                    { 3L, 8L },
                    { 3L, 9L },
                    { 3L, 10L },
                    { 3L, 11L },
                    { 3L, 12L },
                    { 3L, 13L },
                    { 3L, 14L },
                    { 3L, 16L },
                    { 3L, 17L },
                    { 3L, 19L },
                    { 3L, 20L },
                    { 3L, 21L },
                    { 3L, 23L }
                });
        }
    }
}
