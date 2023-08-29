using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 90100L, true, 90L, 69, 930L },
                    { 90101L, false, 90L, 21, 937L },
                    { 90102L, true, 90L, 73, 941L },
                    { 90103L, false, 90L, 17, 934L },
                    { 90104L, true, 90L, 79, 944L },
                    { 90105L, false, 90L, 11, 933L },
                    { 90106L, true, 90L, 90, 923L },
                    { 90107L, true, 90L, 90, 905L },
                    { 90108L, true, 90L, 90, 901L },
                    { 90109L, true, 90L, 90, 909L },
                    { 90110L, true, 90L, 90, 928L },
                    { 90111L, true, 90L, 90, 932L },
                    { 90112L, true, 90L, 90, 922L },
                    { 90113L, true, 90L, 90, 912L },
                    { 90114L, false, 90L, 0, 942L },
                    { 90115L, false, 90L, 0, 916L },
                    { 90116L, false, 90L, 0, 943L },
                    { 90117L, false, 90L, 0, 910L },
                    { 90200L, true, 90L, 75, 120L },
                    { 90201L, false, 90L, 15, 102L },
                    { 90202L, true, 90L, 84, 105L },
                    { 90203L, false, 90L, 6, 103L },
                    { 90204L, true, 90L, 85, 123L },
                    { 90205L, false, 90L, 5, 101L },
                    { 90206L, true, 90L, 90, 113L },
                    { 90207L, true, 90L, 90, 107L },
                    { 90208L, true, 90L, 90, 111L },
                    { 90209L, true, 90L, 90, 135L },
                    { 90210L, true, 90L, 90, 121L },
                    { 90211L, true, 90L, 90, 127L },
                    { 90212L, true, 90L, 90, 129L },
                    { 90213L, true, 90L, 90, 131L },
                    { 90214L, false, 90L, 0, 115L },
                    { 90215L, false, 90L, 0, 126L },
                    { 90216L, false, 90L, 0, 116L },
                    { 91100L, true, 91L, 46, 1310L },
                    { 91101L, false, 91L, 44, 1321L },
                    { 91102L, true, 91L, 60, 1318L },
                    { 91103L, false, 91L, 30, 1306L },
                    { 91104L, true, 91L, 72, 1313L },
                    { 91105L, false, 91L, 18, 1300L },
                    { 91106L, true, 91L, 90, 1322L },
                    { 91107L, true, 91L, 90, 1323L },
                    { 91108L, true, 91L, 90, 1302L },
                    { 91109L, true, 91L, 90, 1325L },
                    { 91110L, true, 91L, 90, 1320L },
                    { 91111L, true, 91L, 90, 1308L },
                    { 91112L, true, 91L, 90, 1305L },
                    { 91113L, true, 91L, 90, 1304L },
                    { 91114L, false, 91L, 0, 1312L },
                    { 91115L, false, 91L, 0, 820L },
                    { 91116L, false, 91L, 0, 1309L },
                    { 91117L, false, 91L, 0, 1319L },
                    { 91200L, true, 91L, 69, 2117L },
                    { 91201L, false, 91L, 21, 2104L },
                    { 91202L, true, 91L, 75, 2121L },
                    { 91203L, false, 91L, 13, 2136L },
                    { 91204L, true, 91L, 2, 2107L },
                    { 91205L, true, 91L, 90, 2106L },
                    { 91206L, true, 91L, 90, 2129L },
                    { 91207L, true, 91L, 90, 2103L },
                    { 91208L, true, 91L, 90, 2110L },
                    { 91209L, true, 91L, 90, 2102L },
                    { 91210L, true, 91L, 90, 2100L },
                    { 91211L, true, 91L, 90, 2116L },
                    { 91212L, true, 91L, 90, 2141L },
                    { 91213L, true, 91L, 90, 2134L },
                    { 91214L, false, 91L, 0, 2119L },
                    { 91215L, false, 91L, 0, 2130L },
                    { 91216L, false, 91L, 0, 2115L },
                    { 91217L, false, 91L, 0, 2128L },
                    { 92100L, true, 92L, 40, 302L },
                    { 92101L, false, 92L, 50, 314L },
                    { 92102L, true, 92L, 57, 313L },
                    { 92103L, false, 92L, 33, 318L },
                    { 92104L, true, 92L, 72, 324L },
                    { 92105L, false, 92L, 18, 326L },
                    { 92106L, true, 92L, 90, 322L },
                    { 92107L, true, 92L, 90, 329L },
                    { 92108L, true, 92L, 90, 312L },
                    { 92109L, true, 92L, 90, 315L },
                    { 92110L, true, 92L, 90, 300L },
                    { 92111L, true, 92L, 90, 311L },
                    { 92112L, true, 92L, 90, 331L },
                    { 92113L, true, 92L, 90, 325L },
                    { 92114L, false, 92L, 0, 601L },
                    { 92115L, false, 92L, 0, 333L },
                    { 92116L, false, 92L, 0, 305L },
                    { 92117L, false, 92L, 0, 304L },
                    { 92200L, true, 92L, 76, 207L },
                    { 92201L, false, 92L, 14, 234L },
                    { 92202L, true, 92L, 86, 212L },
                    { 92203L, false, 92L, 4, 208L },
                    { 92204L, true, 92L, 89, 224L },
                    { 92205L, false, 92L, 1, 202L },
                    { 92206L, true, 92L, 90, 215L },
                    { 92207L, true, 92L, 90, 219L },
                    { 92208L, true, 92L, 90, 204L },
                    { 92209L, true, 92L, 90, 231L },
                    { 92210L, true, 92L, 90, 200L },
                    { 92211L, true, 92L, 90, 206L },
                    { 92212L, true, 92L, 90, 213L },
                    { 92213L, true, 92L, 90, 221L },
                    { 92214L, false, 92L, 0, 228L },
                    { 92215L, false, 92L, 0, 226L },
                    { 92216L, false, 92L, 0, 214L },
                    { 92217L, false, 92L, 0, 220L },
                    { 93100L, true, 93L, 74, 739L },
                    { 93101L, false, 93L, 16, 722L },
                    { 93102L, true, 93L, 90, 726L },
                    { 93103L, true, 93L, 90, 706L },
                    { 93104L, true, 93L, 90, 716L },
                    { 93105L, true, 93L, 90, 710L },
                    { 93106L, true, 93L, 90, 732L },
                    { 93107L, true, 93L, 90, 727L },
                    { 93108L, true, 93L, 90, 721L },
                    { 93109L, true, 93L, 90, 730L },
                    { 93110L, true, 93L, 90, 725L },
                    { 93111L, true, 93L, 90, 702L },
                    { 93112L, false, 93L, 0, 704L },
                    { 93113L, false, 93L, 0, 723L },
                    { 93114L, false, 93L, 0, 714L },
                    { 93115L, false, 93L, 0, 718L },
                    { 93116L, false, 93L, 0, 715L },
                    { 93117L, false, 93L, 0, 709L },
                    { 93200L, true, 93L, 16, 1219L },
                    { 93201L, false, 93L, 74, 1224L },
                    { 93202L, true, 93L, 68, 1211L },
                    { 93203L, false, 93L, 22, 1210L },
                    { 93204L, true, 93L, 80, 1223L },
                    { 93205L, false, 93L, 10, 1245L },
                    { 93206L, true, 93L, 90, 1230L },
                    { 93207L, true, 93L, 90, 1236L },
                    { 93208L, true, 93L, 90, 1227L },
                    { 93209L, true, 93L, 90, 1218L },
                    { 93210L, true, 93L, 90, 1205L },
                    { 93211L, true, 93L, 90, 1212L },
                    { 93212L, true, 93L, 90, 1209L },
                    { 93213L, true, 93L, 90, 1237L },
                    { 93214L, false, 93L, 0, 1217L },
                    { 93215L, false, 93L, 0, 1226L },
                    { 93216L, false, 93L, 0, 1214L },
                    { 93217L, false, 93L, 0, 1206L },
                    { 94100L, true, 94L, 58, 502L },
                    { 94101L, false, 94L, 32, 516L },
                    { 94102L, true, 94L, 66, 527L },
                    { 94103L, false, 94L, 24, 512L },
                    { 94104L, true, 94L, 75, 506L },
                    { 94105L, false, 94L, 15, 521L },
                    { 94106L, true, 94L, 90, 507L },
                    { 94107L, true, 94L, 90, 515L },
                    { 94108L, true, 94L, 90, 529L },
                    { 94109L, true, 94L, 90, 500L },
                    { 94110L, true, 94L, 90, 501L },
                    { 94111L, true, 94L, 90, 511L },
                    { 94112L, true, 94L, 90, 524L },
                    { 94113L, true, 94L, 90, 518L },
                    { 94114L, false, 94L, 0, 519L },
                    { 94115L, false, 94L, 0, 523L },
                    { 94116L, false, 94L, 0, 520L },
                    { 94200L, true, 94L, 69, 1600L },
                    { 94201L, false, 94L, 21, 1602L },
                    { 94202L, true, 94L, 69, 1624L },
                    { 94203L, false, 94L, 21, 1606L },
                    { 94204L, true, 94L, 75, 1626L },
                    { 94205L, false, 94L, 15, 1601L },
                    { 94206L, true, 94L, 90, 1613L },
                    { 94207L, true, 94L, 90, 1618L },
                    { 94208L, true, 94L, 90, 1610L },
                    { 94209L, true, 94L, 90, 1604L },
                    { 94210L, true, 94L, 90, 1605L },
                    { 94211L, true, 94L, 90, 1614L },
                    { 94212L, true, 94L, 90, 1609L },
                    { 94213L, true, 94L, 90, 1612L },
                    { 94214L, false, 94L, 0, 1622L },
                    { 94215L, false, 94L, 0, 1627L },
                    { 94216L, false, 94L, 0, 1616L },
                    { 94217L, false, 94L, 0, 1617L },
                    { 95100L, true, 95L, 77, 1801L },
                    { 95101L, false, 95L, 13, 1809L },
                    { 95102L, true, 95L, 82, 1812L },
                    { 95103L, false, 95L, 8, 1814L },
                    { 95104L, true, 95L, 86, 1808L },
                    { 95105L, false, 95L, 4, 1818L },
                    { 95106L, true, 95L, 90, 1821L },
                    { 95107L, true, 95L, 90, 1803L },
                    { 95108L, true, 95L, 90, 1823L },
                    { 95109L, true, 95L, 90, 1824L },
                    { 95110L, true, 95L, 90, 1810L },
                    { 95111L, true, 95L, 90, 1430L },
                    { 95112L, true, 95L, 90, 1802L },
                    { 95113L, true, 95L, 90, 1804L },
                    { 95114L, false, 95L, 0, 1807L },
                    { 95115L, false, 95L, 0, 1813L },
                    { 95116L, false, 95L, 0, 1800L },
                    { 95117L, false, 95L, 0, 1815L },
                    { 95200L, true, 95L, 46, 406L },
                    { 95201L, false, 95L, 44, 1500L },
                    { 95202L, true, 95L, 58, 1507L },
                    { 95203L, false, 95L, 32, 1526L },
                    { 95204L, true, 95L, 82, 1521L },
                    { 95205L, false, 95L, 2, 1524L },
                    { 95206L, true, 95L, 90, 1513L },
                    { 95207L, true, 95L, 90, 1502L },
                    { 95208L, true, 95L, 90, 1519L },
                    { 95209L, true, 95L, 90, 1515L },
                    { 95210L, true, 95L, 90, 1509L },
                    { 95211L, true, 95L, 90, 1522L },
                    { 95212L, true, 95L, 90, 1525L },
                    { 95213L, true, 95L, 90, 227L },
                    { 95214L, false, 95L, 0, 1504L },
                    { 95215L, false, 95L, 0, 1501L },
                    { 95216L, false, 95L, 0, 1523L },
                    { 95217L, false, 95L, 0, 1517L },
                    { 96100L, true, 96L, 59, 1711L },
                    { 96101L, false, 96L, 31, 1723L },
                    { 96102L, true, 96L, 77, 1730L },
                    { 96103L, false, 96L, 13, 1721L },
                    { 96104L, true, 96L, 85, 1722L },
                    { 96105L, false, 96L, 5, 1710L },
                    { 96106L, true, 96L, 90, 1706L },
                    { 96107L, true, 96L, 90, 1732L },
                    { 96108L, true, 96L, 90, 1733L },
                    { 96109L, true, 96L, 90, 1728L },
                    { 96110L, true, 96L, 90, 1701L },
                    { 96111L, true, 96L, 90, 1719L },
                    { 96112L, true, 96L, 90, 1724L },
                    { 96113L, true, 96L, 90, 1707L },
                    { 96114L, false, 96L, 0, 1705L },
                    { 96115L, false, 96L, 0, 1720L },
                    { 96116L, false, 96L, 0, 1712L },
                    { 96117L, false, 96L, 0, 1703L },
                    { 96200L, true, 96L, 66, 1917L },
                    { 96201L, false, 96L, 24, 1931L },
                    { 96202L, true, 96L, 78, 1903L },
                    { 96203L, false, 96L, 12, 1928L },
                    { 96204L, true, 96L, 79, 1905L },
                    { 96205L, false, 96L, 11, 1916L },
                    { 96206L, true, 96L, 90, 1900L },
                    { 96207L, true, 96L, 90, 408L },
                    { 96208L, true, 96L, 90, 1907L },
                    { 96209L, true, 96L, 90, 1933L },
                    { 96210L, true, 96L, 90, 1926L },
                    { 96211L, true, 96L, 90, 1920L },
                    { 96212L, true, 96L, 90, 1925L },
                    { 96213L, true, 96L, 90, 1922L },
                    { 96214L, false, 96L, 0, 1901L },
                    { 96215L, false, 96L, 0, 1912L },
                    { 96216L, false, 96L, 0, 1910L },
                    { 96217L, false, 96L, 0, 1918L },
                    { 97100L, true, 97L, 69, 2211L },
                    { 97101L, false, 97L, 21, 2212L },
                    { 97102L, true, 97L, 70, 1729L },
                    { 97103L, false, 97L, 20, 2224L },
                    { 97104L, true, 97L, 89, 2216L },
                    { 97105L, false, 97L, 1, 2202L },
                    { 97106L, true, 97L, 90, 2215L },
                    { 97107L, true, 97L, 90, 2220L },
                    { 97108L, true, 97L, 90, 2206L },
                    { 97109L, true, 97L, 90, 2205L },
                    { 97110L, true, 97L, 90, 1201L },
                    { 97111L, true, 97L, 90, 2210L },
                    { 97112L, true, 97L, 90, 2203L },
                    { 97113L, true, 97L, 90, 2219L },
                    { 97114L, false, 97L, 0, 2217L },
                    { 97115L, false, 97L, 0, 2214L },
                    { 97116L, false, 97L, 0, 2204L },
                    { 97117L, false, 97L, 0, 2222L },
                    { 97200L, true, 97L, 46, 618L },
                    { 97201L, false, 97L, 44, 613L },
                    { 97202L, true, 97L, 69, 600L },
                    { 97203L, false, 97L, 21, 612L },
                    { 97204L, true, 97L, 77, 615L },
                    { 97205L, false, 97L, 13, 627L },
                    { 97206L, true, 97L, 90, 604L },
                    { 97207L, true, 97L, 90, 616L },
                    { 97208L, true, 97L, 90, 610L },
                    { 97209L, true, 97L, 90, 633L },
                    { 97210L, true, 97L, 90, 605L },
                    { 97211L, true, 97L, 90, 620L },
                    { 97212L, true, 97L, 90, 609L },
                    { 97213L, true, 97L, 90, 634L },
                    { 97214L, false, 97L, 0, 632L },
                    { 97215L, false, 97L, 0, 617L },
                    { 97216L, false, 97L, 0, 630L },
                    { 97217L, false, 97L, 0, 611L },
                    { 98100L, true, 98L, 67, 1003L },
                    { 98101L, false, 98L, 23, 1004L },
                    { 98102L, true, 98L, 82, 1001L },
                    { 98103L, false, 98L, 8, 1006L },
                    { 98104L, true, 98L, 82, 1027L },
                    { 98105L, false, 98L, 8, 1000L },
                    { 98106L, true, 98L, 90, 1013L },
                    { 98107L, true, 98L, 90, 1026L },
                    { 98108L, true, 98L, 90, 1019L },
                    { 98109L, true, 98L, 90, 924L },
                    { 98110L, true, 98L, 90, 1016L },
                    { 98111L, true, 98L, 90, 1008L },
                    { 98112L, true, 98L, 90, 1007L },
                    { 98113L, true, 98L, 90, 1024L },
                    { 98114L, false, 98L, 0, 1015L },
                    { 98115L, false, 98L, 0, 1028L },
                    { 98116L, false, 98L, 0, 1029L },
                    { 98117L, false, 98L, 0, 1017L },
                    { 98200L, true, 98L, 89, 1408L },
                    { 98201L, false, 98L, 1, 1406L },
                    { 98202L, true, 98L, 90, 1431L },
                    { 98203L, true, 98L, 90, 100L },
                    { 98204L, true, 98L, 90, 1409L },
                    { 98205L, true, 98L, 90, 1418L },
                    { 98206L, true, 98L, 90, 1422L },
                    { 98207L, true, 98L, 90, 1416L },
                    { 98208L, true, 98L, 90, 1404L },
                    { 98209L, true, 98L, 90, 1401L },
                    { 98210L, true, 98L, 90, 1411L },
                    { 98211L, true, 98L, 90, 1432L },
                    { 98212L, false, 98L, 0, 1414L },
                    { 98213L, false, 98L, 0, 1429L },
                    { 98214L, false, 98L, 0, 1427L },
                    { 98215L, false, 98L, 0, 1419L },
                    { 98216L, false, 98L, 0, 1410L },
                    { 98217L, false, 98L, 0, 1407L },
                    { 99100L, true, 99L, 61, 439L },
                    { 99101L, false, 99L, 29, 433L },
                    { 99102L, true, 99L, 61, 419L },
                    { 99103L, false, 99L, 29, 426L },
                    { 99104L, true, 99L, 70, 427L },
                    { 99105L, false, 99L, 20, 400L },
                    { 99106L, true, 99L, 90, 404L },
                    { 99107L, true, 99L, 90, 418L },
                    { 99108L, true, 99L, 90, 437L },
                    { 99109L, true, 99L, 90, 435L },
                    { 99110L, true, 99L, 90, 424L },
                    { 99111L, true, 99L, 90, 417L },
                    { 99112L, true, 99L, 90, 402L },
                    { 99113L, true, 99L, 90, 403L },
                    { 99114L, false, 99L, 0, 415L },
                    { 99115L, false, 99L, 0, 414L },
                    { 99116L, false, 99L, 0, 410L },
                    { 99200L, true, 99L, 61, 2019L },
                    { 99201L, false, 99L, 29, 2022L },
                    { 99202L, true, 99L, 69, 2026L },
                    { 99203L, false, 99L, 21, 2025L },
                    { 99204L, true, 99L, 75, 2015L },
                    { 99205L, false, 99L, 15, 2027L },
                    { 99206L, true, 99L, 90, 2018L },
                    { 99207L, true, 99L, 90, 2005L },
                    { 99208L, true, 99L, 90, 117L },
                    { 99209L, true, 99L, 90, 2017L },
                    { 99210L, true, 99L, 90, 2024L },
                    { 99211L, true, 99L, 90, 2030L },
                    { 99212L, true, 99L, 90, 2002L },
                    { 99213L, true, 99L, 90, 2016L },
                    { 99214L, false, 99L, 0, 2004L },
                    { 99215L, false, 99L, 0, 2028L },
                    { 99216L, false, 99L, 0, 2003L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 901L, 7, 5, 9, 18, 2, 611, 62, 0, 2, 21, 6, 12, 901L, 2 },
                    { 902L, 0, 3, 17, 11, 1, 371, 38, 0, 4, 7, 4, 21, 902L, 5 },
                    { 911L, 3, 8, 23, 14, 2, 420, 45, 0, 1, 10, 1, 22, 911L, 3 },
                    { 912L, 4, 2, 13, 25, 1, 520, 55, 0, 1, 9, 3, 15, 912L, 1 },
                    { 921L, 2, 10, 8, 11, 3, 377, 44, 0, 1, 13, 4, 32, 921L, 3 },
                    { 922L, 4, 6, 10, 11, 2, 506, 56, 0, 4, 10, 2, 13, 922L, 0 },
                    { 931L, 9, 10, 13, 19, 1, 504, 68, 0, 1, 27, 6, 17, 931L, 0 },
                    { 932L, 2, 2, 17, 11, 1, 247, 32, 0, 6, 8, 2, 19, 932L, 2 },
                    { 941L, 8, 10, 11, 5, 0, 679, 69, 0, 0, 24, 10, 12, 941L, 2 },
                    { 942L, 1, 1, 5, 10, 0, 302, 31, 0, 5, 5, 0, 12, 942L, 2 },
                    { 951L, 7, 4, 15, 15, 0, 313, 40, 0, 2, 22, 5, 13, 951L, 3 },
                    { 952L, 2, 4, 16, 15, 0, 479, 60, 0, 1, 9, 4, 17, 952L, 3 },
                    { 961L, 2, 6, 11, 18, 0, 458, 57, 0, 4, 9, 2, 9, 961L, 1 },
                    { 962L, 2, 4, 14, 11, 4, 346, 43, 0, 2, 8, 4, 18, 962L, 2 },
                    { 971L, 6, 2, 9, 7, 3, 524, 48, 0, 1, 13, 1, 22, 971L, 0 },
                    { 972L, 5, 4, 6, 12, 21, 585, 52, 0, 1, 11, 2, 13, 972L, 2 },
                    { 981L, 7, 10, 13, 17, 1, 510, 60, 0, 3, 20, 4, 19, 981L, 2 },
                    { 982L, 0, 5, 17, 13, 0, 350, 40, 0, 2, 7, 3, 23, 982L, 1 },
                    { 991L, 2, 6, 10, 11, 2, 703, 69, 0, 1, 19, 6, 20, 991L, 2 },
                    { 992L, 3, 4, 10, 12, 1, 309, 31, 0, 3, 8, 2, 14, 992L, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DC1477A4A49BF14518D5B1E8DEA7B83398996A53690579DB4F4094BD5F022F618020D792700DD87EDCC911892EAD062B155A1AB9BD76D7B927182678C1544CCE", new byte[] { 42, 14, 170, 109, 9, 157, 1, 117, 4, 220, 191, 18, 120, 114, 89, 186, 213, 141, 247, 153, 232, 178, 79, 77, 18, 211, 114, 61, 191, 189, 79, 211, 245, 223, 233, 210, 75, 64, 102, 178, 156, 110, 48, 116, 114, 105, 97, 113, 55, 154, 119, 177, 59, 56, 28, 69, 15, 174, 183, 96, 148, 235, 38, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6AEC985AFEA06FF11B91093D35EB67E8452D9C8DC622D3D72E89F5541B1B6532A437081CC20DA9D7F8BCB573C9839FD10058E5677122290CD8F807662C6BCE52", new byte[] { 69, 218, 115, 134, 110, 121, 203, 18, 231, 164, 222, 60, 98, 66, 196, 7, 249, 160, 214, 8, 187, 192, 4, 120, 218, 169, 198, 220, 46, 246, 194, 69, 232, 48, 188, 49, 42, 131, 29, 46, 50, 79, 8, 53, 166, 83, 39, 24, 174, 97, 173, 59, 190, 213, 174, 112, 137, 241, 194, 108, 221, 253, 159, 74 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 9011L, 90101L, true, false, 90 },
                    { 9012L, 90108L, false, false, 21 },
                    { 9021L, 90202L, false, false, 55 },
                    { 9022L, 90202L, false, false, 73 },
                    { 9121L, 91211L, false, false, 20 },
                    { 9122L, 91213L, false, false, 21 },
                    { 9221L, 92200L, false, false, 76 },
                    { 9321L, 93212L, false, false, 29 },
                    { 9411L, 94100L, false, false, 54 },
                    { 9412L, 94111L, false, false, 56 },
                    { 9413L, 94112L, false, false, 83 },
                    { 9414L, 94102L, false, false, 17 },
                    { 9415L, 94113L, false, false, 90 },
                    { 9511L, 95103L, false, false, 87 },
                    { 9512L, 95102L, false, false, 15 },
                    { 9513L, 95112L, false, false, 20 },
                    { 9514L, 95113L, false, false, 65 },
                    { 9521L, 95211L, false, false, 11 },
                    { 9522L, 95213L, false, false, 34 },
                    { 9721L, 97211L, false, false, 24 },
                    { 9811L, 98104L, false, false, 89 },
                    { 9812L, 98103L, false, false, 87 },
                    { 9911L, 99101L, false, false, 63 },
                    { 9912L, 99101L, false, false, 66 },
                    { 9913L, 99104L, false, false, 45 },
                    { 9914L, 99107L, false, false, 31 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9012L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9122L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9413L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9414L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9415L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9513L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9514L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9522L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9912L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9913L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9914L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 96217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99216L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 961L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 962L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 971L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 972L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 981L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 982L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 991L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 992L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 90202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 91213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 92200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 93212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 94113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 95213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 97211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 98104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 99107L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "2BBBD012DEE93630DB442EDE6A17C245798F0854FD757BFF940A6008D7F92DC919FE3AA5F710238807D8B7375248B87EDF48AD736DEFBE8C7E077051A117773C", new byte[] { 33, 142, 228, 61, 125, 141, 127, 25, 117, 34, 252, 195, 91, 181, 255, 114, 98, 49, 42, 58, 175, 108, 220, 83, 201, 96, 8, 42, 209, 233, 46, 4, 22, 209, 188, 105, 150, 6, 212, 234, 210, 187, 97, 51, 202, 180, 56, 151, 199, 115, 37, 111, 9, 104, 110, 11, 219, 159, 140, 186, 147, 177, 131, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "38AEB84B479C419581B84EF2C41A7F0234FD565EE845CF76BAE0BAD0E84CA4068D9AA35FD9EA79174E49155DEA4F7D4907B0131FD7167D68EB798D2C5A3638FE", new byte[] { 191, 17, 35, 208, 146, 46, 65, 35, 229, 34, 186, 234, 122, 139, 72, 96, 212, 40, 215, 236, 129, 43, 125, 140, 233, 66, 6, 229, 95, 78, 223, 174, 21, 116, 38, 192, 15, 125, 49, 218, 173, 1, 214, 23, 44, 191, 168, 249, 225, 149, 60, 177, 125, 249, 23, 184, 240, 185, 244, 214, 93, 110, 76, 245 } });
        }
    }
}
