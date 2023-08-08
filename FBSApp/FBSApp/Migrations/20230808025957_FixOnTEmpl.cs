using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class FixOnTEmpl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StaffId",
                value: 65L);

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StaffId",
                value: 66L);

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 67L,
                column: "StaffId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 68L,
                column: "StaffId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DAB85829C7A069029F2F51AA269ABBB6D540FA0ABCF84EF422A755A6ABEC59EA2D8594FF6AE77F36D1ACFEC00944B20B25A6374DAF752A4F119EC06671BAE10E", new byte[] { 171, 140, 150, 179, 184, 251, 85, 238, 236, 173, 195, 219, 141, 183, 60, 173, 99, 205, 211, 132, 75, 167, 150, 33, 201, 66, 238, 19, 253, 196, 172, 64, 49, 244, 166, 40, 39, 120, 165, 61, 242, 126, 239, 50, 91, 192, 142, 213, 189, 197, 130, 27, 147, 64, 102, 152, 14, 71, 235, 142, 160, 170, 148, 181 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StaffId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StaffId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 67L,
                column: "StaffId",
                value: 65L);

            migrationBuilder.UpdateData(
                table: "TeamEmployments",
                keyColumn: "Id",
                keyValue: 68L,
                column: "StaffId",
                value: 66L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "8E61EBEB6FA7EC29DDD4E808E63062632E4DCC66DDA28F555F51493501CABF43D7DA9BF620ADB39FE2B278CB7C384CC9E073A530E6B81319CCA33CE620EA9A90", new byte[] { 4, 125, 188, 118, 221, 152, 31, 230, 251, 132, 75, 47, 27, 8, 186, 188, 137, 160, 189, 123, 233, 194, 4, 121, 30, 111, 141, 39, 48, 238, 44, 110, 122, 26, 79, 241, 158, 214, 52, 197, 183, 220, 114, 136, 8, 150, 78, 42, 6, 230, 202, 195, 165, 53, 10, 31, 80, 115, 2, 123, 62, 200, 81, 64 } });
        }
    }
}
