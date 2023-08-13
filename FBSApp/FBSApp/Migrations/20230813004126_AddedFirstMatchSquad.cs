using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstMatchSquad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStarter",
                table: "PlayedMatches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 1100L, false, 1L, 25, 900L },
                    { 1101L, true, 1L, 65, 901L },
                    { 1105L, true, 1L, 90, 905L },
                    { 1109L, true, 1L, 90, 909L },
                    { 1110L, false, 1L, 0, 910L },
                    { 1112L, true, 1L, 90, 912L },
                    { 1118L, true, 1L, 90, 918L },
                    { 1122L, true, 1L, 90, 922L },
                    { 1123L, true, 1L, 90, 923L },
                    { 1128L, true, 1L, 90, 928L },
                    { 1130L, true, 1L, 73, 930L },
                    { 1132L, true, 1L, 90, 932L },
                    { 1133L, false, 1L, 0, 933L },
                    { 1134L, false, 1L, 6, 934L },
                    { 1137L, false, 1L, 0, 937L },
                    { 1138L, false, 1L, 14, 938L },
                    { 1141L, true, 1L, 84, 941L },
                    { 1142L, false, 1L, 0, 942L },
                    { 1201L, false, 1L, 25, 101L },
                    { 1202L, true, 1L, 90, 102L },
                    { 1203L, false, 1L, 0, 103L },
                    { 1205L, false, 1L, 0, 105L },
                    { 1207L, true, 1L, 90, 107L },
                    { 1213L, true, 1L, 90, 113L },
                    { 1215L, true, 1L, 71, 115L },
                    { 1220L, true, 1L, 81, 120L },
                    { 1221L, true, 1L, 90, 121L },
                    { 1222L, false, 1L, 19, 122L },
                    { 1223L, true, 1L, 65, 123L },
                    { 1226L, false, 1L, 0, 126L },
                    { 1227L, true, 1L, 90, 127L },
                    { 1229L, true, 1L, 90, 129L },
                    { 1231L, true, 1L, 90, 131L },
                    { 1232L, false, 1L, 9, 132L },
                    { 1235L, true, 1L, 90, 135L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9ACAB166DA14406B5067A3934CAE6457BF46276101FCD15D391933354EF3461366952590D068A2E8465BE1AAEB9B0A798E50906569B27960893EC885A394CF6F", new byte[] { 191, 93, 183, 210, 47, 50, 83, 238, 29, 172, 99, 88, 24, 32, 40, 112, 26, 171, 120, 207, 80, 112, 239, 236, 171, 121, 36, 56, 5, 11, 34, 155, 40, 152, 137, 177, 74, 106, 56, 251, 232, 34, 30, 82, 160, 236, 190, 101, 42, 30, 117, 99, 43, 58, 194, 220, 190, 108, 110, 52, 29, 49, 65, 81 } });

            migrationBuilder.InsertData(
                table: "Goal",
                columns: new[] { "Id", "GoalInfoId", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 111L, 1128L, false, 43 },
                    { 121L, 1220L, false, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goal",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Goal",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1118L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1122L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1123L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1130L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1132L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1133L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1134L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1137L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1138L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1141L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1142L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1221L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1222L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1223L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1226L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1227L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1229L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1231L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1232L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1235L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1128L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1220L);

            migrationBuilder.DropColumn(
                name: "IsStarter",
                table: "PlayedMatches");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "FED8F446C20B2FFA7BA7D9EAD37CA95516457A1D150BB83270ADFF03D57955479CBE3922E9A88759248B2D46B140D21850A434C96C3B80B7CE9DD7C9FDF4E2EE", new byte[] { 133, 95, 216, 240, 218, 174, 54, 188, 95, 240, 239, 196, 75, 72, 190, 236, 89, 114, 242, 32, 59, 175, 207, 152, 168, 221, 126, 4, 214, 37, 93, 226, 236, 99, 32, 195, 223, 190, 34, 96, 134, 62, 37, 212, 119, 56, 245, 221, 54, 232, 204, 83, 26, 59, 70, 145, 88, 7, 94, 72, 21, 189, 105, 197 } });
        }
    }
}
