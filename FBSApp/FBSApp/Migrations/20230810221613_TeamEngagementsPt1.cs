using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class TeamEngagementsPt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 101L, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 101L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 102L, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 102L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 103L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 103L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 104L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 105L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 105L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 106L, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 106L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 107L, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 107L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 108L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 108L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 109L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 109L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 110L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110L, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 111L, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 111L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 112L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 112L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 113L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 113L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 114L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 114L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 115L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 116L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 116L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 117L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 117L, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 118L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 118L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 119L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 119L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 120L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 121L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 121L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 122L, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 122L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 123L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 123L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 124L, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 124L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 125L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 125L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 126L, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 126L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 127L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 127L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 128L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 128L, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 129L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 130L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 130L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 131L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 131L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 132L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 132L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 133L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 133L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 134L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 134L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 135L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 200L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 201L, new DateTime(2018, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 201L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 202L, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 202L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 203L, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 203L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 204L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 204L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 205L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 205L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 206L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 206L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 207L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 207L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 208L, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 208L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 209L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209L, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 210L, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 210L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 211L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 211L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 212L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 212L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 213L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 214L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 214L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 215L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 215L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 216L, new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 216L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 217L, new DateTime(2018, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 217L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 218L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 218L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 219L, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 219L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 220L, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 220L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 221L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 222L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 222L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 223L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 223L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 224L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 224L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 225L, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 225L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 226L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 227L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 227L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 228L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 228L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 229L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229L, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 230L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230L, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 231L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 231L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 232L, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 232L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 233L, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 233L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 234L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201L, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 235L, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 222L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 236L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 203L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 237L, new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 210L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 238L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 217L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 239L, new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 220L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 400L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 400L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 401L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 401L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 402L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 402L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 403L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 403L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 404L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 404L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 405L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 405L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 406L, new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 406L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 407L, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 407L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 408L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 408L, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 409L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 409L, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 410L, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 410L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 411L, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 411L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 412L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 412L, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 413L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 413L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 414L, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 414L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 415L, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 415L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 416L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 416L, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 417L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 417L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 418L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 418L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 419L, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 419L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 420L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 420L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 421L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 422L, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 422L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 423L, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 423L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 424L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 424L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 425L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 425L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 426L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 426L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 427L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 428L, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 428L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 429L, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 429L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 430L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 430L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 431L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431L, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 432L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 433L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 433L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 434L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 434L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 435L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 435L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 436L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 436L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 437L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 437L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 438L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 438L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 439L, new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 439L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 440L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 909L, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 441L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 406L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 442L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 413L, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 443L, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 414L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 444L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 414L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 445L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 446L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 419L, new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 447L, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 422L, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 448L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 428L, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 449L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 942L, new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 500L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 501L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 502L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 503L, new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 503L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 504L, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 504L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 505L, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 505L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 506L, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 506L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 507L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 507L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 508L, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 508L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 509L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 510L, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 510L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 511L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 511L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 512L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 512L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 513L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 513L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 514L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 514L, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 515L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 516L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 516L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 517L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 517L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 518L, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 518L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 519L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 519L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 520L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 520L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 521L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 521L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 522L, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 522L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 523L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 523L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 524L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 524L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 525L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 525L, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 526L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 526L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 527L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 527L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 528L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 528L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 529L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 529L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 530L, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 431L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 531L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504L, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 532L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 522L, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 600L, new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 600L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 601L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601L, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 602L, new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 602L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 603L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 603L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 604L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 604L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 605L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 605L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 606L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 606L, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 607L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 607L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 608L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 608L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 609L, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 609L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 610L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 610L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 611L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 611L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 612L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 612L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 613L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 613L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 614L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 614L, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 615L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 615L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 616L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 616L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 617L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 617L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 618L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 618L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 619L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 619L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 620L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 620L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 621L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 621L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 622L, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 622L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 623L, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 623L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 624L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 624L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 625L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 625L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 626L, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 626L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 627L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 627L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 628L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 628L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 629L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 629L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 630L, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 630L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 631L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 631L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 632L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 633L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 633L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 634L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 634L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 635L, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 622L, new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 636L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 622L, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 637L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 623L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 638L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 626L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 700L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 203L, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 800L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 108L, new DateTime(2018, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L },
                    { 801L, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 908L, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 802L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 939L, new DateTime(2018, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 900L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 901L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 901L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 902L, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 902L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 903L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 903L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 904L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 904L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 905L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 905L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 906L, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 906L, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 907L, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 907L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 908L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 908L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 909L, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 909L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 910L, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 910L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 911L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 911L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 912L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 912L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 913L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 913L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 914L, new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 914L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 915L, new DateTime(2018, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 915L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 916L, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 916L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 917L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 917L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 918L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 918L, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 919L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 919L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 920L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 920L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 921L, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 921L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 922L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 922L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 923L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 923L, new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 924L, new DateTime(2018, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 924L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 925L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 925L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 926L, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 926L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 927L, new DateTime(2019, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 927L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 928L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 928L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 929L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 929L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 930L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 930L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 931L, new DateTime(2018, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 931L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 932L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 932L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 933L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 933L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 934L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 934L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 935L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 935L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 936L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 936L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 937L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 937L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 938L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 938L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 939L, new DateTime(2018, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 939L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 940L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 940L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 941L, new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 941L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 942L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 942L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 943L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 906L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 944L, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 907L, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 945L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 907L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 946L, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 908L, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 947L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 908L, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 948L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 910L, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 949L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 914L, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 950L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 915L, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 951L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 924L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 952L, new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 926L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 953L, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 931L, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 954L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 931L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 955L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 939L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 1000L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 402L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 1001L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 510L, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 1002L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 924L, new DateTime(2018, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 1100L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 217L, new DateTime(2018, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 1400L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 1401L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 222L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 1402L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 916L, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 1403L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 931L, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 1500L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 134L, new DateTime(2018, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 1501L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 227L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 1502L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 217L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 1503L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 406L, new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 1600L, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 908L, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 1900L, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 220L, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 1901L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 220L, new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 1902L, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 408L, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 2100L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410L, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 2300L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 225L, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "AA96FBAE8C918B8825DFAA7F8F36E2B1F6B92585A4D3CC5A3D7DA993B1118F991DA2FEB9EA5B1C99092C572E56312D77F5B358B79C3B280C67A0B7F35454C0C9", new byte[] { 170, 106, 59, 111, 147, 73, 109, 111, 99, 198, 238, 97, 235, 29, 46, 111, 244, 181, 190, 173, 193, 97, 5, 246, 134, 91, 187, 121, 45, 83, 11, 173, 66, 254, 248, 194, 70, 233, 2, 70, 76, 114, 164, 188, 99, 27, 87, 87, 50, 94, 32, 209, 202, 102, 214, 25, 183, 224, 8, 92, 17, 173, 198, 70 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 620L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 700L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 800L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 900L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 903L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 904L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 905L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 906L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 907L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 908L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 909L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 910L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 913L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 914L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 915L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 916L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 917L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 918L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 919L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 920L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 923L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 924L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 925L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 926L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 927L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 928L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 929L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 930L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 933L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 934L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 935L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 936L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 937L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 938L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 939L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 940L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 943L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 944L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 945L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 946L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 947L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 948L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 949L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 950L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 953L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 954L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 955L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1000L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1001L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1002L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1100L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1400L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1401L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1402L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1403L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1500L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1501L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1502L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1503L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1600L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1900L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1901L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1902L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2100L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2300L);

            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 110L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 2L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 129L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 3L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 113L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 4L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 123L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 5L, new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 131L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 6L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 131L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 7L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 905L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 8L, new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 918L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 9L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 929L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "0B367E05DF1CADFDB160A7F0FF4E588C9590ADF41652758297724A89957AB41163BF7060CB3D7CEC0D040A3758B1F02A8712CA4C88704B3B2297A3B37AFC86A9", new byte[] { 86, 218, 144, 124, 29, 61, 178, 72, 31, 124, 43, 76, 104, 124, 121, 110, 244, 81, 147, 21, 204, 44, 74, 181, 50, 131, 1, 5, 173, 205, 41, 154, 195, 42, 44, 189, 8, 186, 19, 167, 43, 168, 120, 221, 32, 159, 104, 140, 226, 153, 135, 121, 108, 142, 87, 46, 62, 164, 28, 44, 226, 82, 248, 55 } });
        }
    }
}
