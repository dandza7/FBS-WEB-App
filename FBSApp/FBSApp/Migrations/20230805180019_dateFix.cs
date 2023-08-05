using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class dateFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Date",
                value: new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "AA45DAD2921B6D4D97A24407E4B263C41FE1725BD9E7444AA9DA6ABB9AC810C22FE1A7A54D1E5482796A2E0AAD3553B509AC4078A8CBE1655815B7A10D267B06", new byte[] { 27, 92, 191, 38, 95, 69, 93, 8, 126, 215, 54, 42, 46, 178, 249, 174, 182, 234, 253, 25, 176, 234, 7, 19, 119, 112, 86, 222, 247, 18, 72, 213, 173, 174, 238, 79, 137, 111, 184, 205, 197, 141, 74, 119, 183, 227, 31, 96, 109, 155, 249, 55, 162, 92, 152, 25, 117, 154, 6, 110, 109, 232, 12, 58 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Date",
                value: new DateTime(2019, 1, 3, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "72E510DC6BF5EDF6ECE1697B07C2E02254A0182EC74E29ACC570CB22DFDA7390417AEE7540C8A93509E46499629D6F42E55707D06A0D129ED91134827C634AA5", new byte[] { 30, 20, 84, 155, 208, 208, 132, 30, 152, 113, 21, 236, 148, 82, 86, 253, 233, 231, 94, 1, 87, 71, 71, 180, 225, 41, 134, 211, 101, 201, 239, 17, 220, 118, 156, 169, 51, 51, 162, 86, 208, 176, 11, 198, 103, 13, 253, 83, 23, 43, 41, 18, 137, 135, 65, 232, 18, 127, 234, 44, 247, 184, 132, 106 } });
        }
    }
}
