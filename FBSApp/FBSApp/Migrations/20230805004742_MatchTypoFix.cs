using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class MatchTypoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TeamId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "542F1C79B40B59583AE91EB893A2E40E1B60DECE936C3B6D69A1CD5E6971BB07E9C5976EA95E52FF663AB898B2A474936DD840D15221A93813583EACB38F63ED", new byte[] { 198, 121, 231, 33, 89, 65, 31, 136, 200, 65, 134, 119, 44, 9, 192, 141, 133, 175, 13, 156, 141, 168, 213, 237, 134, 191, 36, 234, 251, 214, 227, 38, 89, 157, 213, 142, 63, 162, 232, 197, 11, 137, 204, 83, 144, 181, 139, 12, 194, 213, 53, 80, 169, 84, 18, 220, 152, 132, 245, 22, 20, 171, 84, 92 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "MatchActors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TeamId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BEEF12FDB410E1B4AB0B4AD7B631B4E0120DA0ADE0F6BFA4C9B91E7BF3773F1B284239E0C3A2C3F51E3D091A4AEFD5570F9030A272FBC3BC388EF4C827C88D27", new byte[] { 234, 43, 1, 109, 202, 247, 232, 94, 178, 48, 219, 168, 166, 39, 141, 189, 28, 140, 218, 126, 7, 172, 79, 255, 243, 112, 117, 69, 161, 145, 168, 141, 219, 242, 186, 43, 253, 71, 247, 251, 102, 70, 119, 224, 128, 19, 116, 112, 83, 189, 82, 52, 46, 116, 158, 12, 142, 188, 197, 112, 23, 3, 251, 18 } });
        }
    }
}
