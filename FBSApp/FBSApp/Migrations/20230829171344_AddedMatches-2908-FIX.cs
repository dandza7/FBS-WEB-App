using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908FIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3511L,
                column: "GoalInfoId",
                value: 35112L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4812L,
                column: "IsOwnGoal",
                value: true);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5321L,
                column: "GoalInfoId",
                value: 53211L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6722L,
                column: "IsOwnGoal",
                value: false);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8512L,
                column: "GoalInfoId",
                value: 85209L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9914L,
                column: "IsOwnGoal",
                value: true);

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 801L, 1, 2, 12, 8, 5, 282, 35, 0, 4, 9, 4, 17, 801L, 3 },
                    { 802L, 5, 9, 8, 18, 1, 514, 65, 0, 3, 16, 4, 12, 802L, 2 },
                    { 811L, 10, 10, 11, 11, 1, 374, 47, 1, 3, 14, 2, 17, 811L, 5 },
                    { 812L, 0, 7, 9, 11, 2, 428, 53, 0, 2, 10, 7, 9, 812L, 1 },
                    { 821L, 6, 6, 7, 14, 0, 685, 76, 0, 6, 19, 7, 18, 821L, 3 },
                    { 822L, 0, 2, 11, 7, 3, 222, 24, 1, 6, 8, 6, 15, 822L, 1 },
                    { 831L, 1, 2, 10, 11, 5, 461, 51, 1, 6, 8, 2, 13, 831L, 4 },
                    { 832L, 4, 10, 11, 15, 0, 422, 49, 0, 1, 17, 8, 11, 832L, 1 },
                    { 841L, 3, 6, 11, 14, 1, 641, 67, 0, 1, 11, 4, 17, 841L, 3 },
                    { 842L, 0, 3, 13, 12, 1, 314, 33, 0, 4, 7, 2, 19, 842L, 4 },
                    { 851L, 3, 1, 9, 11, 3, 275, 32, 0, 1, 6, 3, 16, 851L, 2 },
                    { 852L, 9, 10, 11, 11, 0, 581, 68, 0, 2, 19, 2, 11, 852L, 2 },
                    { 861L, 3, 10, 16, 9, 1, 610, 73, 0, 6, 18, 10, 10, 861L, 2 },
                    { 862L, 0, 6, 8, 18, 0, 222, 27, 0, 7, 13, 8, 18, 862L, 2 },
                    { 871L, 9, 4, 11, 13, 4, 473, 49, 0, 2, 21, 4, 15, 871L, 2 },
                    { 872L, 0, 2, 12, 15, 1, 504, 51, 0, 3, 9, 7, 20, 872L, 0 },
                    { 881L, 3, 4, 13, 11, 0, 346, 35, 0, 3, 15, 6, 21, 881L, 6 },
                    { 882L, 12, 12, 11, 13, 0, 651, 65, 0, 6, 21, 6, 13, 882L, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "D9BFCA8598F2284FFE00AEE8AF3BF5D1D7E5B08653CBEB236D965135A72BC481ACD5D9354453D855D5BB01BFF42B54C3ADA4892B457740EBE67D4F9517EB309E", new byte[] { 72, 201, 134, 86, 25, 252, 82, 45, 171, 117, 6, 207, 147, 82, 58, 8, 42, 78, 196, 212, 28, 36, 113, 202, 169, 165, 146, 122, 161, 225, 107, 70, 38, 52, 121, 174, 50, 153, 164, 203, 230, 137, 246, 79, 114, 81, 60, 47, 240, 132, 69, 110, 111, 25, 144, 128, 35, 40, 251, 63, 49, 122, 73, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "C7A386BD3A11D356B91B698879FF80F0E2590845BBC1FED7C3CAF5CBD6B17F6C247F945B381E767AC9C6C4886A599F73E2E4754F9747DE95C2000A0A43A847B2", new byte[] { 34, 134, 197, 81, 80, 194, 55, 242, 224, 0, 159, 89, 6, 71, 38, 227, 126, 213, 211, 2, 107, 215, 20, 227, 130, 241, 61, 185, 170, 18, 164, 152, 69, 150, 178, 90, 69, 165, 109, 14, 20, 164, 174, 40, 246, 194, 229, 149, 254, 175, 32, 248, 252, 0, 28, 62, 108, 128, 129, 102, 71, 101, 63, 85 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 811L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 812L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 821L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 822L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 831L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 832L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 841L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 842L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 851L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 852L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 861L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 862L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 871L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 872L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 881L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 882L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3511L,
                column: "GoalInfoId",
                value: 34112L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4812L,
                column: "IsOwnGoal",
                value: false);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5321L,
                column: "GoalInfoId",
                value: 52211L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6722L,
                column: "IsOwnGoal",
                value: true);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8512L,
                column: "GoalInfoId",
                value: 85109L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9914L,
                column: "IsOwnGoal",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DE19A03D98743428FE7416BB415B6CF85B45CD27FAEB7EFE333E24E93563BF2BD8807DA50C3296CFB42B9DEC3AD487C4578628CBAEB275D548FF8CC919F243E5", new byte[] { 38, 201, 221, 56, 47, 220, 50, 226, 104, 33, 185, 215, 98, 217, 157, 39, 18, 201, 137, 99, 173, 101, 14, 28, 43, 157, 0, 127, 102, 84, 187, 97, 105, 157, 199, 133, 0, 112, 19, 67, 247, 36, 240, 129, 133, 168, 157, 158, 214, 63, 44, 54, 27, 211, 242, 113, 219, 2, 43, 147, 194, 132, 246, 107 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "65EE6D26021D8C0957F9D19A67393145538D2DBCA548D233D242B539591A33E7271951938552FD261EFF65ECAA016F3C4248D4C7438B669CFD05CB1758994ADA", new byte[] { 142, 100, 37, 14, 120, 203, 69, 30, 183, 121, 184, 203, 157, 83, 128, 21, 200, 147, 191, 244, 11, 103, 119, 17, 22, 146, 9, 64, 212, 194, 215, 134, 116, 142, 86, 193, 149, 209, 147, 162, 245, 134, 88, 133, 210, 46, 39, 174, 122, 50, 18, 22, 83, 44, 16, 209, 16, 176, 92, 41, 151, 133, 67, 13 } });
        }
    }
}
