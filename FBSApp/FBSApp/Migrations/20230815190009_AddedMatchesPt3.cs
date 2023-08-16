using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchesPt3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 258100L, true, 258L, 81, 527L },
                    { 258101L, false, 258L, 9, 512L },
                    { 258102L, true, 258L, 88, 516L },
                    { 258103L, false, 258L, 2, 524L },
                    { 258104L, true, 258L, 90, 507L },
                    { 258105L, true, 258L, 90, 517L },
                    { 258106L, true, 258L, 90, 511L },
                    { 258107L, true, 258L, 90, 519L },
                    { 258108L, true, 258L, 90, 500L },
                    { 258109L, true, 258L, 90, 513L },
                    { 258110L, true, 258L, 90, 506L },
                    { 258111L, true, 258L, 90, 502L },
                    { 258112L, true, 258L, 90, 523L },
                    { 258114L, false, 258L, 0, 505L },
                    { 258115L, false, 258L, 0, 510L },
                    { 258116L, false, 258L, 0, 518L },
                    { 258117L, false, 258L, 0, 515L },
                    { 258200L, true, 258L, 66, 402L },
                    { 258201L, false, 258L, 24, 400L },
                    { 258202L, true, 258L, 66, 436L },
                    { 258203L, false, 258L, 24, 412L },
                    { 258204L, true, 258L, 79, 437L },
                    { 258205L, false, 258L, 11, 422L },
                    { 258206L, true, 258L, 90, 404L },
                    { 258207L, true, 258L, 90, 439L },
                    { 258208L, true, 258L, 90, 423L },
                    { 258209L, true, 258L, 90, 429L },
                    { 258210L, true, 258L, 90, 424L },
                    { 258211L, true, 258L, 90, 426L },
                    { 258212L, true, 258L, 90, 403L },
                    { 258213L, true, 258L, 90, 433L },
                    { 258214L, false, 258L, 0, 432L },
                    { 258215L, false, 258L, 0, 428L },
                    { 258216L, false, 258L, 0, 413L },
                    { 258217L, false, 258L, 0, 427L },
                    { 268100L, true, 268L, 65, 527L },
                    { 268101L, false, 268L, 25, 512L },
                    { 268102L, true, 268L, 68, 516L },
                    { 268103L, false, 268L, 22, 524L },
                    { 268104L, true, 268L, 75, 511L },
                    { 268105L, false, 268L, 15, 506L },
                    { 268106L, true, 268L, 90, 507L },
                    { 268107L, true, 268L, 90, 517L },
                    { 268108L, true, 268L, 90, 515L },
                    { 268109L, true, 268L, 90, 500L },
                    { 268110L, true, 268L, 90, 520L },
                    { 268111L, true, 268L, 90, 513L },
                    { 268112L, true, 268L, 90, 502L },
                    { 268113L, true, 268L, 90, 523L },
                    { 268114L, false, 268L, 0, 505L },
                    { 268115L, false, 268L, 0, 519L },
                    { 268116L, false, 268L, 0, 518L },
                    { 268200L, true, 268L, 52, 937L },
                    { 268201L, false, 268L, 38, 930L },
                    { 268202L, true, 268L, 65, 934L },
                    { 268203L, false, 268L, 25, 938L },
                    { 268204L, true, 268L, 73, 928L },
                    { 268205L, false, 268L, 17, 913L },
                    { 268206L, true, 268L, 90, 923L },
                    { 268207L, true, 268L, 90, 905L },
                    { 268208L, true, 268L, 90, 901L },
                    { 268209L, true, 268L, 90, 932L },
                    { 268210L, true, 268L, 90, 922L },
                    { 268211L, true, 268L, 90, 918L },
                    { 268212L, true, 268L, 90, 912L },
                    { 268213L, true, 268L, 90, 909L },
                    { 268214L, false, 268L, 0, 942L },
                    { 268215L, false, 268L, 0, 900L },
                    { 268216L, false, 268L, 0, 933L },
                    { 268217L, false, 268L, 0, 941L },
                    { 277100L, true, 277L, 21, 102L },
                    { 277101L, false, 277L, 69, 103L },
                    { 277102L, true, 277L, 25, 120L },
                    { 277103L, false, 277L, 18, 119L },
                    { 277104L, false, 277L, 47, 101L },
                    { 277105L, true, 277L, 90, 113L },
                    { 277106L, true, 277L, 90, 107L },
                    { 277107L, true, 277L, 90, 111L },
                    { 277108L, true, 277L, 90, 135L },
                    { 277109L, true, 277L, 90, 121L },
                    { 277110L, true, 277L, 90, 132L },
                    { 277111L, true, 277L, 90, 129L },
                    { 277112L, true, 277L, 90, 131L },
                    { 277113L, true, 277L, 90, 123L },
                    { 277114L, false, 277L, 0, 115L },
                    { 277115L, false, 277L, 0, 114L },
                    { 277116L, false, 277L, 0, 116L },
                    { 277200L, true, 277L, 31, 627L },
                    { 277201L, false, 277L, 59, 609L },
                    { 277202L, true, 277L, 72, 618L },
                    { 277203L, false, 277L, 18, 634L },
                    { 277204L, true, 277L, 79, 620L },
                    { 277205L, false, 277L, 11, 611L },
                    { 277206L, true, 277L, 90, 604L },
                    { 277207L, true, 277L, 90, 615L },
                    { 277208L, true, 277L, 90, 617L },
                    { 277209L, true, 277L, 90, 633L },
                    { 277210L, true, 277L, 90, 605L },
                    { 277211L, true, 277L, 90, 612L },
                    { 277212L, true, 277L, 90, 613L },
                    { 277213L, true, 277L, 90, 628L },
                    { 277214L, false, 277L, 0, 632L },
                    { 277215L, false, 277L, 0, 621L },
                    { 277216L, false, 277L, 0, 600L },
                    { 277217L, false, 277L, 0, 630L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 2581L, 4, 4, 11, 8, 5, 613, 59, 0, 1, 19, 12, 13, 2581L, 1 },
                    { 2582L, 2, 2, 8, 17, 0, 432, 41, 0, 9, 4, 2, 10, 2582L, 1 },
                    { 2681L, 1, 2, 9, 13, 2, 681, 56, 0, 4, 15, 9, 14, 2681L, 1 },
                    { 2682L, 5, 2, 13, 12, 1, 535, 44, 0, 3, 12, 4, 23, 2682L, 2 },
                    { 2771L, 2, 3, 15, 17, 3, 317, 35, 0, 1, 6, 3, 18, 2771L, 1 },
                    { 2772L, 2, 7, 17, 18, 1, 565, 65, 0, 3, 7, 1, 19, 2772L, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "FF9ED36257C3E6588F37E25F39F6F6D29F55A6DCAF32F536F1E78F220B8F90354D72FE827CDB1146A67E361F0DD0AB7E6E6C9587B2D13A1E30104B605560A8A5", new byte[] { 254, 74, 113, 159, 177, 91, 31, 116, 65, 38, 203, 252, 89, 116, 19, 93, 8, 14, 171, 164, 154, 71, 221, 140, 244, 2, 185, 88, 249, 40, 116, 226, 239, 27, 17, 116, 61, 139, 201, 200, 183, 131, 122, 171, 193, 47, 182, 198, 59, 41, 248, 115, 78, 243, 52, 102, 18, 168, 136, 57, 230, 45, 23, 175 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 25811L, 258100L, false, false, 1 },
                    { 25812L, 258100L, false, false, 44 },
                    { 25813L, 258100L, false, false, 61 },
                    { 25821L, 258208L, false, false, 11 },
                    { 26811L, 268100L, false, false, 13 },
                    { 26812L, 268100L, false, false, 19 },
                    { 26813L, 268100L, false, false, 56 },
                    { 26814L, 268111L, false, false, 25 },
                    { 26815L, 268113L, false, false, 4 },
                    { 26816L, 268113L, false, false, 80 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26814L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26815L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26816L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 277217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2581L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2582L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2681L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2682L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2771L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2772L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 268113L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "05651707A36E2845717BF690FF69603F32D5AFF89FA697471E7D8958E73FD9B13C41AB3188A9DA891D42E4C76D8A93AAC385AE40C256DD5F9C7B15ED034504F7", new byte[] { 255, 143, 68, 28, 74, 11, 255, 165, 248, 101, 96, 207, 116, 99, 17, 150, 154, 238, 182, 152, 201, 76, 147, 255, 60, 246, 176, 152, 50, 126, 229, 205, 61, 198, 150, 17, 39, 158, 232, 186, 41, 186, 101, 78, 139, 229, 233, 206, 78, 123, 101, 63, 49, 2, 115, 216, 176, 153, 112, 195, 139, 201, 106, 127 } });
        }
    }
}
