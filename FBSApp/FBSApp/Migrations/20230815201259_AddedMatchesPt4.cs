using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchesPt4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 179100L, true, 179L, 70, 621L },
                    { 179101L, false, 179L, 20, 634L },
                    { 179102L, true, 179L, 84, 628L },
                    { 179103L, false, 179L, 6, 618L },
                    { 179104L, true, 179L, 90, 604L },
                    { 179105L, true, 179L, 90, 623L },
                    { 179106L, true, 179L, 90, 610L },
                    { 179107L, true, 179L, 90, 633L },
                    { 179108L, true, 179L, 90, 605L },
                    { 179109L, true, 179L, 90, 613L },
                    { 179110L, true, 179L, 90, 612L },
                    { 179111L, true, 179L, 90, 627L },
                    { 179112L, true, 179L, 90, 620L },
                    { 179113L, false, 179L, 0, 625L },
                    { 179114L, false, 179L, 0, 600L },
                    { 179115L, false, 179L, 0, 630L },
                    { 179116L, false, 179L, 0, 602L },
                    { 179117L, false, 179L, 0, 609L },
                    { 179200L, true, 179L, 46, 114L },
                    { 179201L, false, 179L, 44, 124L },
                    { 179202L, true, 179L, 79, 102L },
                    { 179203L, false, 179L, 11, 105L },
                    { 179204L, true, 179L, 85, 119L },
                    { 179205L, false, 179L, 5, 120L },
                    { 179206L, true, 179L, 90, 113L },
                    { 179207L, true, 179L, 90, 126L },
                    { 179208L, true, 179L, 90, 115L },
                    { 179209L, true, 179L, 90, 135L },
                    { 179210L, true, 179L, 90, 107L },
                    { 179211L, true, 179L, 90, 127L },
                    { 179212L, true, 179L, 90, 123L },
                    { 179213L, true, 179L, 90, 131L },
                    { 179214L, false, 179L, 0, 130L },
                    { 179215L, false, 179L, 0, 129L },
                    { 179216L, false, 179L, 0, 106L },
                    { 205100L, true, 205L, 62, 628L },
                    { 205101L, false, 205L, 28, 618L },
                    { 205102L, true, 205L, 78, 613L },
                    { 205103L, false, 205L, 12, 600L },
                    { 205104L, true, 205L, 83, 605L },
                    { 205105L, false, 205L, 7, 623L },
                    { 205106L, true, 205L, 90, 604L },
                    { 205107L, true, 205L, 90, 632L },
                    { 205108L, true, 205L, 90, 610L },
                    { 205109L, true, 205L, 90, 633L },
                    { 205110L, true, 205L, 90, 612L },
                    { 205111L, true, 205L, 90, 634L },
                    { 205112L, true, 205L, 90, 627L },
                    { 205113L, true, 205L, 90, 620L },
                    { 205114L, false, 205L, 0, 621L },
                    { 205115L, false, 205L, 0, 630L },
                    { 205116L, false, 205L, 0, 611L },
                    { 205117L, false, 205L, 0, 609L },
                    { 205200L, true, 205L, 46, 437L },
                    { 205201L, false, 205L, 44, 423L },
                    { 205202L, true, 205L, 71, 433L },
                    { 205203L, false, 205L, 19, 403L },
                    { 205204L, true, 205L, 80, 436L },
                    { 205205L, false, 205L, 10, 426L },
                    { 205206L, true, 205L, 90, 404L },
                    { 205207L, true, 205L, 90, 439L },
                    { 205208L, true, 205L, 90, 438L },
                    { 205209L, true, 205L, 90, 424L },
                    { 205210L, true, 205L, 90, 417L },
                    { 205211L, true, 205L, 90, 401L },
                    { 205212L, true, 205L, 90, 400L },
                    { 205213L, true, 205L, 90, 402L },
                    { 205214L, false, 205L, 0, 432L },
                    { 205215L, false, 205L, 0, 428L },
                    { 205216L, false, 205L, 0, 405L },
                    { 205217L, false, 205L, 0, 420L },
                    { 219100L, true, 219L, 65, 506L },
                    { 219101L, false, 219L, 25, 513L },
                    { 219102L, true, 219L, 86, 500L },
                    { 219103L, false, 219L, 4, 517L },
                    { 219104L, true, 219L, 88, 529L },
                    { 219105L, false, 219L, 2, 519L },
                    { 219106L, true, 219L, 90, 507L },
                    { 219107L, true, 219L, 90, 505L },
                    { 219108L, true, 219L, 90, 515L },
                    { 219109L, true, 219L, 90, 511L },
                    { 219110L, true, 219L, 90, 523L },
                    { 219111L, true, 219L, 90, 527L },
                    { 219112L, true, 219L, 90, 518L },
                    { 219113L, true, 219L, 90, 502L },
                    { 219114L, false, 219L, 0, 516L },
                    { 219115L, false, 219L, 0, 512L },
                    { 219116L, false, 219L, 0, 524L },
                    { 219200L, true, 219L, 57, 615L },
                    { 219201L, false, 219L, 33, 612L },
                    { 219202L, true, 219L, 77, 628L },
                    { 219203L, false, 219L, 13, 634L },
                    { 219204L, true, 219L, 86, 613L },
                    { 219205L, false, 219L, 4, 609L },
                    { 219206L, true, 219L, 90, 604L },
                    { 219207L, true, 219L, 90, 632L },
                    { 219208L, true, 219L, 90, 610L },
                    { 219209L, true, 219L, 90, 633L },
                    { 219210L, true, 219L, 90, 605L },
                    { 219211L, true, 219L, 90, 618L },
                    { 219212L, true, 219L, 90, 620L },
                    { 219213L, true, 219L, 90, 627L },
                    { 219214L, false, 219L, 0, 621L },
                    { 219215L, false, 219L, 0, 600L },
                    { 219216L, false, 219L, 0, 630L },
                    { 219217L, false, 219L, 0, 602L },
                    { 228100L, true, 228L, 43, 224L },
                    { 228101L, false, 228L, 47, 207L },
                    { 228102L, true, 228L, 81, 213L },
                    { 228103L, false, 228L, 9, 208L },
                    { 228104L, true, 228L, 90, 215L },
                    { 228105L, true, 228L, 90, 219L },
                    { 228106L, true, 228L, 90, 231L },
                    { 228107L, true, 228L, 90, 216L },
                    { 228108L, true, 228L, 90, 200L },
                    { 228109L, true, 228L, 90, 202L },
                    { 228110L, true, 228L, 90, 205L },
                    { 228111L, true, 228L, 90, 214L },
                    { 228112L, true, 228L, 90, 212L },
                    { 228113L, false, 228L, 0, 218L },
                    { 228114L, false, 228L, 0, 226L },
                    { 228115L, false, 228L, 0, 203L },
                    { 228116L, false, 228L, 0, 204L },
                    { 228117L, false, 228L, 0, 225L },
                    { 228200L, true, 228L, 73, 105L },
                    { 228201L, false, 228L, 17, 131L },
                    { 228202L, true, 228L, 83, 119L },
                    { 228203L, false, 228L, 7, 114L },
                    { 228204L, true, 228L, 89, 129L },
                    { 228205L, false, 228L, 1, 132L },
                    { 228206L, true, 228L, 90, 113L },
                    { 228207L, true, 228L, 90, 107L },
                    { 228208L, true, 228L, 90, 135L },
                    { 228209L, true, 228L, 90, 130L },
                    { 228210L, true, 228L, 90, 121L },
                    { 228211L, true, 228L, 90, 127L },
                    { 228212L, true, 228L, 90, 102L },
                    { 228213L, true, 228L, 90, 123L },
                    { 228214L, false, 228L, 0, 116L },
                    { 228215L, false, 228L, 0, 120L },
                    { 228216L, false, 228L, 0, 103L },
                    { 237100L, true, 237L, 67, 400L },
                    { 237101L, false, 237L, 23, 401L },
                    { 237102L, true, 237L, 68, 403L },
                    { 237103L, false, 237L, 22, 402L },
                    { 237104L, true, 237L, 72, 418L },
                    { 237105L, false, 237L, 18, 428L },
                    { 237106L, true, 237L, 90, 404L },
                    { 237107L, true, 237L, 90, 438L },
                    { 237108L, true, 237L, 90, 423L },
                    { 237109L, true, 237L, 90, 436L },
                    { 237110L, true, 237L, 90, 417L },
                    { 237111L, true, 237L, 90, 424L },
                    { 237112L, true, 237L, 90, 426L },
                    { 237113L, true, 237L, 90, 433L },
                    { 237114L, false, 237L, 0, 432L },
                    { 237115L, false, 237L, 0, 429L },
                    { 237116L, false, 237L, 0, 437L },
                    { 237117L, false, 237L, 0, 427L },
                    { 237200L, true, 237L, 63, 930L },
                    { 237201L, false, 237L, 27, 937L },
                    { 237202L, true, 237L, 68, 941L },
                    { 237203L, false, 237L, 22, 933L },
                    { 237204L, true, 237L, 80, 934L },
                    { 237205L, false, 237L, 10, 904L },
                    { 237206L, true, 237L, 90, 923L },
                    { 237207L, true, 237L, 90, 905L },
                    { 237208L, true, 237L, 90, 901L },
                    { 237209L, true, 237L, 90, 909L },
                    { 237210L, true, 237L, 90, 928L },
                    { 237211L, true, 237L, 90, 932L },
                    { 237212L, true, 237L, 90, 922L },
                    { 237213L, true, 237L, 90, 912L },
                    { 237214L, false, 237L, 0, 914L },
                    { 237215L, false, 237L, 0, 942L },
                    { 237216L, false, 237L, 0, 900L },
                    { 237217L, false, 237L, 0, 913L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 1791L, 14, 13, 6, 17, 2, 562, 64, 0, 1, 36, 11, 12, 1791L, 0 },
                    { 1792L, 1, 2, 14, 8, 3, 321, 36, 0, 8, 6, 2, 26, 1792L, 2 },
                    { 2051L, 2, 5, 8, 16, 2, 511, 48, 0, 1, 15, 10, 17, 2051L, 1 },
                    { 2052L, 3, 3, 13, 10, 5, 551, 52, 0, 5, 8, 2, 17, 2052L, 2 },
                    { 2191L, 1, 2, 12, 8, 2, 578, 50, 0, 4, 9, 4, 14, 2191L, 4 },
                    { 2192L, 0, 1, 7, 14, 1, 583, 50, 0, 2, 7, 5, 18, 2192L, 2 },
                    { 2281L, 4, 7, 8, 9, 4, 567, 61, 0, 7, 21, 11, 19, 2281L, 1 },
                    { 2282L, 2, 4, 8, 12, 1, 363, 39, 0, 11, 13, 8, 15, 2282L, 2 },
                    { 2371L, 1, 5, 13, 15, 1, 355, 36, 0, 1, 13, 5, 33, 2371L, 0 },
                    { 2372L, 3, 6, 15, 13, 0, 647, 64, 0, 3, 13, 1, 13, 2372L, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "C63704173B0543FB47A20AFF78CDEEAF18E842CD286E06173E45430AA57E24B4B02C32E534BAE78A806EB30BFC07085E281A63264EA5058C5766C7A6574158DD", new byte[] { 4, 131, 127, 172, 70, 33, 154, 76, 61, 87, 52, 129, 228, 37, 205, 27, 20, 4, 57, 210, 155, 10, 33, 99, 226, 26, 124, 68, 110, 180, 24, 77, 39, 10, 79, 70, 153, 227, 24, 139, 41, 213, 167, 241, 63, 206, 104, 85, 169, 162, 70, 137, 67, 63, 109, 243, 184, 229, 166, 180, 28, 111, 166, 3 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 17911L, 179101L, false, false, 73 },
                    { 17912L, 179101L, false, false, 80 },
                    { 17913L, 179102L, false, false, 24 },
                    { 17921L, 179204L, false, false, 33 },
                    { 20511L, 205100L, false, false, 32 },
                    { 20512L, 205112L, false, false, 14 },
                    { 20513L, 205112L, false, false, 16 },
                    { 20514L, 205112L, false, false, 65 },
                    { 20515L, 205113L, true, false, 45 },
                    { 20521L, 205211L, false, false, 11 },
                    { 21911L, 219111L, false, false, 40 },
                    { 21912L, 219112L, false, false, 72 },
                    { 21921L, 219213L, false, false, 64 },
                    { 22821L, 228213L, false, false, 44 },
                    { 23711L, 237102L, false, false, 14 },
                    { 23712L, 237108L, false, false, 39 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 17911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 17912L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 17913L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 17921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20513L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20514L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20515L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 20521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 21911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 21912L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 21921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 22821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 23711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 23712L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1791L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1792L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2051L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2052L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2191L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2192L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2281L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2282L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2371L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2372L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 179204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 205211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 219213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 228213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 237108L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "FF9ED36257C3E6588F37E25F39F6F6D29F55A6DCAF32F536F1E78F220B8F90354D72FE827CDB1146A67E361F0DD0AB7E6E6C9587B2D13A1E30104B605560A8A5", new byte[] { 254, 74, 113, 159, 177, 91, 31, 116, 65, 38, 203, 252, 89, 116, 19, 93, 8, 14, 171, 164, 154, 71, 221, 140, 244, 2, 185, 88, 249, 40, 116, 226, 239, 27, 17, 116, 61, 139, 201, 200, 183, 131, 122, 171, 193, 47, 182, 198, 59, 41, 248, 115, 78, 243, 52, 102, 18, 168, 136, 57, 230, 45, 23, 175 } });
        }
    }
}
