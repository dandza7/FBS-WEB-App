using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches05096 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25911L,
                column: "GoalInfoId",
                value: 259112L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25921L,
                column: "GoalInfoId",
                value: 259212L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "5ADC5EEFBF2E6A09BE57E51C78CCC0FDB8F625416CDE83EF3EF278B58CB79B2A30FC7AA0B3066F240747455CE46AD0F22A6396DC05DED643F9A338F6E6A1AB27", new byte[] { 15, 67, 40, 169, 60, 180, 239, 250, 2, 178, 194, 30, 125, 104, 128, 250, 78, 254, 2, 140, 138, 130, 33, 178, 213, 237, 174, 41, 135, 66, 177, 204, 151, 36, 218, 80, 246, 246, 44, 76, 24, 245, 39, 248, 74, 181, 124, 91, 105, 128, 126, 2, 19, 58, 82, 246, 172, 66, 44, 156, 175, 163, 185, 143 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "16B0D0A195D928388A9FDFF8029EDBF57B08AEC8FEDF39DB085B29C5D889F30AB4B94929DFB9C8B483F7C0F9A0A8204BC810D98D892507BFAEE9EAECC40A8C78", new byte[] { 211, 245, 75, 219, 69, 192, 24, 139, 141, 115, 109, 62, 222, 109, 179, 253, 242, 35, 113, 79, 181, 179, 93, 245, 182, 249, 153, 1, 58, 122, 12, 176, 57, 142, 97, 70, 154, 139, 150, 44, 85, 144, 198, 216, 206, 251, 197, 115, 7, 157, 119, 34, 231, 80, 97, 59, 151, 127, 38, 70, 56, 202, 224, 208 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25911L,
                column: "GoalInfoId",
                value: 258112L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25921L,
                column: "GoalInfoId",
                value: 258212L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "1191E6D66616CE2E7F397A4231365D6620192987668185E894936FAE07C80FF3BFF6069C6BBCDC14F5ED42CE96A28981A01ABBF5C21CEAA129F7DC63CF7A14DC", new byte[] { 222, 21, 51, 209, 48, 83, 32, 21, 59, 215, 146, 183, 121, 4, 41, 137, 194, 192, 146, 84, 49, 155, 38, 154, 66, 71, 115, 200, 12, 109, 100, 228, 131, 88, 189, 156, 216, 241, 35, 48, 214, 143, 247, 30, 123, 105, 164, 21, 139, 42, 153, 218, 92, 86, 157, 198, 78, 160, 255, 179, 185, 132, 160, 87 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "5774CA7283C63585101ECB6C964D8F95888E66884DA35AA4F1B23A29755F831C70AFCF5452C27F34A00B0E6E5122E2CA2A46102C16FC255C188003606EAD48A6", new byte[] { 104, 214, 92, 173, 101, 30, 182, 170, 66, 48, 242, 208, 70, 223, 141, 203, 224, 248, 187, 239, 198, 108, 177, 193, 187, 7, 253, 4, 204, 54, 186, 189, 227, 187, 210, 196, 47, 124, 88, 188, 135, 190, 20, 169, 12, 102, 73, 54, 4, 114, 37, 48, 98, 121, 84, 183, 212, 117, 199, 122, 23, 175, 248, 130 } });
        }
    }
}
