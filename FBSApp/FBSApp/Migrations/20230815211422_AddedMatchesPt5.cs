using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchesPt5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 166100L, true, 166L, 65, 930L },
                    { 166101L, false, 166L, 25, 937L },
                    { 166102L, true, 166L, 75, 941L },
                    { 166103L, false, 166L, 15, 938L },
                    { 166104L, true, 166L, 89, 912L },
                    { 166105L, false, 166L, 1, 933L },
                    { 166106L, true, 166L, 90, 923L },
                    { 166107L, true, 166L, 90, 905L },
                    { 166108L, true, 166L, 90, 901L },
                    { 166109L, true, 166L, 90, 909L },
                    { 166110L, true, 166L, 90, 928L },
                    { 166111L, true, 166L, 90, 932L },
                    { 166112L, true, 166L, 90, 922L },
                    { 166113L, true, 166L, 90, 934L },
                    { 166114L, false, 166L, 0, 942L },
                    { 166115L, false, 166L, 0, 900L },
                    { 166116L, false, 166L, 0, 913L },
                    { 166200L, true, 166L, 53, 518L },
                    { 166201L, false, 166L, 37, 512L },
                    { 166202L, true, 166L, 68, 506L },
                    { 166203L, false, 166L, 22, 513L },
                    { 166204L, true, 166L, 84, 524L },
                    { 166205L, false, 166L, 6, 521L },
                    { 166206L, true, 166L, 90, 507L },
                    { 166207L, true, 166L, 90, 517L },
                    { 166208L, true, 166L, 90, 515L },
                    { 166209L, true, 166L, 90, 500L },
                    { 166210L, true, 166L, 90, 510L },
                    { 166211L, true, 166L, 90, 502L },
                    { 166212L, true, 166L, 90, 511L },
                    { 166213L, true, 166L, 90, 523L },
                    { 166214L, false, 166L, 0, 505L },
                    { 166215L, false, 166L, 0, 529L },
                    { 166216L, false, 166L, 0, 519L }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "CountryId", "Name", "Photo", "Position" },
                values: new object[] { 943L, new DateTime(1987, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 167L, "Cesc Fabregas", "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", "Midfielder" });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 1661L, 2, 1, 12, 13, 1, 410, 39, 0, 4, 8, 5, 26, 1661L, 2 },
                    { 1662L, 4, 13, 11, 13, 2, 640, 61, 0, 3, 14, 4, 19, 1662L, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "12BD7A3C460BB880642AD8ECB1AF17C8E6B364A3084F37D72E13BF4E23053CFA2D6D495FB37CEA46D675F52DC57428FEB93E3A0B7026F6BB7645C76BA580F286", new byte[] { 1, 248, 238, 95, 206, 204, 108, 144, 186, 130, 79, 138, 143, 81, 67, 167, 233, 18, 43, 3, 37, 239, 224, 80, 59, 211, 49, 59, 31, 224, 239, 236, 70, 131, 160, 253, 171, 112, 225, 135, 49, 34, 20, 191, 52, 243, 134, 175, 45, 0, 67, 11, 24, 234, 112, 234, 17, 187, 126, 154, 228, 207, 92, 139 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 16611L, 166109L, false, false, 78 },
                    { 16612L, 166111L, false, false, 45 }
                });

            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[] { 166117L, false, 166L, 0, 943L });

            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[] { 961L, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 943L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 16611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 16612L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166216L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 961L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1661L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1662L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 166111L);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 943L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "C63704173B0543FB47A20AFF78CDEEAF18E842CD286E06173E45430AA57E24B4B02C32E534BAE78A806EB30BFC07085E281A63264EA5058C5766C7A6574158DD", new byte[] { 4, 131, 127, 172, 70, 33, 154, 76, 61, 87, 52, 129, 228, 37, 205, 27, 20, 4, 57, 210, 155, 10, 33, 99, 226, 26, 124, 68, 110, 180, 24, 77, 39, 10, 79, 70, 153, 227, 24, 139, 41, 213, 167, 241, 63, 206, 104, 85, 169, 162, 70, 137, 67, 63, 109, 243, 184, 229, 166, 180, 28, 111, 166, 3 } });
        }
    }
}
