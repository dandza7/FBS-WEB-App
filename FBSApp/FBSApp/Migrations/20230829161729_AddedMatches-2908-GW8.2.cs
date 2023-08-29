using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW82 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 82100L, true, 82L, 72, 214L },
                    { 82101L, false, 82L, 18, 207L },
                    { 82102L, true, 82L, 85, 224L },
                    { 82103L, false, 82L, 5, 232L },
                    { 82104L, true, 82L, 88, 203L },
                    { 82105L, false, 82L, 2, 200L },
                    { 82106L, true, 82L, 90, 215L },
                    { 82107L, true, 82L, 90, 219L },
                    { 82108L, true, 82L, 90, 204L },
                    { 82109L, true, 82L, 90, 231L },
                    { 82110L, true, 82L, 90, 213L },
                    { 82111L, true, 82L, 90, 206L },
                    { 82112L, true, 82L, 90, 221L },
                    { 82113L, true, 82L, 90, 212L },
                    { 82114L, false, 82L, 0, 226L },
                    { 82115L, false, 82L, 0, 208L },
                    { 82116L, false, 82L, 0, 225L },
                    { 82117L, false, 82L, 0, 220L },
                    { 82200L, true, 82L, 78, 1813L },
                    { 82201L, false, 82L, 12, 1814L },
                    { 82202L, true, 82L, 78, 1804L },
                    { 82203L, false, 82L, 8, 1805L },
                    { 82204L, false, 82L, 5, 1802L },
                    { 82205L, true, 82L, 90, 1821L },
                    { 82206L, true, 82L, 90, 1803L },
                    { 82207L, true, 82L, 90, 1823L },
                    { 82208L, true, 82L, 90, 1824L },
                    { 82209L, true, 82L, 90, 1810L },
                    { 82210L, true, 82L, 90, 1811L },
                    { 82211L, true, 82L, 90, 1430L },
                    { 82212L, true, 82L, 90, 1808L },
                    { 82213L, true, 82L, 90, 1812L },
                    { 82214L, false, 82L, 0, 1801L },
                    { 82215L, false, 82L, 0, 1809L },
                    { 82216L, false, 82L, 0, 1815L },
                    { 83100L, true, 83L, 67, 2019L },
                    { 83101L, false, 83L, 23, 2022L },
                    { 83102L, true, 83L, 80, 2015L },
                    { 83103L, false, 83L, 10, 2025L },
                    { 83104L, true, 83L, 86, 2026L },
                    { 83105L, false, 83L, 4, 2027L },
                    { 83106L, true, 83L, 90, 2018L },
                    { 83107L, true, 83L, 90, 2005L },
                    { 83108L, true, 83L, 63, 2029L },
                    { 83109L, true, 83L, 90, 117L },
                    { 83110L, true, 83L, 90, 2002L },
                    { 83111L, true, 83L, 90, 2024L },
                    { 83112L, true, 83L, 90, 2030L },
                    { 83113L, true, 83L, 90, 2016L },
                    { 83114L, false, 83L, 0, 2017L },
                    { 83115L, false, 83L, 0, 2004L },
                    { 83116L, false, 83L, 0, 2028L },
                    { 83200L, true, 83L, 71, 1028L },
                    { 83201L, false, 83L, 19, 1004L },
                    { 83202L, true, 83L, 89, 1003L },
                    { 83203L, false, 83L, 1, 1021L },
                    { 83204L, true, 83L, 89, 1027L },
                    { 83205L, false, 83L, 1, 1006L },
                    { 83206L, true, 83L, 90, 1013L },
                    { 83207L, true, 83L, 90, 1012L },
                    { 83208L, true, 83L, 90, 1019L },
                    { 83209L, true, 83L, 90, 924L },
                    { 83210L, true, 83L, 90, 1016L },
                    { 83211L, true, 83L, 90, 1008L },
                    { 83212L, true, 83L, 90, 1007L },
                    { 83213L, true, 83L, 90, 1024L },
                    { 83214L, false, 83L, 0, 1015L },
                    { 83215L, false, 83L, 0, 1018L },
                    { 83216L, false, 83L, 0, 1000L },
                    { 83217L, false, 83L, 0, 1017L },
                    { 84100L, true, 84L, 63, 1408L },
                    { 84101L, false, 84L, 27, 1420L },
                    { 84102L, true, 84L, 72, 1414L },
                    { 84103L, false, 84L, 18, 1404L },
                    { 84104L, true, 84L, 82, 1411L },
                    { 84105L, false, 84L, 8, 1400L },
                    { 84106L, true, 84L, 90, 1431L },
                    { 84107L, true, 84L, 90, 100L },
                    { 84108L, true, 84L, 90, 1409L },
                    { 84109L, true, 84L, 90, 1418L },
                    { 84110L, true, 84L, 90, 1422L },
                    { 84111L, true, 84L, 90, 1401L },
                    { 84112L, true, 84L, 90, 1416L },
                    { 84113L, true, 84L, 90, 1432L },
                    { 84114L, false, 84L, 0, 1429L },
                    { 84115L, false, 84L, 0, 1419L },
                    { 84116L, false, 84L, 0, 1410L },
                    { 84117L, false, 84L, 0, 1412L },
                    { 84200L, true, 84L, 76, 1318L },
                    { 84201L, false, 84L, 14, 1306L },
                    { 84202L, true, 84L, 84, 1305L },
                    { 84203L, false, 84L, 6, 1319L },
                    { 84204L, true, 84L, 87, 1304L },
                    { 84205L, false, 84L, 3, 1300L },
                    { 84206L, true, 84L, 90, 1322L },
                    { 84207L, true, 84L, 90, 1323L },
                    { 84208L, true, 84L, 90, 1302L },
                    { 84209L, true, 84L, 90, 1325L },
                    { 84210L, true, 84L, 90, 1313L },
                    { 84211L, true, 84L, 90, 1308L },
                    { 84212L, true, 84L, 90, 1320L },
                    { 84213L, true, 84L, 90, 1310L },
                    { 84214L, false, 84L, 0, 1312L },
                    { 84215L, false, 84L, 0, 1315L },
                    { 84216L, false, 84L, 0, 820L },
                    { 84217L, false, 84L, 0, 1309L },
                    { 85100L, true, 85L, 61, 1601L },
                    { 85101L, false, 85L, 29, 1606L },
                    { 85102L, true, 85L, 73, 1602L },
                    { 85103L, false, 85L, 17, 1612L },
                    { 85104L, true, 85L, 89, 1624L },
                    { 85105L, false, 85L, 1, 1617L },
                    { 85106L, true, 85L, 90, 1613L },
                    { 85107L, true, 85L, 90, 1618L },
                    { 85108L, true, 85L, 90, 1610L },
                    { 85109L, true, 85L, 90, 1604L },
                    { 85110L, true, 85L, 90, 1605L },
                    { 85111L, true, 85L, 90, 1614L },
                    { 85112L, true, 85L, 90, 1609L },
                    { 85113L, true, 85L, 90, 1600L },
                    { 85114L, false, 85L, 0, 1622L },
                    { 85115L, false, 85L, 0, 1627L },
                    { 85116L, false, 85L, 0, 1616L },
                    { 85117L, false, 85L, 0, 1608L },
                    { 85200L, true, 85L, 59, 2219L },
                    { 85201L, false, 85L, 31, 2212L },
                    { 85202L, true, 85L, 59, 2222L },
                    { 85203L, false, 85L, 31, 2224L },
                    { 85204L, true, 85L, 86, 2205L },
                    { 85205L, false, 85L, 4, 2211L },
                    { 85206L, true, 85L, 90, 2215L },
                    { 85207L, true, 85L, 90, 2210L },
                    { 85208L, true, 85L, 90, 2220L },
                    { 85209L, true, 85L, 90, 2206L },
                    { 85210L, true, 85L, 90, 1729L },
                    { 85211L, true, 85L, 90, 2216L },
                    { 85212L, true, 85L, 90, 1201L },
                    { 85213L, true, 85L, 90, 2203L },
                    { 85214L, false, 85L, 0, 2202L },
                    { 85215L, false, 85L, 0, 2214L },
                    { 85216L, false, 85L, 0, 2204L },
                    { 85217L, false, 85L, 0, 2227L },
                    { 86100L, true, 86L, 19, 115L },
                    { 86101L, false, 86L, 71, 120L },
                    { 86102L, true, 86L, 46, 132L },
                    { 86103L, false, 86L, 44, 124L },
                    { 86104L, true, 86L, 67, 123L },
                    { 86105L, false, 86L, 23, 101L },
                    { 86106L, true, 86L, 90, 113L },
                    { 86107L, true, 86L, 90, 107L },
                    { 86108L, true, 86L, 90, 111L },
                    { 86109L, true, 86L, 90, 121L },
                    { 86110L, true, 86L, 90, 127L },
                    { 86111L, true, 86L, 90, 129L },
                    { 86112L, true, 86L, 90, 131L },
                    { 86113L, true, 86L, 90, 105L },
                    { 86114L, false, 86L, 0, 116L },
                    { 86115L, false, 86L, 0, 135L },
                    { 86116L, false, 86L, 0, 103L },
                    { 86200L, true, 86L, 68, 725L },
                    { 86201L, false, 86L, 22, 715L },
                    { 86202L, true, 86L, 78, 739L },
                    { 86203L, false, 86L, 12, 704L },
                    { 86204L, true, 86L, 88, 702L },
                    { 86205L, false, 86L, 2, 722L },
                    { 86206L, true, 86L, 90, 726L },
                    { 86207L, true, 86L, 90, 706L },
                    { 86208L, true, 86L, 90, 716L },
                    { 86209L, true, 86L, 90, 710L },
                    { 86210L, true, 86L, 90, 718L },
                    { 86211L, true, 86L, 90, 727L },
                    { 86212L, true, 86L, 90, 721L },
                    { 86213L, true, 86L, 90, 730L },
                    { 86214L, false, 86L, 0, 705L },
                    { 86215L, false, 86L, 0, 723L },
                    { 86216L, false, 86L, 0, 714L },
                    { 86217L, false, 86L, 0, 709L },
                    { 87100L, true, 87L, 54, 1519L },
                    { 87101L, false, 87L, 36, 1523L },
                    { 87102L, true, 87L, 62, 1504L },
                    { 87103L, false, 87L, 28, 1509L },
                    { 87104L, true, 87L, 83, 1524L },
                    { 87105L, false, 87L, 7, 1521L },
                    { 87106L, true, 87L, 90, 1513L },
                    { 87107L, true, 87L, 90, 1502L },
                    { 87108L, true, 87L, 90, 1515L },
                    { 87109L, true, 87L, 90, 1501L },
                    { 87110L, true, 87L, 90, 1507L },
                    { 87111L, true, 87L, 90, 227L },
                    { 87112L, true, 87L, 90, 1525L },
                    { 87113L, true, 87L, 90, 1522L },
                    { 87114L, false, 87L, 0, 1526L },
                    { 87115L, false, 87L, 0, 1500L },
                    { 87116L, false, 87L, 0, 1517L },
                    { 87117L, false, 87L, 0, 1518L },
                    { 87200L, true, 87L, 62, 410L },
                    { 87201L, false, 87L, 28, 433L },
                    { 87202L, true, 87L, 67, 402L },
                    { 87203L, false, 87L, 23, 400L },
                    { 87204L, true, 87L, 80, 403L },
                    { 87205L, false, 87L, 10, 426L },
                    { 87206L, true, 87L, 90, 404L },
                    { 87207L, true, 87L, 90, 418L },
                    { 87208L, true, 87L, 90, 437L },
                    { 87209L, true, 87L, 90, 435L },
                    { 87210L, true, 87L, 90, 429L },
                    { 87211L, true, 87L, 90, 424L },
                    { 87212L, true, 87L, 90, 417L },
                    { 87213L, true, 87L, 90, 419L },
                    { 87214L, false, 87L, 0, 436L },
                    { 87215L, false, 87L, 0, 439L },
                    { 87216L, false, 87L, 0, 415L },
                    { 87217L, false, 87L, 0, 438L },
                    { 88100L, true, 88L, 46, 1911L },
                    { 88101L, false, 88L, 44, 1924L },
                    { 88102L, true, 88L, 78, 1916L },
                    { 88103L, false, 88L, 12, 1928L },
                    { 88104L, true, 88L, 90, 1900L },
                    { 88105L, true, 88L, 90, 1933L },
                    { 88106L, true, 88L, 90, 1918L },
                    { 88107L, true, 88L, 90, 408L },
                    { 88108L, true, 88L, 90, 1925L },
                    { 88109L, true, 88L, 90, 1917L },
                    { 88110L, true, 88L, 90, 1926L },
                    { 88111L, true, 88L, 90, 1922L },
                    { 88112L, true, 88L, 90, 1905L },
                    { 88113L, false, 88L, 0, 1903L },
                    { 88114L, false, 88L, 0, 1930L },
                    { 88115L, false, 88L, 0, 1901L },
                    { 88116L, false, 88L, 0, 824L },
                    { 88117L, false, 88L, 0, 1912L },
                    { 88200L, true, 88L, 68, 933L },
                    { 88201L, false, 88L, 22, 944L },
                    { 88202L, true, 88L, 75, 941L },
                    { 88203L, false, 88L, 15, 934L },
                    { 88204L, true, 88L, 81, 937L },
                    { 88205L, false, 88L, 9, 930L },
                    { 88206L, true, 88L, 90, 923L },
                    { 88207L, true, 88L, 90, 905L },
                    { 88208L, true, 88L, 90, 901L },
                    { 88209L, true, 88L, 90, 909L },
                    { 88210L, true, 88L, 90, 928L },
                    { 88211L, true, 88L, 90, 932L },
                    { 88212L, true, 88L, 90, 922L },
                    { 88213L, true, 88L, 90, 912L },
                    { 88214L, false, 88L, 0, 942L },
                    { 88215L, false, 88L, 0, 916L },
                    { 88216L, false, 88L, 0, 943L },
                    { 88217L, false, 88L, 0, 910L },
                    { 89100L, true, 89L, 29, 615L },
                    { 89101L, false, 89L, 51, 621L },
                    { 89102L, true, 89L, 72, 627L },
                    { 89103L, false, 89L, 18, 609L },
                    { 89104L, true, 89L, 90, 604L },
                    { 89105L, true, 89L, 90, 616L },
                    { 89106L, true, 89L, 90, 610L },
                    { 89107L, true, 89L, 90, 633L },
                    { 89108L, true, 89L, 90, 618L },
                    { 89109L, true, 89L, 90, 620L },
                    { 89110L, true, 89L, 90, 628L },
                    { 89111L, true, 89L, 90, 613L },
                    { 89112L, true, 89L, 90, 605L },
                    { 89113L, false, 89L, 0, 632L },
                    { 89114L, false, 89L, 0, 612L },
                    { 89115L, false, 89L, 0, 617L },
                    { 89116L, false, 89L, 0, 630L },
                    { 89117L, false, 89L, 0, 634L },
                    { 89200L, true, 89L, 66, 527L },
                    { 89201L, false, 89L, 24, 512L },
                    { 89202L, true, 89L, 76, 523L },
                    { 89203L, false, 89L, 14, 518L },
                    { 89204L, true, 89L, 90, 507L },
                    { 89205L, true, 89L, 90, 517L },
                    { 89206L, true, 89L, 90, 515L },
                    { 89207L, true, 89L, 90, 500L },
                    { 89208L, true, 89L, 90, 501L },
                    { 89209L, true, 89L, 90, 502L },
                    { 89210L, true, 89L, 90, 511L },
                    { 89211L, true, 89L, 90, 524L },
                    { 89212L, true, 89L, 90, 506L },
                    { 89213L, false, 89L, 0, 505L },
                    { 89214L, false, 89L, 0, 521L },
                    { 89215L, false, 89L, 0, 529L },
                    { 89216L, false, 89L, 0, 519L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9AD69563D52CB6C969F878F43EB1FC04A5CD37849B40E3E5A13BB74ABBECEA5F17C2E2710750D1A07DD302EB77A2729B6DBA1CAE0F4EA6277C5F5243CDD74EBC", new byte[] { 132, 116, 7, 10, 202, 152, 141, 24, 70, 103, 237, 82, 172, 230, 102, 4, 109, 86, 10, 166, 189, 47, 40, 236, 223, 80, 166, 241, 70, 153, 242, 199, 73, 56, 43, 186, 124, 41, 64, 46, 116, 105, 177, 183, 186, 38, 62, 29, 129, 180, 36, 184, 94, 133, 145, 210, 250, 107, 80, 190, 212, 189, 43, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E9E9C32A967702C86FE36BE4D652AA41680279C11034E09D9825BF2D06122FB745955E2E59E4F2E2E290B14F2A389FEAE3EA65A2BE04399AB9A560A6E3AD863E", new byte[] { 169, 147, 147, 30, 249, 110, 155, 78, 141, 104, 133, 94, 229, 239, 247, 34, 223, 106, 69, 250, 101, 81, 146, 115, 193, 82, 77, 124, 50, 107, 45, 10, 85, 52, 168, 204, 185, 200, 194, 159, 190, 6, 234, 104, 111, 149, 177, 154, 44, 192, 46, 40, 92, 103, 60, 18, 250, 121, 156, 137, 55, 229, 148, 119 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 82216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 83217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 84217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 85217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 86217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 87217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 88217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 89216L);

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
    }
}
