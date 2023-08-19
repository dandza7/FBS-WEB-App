using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMissingTEpt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1705L,
                column: "StartDate",
                value: new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "D15496260759089170EC99511B87403DA00842912BC9B8CF98931401132B82A6CFB6B77667F6AE5795D1365CB2AB7A6CD2ACD6F0DB7507681040E6BF1D4F54E7", new byte[] { 175, 249, 213, 214, 85, 245, 244, 233, 24, 175, 80, 221, 1, 76, 116, 94, 81, 1, 15, 12, 181, 199, 58, 168, 89, 166, 180, 107, 71, 2, 148, 75, 58, 40, 42, 21, 202, 68, 206, 75, 53, 7, 219, 191, 220, 209, 224, 231, 67, 204, 155, 99, 133, 124, 126, 159, 37, 152, 86, 109, 131, 228, 106, 16 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1705L,
                column: "StartDate",
                value: new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9763EA0E73B512D497724EF807914E59E5904780010C0C20791AF01A0CF1F559CE13A531CF3D0360333F662CD88D6C32244212F982D21CFB3AB0186F4670B587", new byte[] { 92, 42, 70, 58, 197, 170, 12, 76, 85, 183, 33, 167, 239, 171, 146, 189, 49, 242, 64, 123, 171, 235, 111, 75, 242, 0, 187, 236, 69, 181, 72, 79, 224, 193, 83, 63, 61, 39, 139, 118, 140, 178, 210, 157, 133, 69, 54, 253, 233, 228, 174, 0, 19, 48, 61, 190, 72, 84, 248, 130, 216, 24, 206, 231 } });
        }
    }
}
