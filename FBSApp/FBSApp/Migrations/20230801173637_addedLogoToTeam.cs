using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedLogoToTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Teams",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "29294EBC61AAC9B0130B3FD70DB42F7C9560256FE65C53937393784646F3E4BC8903755220DBF5E8E4DAEA8CF8B4A4A9F6127E4EC6F9ED2499D6C51339B3DED0", new byte[] { 150, 52, 149, 5, 53, 189, 15, 108, 239, 199, 89, 86, 163, 66, 164, 26, 66, 239, 239, 21, 96, 137, 66, 106, 158, 123, 162, 231, 151, 88, 22, 134, 54, 52, 245, 175, 78, 16, 184, 117, 96, 34, 173, 46, 68, 223, 128, 70, 243, 189, 31, 246, 240, 35, 76, 168, 75, 47, 133, 179, 166, 26, 82, 146 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6617E8CA4FB09B09AD60CA83D4386D10C03CF0668107485212BC431305E7F2ED89192C992B31AF37894B0CBCA05AD7060CC6D0C13209759E997974FF14FF5B79", new byte[] { 158, 27, 52, 50, 186, 233, 12, 138, 76, 6, 238, 244, 75, 69, 29, 233, 132, 152, 115, 223, 141, 176, 2, 41, 209, 43, 95, 75, 24, 220, 0, 75, 139, 245, 157, 89, 3, 226, 209, 91, 232, 96, 92, 18, 134, 8, 211, 93, 144, 80, 210, 67, 181, 15, 243, 39, 235, 155, 240, 152, 174, 135, 6, 198 } });
        }
    }
}
