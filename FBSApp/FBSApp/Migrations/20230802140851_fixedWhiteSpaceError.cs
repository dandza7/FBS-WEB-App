using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class fixedWhiteSpaceError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Position",
                value: "Attacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Position",
                value: "Goalkeeper");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Position",
                value: "Attacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Position",
                value: "Goalkeeper");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Position",
                value: "Goalkeeper");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Position",
                value: "Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Position",
                value: "Attacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Position",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6E66A90DCAA96C3DFA473A8D40CA6F64F183D7596918FBE2FBF175D504C2656D9519CFD600BAE7859E01BE5F6E9F33906AFD7C8C62DC39770CF72E963B3BCCB5", new byte[] { 42, 7, 53, 139, 243, 46, 183, 99, 181, 114, 239, 99, 182, 19, 20, 43, 33, 177, 175, 138, 64, 120, 57, 67, 151, 131, 248, 174, 97, 52, 74, 132, 101, 98, 244, 48, 41, 20, 229, 249, 68, 248, 31, 169, 249, 224, 227, 238, 219, 213, 141, 5, 14, 224, 204, 181, 18, 167, 103, 244, 122, 140, 48, 181 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Position",
                value: " Attacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Position",
                value: " Goalkeeper");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Position",
                value: " Attacker ");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Position",
                value: " Goalkeeper");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Position",
                value: " Goalkeeper");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Position",
                value: " Defender ");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Position",
                value: " Midfielder");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Position",
                value: " Attacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Position",
                value: " Defender ");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Position",
                value: " Defender");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9998AE43002A1E00CEA3A3D98C030B61D2884E3C76313AB25142775B23B99EEF8234A17123E0E6BDA1242B860AB356561BB7391E65F934BDA5B0C7C6B2C95CC7", new byte[] { 80, 232, 26, 72, 34, 70, 128, 131, 84, 250, 248, 109, 60, 29, 180, 128, 175, 215, 215, 172, 236, 119, 144, 202, 22, 250, 126, 123, 117, 112, 251, 26, 152, 69, 113, 217, 249, 206, 162, 173, 62, 4, 125, 187, 218, 146, 31, 192, 99, 17, 8, 65, 10, 71, 119, 173, 63, 80, 245, 176, 151, 42, 78, 52 } });
        }
    }
}
