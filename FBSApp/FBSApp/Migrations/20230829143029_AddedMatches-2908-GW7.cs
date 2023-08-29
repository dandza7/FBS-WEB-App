using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 70100L, true, 70L, 72, 302L },
                    { 70101L, false, 70L, 18, 331L },
                    { 70102L, true, 70L, 83, 325L },
                    { 70103L, false, 70L, 7, 326L },
                    { 70104L, true, 70L, 89, 313L },
                    { 70105L, false, 70L, 1, 314L },
                    { 70106L, true, 70L, 90, 322L },
                    { 70107L, true, 70L, 90, 329L },
                    { 70108L, true, 70L, 90, 312L },
                    { 70109L, true, 70L, 90, 315L },
                    { 70110L, true, 70L, 90, 305L },
                    { 70111L, true, 70L, 90, 311L },
                    { 70112L, true, 70L, 90, 324L },
                    { 70113L, true, 70L, 90, 330L },
                    { 70114L, false, 70L, 0, 601L },
                    { 70115L, false, 70L, 0, 333L },
                    { 70116L, false, 70L, 0, 304L },
                    { 70117L, false, 70L, 0, 321L },
                    { 70200L, true, 70L, 57, 135L },
                    { 70201L, false, 70L, 33, 123L },
                    { 70202L, true, 70L, 70, 129L },
                    { 70203L, false, 70L, 20, 116L },
                    { 70204L, true, 70L, 71, 105L },
                    { 70205L, false, 70L, 19, 120L },
                    { 70206L, true, 70L, 90, 113L },
                    { 70207L, true, 70L, 90, 107L },
                    { 70208L, true, 70L, 90, 111L },
                    { 70209L, true, 70L, 90, 121L },
                    { 70210L, true, 70L, 90, 132L },
                    { 70211L, true, 70L, 90, 127L },
                    { 70212L, true, 70L, 90, 124L },
                    { 70213L, true, 70L, 90, 131L },
                    { 70214L, false, 70L, 0, 115L },
                    { 70215L, false, 70L, 0, 126L },
                    { 70216L, false, 70L, 0, 102L },
                    { 71100L, true, 71L, 53, 1305L },
                    { 71101L, false, 71L, 37, 1300L },
                    { 71102L, true, 71L, 77, 1304L },
                    { 71103L, false, 71L, 13, 1306L },
                    { 71104L, true, 71L, 89, 1318L },
                    { 71105L, false, 71L, 1, 1312L },
                    { 71106L, true, 71L, 90, 1322L },
                    { 71107L, true, 71L, 90, 1323L },
                    { 71108L, true, 71L, 90, 1302L },
                    { 71109L, true, 71L, 90, 1325L },
                    { 71110L, true, 71L, 90, 1313L },
                    { 71111L, true, 71L, 90, 1308L },
                    { 71112L, true, 71L, 90, 1320L },
                    { 71113L, true, 71L, 90, 1310L },
                    { 71114L, false, 71L, 0, 820L },
                    { 71115L, false, 71L, 0, 1309L },
                    { 71116L, false, 71L, 0, 1319L },
                    { 71117L, false, 71L, 0, 1321L },
                    { 71200L, true, 71L, 71, 1920L },
                    { 71201L, false, 71L, 19, 1931L },
                    { 71202L, true, 71L, 77, 1903L },
                    { 71203L, false, 71L, 13, 1916L },
                    { 71204L, true, 71L, 90, 1900L },
                    { 71205L, true, 71L, 90, 408L },
                    { 71206L, true, 71L, 90, 1912L },
                    { 71207L, true, 71L, 90, 1933L },
                    { 71208L, true, 71L, 90, 1926L },
                    { 71209L, true, 71L, 90, 1917L },
                    { 71210L, true, 71L, 90, 1925L },
                    { 71211L, true, 71L, 90, 1922L },
                    { 71212L, true, 71L, 90, 1905L },
                    { 71213L, false, 71L, 0, 1930L },
                    { 71214L, false, 71L, 0, 1901L },
                    { 71215L, false, 71L, 0, 1924L },
                    { 71216L, false, 71L, 0, 824L },
                    { 71217L, false, 71L, 0, 1918L },
                    { 72100L, true, 72L, 65, 727L },
                    { 72101L, false, 72L, 25, 715L },
                    { 72102L, true, 72L, 69, 702L },
                    { 72103L, false, 72L, 21, 739L },
                    { 72104L, true, 72L, 80, 706L },
                    { 72105L, false, 72L, 10, 718L },
                    { 72106L, true, 72L, 90, 726L },
                    { 72107L, true, 72L, 90, 716L },
                    { 72108L, true, 72L, 90, 705L },
                    { 72109L, true, 72L, 90, 725L },
                    { 72110L, true, 72L, 90, 730L },
                    { 72111L, true, 72L, 90, 721L },
                    { 72112L, true, 72L, 90, 704L },
                    { 72113L, true, 72L, 90, 722L },
                    { 72114L, false, 72L, 0, 723L },
                    { 72115L, false, 72L, 0, 714L },
                    { 72116L, false, 72L, 0, 735L },
                    { 72117L, false, 72L, 0, 709L },
                    { 72200L, true, 72L, 74, 2016L },
                    { 72201L, false, 72L, 16, 2022L },
                    { 72202L, true, 72L, 85, 2015L },
                    { 72203L, false, 72L, 5, 2028L },
                    { 72204L, true, 72L, 90, 2018L },
                    { 72205L, true, 72L, 90, 2005L },
                    { 72206L, true, 72L, 90, 2029L },
                    { 72207L, true, 72L, 90, 117L },
                    { 72208L, true, 72L, 90, 2002L },
                    { 72209L, true, 72L, 90, 2024L },
                    { 72210L, true, 72L, 90, 2030L },
                    { 72211L, true, 72L, 90, 2026L },
                    { 72212L, true, 72L, 90, 2019L },
                    { 72213L, false, 72L, 0, 2017L },
                    { 72214L, false, 72L, 0, 2004L },
                    { 72215L, false, 72L, 0, 2025L },
                    { 72216L, false, 72L, 0, 2027L },
                    { 73100L, true, 73L, 66, 527L },
                    { 73101L, false, 73L, 24, 512L },
                    { 73102L, true, 73L, 71, 518L },
                    { 73103L, false, 73L, 19, 524L },
                    { 73104L, true, 73L, 88, 506L },
                    { 73105L, false, 73L, 2, 521L },
                    { 73106L, true, 73L, 90, 507L },
                    { 73107L, true, 73L, 90, 517L },
                    { 73108L, true, 73L, 90, 519L },
                    { 73109L, true, 73L, 90, 500L },
                    { 73110L, true, 73L, 90, 520L },
                    { 73111L, true, 73L, 90, 502L },
                    { 73112L, true, 73L, 90, 511L },
                    { 73113L, true, 73L, 90, 523L },
                    { 73114L, false, 73L, 0, 505L },
                    { 73115L, false, 73L, 0, 529L },
                    { 73116L, false, 73L, 0, 515L },
                    { 73200L, true, 73L, 73, 1224L },
                    { 73201L, false, 73L, 17, 1219L },
                    { 73202L, true, 73L, 78, 1206L },
                    { 73203L, false, 73L, 12, 1205L },
                    { 73204L, true, 73L, 83, 1237L },
                    { 73205L, false, 73L, 7, 1223L },
                    { 73206L, true, 73L, 90, 1230L },
                    { 73207L, true, 73L, 90, 1229L },
                    { 73208L, true, 73L, 90, 1236L },
                    { 73209L, true, 73L, 90, 1227L },
                    { 73210L, true, 73L, 90, 1218L },
                    { 73211L, true, 73L, 90, 1215L },
                    { 73212L, true, 73L, 90, 1209L },
                    { 73213L, true, 73L, 90, 1245L },
                    { 73214L, false, 73L, 0, 1226L },
                    { 73215L, false, 73L, 0, 1210L },
                    { 73216L, false, 73L, 0, 1214L },
                    { 73217L, false, 73L, 0, 1211L },
                    { 74100L, true, 74L, 29, 2225L },
                    { 74101L, false, 74L, 61, 2211L },
                    { 74102L, true, 74L, 71, 2206L },
                    { 74103L, false, 74L, 19, 2212L },
                    { 74104L, true, 74L, 85, 2203L },
                    { 74105L, false, 74L, 5, 2224L },
                    { 74106L, true, 74L, 90, 2215L },
                    { 74107L, true, 74L, 90, 2220L },
                    { 74108L, true, 74L, 90, 2210L },
                    { 74109L, true, 74L, 90, 1201L },
                    { 74110L, true, 74L, 90, 2216L },
                    { 74111L, true, 74L, 90, 1729L },
                    { 74112L, true, 74L, 90, 2205L },
                    { 74113L, true, 74L, 90, 2219L },
                    { 74114L, false, 74L, 0, 2214L },
                    { 74115L, false, 74L, 0, 2204L },
                    { 74116L, false, 74L, 0, 2226L },
                    { 74117L, false, 74L, 0, 2222L },
                    { 74200L, true, 74L, 46, 216L },
                    { 74201L, false, 74L, 44, 232L },
                    { 74202L, true, 74L, 46, 234L },
                    { 74203L, false, 74L, 44, 213L },
                    { 74204L, true, 74L, 89, 214L },
                    { 74205L, false, 74L, 1, 224L },
                    { 74206L, true, 74L, 90, 226L },
                    { 74207L, true, 74L, 90, 231L },
                    { 74208L, true, 74L, 90, 204L },
                    { 74209L, true, 74L, 90, 219L },
                    { 74210L, true, 74L, 90, 206L },
                    { 74211L, true, 74L, 90, 203L },
                    { 74212L, true, 74L, 90, 221L },
                    { 74213L, true, 74L, 90, 212L },
                    { 74214L, false, 74L, 0, 200L },
                    { 74215L, false, 74L, 0, 207L },
                    { 74216L, false, 74L, 0, 208L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 701L, 1, 4, 12, 16, 2, 455, 49, 0, 3, 8, 3, 25, 701L, 0 },
                    { 702L, 4, 9, 12, 14, 4, 457, 51, 0, 0, 9, 4, 9, 702L, 1 },
                    { 711L, 2, 8, 11, 8, 0, 425, 49, 0, 6, 14, 6, 20, 711L, 3 },
                    { 712L, 7, 6, 7, 11, 2, 444, 51, 0, 4, 17, 6, 30, 712L, 1 },
                    { 721L, 1, 5, 11, 5, 1, 374, 41, 0, 3, 6, 1, 24, 721L, 0 },
                    { 722L, 3, 9, 5, 11, 0, 524, 59, 0, 1, 12, 5, 22, 722L, 0 },
                    { 731L, 7, 10, 4, 13, 0, 850, 80, 0, 1, 28, 8, 15, 731L, 0 },
                    { 732L, 2, 3, 10, 4, 2, 210, 20, 0, 6, 4, 1, 15, 732L, 3 },
                    { 741L, 1, 3, 17, 17, 1, 421, 53, 0, 4, 9, 5, 26, 741L, 2 },
                    { 742L, 0, 0, 16, 17, 1, 389, 47, 0, 5, 10, 6, 16, 742L, 2 }
                });

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

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 7011L, 70104L, false, false, 5 },
                    { 7012L, 70102L, false, false, 74 },
                    { 7021L, 70201L, false, false, 71 },
                    { 7022L, 70200L, false, true, 43 },
                    { 7111L, 71103L, false, false, 79 },
                    { 7112L, 71113L, false, false, 87 },
                    { 7221L, 72207L, false, false, 73 },
                    { 7222L, 72200L, false, false, 30 },
                    { 7311L, 73100L, false, false, 65 },
                    { 7312L, 73113L, false, false, 29 },
                    { 7421L, 74213L, false, false, 25 },
                    { 7422L, 74213L, false, false, 34 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7012L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7112L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7222L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7422L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74216L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 701L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 702L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 711L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 712L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 721L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 722L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 731L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 732L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 741L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 742L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 70201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 71113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 72207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 73113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 74213L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6FC17FA9B7047C69F97FEEFDFFCC52FFD45476E45D9A5C200D36893D1AFBFCEF800C8EA5296BAA8EFE1F1EB7998816B1AE91FFAA4135048C4568BFB926C58FC5", new byte[] { 211, 89, 241, 28, 177, 104, 231, 59, 158, 54, 67, 80, 137, 60, 26, 26, 171, 87, 59, 73, 3, 148, 95, 19, 168, 158, 179, 109, 43, 236, 182, 206, 197, 9, 51, 212, 179, 205, 244, 62, 255, 198, 104, 70, 227, 151, 72, 235, 155, 121, 191, 9, 71, 228, 14, 71, 203, 104, 86, 255, 82, 132, 246, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "52405AADE00AECB1FF0C8C73284002EAE7122549C5D20FF02093ED00BC766F5CDC7C01FDC1EC67A4895D085E8CA76C287521C47F066DA3DFF88F97687F2A8688", new byte[] { 167, 13, 49, 29, 211, 207, 59, 22, 49, 177, 242, 154, 52, 218, 141, 131, 163, 223, 246, 174, 240, 135, 160, 97, 144, 73, 137, 97, 29, 100, 149, 125, 71, 84, 8, 14, 216, 76, 229, 122, 32, 61, 196, 24, 32, 147, 205, 192, 160, 6, 189, 231, 84, 46, 22, 31, 196, 53, 195, 175, 81, 191, 140, 190 } });
        }
    }
}
