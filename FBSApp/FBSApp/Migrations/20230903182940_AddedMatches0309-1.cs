using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches03091 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 19421L,
                column: "GoalInfoId",
                value: 194202L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 23221L,
                column: "IsOwnGoal",
                value: true);

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 22221L, 222209L, false, true, 38 },
                    { 22222L, 222209L, false, false, 68 },
                    { 22223L, 222203L, false, false, 74 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22222L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22223L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 19421L,
                column: "GoalInfoId",
                value: 194102L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 23221L,
                column: "IsOwnGoal",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "2CB2A8DB3DD6A333848D1A374211E742AEC0BDAC023CCE894AF71229BE23D68552593A2B7DF2643394F809AC7F97693678152496724334DC3EF6D1282AA1590A", new byte[] { 38, 4, 219, 146, 55, 51, 170, 134, 78, 31, 100, 88, 173, 243, 55, 227, 87, 179, 52, 170, 26, 54, 193, 37, 148, 216, 102, 255, 72, 254, 173, 134, 116, 6, 113, 228, 184, 230, 78, 200, 108, 227, 232, 192, 159, 100, 188, 132, 36, 51, 44, 238, 253, 86, 236, 46, 22, 208, 108, 202, 131, 47, 117, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "B7CE9AAFCF20616B6979B0459A96E734D10A98E29077719499074416137546B13CB7F8000C0F253AD1D2EE5F70E186A2356F53903078E683ADB5E2031A9AF635", new byte[] { 1, 80, 124, 7, 147, 224, 185, 211, 232, 179, 212, 123, 123, 187, 23, 57, 154, 232, 85, 47, 8, 172, 218, 192, 207, 249, 186, 67, 163, 70, 220, 154, 84, 6, 100, 231, 199, 149, 249, 66, 209, 114, 14, 112, 192, 115, 118, 86, 211, 65, 65, 130, 76, 130, 231, 216, 69, 33, 70, 249, 56, 67, 135, 249 } });
        }
    }
}
