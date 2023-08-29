using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW71 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 75100L, true, 75L, 55, 1006L },
                    { 75101L, false, 75L, 35, 1004L },
                    { 75102L, true, 75L, 88, 1024L },
                    { 75103L, false, 75L, 2, 1003L },
                    { 75104L, true, 75L, 89, 1007L },
                    { 75105L, false, 75L, 1, 1021L },
                    { 75106L, true, 75L, 90, 1013L },
                    { 75107L, true, 75L, 90, 1012L },
                    { 75108L, true, 75L, 90, 1019L },
                    { 75109L, true, 75L, 90, 924L },
                    { 75110L, true, 75L, 90, 1016L },
                    { 75111L, true, 75L, 90, 1028L },
                    { 75112L, true, 75L, 90, 1008L },
                    { 75113L, true, 75L, 90, 1027L },
                    { 75114L, false, 75L, 0, 1015L },
                    { 75115L, false, 75L, 0, 1018L },
                    { 75116L, false, 75L, 0, 1000L },
                    { 75117L, false, 75L, 0, 1017L },
                    { 75200L, true, 75L, 8, 134L },
                    { 75201L, false, 75L, 82, 1501L },
                    { 75202L, true, 75L, 64, 1524L },
                    { 75203L, false, 75L, 26, 1520L },
                    { 75204L, true, 75L, 84, 1507L },
                    { 75205L, false, 75L, 6, 1526L },
                    { 75206L, true, 75L, 90, 1513L },
                    { 75207L, true, 75L, 90, 1502L },
                    { 75208L, true, 75L, 90, 1519L },
                    { 75209L, true, 75L, 90, 1508L },
                    { 75210L, true, 75L, 90, 1504L },
                    { 75211L, true, 75L, 90, 227L },
                    { 75212L, true, 75L, 90, 1522L },
                    { 75213L, true, 75L, 90, 1525L },
                    { 75214L, false, 75L, 0, 1521L },
                    { 75215L, false, 75L, 0, 1515L },
                    { 75216L, false, 75L, 0, 1509L },
                    { 75217L, false, 75L, 0, 1517L },
                    { 76100L, true, 76L, 45, 432L },
                    { 76101L, false, 76L, 45, 404L },
                    { 76102L, true, 76L, 63, 400L },
                    { 76103L, false, 76L, 27, 402L },
                    { 76104L, true, 76L, 77, 433L },
                    { 76105L, false, 76L, 13, 410L },
                    { 76106L, true, 76L, 90, 418L },
                    { 76107L, true, 76L, 90, 437L },
                    { 76108L, true, 76L, 90, 435L },
                    { 76109L, true, 76L, 90, 429L },
                    { 76110L, true, 76L, 90, 424L },
                    { 76111L, true, 76L, 90, 417L },
                    { 76112L, true, 76L, 90, 427L },
                    { 76113L, true, 76L, 90, 403L },
                    { 76114L, false, 76L, 0, 426L },
                    { 76115L, false, 76L, 0, 436L },
                    { 76116L, false, 76L, 0, 439L },
                    { 76117L, false, 76L, 0, 419L },
                    { 76200L, true, 76L, 72, 2104L },
                    { 76201L, false, 76L, 18, 2121L },
                    { 76202L, true, 76L, 84, 2130L },
                    { 76203L, false, 76L, 6, 2129L },
                    { 76204L, true, 76L, 90, 2106L },
                    { 76205L, true, 76L, 90, 2110L },
                    { 76206L, true, 76L, 90, 2109L },
                    { 76207L, true, 76L, 90, 2125L },
                    { 76208L, true, 76L, 90, 2100L },
                    { 76209L, true, 76L, 90, 2116L },
                    { 76210L, true, 76L, 90, 2141L },
                    { 76211L, true, 76L, 90, 2134L },
                    { 76212L, true, 76L, 90, 2140L },
                    { 76213L, false, 76L, 0, 2133L },
                    { 76214L, false, 76L, 0, 2119L },
                    { 76215L, false, 76L, 0, 2103L },
                    { 76216L, false, 76L, 0, 2102L },
                    { 76217L, false, 76L, 0, 2128L },
                    { 77100L, true, 77L, 65, 933L },
                    { 77101L, false, 77L, 25, 944L },
                    { 77102L, true, 77L, 73, 941L },
                    { 77103L, false, 77L, 17, 945L },
                    { 77104L, true, 77L, 81, 930L },
                    { 77105L, false, 77L, 9, 937L },
                    { 77106L, true, 77L, 90, 923L },
                    { 77107L, true, 77L, 90, 905L },
                    { 77108L, true, 77L, 90, 901L },
                    { 77109L, true, 77L, 90, 909L },
                    { 77110L, true, 77L, 90, 928L },
                    { 77111L, true, 77L, 90, 932L },
                    { 77112L, true, 77L, 90, 922L },
                    { 77113L, true, 77L, 90, 912L },
                    { 77114L, false, 77L, 0, 942L },
                    { 77115L, false, 77L, 0, 916L },
                    { 77116L, false, 77L, 0, 943L },
                    { 77117L, false, 77L, 0, 910L },
                    { 77200L, true, 77L, 66, 620L },
                    { 77201L, false, 77L, 24, 634L },
                    { 77202L, true, 77L, 78, 618L },
                    { 77203L, false, 77L, 12, 621L },
                    { 77204L, true, 77L, 86, 615L },
                    { 77205L, false, 77L, 4, 609L },
                    { 77206L, true, 77L, 90, 604L },
                    { 77207L, true, 77L, 90, 632L },
                    { 77208L, true, 77L, 90, 616L },
                    { 77209L, true, 77L, 90, 633L },
                    { 77210L, true, 77L, 90, 605L },
                    { 77211L, true, 77L, 90, 613L },
                    { 77212L, true, 77L, 90, 627L },
                    { 77213L, true, 77L, 90, 628L },
                    { 77214L, false, 77L, 0, 612L },
                    { 77215L, false, 77L, 0, 617L },
                    { 77216L, false, 77L, 0, 630L },
                    { 77217L, false, 77L, 0, 602L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 751L, 7, 12, 13, 12, 6, 389, 51, 0, 0, 19, 6, 25, 751L, 0 },
                    { 752L, 0, 1, 13, 19, 0, 389, 49, 0, 3, 6, 0, 21, 752L, 3 },
                    { 761L, 1, 6, 11, 20, 1, 541, 63, 0, 4, 9, 2, 10, 761L, 2 },
                    { 762L, 2, 6, 17, 12, 3, 299, 37, 0, 1, 13, 4, 24, 762L, 2 },
                    { 771L, 2, 4, 7, 11, 2, 558, 47, 0, 5, 10, 4, 13, 771L, 0 },
                    { 772L, 1, 4, 9, 9, 2, 616, 53, 0, 3, 13, 6, 15, 772L, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "1F83224D387ED96561178BD24B1C11CD28D1A6ACE06DED684121420EC8368EEC6EB725EF191440D1B52E2669F2A6D4B704D5473BDEF2AE1F9327B89CA5EA247A", new byte[] { 36, 111, 221, 117, 110, 211, 234, 79, 12, 173, 81, 207, 188, 88, 186, 149, 176, 121, 37, 98, 114, 226, 183, 182, 56, 246, 133, 138, 122, 194, 201, 15, 93, 196, 8, 158, 124, 100, 171, 124, 157, 162, 236, 195, 173, 80, 39, 69, 210, 133, 217, 204, 17, 106, 112, 242, 160, 21, 230, 122, 154, 167, 25, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DA0B7EBC1BB9CE180D2077FCA83ABE9922A1E33AE51EA7FDE166A3639E2FA0D1FE83B2DC65F0844742230EFFC4C2D5A47FE0BB9457C159ADDE7A0FF8D2C77272", new byte[] { 145, 140, 91, 9, 193, 115, 66, 164, 30, 225, 100, 14, 21, 204, 178, 94, 235, 134, 132, 26, 151, 170, 3, 145, 142, 77, 161, 62, 198, 78, 242, 93, 138, 127, 6, 200, 142, 69, 117, 167, 225, 140, 219, 66, 94, 4, 9, 79, 154, 56, 153, 119, 189, 135, 242, 215, 177, 42, 191, 17, 255, 29, 211, 113 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 7511L, 75101L, false, false, 66 },
                    { 7512L, 75104L, false, false, 56 },
                    { 7513L, 75104L, false, false, 89 },
                    { 7611L, 76112L, false, false, 83 },
                    { 7621L, 76205L, false, true, 81 },
                    { 7711L, 77113L, false, false, 25 },
                    { 7721L, 77205L, false, false, 89 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7513L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7721L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 751L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 752L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 761L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 762L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 771L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 772L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 75104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 76205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 77205L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "605C1B7F87A894B6A9582DE2152000E6BBEC320A5F167BBEBAFAA9CA3842040DDA9EB43E0D45AF1BBE3DCF2DF530BC4DB2BB2E6DF8BE875D7D8A96ABDA1FEFD5", new byte[] { 178, 71, 38, 27, 98, 175, 144, 209, 135, 73, 175, 31, 123, 170, 175, 57, 211, 223, 246, 70, 27, 198, 200, 23, 172, 70, 112, 141, 33, 251, 10, 86, 21, 97, 185, 89, 113, 60, 80, 208, 71, 130, 137, 206, 42, 191, 189, 205, 187, 197, 77, 215, 40, 193, 202, 249, 188, 192, 199, 106, 167, 31, 102, 251 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "2C46E91B95E13E288D82C800784228E55E1206CB57A679239CC3DE8CC2F5E1762ADD57D98F72D40C8DD4EBC8758C18349B7CA9F9B92B35DEB560A60BA07560A8", new byte[] { 230, 101, 65, 83, 200, 150, 4, 34, 234, 192, 152, 84, 131, 155, 191, 157, 140, 127, 162, 176, 219, 231, 64, 6, 92, 18, 135, 252, 133, 29, 211, 142, 141, 128, 134, 142, 122, 248, 235, 148, 8, 145, 217, 96, 122, 3, 167, 153, 219, 25, 147, 146, 161, 44, 37, 237, 166, 217, 208, 148, 227, 69, 233, 145 } });
        }
    }
}
