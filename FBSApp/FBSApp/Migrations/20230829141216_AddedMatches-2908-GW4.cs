using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 40100L, true, 40L, 61, 2022L },
                    { 40101L, false, 40L, 29, 2019L },
                    { 40102L, true, 40L, 76, 2007L },
                    { 40103L, false, 40L, 14, 2027L },
                    { 40104L, true, 40L, 83, 2015L },
                    { 40105L, false, 40L, 7, 2005L },
                    { 40106L, true, 40L, 90, 2018L },
                    { 40107L, true, 40L, 90, 2026L },
                    { 40108L, true, 40L, 90, 2029L },
                    { 40109L, true, 40L, 90, 117L },
                    { 40110L, true, 40L, 90, 2002L },
                    { 40111L, true, 40L, 90, 2024L },
                    { 40112L, true, 40L, 90, 2030L },
                    { 40113L, true, 40L, 90, 2025L },
                    { 40114L, false, 40L, 0, 2017L },
                    { 40115L, false, 40L, 0, 2004L },
                    { 40116L, false, 40L, 0, 2028L },
                    { 40200L, true, 40L, 71, 618L },
                    { 40201L, false, 40L, 19, 621L },
                    { 40202L, true, 40L, 71, 620L },
                    { 40203L, false, 40L, 19, 634L },
                    { 40204L, true, 40L, 89, 632L },
                    { 40205L, false, 40L, 1, 617L },
                    { 40206L, true, 40L, 90, 604L },
                    { 40207L, true, 40L, 90, 616L },
                    { 40208L, true, 40L, 90, 633L },
                    { 40209L, true, 40L, 90, 605L },
                    { 40210L, true, 40L, 90, 613L },
                    { 40211L, true, 40L, 90, 615L },
                    { 40212L, true, 40L, 90, 627L },
                    { 40213L, true, 40L, 90, 628L },
                    { 40214L, false, 40L, 0, 600L },
                    { 40215L, false, 40L, 0, 630L },
                    { 40216L, false, 40L, 0, 602L },
                    { 40217L, false, 40L, 0, 609L },
                    { 41100L, true, 41L, 46, 331L },
                    { 41101L, false, 41L, 44, 302L },
                    { 41102L, true, 41L, 64, 316L },
                    { 41103L, false, 41L, 26, 330L },
                    { 41104L, true, 41L, 75, 326L },
                    { 41105L, false, 41L, 15, 318L },
                    { 41106L, true, 41L, 90, 322L },
                    { 41107L, true, 41L, 90, 333L },
                    { 41108L, true, 41L, 90, 312L },
                    { 41109L, true, 41L, 90, 315L },
                    { 41110L, true, 41L, 90, 300L },
                    { 41111L, true, 41L, 90, 307L },
                    { 41112L, true, 41L, 90, 313L },
                    { 41113L, true, 41L, 90, 325L },
                    { 41114L, false, 41L, 0, 601L },
                    { 41115L, false, 41L, 0, 324L },
                    { 41116L, false, 41L, 0, 311L },
                    { 41117L, false, 41L, 0, 329L },
                    { 41200L, true, 41L, 62, 1304L },
                    { 41201L, false, 41L, 28, 1300L },
                    { 41202L, true, 41L, 72, 1305L },
                    { 41203L, false, 41L, 18, 1312L },
                    { 41204L, true, 41L, 87, 1318L },
                    { 41205L, false, 41L, 3, 1321L },
                    { 41206L, true, 41L, 90, 1322L },
                    { 41207L, true, 41L, 90, 1323L },
                    { 41208L, true, 41L, 90, 1302L },
                    { 41209L, true, 41L, 90, 1325L },
                    { 41210L, true, 41L, 90, 1313L },
                    { 41211L, true, 41L, 90, 1308L },
                    { 41212L, true, 41L, 90, 1320L },
                    { 41213L, true, 41L, 90, 1310L },
                    { 41214L, false, 41L, 0, 1315L },
                    { 41215L, false, 41L, 0, 820L },
                    { 41216L, false, 41L, 0, 1309L },
                    { 41217L, false, 41L, 0, 1319L },
                    { 42100L, true, 42L, 57, 1027L },
                    { 42101L, false, 42L, 33, 1000L },
                    { 42102L, true, 42L, 76, 1016L },
                    { 42103L, false, 42L, 14, 1015L },
                    { 42104L, true, 42L, 76, 1007L },
                    { 42105L, false, 42L, 14, 1022L },
                    { 42106L, true, 42L, 90, 1013L },
                    { 42107L, true, 42L, 90, 1026L },
                    { 42108L, true, 42L, 90, 1018L },
                    { 42109L, true, 42L, 90, 924L },
                    { 42110L, true, 42L, 90, 1028L },
                    { 42111L, true, 42L, 90, 1021L },
                    { 42112L, true, 42L, 90, 1006L },
                    { 42113L, true, 42L, 90, 1004L },
                    { 42114L, false, 42L, 0, 1014L },
                    { 42115L, false, 42L, 0, 1012L },
                    { 42116L, false, 42L, 0, 1017L },
                    { 42200L, true, 42L, 60, 2202L },
                    { 42201L, false, 42L, 30, 2227L },
                    { 42202L, true, 42L, 76, 2211L },
                    { 42203L, false, 42L, 14, 2210L },
                    { 42204L, true, 42L, 89, 2224L },
                    { 42205L, false, 42L, 1, 2219L },
                    { 42206L, true, 42L, 90, 2215L },
                    { 42207L, true, 42L, 90, 2220L },
                    { 42208L, true, 42L, 90, 2206L },
                    { 42209L, true, 42L, 90, 2225L },
                    { 42210L, true, 42L, 90, 2205L },
                    { 42211L, true, 42L, 90, 1201L },
                    { 42212L, true, 42L, 90, 1729L },
                    { 42213L, true, 42L, 90, 2222L },
                    { 42214L, false, 42L, 0, 2212L },
                    { 42215L, false, 42L, 0, 2203L },
                    { 42216L, false, 42L, 0, 2208L },
                    { 43100L, true, 43L, 72, 1401L },
                    { 43101L, false, 43L, 18, 1404L },
                    { 43102L, true, 43L, 76, 1411L },
                    { 43103L, false, 43L, 14, 1420L },
                    { 43104L, true, 43L, 76, 1414L },
                    { 43105L, false, 43L, 14, 1400L },
                    { 43106L, true, 43L, 90, 1431L },
                    { 43107L, true, 43L, 90, 100L },
                    { 43108L, true, 43L, 90, 1419L },
                    { 43109L, true, 43L, 90, 1418L },
                    { 43110L, true, 43L, 90, 1422L },
                    { 43111L, true, 43L, 90, 1408L },
                    { 43112L, true, 43L, 90, 1416L },
                    { 43113L, true, 43L, 90, 1405L },
                    { 43114L, false, 43L, 0, 1429L },
                    { 43115L, false, 43L, 0, 1410L },
                    { 43116L, false, 43L, 0, 1407L },
                    { 43117L, false, 43L, 0, 1412L },
                    { 43200L, true, 43L, 62, 1928L },
                    { 43201L, false, 43L, 28, 1903L },
                    { 43202L, true, 43L, 73, 1920L },
                    { 43203L, false, 43L, 17, 824L },
                    { 43204L, true, 43L, 78, 1905L },
                    { 43205L, false, 43L, 12, 1924L },
                    { 43206L, true, 43L, 90, 1900L },
                    { 43207L, true, 43L, 90, 408L },
                    { 43208L, true, 43L, 90, 1912L },
                    { 43209L, true, 43L, 90, 1933L },
                    { 43210L, true, 43L, 90, 1926L },
                    { 43211L, true, 43L, 90, 1917L },
                    { 43212L, true, 43L, 90, 1925L },
                    { 43213L, true, 43L, 90, 1922L },
                    { 43214L, false, 43L, 0, 1930L },
                    { 43215L, false, 43L, 0, 1901L },
                    { 43216L, false, 43L, 0, 1910L },
                    { 43217L, false, 43L, 0, 1918L },
                    { 44100L, true, 44L, 61, 944L },
                    { 44101L, false, 44L, 29, 933L },
                    { 44102L, true, 44L, 65, 941L },
                    { 44103L, false, 44L, 25, 934L },
                    { 44104L, true, 44L, 79, 930L },
                    { 44105L, false, 44L, 11, 938L },
                    { 44106L, true, 44L, 90, 923L },
                    { 44107L, true, 44L, 90, 905L },
                    { 44108L, true, 44L, 90, 901L },
                    { 44109L, true, 44L, 90, 909L },
                    { 44110L, true, 44L, 90, 928L },
                    { 44111L, true, 44L, 90, 932L },
                    { 44112L, true, 44L, 90, 922L },
                    { 44113L, true, 44L, 90, 912L },
                    { 44114L, false, 44L, 0, 937L },
                    { 44115L, false, 44L, 0, 942L },
                    { 44116L, false, 44L, 0, 900L },
                    { 44117L, false, 44L, 0, 910L },
                    { 44200L, true, 44L, 80, 1701L },
                    { 44201L, false, 44L, 10, 1721L },
                    { 44202L, true, 44L, 80, 1722L },
                    { 44203L, false, 44L, 10, 1118L },
                    { 44204L, true, 44L, 88, 1719L },
                    { 44205L, false, 44L, 2, 1724L },
                    { 44206L, true, 44L, 90, 1706L },
                    { 44207L, true, 44L, 90, 1732L },
                    { 44208L, true, 44L, 90, 1733L },
                    { 44209L, true, 44L, 90, 1728L },
                    { 44210L, true, 44L, 90, 1710L },
                    { 44211L, true, 44L, 90, 1712L },
                    { 44212L, true, 44L, 90, 1730L },
                    { 44213L, true, 44L, 90, 1707L },
                    { 44214L, false, 44L, 0, 1705L },
                    { 44215L, false, 44L, 0, 1711L },
                    { 44216L, false, 44L, 0, 1734L },
                    { 44217L, false, 44L, 0, 1703L },
                    { 45100L, true, 45L, 60, 1232L },
                    { 45101L, false, 45L, 30, 1245L },
                    { 45102L, true, 45L, 74, 1206L },
                    { 45103L, false, 45L, 16, 1205L },
                    { 45104L, true, 45L, 74, 1215L },
                    { 45105L, false, 45L, 16, 1224L },
                    { 45106L, true, 45L, 90, 1230L },
                    { 45107L, true, 45L, 90, 1229L },
                    { 45108L, true, 45L, 90, 1236L },
                    { 45109L, true, 45L, 90, 1227L },
                    { 45110L, true, 45L, 90, 1218L },
                    { 45111L, true, 45L, 90, 1212L },
                    { 45112L, true, 45L, 90, 1237L },
                    { 45113L, true, 45L, 90, 1219L },
                    { 45114L, false, 45L, 0, 1226L },
                    { 45115L, false, 45L, 0, 1210L },
                    { 45116L, false, 45L, 0, 1214L },
                    { 45117L, false, 45L, 0, 1209L },
                    { 45200L, true, 45L, 74, 1504L },
                    { 45201L, false, 45L, 16, 1521L },
                    { 45202L, true, 45L, 74, 1524L },
                    { 45203L, false, 45L, 16, 227L },
                    { 45204L, true, 45L, 87, 1522L },
                    { 45205L, false, 45L, 3, 406L },
                    { 45206L, true, 45L, 90, 1513L },
                    { 45207L, true, 45L, 90, 134L },
                    { 45208L, true, 45L, 90, 1502L },
                    { 45209L, true, 45L, 90, 1500L },
                    { 45210L, true, 45L, 90, 1515L },
                    { 45211L, true, 45L, 90, 1509L },
                    { 45212L, true, 45L, 90, 1507L },
                    { 45213L, true, 45L, 90, 1525L },
                    { 45214L, false, 45L, 0, 1508L },
                    { 45215L, false, 45L, 0, 1501L },
                    { 45216L, false, 45L, 0, 1503L },
                    { 45217L, false, 45L, 0, 1523L },
                    { 46100L, true, 46L, 58, 512L },
                    { 46101L, false, 46L, 32, 502L },
                    { 46102L, true, 46L, 76, 524L },
                    { 46103L, false, 46L, 14, 513L },
                    { 46104L, true, 46L, 89, 506L },
                    { 46105L, false, 46L, 1, 529L },
                    { 46106L, true, 46L, 90, 507L },
                    { 46107L, true, 46L, 90, 517L },
                    { 46108L, true, 46L, 90, 515L },
                    { 46109L, true, 46L, 90, 500L },
                    { 46110L, true, 46L, 90, 501L },
                    { 46111L, true, 46L, 90, 511L },
                    { 46112L, true, 46L, 90, 523L },
                    { 46113L, true, 46L, 90, 527L },
                    { 46114L, false, 46L, 0, 510L },
                    { 46115L, false, 46L, 0, 521L },
                    { 46116L, false, 46L, 0, 519L },
                    { 46200L, true, 46L, 54, 725L },
                    { 46201L, false, 46L, 36, 704L },
                    { 46202L, true, 46L, 73, 734L },
                    { 46203L, false, 46L, 17, 722L },
                    { 46204L, true, 46L, 81, 705L },
                    { 46205L, false, 46L, 9, 715L },
                    { 46206L, true, 46L, 90, 726L },
                    { 46207L, true, 46L, 90, 706L },
                    { 46208L, true, 46L, 90, 716L },
                    { 46209L, true, 46L, 90, 710L },
                    { 46210L, true, 46L, 90, 732L },
                    { 46211L, true, 46L, 90, 736L },
                    { 46212L, true, 46L, 90, 730L },
                    { 46213L, true, 46L, 90, 702L },
                    { 46214L, false, 46L, 0, 723L },
                    { 46215L, false, 46L, 0, 735L },
                    { 46216L, false, 46L, 0, 739L },
                    { 46217L, false, 46L, 0, 717L },
                    { 47100L, true, 47L, 84, 1805L },
                    { 47101L, false, 47L, 6, 1815L },
                    { 47102L, true, 47L, 89, 1430L },
                    { 47103L, false, 47L, 1, 1806L },
                    { 47104L, true, 47L, 90, 1821L },
                    { 47105L, true, 47L, 90, 1803L },
                    { 47106L, true, 47L, 90, 1823L },
                    { 47107L, true, 47L, 90, 1824L },
                    { 47108L, true, 47L, 90, 1810L },
                    { 47109L, true, 47L, 90, 1808L },
                    { 47110L, true, 47L, 90, 1811L },
                    { 47111L, true, 47L, 90, 1813L },
                    { 47112L, true, 47L, 90, 1802L },
                    { 47113L, false, 47L, 0, 1807L },
                    { 47114L, false, 47L, 0, 1814L },
                    { 47115L, false, 47L, 0, 1812L },
                    { 47116L, false, 47L, 0, 1804L },
                    { 47117L, false, 47L, 0, 1817L },
                    { 47200L, true, 47L, 70, 426L },
                    { 47201L, false, 47L, 20, 424L },
                    { 47202L, true, 47L, 84, 427L },
                    { 47203L, false, 47L, 6, 410L },
                    { 47204L, true, 47L, 89, 433L },
                    { 47205L, false, 47L, 1, 419L },
                    { 47206L, true, 47L, 90, 432L },
                    { 47207L, true, 47L, 90, 418L },
                    { 47208L, true, 47L, 90, 437L },
                    { 47209L, true, 47L, 90, 438L },
                    { 47210L, true, 47L, 90, 429L },
                    { 47211L, true, 47L, 90, 417L },
                    { 47212L, true, 47L, 90, 400L },
                    { 47213L, true, 47L, 90, 403L },
                    { 47214L, false, 47L, 0, 428L },
                    { 47215L, false, 47L, 0, 435L },
                    { 47216L, false, 47L, 0, 404L },
                    { 47217L, false, 47L, 0, 439L },
                    { 48100L, true, 48L, 70, 2104L },
                    { 48101L, false, 48L, 20, 2121L },
                    { 48102L, true, 48L, 86, 2141L },
                    { 48103L, false, 48L, 4, 2133L },
                    { 48104L, true, 48L, 89, 2134L },
                    { 48105L, false, 48L, 1, 2103L },
                    { 48106L, true, 48L, 90, 2106L },
                    { 48107L, true, 48L, 90, 2113L },
                    { 48108L, true, 48L, 90, 2110L },
                    { 48109L, true, 48L, 90, 2109L },
                    { 48110L, true, 48L, 90, 2125L },
                    { 48111L, true, 48L, 90, 2100L },
                    { 48112L, true, 48L, 90, 2116L },
                    { 48113L, true, 48L, 90, 2140L },
                    { 48114L, false, 48L, 0, 2119L },
                    { 48115L, false, 48L, 0, 2129L },
                    { 48116L, false, 48L, 0, 2102L },
                    { 48117L, false, 48L, 0, 2128L },
                    { 48200L, true, 48L, 81, 231L },
                    { 48201L, false, 48L, 9, 208L },
                    { 48202L, true, 48L, 86, 234L },
                    { 48203L, false, 48L, 4, 213L },
                    { 48204L, true, 48L, 89, 200L },
                    { 48205L, false, 48L, 1, 203L },
                    { 48206L, true, 48L, 90, 223L },
                    { 48207L, true, 48L, 90, 204L },
                    { 48208L, true, 48L, 90, 216L },
                    { 48209L, true, 48L, 90, 219L },
                    { 48210L, true, 48L, 90, 202L },
                    { 48211L, true, 48L, 90, 205L },
                    { 48212L, true, 48L, 90, 221L },
                    { 48213L, true, 48L, 90, 212L },
                    { 48214L, false, 48L, 0, 206L },
                    { 48215L, false, 48L, 0, 226L },
                    { 48216L, false, 48L, 0, 220L },
                    { 48217L, false, 48L, 0, 232L },
                    { 49100L, true, 49L, 58, 1612L },
                    { 49101L, false, 49L, 32, 1624L },
                    { 49102L, true, 49L, 80, 1608L },
                    { 49103L, false, 49L, 10, 1601L },
                    { 49104L, true, 49L, 84, 1606L },
                    { 49105L, false, 49L, 6, 1617L },
                    { 49106L, true, 49L, 90, 1613L },
                    { 49107L, true, 49L, 90, 1622L },
                    { 49108L, true, 49L, 90, 1610L },
                    { 49109L, true, 49L, 90, 1604L },
                    { 49110L, true, 49L, 90, 1605L },
                    { 49111L, true, 49L, 90, 1600L },
                    { 49112L, true, 49L, 90, 1602L },
                    { 49113L, true, 49L, 90, 1609L },
                    { 49114L, false, 49L, 0, 1627L },
                    { 49115L, false, 49L, 0, 1616L },
                    { 49116L, false, 49L, 0, 1618L },
                    { 49117L, false, 49L, 0, 1625L },
                    { 49200L, true, 49L, 61, 101L },
                    { 49201L, false, 49L, 29, 123L },
                    { 49202L, true, 49L, 76, 119L },
                    { 49203L, false, 49L, 14, 102L },
                    { 49204L, true, 49L, 89, 129L },
                    { 49205L, false, 49L, 1, 115L },
                    { 49206L, true, 49L, 90, 113L },
                    { 49207L, true, 49L, 90, 106L },
                    { 49208L, true, 49L, 90, 111L },
                    { 49209L, true, 49L, 90, 135L },
                    { 49210L, true, 49L, 90, 121L },
                    { 49211L, true, 49L, 90, 124L },
                    { 49212L, true, 49L, 90, 127L },
                    { 49213L, true, 49L, 90, 131L },
                    { 49214L, false, 49L, 0, 116L },
                    { 49215L, false, 49L, 0, 105L },
                    { 49216L, false, 49L, 0, 107L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 401L, 4, 4, 9, 14, 3, 496, 51, 0, 2, 12, 5, 23, 401L, 3 },
                    { 402L, 2, 4, 12, 12, 2, 473, 49, 0, 4, 10, 4, 18, 402L, 2 },
                    { 411L, 5, 4, 10, 11, 1, 444, 48, 0, 5, 13, 3, 20, 411L, 2 },
                    { 412L, 2, 4, 11, 11, 0, 495, 52, 0, 3, 15, 6, 23, 412L, 1 },
                    { 421L, 2, 4, 13, 14, 1, 464, 58, 0, 5, 11, 1, 15, 421L, 3 },
                    { 422L, 2, 3, 14, 14, 0, 335, 42, 0, 0, 9, 6, 30, 422L, 3 },
                    { 431L, 7, 7, 11, 13, 0, 432, 51, 0, 4, 20, 6, 16, 431L, 1 },
                    { 432L, 7, 4, 12, 10, 1, 423, 49, 0, 6, 19, 6, 19, 432L, 1 },
                    { 441L, 12, 7, 10, 8, 2, 704, 73, 0, 1, 24, 6, 14, 441L, 2 },
                    { 442L, 1, 6, 7, 12, 1, 252, 28, 0, 4, 8, 1, 14, 442L, 2 },
                    { 451L, 3, 7, 12, 13, 2, 370, 41, 0, 3, 15, 53, 19, 451L, 3 },
                    { 452L, 2, 1, 14, 13, 4, 551, 59, 0, 3, 10, 53, 14, 452L, 3 },
                    { 461L, 7, 4, 5, 15, 2, 767, 78, 0, 1, 24, 8, 10, 461L, 0 },
                    { 462L, 0, 0, 13, 7, 1, 217, 22, 0, 6, 3, 2, 18, 462L, 0 },
                    { 471L, 1, 3, 12, 15, 3, 234, 28, 0, 8, 14, 3, 14, 471L, 3 },
                    { 472L, 2, 9, 14, 14, 1, 635, 72, 0, 1, 17, 11, 11, 472L, 4 },
                    { 481L, 1, 3, 9, 4, 2, 289, 35, 0, 1, 7, 3, 16, 481L, 2 },
                    { 482L, 2, 8, 8, 8, 2, 532, 65, 0, 1, 15, 2, 20, 482L, 1 },
                    { 491L, 1, 2, 7, 14, 1, 437, 46, 0, 7, 9, 2, 15, 491L, 2 },
                    { 492L, 6, 5, 13, 7, 1, 513, 54, 1, 2, 21, 9, 6, 492L, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "00908DB52D68F8407135DA994BDCB13F0B31FC129DE10542347CEE2E799972CEFBFACCDBA58844785ED571FDB1F1AC4C83124953A0E10F6CB7F2F30E19FEAB60", new byte[] { 141, 209, 1, 171, 253, 172, 133, 191, 80, 144, 236, 104, 222, 85, 146, 80, 102, 82, 210, 255, 36, 87, 67, 171, 81, 23, 139, 45, 100, 100, 247, 50, 221, 10, 99, 80, 93, 189, 118, 66, 144, 28, 14, 169, 12, 219, 96, 103, 146, 115, 218, 178, 134, 117, 122, 225, 203, 135, 4, 162, 43, 221, 5, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7953CA7E68C207E2830307AEC35AFB44A28A917AD657D5DB316C55F4F941D9BB2C641A756B488464E59AEF7E0BBD48A9C6027C076A396D505D70DDD4A4683E7B", new byte[] { 205, 144, 136, 83, 159, 58, 55, 200, 214, 135, 182, 213, 48, 43, 216, 167, 55, 34, 26, 91, 181, 122, 128, 89, 14, 108, 172, 144, 247, 84, 201, 180, 221, 174, 99, 58, 4, 148, 35, 0, 41, 26, 158, 87, 149, 208, 176, 231, 193, 232, 183, 74, 185, 114, 224, 203, 227, 66, 89, 154, 230, 5, 44, 170 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 4011L, 40113L, false, false, 63 },
                    { 4021L, 40212L, false, false, 45 },
                    { 4022L, 40213L, false, false, 10 },
                    { 4121L, 41201L, true, false, 90 },
                    { 4211L, 42112L, false, false, 36 },
                    { 4221L, 42212L, false, false, 34 },
                    { 4321L, 43212L, true, false, 90 },
                    { 4322L, 43204L, false, false, 47 },
                    { 4411L, 44103L, false, false, 72 },
                    { 4412L, 44113L, false, false, 85 },
                    { 4511L, 45113L, false, false, 67 },
                    { 4512L, 45113L, false, false, 84 },
                    { 4521L, 45213L, false, false, 62 },
                    { 4522L, 45204L, false, false, 43 },
                    { 4611L, 46104L, false, false, 52 },
                    { 4612L, 46112L, false, false, 8 },
                    { 4621L, 46206L, false, false, 30 },
                    { 4711L, 47102L, true, false, 45 },
                    { 4712L, 47100L, false, false, 70 },
                    { 4721L, 47208L, false, false, 12 },
                    { 4722L, 47204L, false, false, 62 },
                    { 4723L, 47213L, false, false, 81 },
                    { 4811L, 48108L, false, false, 76 },
                    { 4812L, 48111L, false, false, 53 },
                    { 4813L, 48113L, false, false, 69 },
                    { 4921L, 49213L, false, false, 27 },
                    { 4922L, 49213L, false, false, 44 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4322L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4522L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4612L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4712L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4722L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4723L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4922L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49216L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 40213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 41201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 42212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 43212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 44113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 45213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 46206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 47213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 48113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 49213L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "FCFAC75AF65F7F7C07FF1355D8314C24585BEBE4AC32F096CECC5A5A13AA3C06C78CB9D477B68714901548607441B855CD5704BEC81CA83B273AAF7E642532CC", new byte[] { 68, 182, 106, 172, 245, 238, 21, 8, 205, 125, 172, 69, 38, 33, 122, 75, 205, 78, 194, 101, 57, 191, 72, 182, 84, 92, 11, 201, 200, 106, 102, 226, 125, 1, 180, 96, 152, 49, 49, 52, 133, 225, 183, 77, 211, 7, 147, 216, 180, 51, 90, 189, 133, 13, 163, 75, 204, 221, 233, 100, 165, 86, 110, 165 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "943F07A14F70B3743D79D461296071E09AE1BA70865537DFCFA84E614189F4C1CA8A433B0367F2B8090C7C1631A733B38BA90B3CC79ADCADF6A1EBB26D9ABC28", new byte[] { 87, 173, 184, 33, 29, 139, 195, 248, 191, 18, 8, 27, 157, 14, 192, 133, 149, 78, 209, 180, 44, 115, 226, 128, 249, 247, 176, 99, 76, 252, 101, 229, 73, 186, 214, 190, 184, 19, 47, 242, 74, 159, 137, 111, 95, 246, 37, 112, 58, 217, 28, 235, 35, 64, 28, 203, 4, 176, 100, 25, 15, 12, 106, 192 } });
        }
    }
}
