using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 60100L, true, 60L, 46, 1509L },
                    { 60101L, false, 60L, 44, 1526L },
                    { 60102L, true, 60L, 46, 1500L },
                    { 60103L, false, 60L, 44, 1502L },
                    { 60104L, true, 60L, 64, 1521L },
                    { 60105L, false, 60L, 26, 1504L },
                    { 60106L, true, 60L, 90, 1513L },
                    { 60107L, true, 60L, 90, 134L },
                    { 60108L, true, 60L, 90, 406L },
                    { 60109L, true, 60L, 90, 227L },
                    { 60110L, true, 60L, 90, 1507L },
                    { 60111L, true, 60L, 90, 1524L },
                    { 60112L, true, 60L, 90, 1525L },
                    { 60113L, true, 60L, 90, 1522L },
                    { 60114L, false, 60L, 0, 1501L },
                    { 60115L, false, 60L, 0, 1523L },
                    { 60116L, false, 60L, 0, 1515L },
                    { 60117L, false, 60L, 0, 1517L },
                    { 60200L, true, 60L, 70, 2141L },
                    { 60201L, false, 60L, 20, 2129L },
                    { 60202L, true, 60L, 80, 2104L },
                    { 60203L, false, 60L, 10, 2121L },
                    { 60204L, true, 60L, 89, 2134L },
                    { 60205L, false, 60L, 1, 2128L },
                    { 60206L, true, 60L, 90, 2106L },
                    { 60207L, true, 60L, 90, 2113L },
                    { 60208L, true, 60L, 90, 2110L },
                    { 60209L, true, 60L, 90, 2109L },
                    { 60210L, true, 60L, 90, 2125L },
                    { 60211L, true, 60L, 90, 2100L },
                    { 60212L, true, 60L, 90, 2116L },
                    { 60213L, true, 60L, 90, 2140L },
                    { 60214L, false, 60L, 0, 2133L },
                    { 60215L, false, 60L, 0, 2119L },
                    { 60216L, false, 60L, 0, 2103L },
                    { 60217L, false, 60L, 0, 2102L },
                    { 61100L, true, 61L, 63, 116L },
                    { 61101L, false, 61L, 27, 105L },
                    { 61102L, true, 61L, 63, 101L },
                    { 61103L, false, 61L, 27, 120L },
                    { 61104L, true, 61L, 75, 119L },
                    { 61105L, false, 61L, 15, 103L },
                    { 61106L, true, 61L, 90, 113L },
                    { 61107L, true, 61L, 90, 106L },
                    { 61108L, true, 61L, 90, 111L },
                    { 61109L, true, 61L, 90, 135L },
                    { 61110L, true, 61L, 90, 121L },
                    { 61111L, true, 61L, 90, 129L },
                    { 61112L, true, 61L, 90, 124L },
                    { 61113L, true, 61L, 90, 131L },
                    { 61114L, false, 61L, 0, 115L },
                    { 61115L, false, 61L, 0, 132L },
                    { 61116L, false, 61L, 0, 107L },
                    { 61200L, true, 61L, 75, 1305L },
                    { 61201L, false, 61L, 15, 1300L },
                    { 61202L, true, 61L, 80, 1308L },
                    { 61203L, false, 61L, 10, 1319L },
                    { 61204L, true, 61L, 87, 1304L },
                    { 61205L, false, 61L, 3, 1315L },
                    { 61206L, true, 61L, 90, 1322L },
                    { 61207L, true, 61L, 90, 1323L },
                    { 61208L, true, 61L, 90, 1302L },
                    { 61209L, true, 61L, 90, 1325L },
                    { 61210L, true, 61L, 90, 1313L },
                    { 61211L, true, 61L, 90, 1320L },
                    { 61212L, true, 61L, 90, 1310L },
                    { 61213L, true, 61L, 90, 1318L },
                    { 61214L, false, 61L, 0, 1312L },
                    { 61215L, false, 61L, 0, 820L },
                    { 61216L, false, 61L, 0, 1309L },
                    { 61217L, false, 61L, 0, 1321L },
                    { 62100L, true, 62L, 46, 634L },
                    { 62101L, false, 62L, 44, 615L },
                    { 62102L, true, 62L, 55, 633L },
                    { 62103L, false, 62L, 35, 616L },
                    { 62104L, true, 62L, 70, 613L },
                    { 62105L, false, 62L, 20, 621L },
                    { 62106L, true, 62L, 90, 604L },
                    { 62107L, true, 62L, 90, 632L },
                    { 62108L, true, 62L, 90, 617L },
                    { 62109L, true, 62L, 90, 605L },
                    { 62110L, true, 62L, 90, 618L },
                    { 62111L, true, 62L, 90, 620L },
                    { 62112L, true, 62L, 90, 628L },
                    { 62113L, true, 62L, 90, 627L },
                    { 62114L, false, 62L, 0, 612L },
                    { 62115L, false, 62L, 0, 630L },
                    { 62116L, false, 62L, 0, 602L },
                    { 62117L, false, 62L, 0, 609L },
                    { 62200L, true, 62L, 55, 824L },
                    { 62201L, false, 62L, 35, 1931L },
                    { 62202L, true, 62L, 55, 1924L },
                    { 62203L, false, 62L, 35, 1911L },
                    { 62204L, true, 62L, 79, 1928L },
                    { 62205L, false, 62L, 11, 1903L },
                    { 62206L, true, 62L, 90, 1900L },
                    { 62207L, true, 62L, 90, 408L },
                    { 62208L, true, 62L, 90, 1912L },
                    { 62209L, true, 62L, 90, 1933L },
                    { 62210L, true, 62L, 90, 1926L },
                    { 62211L, true, 62L, 90, 1922L },
                    { 62212L, true, 62L, 90, 1925L },
                    { 62213L, true, 62L, 90, 1917L },
                    { 62214L, false, 62L, 0, 1930L },
                    { 62215L, false, 62L, 0, 1901L },
                    { 62216L, false, 62L, 0, 1910L },
                    { 62217L, false, 62L, 0, 1918L },
                    { 63100L, true, 63L, 46, 2025L },
                    { 63101L, false, 63L, 44, 2007L },
                    { 63102L, true, 63L, 77, 2019L },
                    { 63103L, false, 63L, 13, 2022L },
                    { 63104L, true, 63L, 85, 2015L },
                    { 63105L, false, 63L, 5, 2027L },
                    { 63106L, true, 63L, 90, 2018L },
                    { 63107L, true, 63L, 90, 2005L },
                    { 63108L, true, 63L, 90, 2017L },
                    { 63109L, true, 63L, 90, 117L },
                    { 63110L, true, 63L, 90, 2002L },
                    { 63111L, true, 63L, 90, 2030L },
                    { 63112L, true, 63L, 90, 2024L },
                    { 63113L, true, 63L, 90, 2016L },
                    { 63114L, false, 63L, 0, 2004L },
                    { 63115L, false, 63L, 0, 2026L },
                    { 63116L, false, 63L, 0, 2000L },
                    { 63200L, true, 63L, 57, 2227L },
                    { 63201L, false, 63L, 33, 2202L },
                    { 63202L, true, 63L, 72, 2225L },
                    { 63203L, false, 63L, 18, 2203L },
                    { 63204L, false, 63L, 90, 2215L },
                    { 63205L, false, 63L, 90, 2210L },
                    { 63206L, true, 63L, 90, 2220L },
                    { 63207L, true, 63L, 90, 2206L },
                    { 63208L, true, 63L, 90, 2205L },
                    { 63209L, true, 63L, 90, 1201L },
                    { 63210L, true, 63L, 90, 1729L },
                    { 63211L, true, 63L, 90, 2222L },
                    { 63212L, true, 63L, 90, 2219L },
                    { 63213L, false, 63L, 0, 2211L },
                    { 63214L, false, 63L, 0, 2204L },
                    { 63215L, false, 63L, 0, 2216L },
                    { 63216L, false, 63L, 0, 2212L },
                    { 63217L, false, 63L, 0, 2224L },
                    { 64100L, true, 64L, 63, 1404L },
                    { 64101L, false, 64L, 27, 1420L },
                    { 64102L, true, 64L, 71, 1414L },
                    { 64103L, false, 64L, 19, 1400L },
                    { 64104L, true, 64L, 90, 1431L },
                    { 64105L, true, 64L, 90, 100L },
                    { 64106L, true, 64L, 90, 1409L },
                    { 64107L, true, 64L, 90, 1418L },
                    { 64108L, true, 64L, 90, 1422L },
                    { 64109L, true, 64L, 90, 1416L },
                    { 64110L, true, 64L, 90, 1408L },
                    { 64111L, true, 64L, 90, 1401L },
                    { 64112L, true, 64L, 90, 1432L },
                    { 64113L, false, 64L, 0, 1429L },
                    { 64114L, false, 64L, 0, 1419L },
                    { 64115L, false, 64L, 0, 1410L },
                    { 64116L, false, 64L, 0, 1411L },
                    { 64117L, false, 64L, 0, 1412L },
                    { 64200L, true, 64L, 46, 734L },
                    { 64201L, false, 64L, 44, 722L },
                    { 64202L, true, 64L, 73, 727L },
                    { 64203L, false, 64L, 17, 704L },
                    { 64204L, true, 64L, 81, 702L },
                    { 64205L, false, 64L, 9, 739L },
                    { 64206L, true, 64L, 90, 726L },
                    { 64207L, true, 64L, 90, 706L },
                    { 64208L, true, 64L, 90, 710L },
                    { 64209L, true, 64L, 90, 716L },
                    { 64210L, true, 64L, 90, 732L },
                    { 64211L, true, 64L, 90, 730L },
                    { 64212L, true, 64L, 90, 721L },
                    { 64213L, true, 64L, 90, 725L },
                    { 64214L, false, 64L, 0, 705L },
                    { 64215L, false, 64L, 0, 723L },
                    { 64216L, false, 64L, 0, 736L },
                    { 64217L, false, 64L, 0, 718L },
                    { 65100L, true, 65L, 51, 1817L },
                    { 65101L, false, 65L, 39, 1809L },
                    { 65102L, true, 65L, 63, 1805L },
                    { 65103L, false, 65L, 27, 1815L },
                    { 65104L, true, 65L, 75, 1813L },
                    { 65105L, false, 65L, 15, 1812L },
                    { 65106L, true, 65L, 90, 1821L },
                    { 65107L, true, 65L, 90, 1823L },
                    { 65108L, true, 65L, 90, 1803L },
                    { 65109L, true, 65L, 90, 1807L },
                    { 65110L, true, 65L, 90, 1430L },
                    { 65111L, true, 65L, 90, 1811L },
                    { 65112L, true, 65L, 90, 1808L },
                    { 65113L, true, 65L, 90, 1802L },
                    { 65114L, false, 65L, 0, 1824L },
                    { 65115L, false, 65L, 0, 1810L },
                    { 65116L, false, 65L, 0, 1804L },
                    { 65200L, true, 65L, 61, 527L },
                    { 65201L, false, 65L, 29, 524L },
                    { 65202L, true, 65L, 69, 513L },
                    { 65203L, false, 65L, 21, 521L },
                    { 65204L, true, 65L, 74, 511L },
                    { 65205L, false, 65L, 16, 515L },
                    { 65206L, true, 65L, 90, 507L },
                    { 65207L, true, 65L, 90, 517L },
                    { 65208L, true, 65L, 90, 519L },
                    { 65209L, true, 65L, 90, 500L },
                    { 65210L, true, 65L, 90, 510L },
                    { 65211L, true, 65L, 90, 502L },
                    { 65212L, true, 65L, 90, 523L },
                    { 65213L, true, 65L, 90, 518L },
                    { 65214L, false, 65L, 0, 512L },
                    { 65215L, false, 65L, 0, 529L },
                    { 65216L, false, 65L, 0, 506L },
                    { 66100L, true, 66L, 60, 1617L },
                    { 66101L, false, 66L, 30, 1606L },
                    { 66102L, true, 66L, 69, 1624L },
                    { 66103L, false, 66L, 21, 1601L },
                    { 66104L, true, 66L, 90, 1613L },
                    { 66105L, true, 66L, 90, 1618L },
                    { 66106L, true, 66L, 90, 1610L },
                    { 66107L, true, 66L, 90, 1604L },
                    { 66108L, true, 66L, 90, 1605L },
                    { 66109L, true, 66L, 90, 1600L },
                    { 66110L, true, 66L, 90, 1602L },
                    { 66111L, true, 66L, 90, 1609L },
                    { 66112L, true, 66L, 90, 1614L },
                    { 66113L, false, 66L, 0, 1622L },
                    { 66114L, false, 66L, 0, 1627L },
                    { 66115L, false, 66L, 0, 1612L },
                    { 66116L, false, 66L, 0, 1616L },
                    { 66117L, false, 66L, 0, 1608L },
                    { 66200L, true, 66L, 46, 1712L },
                    { 66201L, false, 66L, 44, 1732L },
                    { 66202L, true, 66L, 68, 1707L },
                    { 66203L, false, 66L, 22, 1723L },
                    { 66204L, true, 66L, 78, 1701L },
                    { 66205L, false, 66L, 12, 1720L },
                    { 66206L, true, 66L, 90, 1706L },
                    { 66207L, true, 66L, 90, 1733L },
                    { 66208L, true, 66L, 90, 1728L },
                    { 66209L, true, 66L, 90, 1711L },
                    { 66210L, true, 66L, 90, 1719L },
                    { 66211L, true, 66L, 90, 1703L },
                    { 66212L, true, 66L, 90, 1730L },
                    { 66213L, true, 66L, 90, 1722L },
                    { 66214L, false, 66L, 0, 1705L },
                    { 66215L, false, 66L, 0, 1724L },
                    { 66216L, false, 66L, 0, 1721L },
                    { 66217L, false, 66L, 0, 1734L },
                    { 67100L, true, 67L, 21, 1212L },
                    { 67101L, false, 67L, 69, 1209L },
                    { 67102L, true, 67L, 73, 1237L },
                    { 67103L, false, 67L, 17, 1205L },
                    { 67104L, true, 67L, 79, 1245L },
                    { 67105L, false, 67L, 11, 1224L },
                    { 67106L, true, 67L, 90, 1230L },
                    { 67107L, true, 67L, 90, 1229L },
                    { 67108L, true, 67L, 90, 1236L },
                    { 67109L, true, 67L, 90, 1227L },
                    { 67110L, true, 67L, 90, 1218L },
                    { 67111L, true, 67L, 90, 1206L },
                    { 67112L, true, 67L, 90, 1215L },
                    { 67113L, true, 67L, 90, 1219L },
                    { 67114L, false, 67L, 0, 1217L },
                    { 67115L, false, 67L, 0, 1226L },
                    { 67116L, false, 67L, 0, 1210L },
                    { 67117L, false, 67L, 0, 1214L },
                    { 67200L, true, 67L, 68, 214L },
                    { 67201L, false, 67L, 22, 207L },
                    { 67202L, true, 67L, 78, 221L },
                    { 67203L, false, 67L, 12, 205L },
                    { 67204L, true, 67L, 90, 226L },
                    { 67205L, true, 67L, 90, 219L },
                    { 67206L, true, 67L, 90, 231L },
                    { 67207L, true, 67L, 90, 216L },
                    { 67208L, true, 67L, 90, 203L },
                    { 67209L, true, 67L, 90, 206L },
                    { 67210L, true, 67L, 90, 234L },
                    { 67211L, true, 67L, 90, 202L },
                    { 67212L, true, 67L, 90, 212L },
                    { 67213L, false, 67L, 0, 228L },
                    { 67214L, false, 67L, 0, 204L },
                    { 67215L, false, 67L, 0, 232L },
                    { 67216L, false, 67L, 0, 213L },
                    { 68100L, true, 68L, 65, 326L },
                    { 68101L, false, 68L, 35, 321L },
                    { 68102L, true, 68L, 74, 313L },
                    { 68103L, false, 68L, 16, 331L },
                    { 68104L, true, 68L, 85, 324L },
                    { 68105L, false, 68L, 5, 307L },
                    { 68106L, true, 68L, 90, 322L },
                    { 68107L, true, 68L, 90, 329L },
                    { 68108L, true, 68L, 90, 315L },
                    { 68109L, true, 68L, 90, 312L },
                    { 68110L, true, 68L, 90, 305L },
                    { 68111L, true, 68L, 90, 311L },
                    { 68112L, true, 68L, 90, 330L },
                    { 68113L, true, 68L, 90, 302L },
                    { 68114L, false, 68L, 0, 601L },
                    { 68115L, false, 68L, 0, 300L },
                    { 68116L, false, 68L, 0, 333L },
                    { 68117L, false, 68L, 0, 304L },
                    { 68200L, true, 68L, 65, 933L },
                    { 68201L, false, 68L, 25, 944L },
                    { 68202L, true, 68L, 69, 901L },
                    { 68203L, false, 68L, 21, 916L },
                    { 68204L, true, 68L, 79, 930L },
                    { 68205L, false, 68L, 11, 937L },
                    { 68206L, true, 68L, 90, 923L },
                    { 68207L, true, 68L, 90, 905L },
                    { 68208L, true, 68L, 90, 909L },
                    { 68209L, true, 68L, 90, 928L },
                    { 68210L, true, 68L, 90, 932L },
                    { 68211L, true, 68L, 90, 922L },
                    { 68212L, true, 68L, 90, 941L },
                    { 68213L, true, 68L, 90, 912L },
                    { 68214L, false, 68L, 0, 942L },
                    { 68215L, false, 68L, 0, 943L },
                    { 68216L, false, 68L, 0, 945L },
                    { 68217L, false, 68L, 0, 910L },
                    { 69100L, true, 69L, 39, 438L },
                    { 69101L, false, 69L, 51, 435L },
                    { 69102L, true, 69L, 69, 433L },
                    { 69103L, false, 69L, 21, 402L },
                    { 69104L, true, 69L, 80, 400L },
                    { 69105L, false, 69L, 10, 410L },
                    { 69106L, true, 69L, 90, 432L },
                    { 69107L, true, 69L, 90, 418L },
                    { 69108L, true, 69L, 90, 437L },
                    { 69109L, true, 69L, 90, 429L },
                    { 69110L, true, 69L, 90, 424L },
                    { 69111L, true, 69L, 90, 417L },
                    { 69112L, true, 69L, 90, 427L },
                    { 69113L, true, 69L, 90, 403L },
                    { 69114L, false, 69L, 0, 428L },
                    { 69115L, false, 69L, 0, 426L },
                    { 69116L, false, 69L, 0, 404L },
                    { 69117L, false, 69L, 0, 439L },
                    { 69200L, true, 69L, 72, 1027L },
                    { 69201L, false, 69L, 18, 1003L },
                    { 69202L, true, 69L, 72, 1006L },
                    { 69203L, false, 69L, 18, 1004L },
                    { 69204L, true, 69L, 90, 1013L },
                    { 69205L, true, 69L, 90, 1012L },
                    { 69206L, true, 69L, 90, 924L },
                    { 69207L, true, 69L, 90, 1019L },
                    { 69208L, true, 69L, 90, 1016L },
                    { 69209L, true, 69L, 90, 1008L },
                    { 69210L, true, 69L, 90, 1028L },
                    { 69211L, true, 69L, 90, 1007L },
                    { 69212L, true, 69L, 90, 1024L },
                    { 69213L, false, 69L, 0, 1015L },
                    { 69214L, false, 69L, 0, 1018L },
                    { 69215L, false, 69L, 0, 1000L },
                    { 69216L, false, 69L, 0, 1021L },
                    { 69217L, false, 69L, 0, 1017L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 601L, 6, 8, 11, 14, 5, 524, 69, 0, 5, 15, 3, 14, 601L, 2 },
                    { 602L, 1, 8, 9, 17, 6, 335, 31, 0, 2, 11, 6, 11, 602L, 1 },
                    { 611L, 6, 5, 5, 18, 3, 684, 64, 0, 7, 15, 6, 15, 611L, 1 },
                    { 612L, 0, 4, 17, 7, 2, 379, 36, 0, 5, 11, 8, 13, 612L, 1 },
                    { 621L, 3, 5, 7, 11, 4, 749, 61, 0, 1, 12, 4, 16, 621L, 0 },
                    { 622L, 5, 4, 10, 11, 1, 478, 39, 0, 1, 17, 1, 20, 622L, 2 },
                    { 631L, 3, 3, 10, 16, 1, 589, 62, 0, 1, 18, 8, 23, 631L, 2 },
                    { 632L, 2, 1, 16, 11, 0, 357, 38, 0, 5, 9, 2, 11, 632L, 1 },
                    { 641L, 5, 9, 8, 12, 2, 479, 62, 0, 3, 16, 4, 30, 641L, 1 },
                    { 642L, 0, 5, 11, 10, 1, 297, 38, 0, 4, 6, 3, 27, 642L, 1 },
                    { 651L, 0, 1, 6, 5, 2, 219, 22, 0, 5, 2, 2, 15, 651L, 1 },
                    { 652L, 7, 9, 4, 8, 1, 800, 78, 0, 2, 21, 10, 14, 652L, 1 },
                    { 661L, 4, 3, 17, 9, 1, 360, 37, 0, 5, 12, 5, 15, 661L, 2 },
                    { 662L, 9, 8, 6, 18, 2, 603, 63, 0, 1, 19, 5, 9, 662L, 0 },
                    { 671L, 1, 5, 15, 9, 2, 255, 29, 0, 5, 8, 4, 13, 671L, 2 },
                    { 672L, 4, 7, 9, 15, 0, 658, 71, 0, 5, 16, 7, 18, 672L, 1 },
                    { 681L, 1, 1, 11, 12, 2, 297, 28, 0, 6, 6, 1, 22, 681L, 2 },
                    { 682L, 5, 8, 9, 13, 3, 758, 72, 0, 1, 17, 6, 8, 682L, 1 },
                    { 691L, 3, 5, 17, 14, 1, 555, 62, 0, 6, 9, 5, 19, 691L, 2 },
                    { 692L, 1, 9, 12, 18, 2, 315, 38, 0, 3, 9, 6, 21, 692L, 1 }
                });

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

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 6011L, 60112L, false, false, 78 },
                    { 6021L, 60202L, false, false, 2 },
                    { 6111L, 61100L, false, false, 18 },
                    { 6121L, 61202L, false, false, 53 },
                    { 6211L, 62108L, false, false, 21 },
                    { 6212L, 62111L, true, false, 45 },
                    { 6221L, 62209L, false, true, 10 },
                    { 6311L, 63102L, false, false, 19 },
                    { 6312L, 63104L, false, false, 66 },
                    { 6313L, 63113L, false, false, 76 },
                    { 6321L, 63206L, false, false, 5 },
                    { 6521L, 65201L, false, false, 67 },
                    { 6522L, 65201L, false, false, 89 },
                    { 6523L, 65202L, false, false, 44 },
                    { 6524L, 65200L, false, false, 32 },
                    { 6525L, 65211L, false, false, 35 },
                    { 6611L, 66103L, false, false, 83 },
                    { 6612L, 66103L, false, false, 88 },
                    { 6613L, 66109L, false, false, 41 },
                    { 6614L, 66100L, false, false, 39 },
                    { 6711L, 67111L, true, false, 90 },
                    { 6721L, 67201L, false, false, 76 },
                    { 6722L, 67212L, false, true, 42 },
                    { 6911L, 69102L, false, false, 59 },
                    { 6912L, 69113L, false, false, 56 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6212L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6313L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6522L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6523L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6524L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6525L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6612L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6613L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6614L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6722L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6912L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 64217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 68217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 641L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 642L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 651L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 652L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 661L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 662L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 671L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 672L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 681L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 682L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 691L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 692L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 60202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 61202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 62209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 63206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 65211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 66109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 67212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 69113L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4DD41F543BC3011B25B51C7CA3770404FD0C4A9C91CF33D8E61DADC4D06336B7C795FDD68CFA50B67B2B66F5475D06F5AD2A84B94D730C1C55D8D0889A5877A5", new byte[] { 171, 14, 179, 227, 212, 41, 116, 62, 161, 78, 24, 176, 53, 199, 108, 4, 21, 202, 6, 87, 79, 212, 192, 143, 204, 242, 212, 115, 118, 12, 104, 146, 77, 128, 149, 115, 156, 35, 109, 114, 91, 95, 0, 100, 207, 234, 172, 217, 74, 41, 128, 91, 70, 134, 40, 118, 117, 94, 85, 76, 91, 27, 119, 89 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "84D9AF2B1CBF7F7173F537FA0EA79C569032CAD4192B3DED6363E311A61CAFBEADE5B08F10C4D4A05AB5D186D491914B6EEE8FB97EBA69BC80F8C89DC8D40382", new byte[] { 18, 117, 150, 70, 161, 1, 9, 88, 219, 102, 103, 30, 43, 134, 202, 60, 136, 55, 162, 30, 45, 95, 115, 117, 163, 32, 94, 57, 136, 143, 146, 214, 233, 143, 8, 47, 41, 144, 151, 241, 208, 70, 172, 106, 126, 219, 135, 213, 218, 19, 245, 63, 252, 14, 220, 121, 76, 75, 14, 32, 138, 201, 67, 213 } });
        }
    }
}
