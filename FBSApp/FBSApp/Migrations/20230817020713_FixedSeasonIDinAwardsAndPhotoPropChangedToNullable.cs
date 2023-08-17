using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeasonIDinAwardsAndPhotoPropChangedToNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 22L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 23L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 24L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 25L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 26L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 27L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 28L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 29L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 30L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 31L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 32L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 33L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 34L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 35L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 36L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 38L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 39L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 40L,
                column: "SeasonId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "AD9D191C8376966E9ABA0868D4F72104D1203D066E92A01FF2EACD10747D75EA2B5183A9862CB00C344BC5356C56E616B3DBAEC2F6A1159F8DDE72C20F0A906F", new byte[] { 134, 54, 45, 190, 214, 128, 60, 96, 89, 163, 137, 232, 68, 154, 153, 17, 218, 215, 192, 125, 75, 194, 2, 113, 30, 211, 13, 249, 141, 57, 49, 97, 69, 108, 31, 249, 153, 115, 64, 51, 78, 72, 184, 9, 115, 147, 253, 122, 213, 8, 101, 107, 131, 39, 134, 231, 186, 231, 188, 210, 52, 238, 202, 219 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 22L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 23L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 24L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 25L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 26L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 27L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 28L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 29L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 30L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 31L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 32L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 33L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 34L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 35L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 36L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 38L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 39L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 40L,
                column: "SeasonId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "5BCF808344F1465CEE7254109AC2AE909E817F05688380F085AB5A6A96E82D6A7144EAB01D3E904E015B2DD29C682FE8CA632FD8A2572B1351535F9111944D48", new byte[] { 160, 236, 190, 174, 67, 250, 83, 188, 103, 9, 239, 177, 146, 14, 245, 95, 52, 229, 173, 151, 38, 166, 225, 190, 20, 234, 244, 204, 236, 107, 23, 118, 110, 122, 51, 240, 50, 226, 121, 166, 15, 38, 87, 152, 5, 202, 118, 5, 76, 1, 116, 234, 23, 56, 95, 76, 94, 166, 121, 40, 240, 49, 117, 227 } });
        }
    }
}
