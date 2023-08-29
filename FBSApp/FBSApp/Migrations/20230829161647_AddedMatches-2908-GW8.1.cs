using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW81 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 80100L, true, 80L, 71, 1205L },
                    { 80101L, false, 80L, 19, 1223L },
                    { 80102L, true, 80L, 80, 1215L },
                    { 80103L, false, 80L, 10, 1245L },
                    { 80104L, true, 80L, 86, 1237L },
                    { 80105L, false, 80L, 4, 1224L },
                    { 80106L, true, 80L, 90, 1230L },
                    { 80107L, true, 80L, 90, 1211L },
                    { 80108L, true, 80L, 90, 1236L },
                    { 80109L, true, 80L, 90, 1227L },
                    { 80110L, true, 80L, 90, 1218L },
                    { 80111L, true, 80L, 90, 1206L },
                    { 80112L, true, 80L, 90, 1209L },
                    { 80113L, true, 80L, 90, 1219L },
                    { 80114L, false, 80L, 0, 1217L },
                    { 80115L, false, 80L, 0, 1226L },
                    { 80116L, false, 80L, 0, 1210L },
                    { 80117L, false, 80L, 0, 1214L },
                    { 80200L, true, 80L, 60, 330L },
                    { 80201L, false, 80L, 30, 326L },
                    { 80202L, true, 80L, 70, 302L },
                    { 80203L, false, 80L, 20, 321L },
                    { 80204L, true, 80L, 83, 324L },
                    { 80205L, false, 80L, 7, 331L },
                    { 80206L, true, 80L, 90, 322L },
                    { 80207L, true, 80L, 90, 329L },
                    { 80208L, true, 80L, 90, 312L },
                    { 80209L, true, 80L, 90, 315L },
                    { 80210L, true, 80L, 90, 305L },
                    { 80211L, true, 80L, 90, 311L },
                    { 80212L, true, 80L, 90, 313L },
                    { 80213L, true, 80L, 90, 325L },
                    { 80214L, false, 80L, 0, 601L },
                    { 80215L, false, 80L, 0, 300L },
                    { 80216L, false, 80L, 0, 333L },
                    { 80217L, false, 80L, 0, 304L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E9D2E29998A328246DA4B40FF2923AC5250093AE3E184A39B6A534E1A470B043B10A7BD5046172B7DDB0314D7BCF0B74670864CA47F63978B8B1C95D1AD42484", new byte[] { 94, 225, 24, 67, 154, 52, 161, 172, 166, 19, 195, 174, 213, 170, 197, 241, 217, 20, 134, 93, 117, 89, 103, 20, 211, 90, 222, 74, 142, 150, 252, 147, 196, 15, 159, 9, 227, 121, 48, 99, 168, 86, 170, 254, 55, 234, 110, 78, 110, 14, 226, 102, 221, 109, 234, 120, 40, 61, 120, 168, 40, 233, 145, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "D810D7B4EAA70F692E2667ED171AE9C48BB767A319854CA60A1E6227E5F6AACA1C611E92C4347553E92FC08C39D1503BC31D22608D2797D0A9F7C4C23FBBEDCE", new byte[] { 152, 28, 252, 29, 155, 38, 18, 152, 22, 13, 65, 86, 44, 202, 93, 144, 22, 207, 7, 27, 252, 186, 96, 36, 55, 176, 235, 20, 55, 90, 112, 134, 24, 241, 179, 82, 84, 169, 136, 165, 197, 133, 200, 137, 232, 207, 8, 224, 228, 194, 191, 198, 17, 58, 208, 113, 225, 186, 47, 86, 32, 168, 47, 236 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 80217L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "32EAD1C094A92997E84BC327A15C61CE8AF61D155067164862589EF40933E986A29CECA7CB4E0064AC26451F37B2E587E4172DDA4F58E08A571542C0F497EA91", new byte[] { 88, 145, 19, 2, 200, 141, 232, 229, 39, 191, 62, 80, 86, 16, 72, 122, 135, 120, 88, 189, 65, 180, 254, 62, 253, 161, 8, 8, 15, 96, 30, 218, 113, 213, 94, 93, 67, 218, 138, 54, 65, 198, 195, 33, 96, 184, 193, 124, 97, 111, 178, 142, 150, 88, 67, 36, 181, 32, 184, 241, 166, 160, 79, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6943E11D4519DC36A5E9EEF40532F1E51FE0A7F6952E9EEE64210EAA5EDD1317EFE89E14CE9E2BDF667B3849BD4985916F9B8CCFE94D265A138E920E611C54A5", new byte[] { 39, 13, 152, 217, 36, 64, 48, 186, 38, 41, 71, 30, 62, 250, 183, 89, 45, 0, 91, 149, 133, 229, 210, 250, 171, 164, 214, 28, 123, 146, 92, 183, 75, 252, 189, 7, 37, 198, 22, 12, 118, 8, 148, 169, 234, 148, 91, 98, 175, 238, 20, 61, 188, 24, 4, 76, 145, 163, 195, 230, 82, 80, 196, 113 } });
        }
    }
}
