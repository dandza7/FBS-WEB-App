using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllTeamEmployments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1973, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 130L, "Ole Gunnar Solskjaer" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1986, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 127L, "Kieran McKenna" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1972, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L, "Mauricio Pochettino" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BirthDate", "BossId", "Name" },
                values: new object[] { new DateTime(1971, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Jesus Perez" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1963, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 53L, "David Moyes" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1966, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 53L, "Telo Brooks" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1971, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Unai Emery" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1968, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Maxi Paredes" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1982, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 167L, "Mikel Arteta" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1988, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L, 111L, "Miguel Hernandez" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1971, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 167L, "Josep Guardiola" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L, 83L, "Enzo Maresca" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1965, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L, 167L, "Miguel Hernandez" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BirthDate", "BossId", "Name" },
                values: new object[] { new DateTime(1967, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jurgen Klopp" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 17L, new DateTime(1961, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L, 22L, "Zeljko Buvac" },
                    { 19L, new DateTime(1960, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 167L, "Rafael Benitez" },
                    { 21L, new DateTime(1960, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Steve Bruce" },
                    { 23L, new DateTime(1971, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Dean Smith" },
                    { 25L, new DateTime(1959, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83L, "Maurizio Sarri" },
                    { 27L, new DateTime(1978, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Frank Lampard" },
                    { 29L, new DateTime(1977, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 141L, "Marco Silva" },
                    { 31L, new DateTime(1959, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83L, "Carlo Ancelotti" },
                    { 33L, new DateTime(1967, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Chris Wilder" },
                    { 35L, new DateTime(1958, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Chris Hughton" },
                    { 37L, new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Chris Hughton" },
                    { 39L, new DateTime(1974, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 141L, "Nuno Espirito Santo" },
                    { 41L, new DateTime(1947, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Roy Hodgson" },
                    { 43L, new DateTime(1968, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 156L, "Slavisa Jokanovic" },
                    { 45L, new DateTime(1951, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83L, "Claudio Ranieri" },
                    { 47L, new DateTime(1980, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Scott Parker" },
                    { 49L, new DateTime(1971, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Sean Dyche" },
                    { 51L, new DateTime(1977, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Eddie Howe" },
                    { 53L, new DateTime(1948, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Neil Warnock" },
                    { 55L, new DateTime(1963, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Mark Hughes" },
                    { 57L, new DateTime(1967, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11L, "Ralph Hasenhuttl" },
                    { 59L, new DateTime(1970, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 167L, "Javier Gracia" },
                    { 61L, new DateTime(1971, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 188L, "David Wagner" },
                    { 63L, new DateTime(1976, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65L, "Daniel Farke" },
                    { 65L, new DateTime(1953, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83L, "Manuel Pellegrini" }
                });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L, new DateTime(2019, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L, new DateTime(2019, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L, new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L });

            migrationBuilder.InsertData(
                table: "TeamEmployments",
                columns: new[] { "Id", "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 17L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L },
                    { 18L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "8E61EBEB6FA7EC29DDD4E808E63062632E4DCC66DDA28F555F51493501CABF43D7DA9BF620ADB39FE2B278CB7C384CC9E073A530E6B81319CCA33CE620EA9A90", new byte[] { 4, 125, 188, 118, 221, 152, 31, 230, 251, 132, 75, 47, 27, 8, 186, 188, 137, 160, 189, 123, 233, 194, 4, 121, 30, 111, 141, 39, 48, 238, 44, 110, 122, 26, 79, 241, 158, 214, 52, 197, 183, 220, 114, 136, 8, 150, 78, 42, 6, 230, 202, 195, 165, 53, 10, 31, 80, 115, 2, 123, 62, 200, 81, 64 } });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 18L, new DateTime(1980, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 17L, 53L, "Steven Gerard" },
                    { 20L, new DateTime(1965, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L, 167L, "Rudi Gomez" },
                    { 22L, new DateTime(1968, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21L, 81L, "Connor McAtee" },
                    { 24L, new DateTime(1972, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 23L, 53L, "John Arnold" },
                    { 26L, new DateTime(1966, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 25L, 83L, "Gianfranco Zola" },
                    { 28L, new DateTime(1976, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27L, 53L, "Mike Tidy" },
                    { 30L, new DateTime(1976, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29L, 141L, "Bruno Lagos" },
                    { 32L, new DateTime(1965, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31L, 167L, "Pablo Muriccio" },
                    { 34L, new DateTime(1966, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33L, 53L, "Ron Beasaley" },
                    { 36L, new DateTime(1955, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35L, 53L, "Tommy Corton" },
                    { 38L, new DateTime(1978, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 37L, 188L, "Aaron Hamilton" },
                    { 40L, new DateTime(1980, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L, 141L, "Alex Santos" },
                    { 42L, new DateTime(1960, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41L, 53L, "Michael Turner" },
                    { 44L, new DateTime(1969, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 43L, 167L, "Chema Sanz" },
                    { 46L, new DateTime(1958, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 45L, 83L, "Maxi Tolino" },
                    { 48L, new DateTime(1977, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47L, 154L, "Lorren Coleman" },
                    { 50L, new DateTime(1973, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 49L, 53L, "Henry Gothman" },
                    { 52L, new DateTime(1979, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 51L, 53L, "Gale Borrow" },
                    { 54L, new DateTime(1955, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 53L, 195L, "Max Nate" },
                    { 56L, new DateTime(1961, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 55L, 195L, "Garry Neil" },
                    { 58L, new DateTime(1970, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 57L, 65L, "Max Arnold" },
                    { 60L, new DateTime(1973, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 59L, 7L, "Robert Sanchez" },
                    { 62L, new DateTime(1978, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 61L, 65L, "Adrien Werner" },
                    { 64L, new DateTime(1970, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 63L, 172L, "Mark Leichemer" },
                    { 66L, new DateTime(1960, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65L, 83L, "Maximilliano Gallery" }
                });

            migrationBuilder.InsertData(
                table: "TeamEmployments",
                columns: new[] { "Id", "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 19L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 21L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L },
                    { 23L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21L, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L },
                    { 25L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L },
                    { 27L, new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 29L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27L, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 31L, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L },
                    { 33L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31L, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L },
                    { 35L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L },
                    { 37L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L },
                    { 39L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37L, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L },
                    { 41L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L },
                    { 43L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14L },
                    { 45L, new DateTime(2018, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 43L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L },
                    { 47L, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 45L, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L },
                    { 49L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47L, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L },
                    { 51L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L },
                    { 53L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 51L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17L },
                    { 55L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18L },
                    { 57L, new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 55L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L },
                    { 59L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 57L, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20L },
                    { 61L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 59L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21L },
                    { 63L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22L },
                    { 65L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23L },
                    { 67L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65L, new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { 20L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L },
                    { 22L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L },
                    { 24L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22L, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L },
                    { 26L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L },
                    { 28L, new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 26L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 30L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28L, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 32L, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L },
                    { 34L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32L, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L },
                    { 36L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L },
                    { 38L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L },
                    { 40L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38L, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L },
                    { 42L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L },
                    { 44L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14L },
                    { 46L, new DateTime(2018, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L },
                    { 48L, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 46L, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L },
                    { 50L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48L, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L },
                    { 52L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16L },
                    { 54L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17L },
                    { 56L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18L },
                    { 58L, new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 56L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L },
                    { 60L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 58L, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20L },
                    { 62L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21L },
                    { 64L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22L },
                    { 66L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 64L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23L },
                    { 68L, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66L, new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1972, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L, "Mauricio Pochettino" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1971, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Jesus Perez" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1971, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Unai Emery" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BirthDate", "BossId", "Name" },
                values: new object[] { new DateTime(1963, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, "Pako Ayestaran" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1971, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Josep Guardiola" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1982, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Mikel Arteta" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1967, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 65L, "Jurgen Klopp" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BirthDate", "CountryId", "Name" },
                values: new object[] { new DateTime(1975, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22L, "Zeljko Buvac" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1980, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L, 53L, "Steven Gerrard" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1959, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83L, "Maurizio Sarri" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1966, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, 83L, "Gianfranco Zola" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1978, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53L, "Frank Lampard" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[] { new DateTime(1977, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14L, 53L, "Ashley Cole" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BirthDate", "BossId", "Name" },
                values: new object[] { new DateTime(1976, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L, "Michael Ballack" });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndDate", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 4L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 7L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 5L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 8L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 5L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 9L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 6L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 10L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 6L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 11L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 6L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 12L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 13L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 14L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 15L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndDate", "StaffId", "StartDate", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 16L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "45A5DED81D4D597C3A41340A3490FDE9D0E159C35FFF09375677151235517C4A60BB5D8199107273B895B48BE40D0B02FCD1881327FD667561AEE49F358829CA", new byte[] { 2, 193, 162, 159, 198, 122, 199, 15, 200, 54, 92, 102, 155, 56, 140, 21, 102, 125, 46, 112, 28, 2, 81, 70, 184, 225, 131, 44, 204, 228, 201, 68, 25, 189, 254, 129, 150, 232, 226, 196, 236, 188, 34, 254, 81, 24, 3, 124, 232, 55, 74, 101, 166, 73, 130, 12, 170, 136, 247, 209, 129, 107, 252, 31 } });
        }
    }
}
