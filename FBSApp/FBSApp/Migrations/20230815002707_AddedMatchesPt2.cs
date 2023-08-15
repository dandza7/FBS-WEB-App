using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchesPt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 289100L, true, 289L, 60, 912L },
                    { 289101L, false, 289L, 30, 941L },
                    { 289102L, true, 289L, 77, 930L },
                    { 289103L, false, 289L, 13, 938L },
                    { 289104L, true, 289L, 84, 918L },
                    { 289105L, false, 289L, 6, 933L },
                    { 289106L, true, 289L, 90, 942L },
                    { 289107L, true, 289L, 90, 905L },
                    { 289108L, true, 289L, 90, 901L },
                    { 289109L, true, 289L, 90, 909L },
                    { 289110L, true, 289L, 90, 932L },
                    { 289111L, true, 289L, 90, 922L },
                    { 289112L, true, 289L, 90, 930L },
                    { 289113L, true, 289L, 90, 934L },
                    { 289114L, false, 289L, 0, 923L },
                    { 289115L, false, 289L, 0, 937L },
                    { 289116L, false, 289L, 0, 900L },
                    { 289117L, false, 289L, 0, 904L },
                    { 289200L, true, 289L, 70, 207L },
                    { 289201L, false, 289L, 20, 208L },
                    { 289202L, true, 289L, 80, 214L },
                    { 289203L, false, 289L, 10, 221L },
                    { 289204L, true, 289L, 85, 224L },
                    { 289205L, false, 289L, 5, 203L },
                    { 289206L, true, 289L, 90, 215L },
                    { 289207L, true, 289L, 90, 219L },
                    { 289208L, true, 289L, 90, 204L },
                    { 289209L, true, 289L, 90, 231L },
                    { 289210L, true, 289L, 90, 200L },
                    { 289211L, true, 289L, 90, 213L },
                    { 289212L, true, 289L, 90, 202L },
                    { 289213L, true, 289L, 90, 212L },
                    { 289214L, false, 289L, 0, 228L },
                    { 289215L, false, 289L, 0, 218L },
                    { 289216L, false, 289L, 0, 226L },
                    { 289217L, false, 289L, 0, 232L },
                    { 290100L, true, 290L, 59, 232L },
                    { 290101L, false, 290L, 31, 207L },
                    { 290102L, true, 290L, 79, 214L },
                    { 290103L, false, 290L, 11, 208L },
                    { 290104L, true, 290L, 90, 215L },
                    { 290105L, true, 290L, 90, 231L },
                    { 290106L, true, 290L, 90, 204L },
                    { 290107L, true, 290L, 90, 216L },
                    { 290108L, true, 290L, 90, 219L },
                    { 290109L, true, 290L, 90, 224L },
                    { 290110L, true, 290L, 90, 203L },
                    { 290111L, true, 290L, 90, 202L },
                    { 290112L, true, 290L, 90, 212L },
                    { 290113L, false, 290L, 0, 228L },
                    { 290114L, false, 290L, 0, 200L },
                    { 290115L, false, 290L, 0, 226L },
                    { 290116L, false, 290L, 0, 221L },
                    { 290117L, false, 290L, 0, 225L },
                    { 290200L, true, 290L, 46, 426L },
                    { 290201L, false, 290L, 44, 424L },
                    { 290202L, true, 290L, 56, 403L },
                    { 290203L, false, 290L, 34, 433L },
                    { 290204L, true, 290L, 72, 400L },
                    { 290205L, false, 290L, 18, 427L },
                    { 290206L, true, 290L, 90, 404L },
                    { 290207L, true, 290L, 90, 437L },
                    { 290208L, true, 290L, 90, 438L },
                    { 290209L, true, 290L, 90, 423L },
                    { 290210L, true, 290L, 90, 429L },
                    { 290211L, true, 290L, 90, 417L },
                    { 290212L, true, 290L, 90, 419L },
                    { 290213L, true, 290L, 90, 402L },
                    { 290214L, false, 290L, 0, 432L },
                    { 290215L, false, 290L, 0, 436L },
                    { 290216L, false, 290L, 0, 401L },
                    { 290217L, false, 290L, 0, 412L },
                    { 309100L, true, 309L, 77, 427L },
                    { 309101L, false, 309L, 13, 402L },
                    { 309102L, true, 309L, 80, 433L },
                    { 309103L, false, 309L, 10, 408L },
                    { 309104L, true, 309L, 86, 403L },
                    { 309105L, false, 309L, 4, 413L },
                    { 309106L, true, 309L, 90, 404L },
                    { 309107L, true, 309L, 90, 438L },
                    { 309108L, true, 309L, 90, 423L },
                    { 309109L, true, 309L, 90, 429L },
                    { 309110L, true, 309L, 90, 401L },
                    { 309111L, true, 309L, 90, 400L },
                    { 309112L, true, 309L, 90, 417L },
                    { 309113L, true, 309L, 90, 436L },
                    { 309114L, false, 309L, 0, 432L },
                    { 309115L, false, 309L, 0, 428L },
                    { 309116L, false, 309L, 0, 426L },
                    { 309117L, false, 309L, 0, 437L },
                    { 309200L, true, 309L, 71, 114L },
                    { 309201L, false, 309L, 19, 105L },
                    { 309202L, true, 309L, 80, 127L },
                    { 309203L, false, 309L, 10, 125L },
                    { 309204L, true, 309L, 90, 113L },
                    { 309205L, true, 309L, 90, 107L },
                    { 309206L, true, 309L, 90, 111L },
                    { 309207L, true, 309L, 90, 135L },
                    { 309208L, true, 309L, 90, 121L },
                    { 309209L, true, 309L, 90, 116L },
                    { 309210L, true, 309L, 90, 129L },
                    { 309211L, true, 309L, 90, 123L },
                    { 309212L, true, 309L, 90, 131L },
                    { 309213L, false, 309L, 0, 115L },
                    { 309214L, false, 309L, 0, 132L },
                    { 309215L, false, 309L, 0, 103L },
                    { 309216L, false, 309L, 0, 122L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 2891L, 2, 2, 7, 15, 1, 480, 47, 0, 0, 11, 1, 27, 2891L, 1 },
                    { 2892L, 4, 2, 14, 8, 1, 546, 53, 0, 0, 9, 0, 23, 2892L, 1 },
                    { 2901L, 1, 3, 15, 15, 5, 508, 60, 0, 3, 10, 3, 14, 2901L, 3 },
                    { 2902L, 3, 4, 14, 19, 1, 334, 40, 1, 2, 9, 4, 24, 2902L, 2 },
                    { 3091L, 4, 5, 12, 18, 5, 395, 46, 0, 4, 14, 3, 18, 3091L, 2 },
                    { 3092L, 3, 2, 18, 17, 1, 465, 54, 0, 1, 14, 4, 21, 3092L, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "05651707A36E2845717BF690FF69603F32D5AFF89FA697471E7D8958E73FD9B13C41AB3188A9DA891D42E4C76D8A93AAC385AE40C256DD5F9C7B15ED034504F7", new byte[] { 255, 143, 68, 28, 74, 11, 255, 165, 248, 101, 96, 207, 116, 99, 17, 150, 154, 238, 182, 152, 201, 76, 147, 255, 60, 246, 176, 152, 50, 126, 229, 205, 61, 198, 150, 17, 39, 158, 232, 186, 41, 186, 101, 78, 139, 229, 233, 206, 78, 123, 101, 63, 49, 2, 115, 216, 176, 153, 112, 195, 139, 201, 106, 127 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 28911L, 289113L, false, false, 57 },
                    { 28921L, 289207L, false, true, 84 },
                    { 29011L, 290112L, false, false, 74 },
                    { 29022L, 290204L, false, false, 16 },
                    { 30911L, 309112L, false, false, 12 },
                    { 30912L, 309102L, false, false, 69 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 29011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 29022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 30911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 30912L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309216L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2891L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2892L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2901L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2902L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3091L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3092L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 289207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 290204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 309112L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E52840F4F0AC36EC2E160C94C66D44B82C18B7566CD204598A67393CA7EF5E95B842346A5A2ACABEB1566C42174ABDB6B79E8DEE833059D8B37E277A46177BBE", new byte[] { 184, 11, 140, 174, 212, 29, 75, 21, 45, 242, 200, 124, 249, 86, 2, 165, 152, 51, 152, 215, 153, 164, 216, 83, 124, 87, 154, 106, 167, 38, 239, 48, 193, 8, 69, 140, 159, 3, 237, 20, 190, 1, 151, 161, 243, 219, 31, 92, 14, 164, 31, 127, 68, 76, 21, 159, 35, 52, 37, 178, 209, 10, 141, 197 } });
        }
    }
}
