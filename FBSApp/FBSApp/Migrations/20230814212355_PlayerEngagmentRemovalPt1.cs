using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class PlayerEngagmentRemovalPt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1247L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7970C71635155F3AB6EEB7040D75B4D4E053E0F4A3477C81F91389EF66EBD4F487DC572C44200A5A53B96A4CF28A0F8D1D82C88A8C274277BED193AA7B4991B7", new byte[] { 248, 45, 40, 64, 183, 236, 50, 17, 208, 171, 138, 154, 217, 194, 70, 221, 34, 171, 83, 96, 112, 32, 227, 114, 129, 51, 182, 181, 196, 216, 85, 127, 83, 236, 212, 169, 119, 153, 22, 37, 41, 15, 24, 186, 255, 215, 53, 124, 71, 168, 211, 174, 12, 194, 99, 200, 127, 18, 68, 123, 159, 10, 124, 83 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 406L, new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 406L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L },
                    { 1247L, new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1122L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "F4941FF8B55BF8ACF5650EB4094BDD8F265A9586E2C367F14E119849F59ECCAA02B543813B024380FDBDE9FD400980CFC7BEBB1CAE245B1FD3EACC9EEC71C34E", new byte[] { 183, 4, 41, 110, 201, 95, 105, 183, 167, 89, 134, 184, 107, 94, 236, 23, 223, 120, 33, 137, 192, 20, 146, 0, 207, 236, 45, 219, 132, 191, 193, 144, 131, 54, 239, 165, 53, 89, 244, 8, 236, 50, 182, 172, 23, 248, 116, 90, 247, 17, 194, 38, 69, 148, 75, 91, 140, 106, 233, 122, 4, 43, 220, 6 } });
        }
    }
}
