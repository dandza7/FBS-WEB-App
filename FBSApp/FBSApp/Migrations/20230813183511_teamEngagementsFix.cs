using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class teamEngagementsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 449L,
                columns: new[] { "PlayerId", "TeamId" },
                values: new object[] { 941L, 4L });

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 530L,
                column: "TeamId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 700L,
                column: "TeamId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 801L,
                column: "TeamId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 802L,
                column: "TeamId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1000L,
                column: "TeamId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1001L,
                column: "TeamId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1002L,
                column: "TeamId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1100L,
                column: "TeamId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1400L,
                column: "TeamId",
                value: 14L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1401L,
                column: "TeamId",
                value: 14L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1402L,
                column: "TeamId",
                value: 14L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1403L,
                column: "TeamId",
                value: 14L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1500L,
                column: "TeamId",
                value: 15L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1501L,
                column: "TeamId",
                value: 15L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1502L,
                column: "TeamId",
                value: 15L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1503L,
                column: "TeamId",
                value: 15L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1600L,
                column: "TeamId",
                value: 16L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1900L,
                column: "TeamId",
                value: 19L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1901L,
                column: "TeamId",
                value: 19L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1902L,
                column: "TeamId",
                value: 19L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2100L,
                column: "TeamId",
                value: 21L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2300L,
                column: "TeamId",
                value: 23L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "41F40904BA44B06B8EC2764DFE98AAE2819E07ACF605F1E8DD3E1873738DCF46A6E086180C564093634D52275B474C776364034E8115FF27B1E01FB6EA89CA83", new byte[] { 205, 67, 189, 72, 35, 202, 128, 154, 96, 233, 21, 207, 37, 141, 114, 247, 236, 95, 160, 21, 80, 49, 51, 108, 169, 183, 108, 127, 135, 194, 125, 138, 46, 163, 5, 246, 112, 253, 161, 107, 149, 206, 216, 18, 243, 189, 230, 107, 67, 105, 239, 91, 110, 229, 199, 187, 48, 121, 167, 46, 40, 88, 20, 84 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 449L,
                columns: new[] { "PlayerId", "TeamId" },
                values: new object[] { 942L, 9L });

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 530L,
                column: "TeamId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 700L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 801L,
                column: "TeamId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 802L,
                column: "TeamId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1000L,
                column: "TeamId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1001L,
                column: "TeamId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1002L,
                column: "TeamId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1100L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1400L,
                column: "TeamId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1401L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1402L,
                column: "TeamId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1403L,
                column: "TeamId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1500L,
                column: "TeamId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1501L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1502L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1503L,
                column: "TeamId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1600L,
                column: "TeamId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1900L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1901L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1902L,
                column: "TeamId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2100L,
                column: "TeamId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 2300L,
                column: "TeamId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4C7C28FD62244CCFEA42CC61F49A287D6968732F3256A8BE11F46B5C14A59446F4D90FEB56CD79FB52802FE291DF185A71038B7C83E73FDD7F68F3A834B43E4A", new byte[] { 164, 29, 141, 56, 220, 34, 120, 205, 150, 28, 12, 21, 10, 186, 133, 248, 241, 90, 102, 197, 75, 70, 0, 105, 3, 245, 102, 168, 179, 193, 80, 223, 138, 192, 75, 43, 196, 85, 84, 100, 178, 187, 212, 80, 33, 198, 157, 240, 176, 39, 68, 144, 33, 77, 150, 117, 78, 244, 103, 146, 111, 10, 130, 72 } });
        }
    }
}
