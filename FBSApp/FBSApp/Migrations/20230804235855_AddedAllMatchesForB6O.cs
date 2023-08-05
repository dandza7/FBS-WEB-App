using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllMatchesForB6O : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "Gameweek", "SeasonId" },
                values: new object[,]
                {
                    { 4L, new DateTime(2018, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 1L },
                    { 5L, new DateTime(2018, 12, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 2, 1L },
                    { 6L, new DateTime(2018, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 1L },
                    { 7L, new DateTime(2018, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 1L },
                    { 8L, new DateTime(2018, 12, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1L },
                    { 9L, new DateTime(2018, 12, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1L },
                    { 10L, new DateTime(2018, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, 1L },
                    { 11L, new DateTime(2018, 12, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 4, 1L },
                    { 12L, new DateTime(2018, 12, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 1L },
                    { 13L, new DateTime(2018, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, 1L },
                    { 14L, new DateTime(2018, 12, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 1L },
                    { 15L, new DateTime(2018, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 5, 1L },
                    { 16L, new DateTime(2019, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 6, 1L },
                    { 17L, new DateTime(2019, 1, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 6, 1L },
                    { 18L, new DateTime(2019, 1, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, 1L },
                    { 19L, new DateTime(2019, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, 1L },
                    { 20L, new DateTime(2019, 1, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 7, 1L },
                    { 21L, new DateTime(2019, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 1L },
                    { 22L, new DateTime(2019, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, 1L },
                    { 23L, new DateTime(2019, 1, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 8, 1L },
                    { 24L, new DateTime(2019, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, 1L },
                    { 25L, new DateTime(2019, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 9, 1L },
                    { 26L, new DateTime(2019, 1, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 9, 1L },
                    { 27L, new DateTime(2019, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, 1L },
                    { 28L, new DateTime(2019, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 10, 1L },
                    { 29L, new DateTime(2019, 2, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 10, 1L },
                    { 30L, new DateTime(2019, 1, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 10, 1L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BEEF12FDB410E1B4AB0B4AD7B631B4E0120DA0ADE0F6BFA4C9B91E7BF3773F1B284239E0C3A2C3F51E3D091A4AEFD5570F9030A272FBC3BC388EF4C827C88D27", new byte[] { 234, 43, 1, 109, 202, 247, 232, 94, 178, 48, 219, 168, 166, 39, 141, 189, 28, 140, 218, 126, 7, 172, 79, 255, 243, 112, 117, 69, 161, 145, 168, 141, 219, 242, 186, 43, 253, 71, 247, 251, 102, 70, 119, 224, 128, 19, 116, 112, 83, 189, 82, 52, 46, 116, 158, 12, 142, 188, 197, 112, 23, 3, 251, 18 } });

            migrationBuilder.InsertData(
                table: "MatchActors",
                columns: new[] { "Id", "IsTeamHost", "MatchId", "TeamId" },
                values: new object[,]
                {
                    { 7L, true, 4L, 2L },
                    { 8L, false, 4L, 1L },
                    { 9L, true, 5L, 4L },
                    { 10L, false, 5L, 9L },
                    { 11L, true, 6L, 6L },
                    { 12L, false, 6L, 5L },
                    { 13L, true, 7L, 1L },
                    { 14L, false, 7L, 6L },
                    { 15L, true, 8L, 2L },
                    { 16L, false, 8L, 9L },
                    { 17L, true, 9L, 5L },
                    { 18L, false, 9L, 4L },
                    { 19L, true, 10L, 9L },
                    { 20L, false, 10L, 1L },
                    { 21L, true, 11L, 2L },
                    { 22L, false, 11L, 6L },
                    { 23L, true, 12L, 4L },
                    { 24L, false, 12L, 5L },
                    { 25L, true, 13L, 1L },
                    { 26L, false, 13L, 5L },
                    { 27L, true, 14L, 6L },
                    { 28L, false, 14L, 2L },
                    { 29L, true, 15L, 9L },
                    { 30L, false, 15L, 4L },
                    { 31L, true, 16L, 5L },
                    { 32L, false, 16L, 1L },
                    { 33L, true, 17L, 4L },
                    { 34L, false, 17L, 2L },
                    { 35L, true, 18L, 6L },
                    { 36L, false, 18L, 9L },
                    { 37L, true, 19L, 1L },
                    { 38L, false, 19L, 4L },
                    { 39L, true, 20L, 2L },
                    { 40L, false, 20L, 5L },
                    { 41L, true, 21L, 9L },
                    { 42L, false, 21L, 6L },
                    { 43L, true, 22L, 6L },
                    { 44L, false, 22L, 1L },
                    { 45L, true, 23L, 2L },
                    { 46L, false, 23L, 4L },
                    { 47L, true, 24L, 5L },
                    { 48L, false, 24L, 9L },
                    { 49L, true, 25L, 1L },
                    { 50L, false, 25L, 2L },
                    { 51L, true, 26L, 4L },
                    { 52L, false, 26L, 6L },
                    { 53L, true, 27L, 9L },
                    { 54L, false, 27L, 5L },
                    { 55L, true, 28L, 4L },
                    { 56L, false, 28L, 1L },
                    { 57L, true, 29L, 9L },
                    { 58L, false, 29L, 2L },
                    { 59L, true, 30L, 5L },
                    { 60L, false, 30L, 6L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "88B1F73EFFA91C273E5F564E93F0868A6529B1514D88E9E0DFC1D2846D5AAC11BE6E91825B16B20F84F51ECE15082424C498E8A2B10E9AD5A362FC533B283206", new byte[] { 65, 188, 69, 215, 55, 192, 123, 131, 36, 127, 120, 113, 253, 206, 87, 91, 117, 115, 215, 151, 225, 22, 77, 222, 191, 213, 8, 184, 108, 236, 166, 239, 98, 193, 220, 163, 146, 69, 126, 21, 153, 107, 148, 248, 1, 156, 171, 196, 83, 78, 23, 143, 125, 57, 232, 95, 90, 79, 241, 16, 240, 172, 239, 46 } });
        }
    }
}
