using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMissingTEpt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[] { 1744L, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 623L, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9763EA0E73B512D497724EF807914E59E5904780010C0C20791AF01A0CF1F559CE13A531CF3D0360333F662CD88D6C32244212F982D21CFB3AB0186F4670B587", new byte[] { 92, 42, 70, 58, 197, 170, 12, 76, 85, 183, 33, 167, 239, 171, 146, 189, 49, 242, 64, 123, 171, 235, 111, 75, 242, 0, 187, 236, 69, 181, 72, 79, 224, 193, 83, 63, 61, 39, 139, 118, 140, 178, 210, 157, 133, 69, 54, 253, 233, 228, 174, 0, 19, 48, 61, 190, 72, 84, 248, 130, 216, 24, 206, 231 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1744L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "02516EF54165AAE86DFA68CC75399CE3993B4BF2ACA755A1E1E5BE9B5871F55AD980EC29EFA9D981CBAEC29C53315269A45D54A5D142A2B2E021EBF36FFE3BC7", new byte[] { 213, 188, 94, 127, 174, 63, 98, 32, 199, 102, 247, 138, 35, 170, 18, 16, 225, 228, 251, 214, 197, 136, 204, 35, 110, 7, 9, 233, 105, 17, 90, 235, 217, 170, 29, 70, 146, 2, 236, 32, 227, 91, 112, 62, 118, 108, 193, 175, 197, 236, 137, 102, 186, 145, 189, 129, 75, 66, 100, 219, 84, 116, 171, 238 } });
        }
    }
}
