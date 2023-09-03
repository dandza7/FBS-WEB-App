using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches03092 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22221L,
                column: "GoalInfoId",
                value: 222208L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22222L,
                column: "GoalInfoId",
                value: 222208L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22223L,
                column: "GoalInfoId",
                value: 222202L);

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222201L,
                column: "Minutes",
                value: 49);

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222202L,
                columns: new[] { "IsStarter", "Minutes" },
                values: new object[] { false, 22 });

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222203L,
                columns: new[] { "Minutes", "PlayerId" },
                values: new object[] { 1, 2101L });

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222204L,
                columns: new[] { "Minutes", "PlayerId" },
                values: new object[] { 89, 2134L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "878E32BCD5D1AEA4CA89F397ED7C9C0895AEE73BE4115AC890E232AF997A98131DF7CE170BFFD6DF286DF78EE518447AA2402F79F41E4F93499EA31B6AE758A5", new byte[] { 249, 120, 30, 144, 153, 106, 37, 40, 45, 5, 223, 70, 0, 37, 4, 228, 57, 222, 35, 11, 171, 136, 231, 156, 97, 83, 158, 173, 77, 143, 250, 62, 76, 18, 193, 233, 198, 230, 13, 217, 137, 187, 166, 5, 190, 125, 187, 217, 203, 72, 200, 202, 81, 124, 106, 105, 234, 183, 129, 144, 133, 125, 207, 170 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9B50E274C2E81F2180E817F6930F127A6EE3DA4C62A3A8CC743009D83046A66957C3AB746150C4471134FF890126FA084AF1DF67D9BD64AFD77EFDE86A6C9E6D", new byte[] { 80, 8, 42, 232, 182, 15, 216, 50, 8, 203, 3, 84, 97, 118, 169, 245, 96, 205, 215, 156, 119, 106, 231, 136, 159, 184, 50, 147, 44, 142, 99, 2, 136, 80, 112, 55, 51, 32, 179, 14, 51, 195, 211, 125, 74, 182, 249, 125, 207, 191, 203, 72, 186, 150, 64, 246, 197, 109, 6, 166, 123, 70, 43, 237 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22221L,
                column: "GoalInfoId",
                value: 222209L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22222L,
                column: "GoalInfoId",
                value: 222209L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22223L,
                column: "GoalInfoId",
                value: 222203L);

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222201L,
                column: "Minutes",
                value: 68);

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222202L,
                columns: new[] { "IsStarter", "Minutes" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222203L,
                columns: new[] { "Minutes", "PlayerId" },
                values: new object[] { 89, 2134L });

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 222204L,
                columns: new[] { "Minutes", "PlayerId" },
                values: new object[] { 1, 2102L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "05CF2ACB50D3F010456A01E11AA6EC1B7A826FB99F32D0CDFE6942A33556617E0FDA2BD4AC5141558E6847295CFF44AEF8A0D0616831D9462E4B80299F5052DB", new byte[] { 39, 113, 53, 32, 10, 237, 72, 192, 129, 205, 210, 118, 56, 27, 132, 7, 148, 100, 225, 76, 236, 88, 6, 152, 150, 205, 24, 58, 169, 241, 101, 169, 64, 239, 108, 73, 37, 252, 250, 43, 13, 140, 126, 85, 187, 140, 119, 36, 223, 33, 224, 181, 39, 215, 105, 164, 103, 150, 194, 10, 164, 34, 20, 189 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "ABA8D05D8E9E40160F9406124F7EE585303A526779E197BD567B226AC00CA32FC32C4251A6EBEC00F44700A1D3441B71E4558CEC0F43B0A5838EF2C2471256F0", new byte[] { 121, 83, 238, 118, 101, 238, 38, 212, 186, 36, 244, 232, 155, 195, 119, 136, 167, 36, 219, 80, 178, 134, 204, 114, 154, 176, 70, 101, 84, 35, 197, 162, 216, 115, 250, 165, 128, 107, 136, 225, 72, 19, 116, 236, 129, 40, 85, 30, 116, 61, 172, 76, 165, 254, 6, 191, 58, 64, 237, 246, 135, 214, 88, 119 } });
        }
    }
}
