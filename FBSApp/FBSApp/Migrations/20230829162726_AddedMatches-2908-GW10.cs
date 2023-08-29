using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 100100L, true, 100L, 65, 2117L },
                    { 100101L, false, 100L, 25, 2128L },
                    { 100102L, true, 100L, 83, 2121L },
                    { 100103L, false, 100L, 7, 2104L },
                    { 100104L, true, 100L, 85, 2110L },
                    { 100105L, false, 100L, 5, 2109L },
                    { 100106L, true, 100L, 90, 2106L },
                    { 100107L, true, 100L, 90, 2129L },
                    { 100108L, true, 100L, 90, 2103L },
                    { 100109L, true, 100L, 90, 2102L },
                    { 100110L, true, 100L, 90, 2100L },
                    { 100111L, true, 100L, 90, 2116L },
                    { 100112L, true, 100L, 90, 2141L },
                    { 100113L, true, 100L, 90, 2134L },
                    { 100114L, false, 100L, 0, 2119L },
                    { 100115L, false, 100L, 0, 2125L },
                    { 100116L, false, 100L, 0, 2137L },
                    { 100117L, false, 100L, 0, 2107L },
                    { 100200L, true, 100L, 63, 2219L },
                    { 100201L, false, 100L, 27, 2224L },
                    { 100202L, true, 100L, 63, 2212L },
                    { 100203L, false, 100L, 27, 2223L },
                    { 100204L, true, 100L, 78, 1729L },
                    { 100205L, false, 100L, 12, 2217L },
                    { 100206L, true, 100L, 90, 2215L },
                    { 100207L, true, 100L, 90, 2210L },
                    { 100208L, true, 100L, 90, 2220L },
                    { 100209L, true, 100L, 90, 2206L },
                    { 100210L, true, 100L, 90, 2205L },
                    { 100211L, true, 100L, 90, 2216L },
                    { 100212L, true, 100L, 90, 1201L },
                    { 100213L, true, 100L, 90, 2203L },
                    { 100214L, false, 100L, 0, 2214L },
                    { 100215L, false, 100L, 0, 2211L },
                    { 100216L, false, 100L, 0, 2204L },
                    { 100217L, false, 100L, 0, 2207L },
                    { 101100L, true, 101L, 63, 1903L },
                    { 101101L, false, 101L, 27, 1916L },
                    { 101102L, true, 101L, 78, 1920L },
                    { 101103L, false, 101L, 12, 1928L },
                    { 101104L, true, 101L, 78, 1924L },
                    { 101105L, false, 101L, 12, 1910L },
                    { 101106L, true, 101L, 90, 1900L },
                    { 101107L, true, 101L, 90, 408L },
                    { 101108L, true, 101L, 90, 1907L },
                    { 101109L, true, 101L, 90, 1933L },
                    { 101110L, true, 101L, 90, 1926L },
                    { 101111L, true, 101L, 90, 1922L },
                    { 101112L, true, 101L, 90, 1917L },
                    { 101113L, true, 101L, 90, 1905L },
                    { 101114L, false, 101L, 0, 1931L },
                    { 101115L, false, 101L, 0, 1901L },
                    { 101116L, false, 101L, 0, 1912L },
                    { 101117L, false, 101L, 0, 1918L },
                    { 101200L, true, 101L, 69, 702L },
                    { 101201L, false, 101L, 21, 734L },
                    { 101202L, true, 101L, 76, 730L },
                    { 101203L, false, 101L, 14, 736L },
                    { 101204L, true, 101L, 80, 739L },
                    { 101205L, false, 101L, 10, 704L },
                    { 101206L, true, 101L, 90, 726L },
                    { 101207L, true, 101L, 90, 706L },
                    { 101208L, true, 101L, 90, 716L },
                    { 101209L, true, 101L, 90, 710L },
                    { 101210L, true, 101L, 90, 732L },
                    { 101211L, true, 101L, 90, 727L },
                    { 101212L, true, 101L, 90, 721L },
                    { 101213L, true, 101L, 90, 725L },
                    { 101214L, false, 101L, 0, 723L },
                    { 101215L, false, 101L, 0, 722L },
                    { 101216L, false, 101L, 0, 718L },
                    { 101217L, false, 101L, 0, 709L },
                    { 102100L, true, 102L, 61, 600L },
                    { 102101L, false, 102L, 29, 634L },
                    { 102102L, true, 102L, 71, 627L },
                    { 102103L, false, 102L, 19, 615L },
                    { 102104L, true, 102L, 90, 604L },
                    { 102105L, true, 102L, 90, 632L },
                    { 102106L, true, 102L, 90, 610L },
                    { 102107L, true, 102L, 90, 633L },
                    { 102108L, true, 102L, 90, 602L },
                    { 102109L, true, 102L, 90, 613L },
                    { 102110L, true, 102L, 90, 612L },
                    { 102111L, true, 102L, 90, 628L },
                    { 102112L, true, 102L, 90, 620L },
                    { 102113L, false, 102L, 0, 616L },
                    { 102114L, false, 102L, 0, 617L },
                    { 102115L, false, 102L, 0, 630L },
                    { 102116L, false, 102L, 0, 605L },
                    { 102117L, false, 102L, 0, 609L },
                    { 102200L, true, 102L, 73, 1801L },
                    { 102201L, false, 102L, 17, 1818L },
                    { 102202L, true, 102L, 74, 1812L },
                    { 102203L, false, 102L, 16, 1814L },
                    { 102204L, true, 102L, 83, 1802L },
                    { 102205L, false, 102L, 7, 1815L },
                    { 102206L, true, 102L, 90, 1821L },
                    { 102207L, true, 102L, 90, 1803L },
                    { 102208L, true, 102L, 90, 1823L },
                    { 102209L, true, 102L, 90, 1824L },
                    { 102210L, true, 102L, 90, 1810L },
                    { 102211L, true, 102L, 90, 1813L },
                    { 102212L, true, 102L, 90, 1430L },
                    { 102213L, true, 102L, 90, 1804L },
                    { 102214L, false, 102L, 0, 1819L },
                    { 102215L, false, 102L, 0, 1807L },
                    { 102216L, false, 102L, 0, 1806L },
                    { 102217L, false, 102L, 0, 1800L },
                    { 103100L, true, 103L, 60, 1515L },
                    { 103101L, false, 103L, 30, 1520L },
                    { 103102L, true, 103L, 80, 1507L },
                    { 103103L, false, 103L, 10, 1504L },
                    { 103104L, true, 103L, 90, 1517L },
                    { 103105L, true, 103L, 90, 134L },
                    { 103106L, true, 103L, 90, 1502L },
                    { 103107L, true, 103L, 90, 1519L },
                    { 103108L, true, 103L, 90, 1509L },
                    { 103109L, true, 103L, 90, 1523L },
                    { 103110L, true, 103L, 90, 1522L },
                    { 103111L, true, 103L, 90, 227L },
                    { 103112L, true, 103L, 90, 1525L },
                    { 103113L, false, 103L, 0, 1513L },
                    { 103114L, false, 103L, 0, 1501L },
                    { 103115L, false, 103L, 0, 1521L },
                    { 103116L, false, 103L, 0, 1500L },
                    { 103117L, false, 103L, 0, 1524L },
                    { 103200L, true, 103L, 80, 1724L },
                    { 103201L, false, 103L, 10, 1710L },
                    { 103202L, true, 103L, 86, 1711L },
                    { 103203L, false, 103L, 4, 1723L },
                    { 103204L, true, 103L, 89, 1730L },
                    { 103205L, false, 103L, 1, 1720L },
                    { 103206L, true, 103L, 90, 1706L },
                    { 103207L, true, 103L, 90, 1732L },
                    { 103208L, true, 103L, 90, 1733L },
                    { 103209L, true, 103L, 90, 1728L },
                    { 103210L, true, 103L, 90, 1701L },
                    { 103211L, true, 103L, 90, 1719L },
                    { 103212L, true, 103L, 90, 1708L },
                    { 103213L, true, 103L, 90, 1707L },
                    { 103214L, false, 103L, 0, 1705L },
                    { 103215L, false, 103L, 0, 1721L },
                    { 103216L, false, 103L, 0, 1712L },
                    { 103217L, false, 103L, 0, 1703L },
                    { 104100L, true, 104L, 71, 1237L },
                    { 104101L, false, 104L, 19, 1245L },
                    { 104102L, true, 104L, 81, 1223L },
                    { 104103L, false, 104L, 9, 1206L },
                    { 104104L, true, 104L, 90, 1230L },
                    { 104105L, true, 104L, 90, 1211L },
                    { 104106L, true, 104L, 90, 1236L },
                    { 104107L, true, 104L, 90, 1227L },
                    { 104108L, true, 104L, 90, 1218L },
                    { 104109L, true, 104L, 90, 1205L },
                    { 104110L, true, 104L, 90, 1212L },
                    { 104111L, true, 104L, 90, 1209L },
                    { 104112L, true, 104L, 90, 1219L },
                    { 104113L, false, 104L, 0, 1217L },
                    { 104114L, false, 104L, 0, 1226L },
                    { 104115L, false, 104L, 0, 1210L },
                    { 104116L, false, 104L, 0, 1224L },
                    { 104117L, false, 104L, 0, 1222L },
                    { 104200L, true, 104L, 61, 1300L },
                    { 104201L, false, 104L, 29, 1306L },
                    { 104202L, true, 104L, 61, 1318L },
                    { 104203L, false, 104L, 29, 1304L },
                    { 104204L, true, 104L, 85, 1310L },
                    { 104205L, false, 104L, 5, 1312L },
                    { 104206L, true, 104L, 90, 1322L },
                    { 104207L, true, 104L, 90, 1323L },
                    { 104208L, true, 104L, 90, 1302L },
                    { 104209L, true, 104L, 90, 1325L },
                    { 104210L, true, 104L, 90, 1313L },
                    { 104211L, true, 104L, 90, 1320L },
                    { 104212L, true, 104L, 90, 1308L },
                    { 104213L, true, 104L, 90, 1305L },
                    { 104214L, false, 104L, 0, 1311L },
                    { 104215L, false, 104L, 0, 1315L },
                    { 104216L, false, 104L, 0, 1309L },
                    { 104217L, false, 104L, 0, 1321L },
                    { 105100L, true, 105L, 46, 2025L },
                    { 105101L, false, 105L, 44, 2016L },
                    { 105102L, true, 105L, 61, 2019L },
                    { 105103L, false, 105L, 29, 2007L },
                    { 105104L, true, 105L, 80, 2003L },
                    { 105105L, false, 105L, 10, 2027L },
                    { 105106L, true, 105L, 90, 2018L },
                    { 105107L, true, 105L, 90, 2005L },
                    { 105108L, true, 105L, 90, 117L },
                    { 105109L, true, 105L, 90, 2002L },
                    { 105110L, true, 105L, 90, 2030L },
                    { 105111L, true, 105L, 90, 2028L },
                    { 105112L, true, 105L, 90, 2015L },
                    { 105113L, true, 105L, 90, 2022L },
                    { 105114L, false, 105L, 0, 2017L },
                    { 105115L, false, 105L, 0, 2024L },
                    { 105116L, false, 105L, 0, 2026L },
                    { 105200L, true, 105L, 61, 318L },
                    { 105201L, false, 105L, 29, 326L },
                    { 105202L, true, 105L, 75, 314L },
                    { 105203L, false, 105L, 15, 300L },
                    { 105204L, true, 105L, 81, 313L },
                    { 105205L, false, 105L, 9, 304L },
                    { 105206L, true, 105L, 90, 322L },
                    { 105207L, true, 105L, 90, 329L },
                    { 105208L, true, 105L, 90, 312L },
                    { 105209L, true, 105L, 90, 315L },
                    { 105210L, true, 105L, 90, 305L },
                    { 105211L, true, 105L, 90, 311L },
                    { 105212L, true, 105L, 90, 324L },
                    { 105213L, true, 105L, 90, 331L },
                    { 105214L, false, 105L, 0, 601L },
                    { 105215L, false, 105L, 0, 308L },
                    { 105216L, false, 105L, 0, 333L },
                    { 105217L, false, 105L, 0, 320L },
                    { 106100L, true, 106L, 61, 1408L },
                    { 106101L, false, 106L, 29, 1420L },
                    { 106102L, true, 106L, 64, 1414L },
                    { 106103L, false, 106L, 26, 1400L },
                    { 106104L, true, 106L, 88, 1404L },
                    { 106105L, false, 106L, 2, 1410L },
                    { 106106L, true, 106L, 90, 1431L },
                    { 106107L, true, 106L, 90, 100L },
                    { 106108L, true, 106L, 90, 1409L },
                    { 106109L, true, 106L, 90, 1418L },
                    { 106110L, true, 106L, 90, 1422L },
                    { 106111L, true, 106L, 90, 1416L },
                    { 106112L, true, 106L, 90, 1401L },
                    { 106113L, true, 106L, 90, 1432L },
                    { 106114L, false, 106L, 0, 1429L },
                    { 106115L, false, 106L, 0, 1419L },
                    { 106116L, false, 106L, 0, 1407L },
                    { 106117L, false, 106L, 0, 1411L },
                    { 106200L, true, 106L, 46, 418L },
                    { 106201L, false, 106L, 44, 439L },
                    { 106202L, true, 106L, 68, 427L },
                    { 106203L, false, 106L, 22, 410L },
                    { 106204L, true, 106L, 78, 433L },
                    { 106205L, false, 106L, 12, 400L },
                    { 106206L, true, 106L, 90, 404L },
                    { 106207L, true, 106L, 90, 437L },
                    { 106208L, true, 106L, 90, 435L },
                    { 106209L, true, 106L, 90, 417L },
                    { 106210L, true, 106L, 90, 424L },
                    { 106211L, true, 106L, 90, 426L },
                    { 106212L, true, 106L, 90, 402L },
                    { 106213L, true, 106L, 90, 403L },
                    { 106214L, false, 106L, 0, 432L },
                    { 106215L, false, 106L, 0, 419L },
                    { 106216L, false, 106L, 0, 414L },
                    { 106217L, false, 106L, 0, 438L },
                    { 107100L, true, 107L, 59, 1624L },
                    { 107101L, false, 107L, 31, 1606L },
                    { 107102L, true, 107L, 65, 1612L },
                    { 107103L, false, 107L, 25, 1601L },
                    { 107104L, true, 107L, 73, 1609L },
                    { 107105L, false, 107L, 17, 1602L },
                    { 107106L, true, 107L, 90, 1613L },
                    { 107107L, true, 107L, 90, 1618L },
                    { 107108L, true, 107L, 90, 1610L },
                    { 107109L, true, 107L, 90, 1604L },
                    { 107110L, true, 107L, 90, 1605L },
                    { 107111L, true, 107L, 90, 1614L },
                    { 107112L, true, 107L, 90, 1626L },
                    { 107113L, true, 107L, 90, 1623L },
                    { 107114L, false, 107L, 0, 1622L },
                    { 107115L, false, 107L, 0, 1627L },
                    { 107116L, false, 107L, 0, 1616L },
                    { 107117L, false, 107L, 0, 1617L },
                    { 107200L, true, 107L, 30, 934L },
                    { 107201L, false, 107L, 60, 938L },
                    { 107202L, true, 107L, 74, 944L },
                    { 107203L, false, 107L, 16, 933L },
                    { 107204L, true, 107L, 78, 922L },
                    { 107205L, false, 107L, 12, 943L },
                    { 107206L, true, 107L, 90, 923L },
                    { 107207L, true, 107L, 90, 905L },
                    { 107208L, true, 107L, 90, 901L },
                    { 107209L, true, 107L, 90, 909L },
                    { 107210L, true, 107L, 90, 928L },
                    { 107211L, true, 107L, 90, 932L },
                    { 107212L, true, 107L, 90, 937L },
                    { 107213L, true, 107L, 90, 941L },
                    { 107214L, false, 107L, 0, 942L },
                    { 107215L, false, 107L, 0, 916L },
                    { 107216L, false, 107L, 0, 930L },
                    { 107217L, false, 107L, 0, 910L },
                    { 108100L, true, 108L, 65, 123L },
                    { 108101L, false, 108L, 25, 131L },
                    { 108102L, true, 108L, 85, 120L },
                    { 108103L, false, 108L, 5, 102L },
                    { 108104L, true, 108L, 89, 116L },
                    { 108105L, false, 108L, 1, 119L },
                    { 108106L, true, 108L, 90, 113L },
                    { 108107L, true, 108L, 90, 107L },
                    { 108108L, true, 108L, 90, 111L },
                    { 108109L, true, 108L, 90, 135L },
                    { 108110L, true, 108L, 90, 121L },
                    { 108111L, true, 108L, 90, 127L },
                    { 108112L, true, 108L, 90, 129L },
                    { 108113L, true, 108L, 90, 105L },
                    { 108114L, false, 108L, 0, 126L },
                    { 108115L, false, 108L, 0, 122L },
                    { 108116L, false, 108L, 0, 101L },
                    { 108200L, true, 108L, 62, 1003L },
                    { 108201L, false, 108L, 28, 1000L },
                    { 108202L, true, 108L, 78, 1008L },
                    { 108203L, false, 108L, 12, 1006L },
                    { 108204L, true, 108L, 78, 1027L },
                    { 108205L, false, 108L, 12, 1004L },
                    { 108206L, true, 108L, 90, 1013L },
                    { 108207L, true, 108L, 90, 1026L },
                    { 108208L, true, 108L, 90, 1019L },
                    { 108209L, true, 108L, 90, 924L },
                    { 108210L, true, 108L, 90, 1016L },
                    { 108211L, true, 108L, 90, 1001L },
                    { 108212L, true, 108L, 90, 1007L },
                    { 108213L, true, 108L, 90, 1024L },
                    { 108214L, false, 108L, 0, 1015L },
                    { 108215L, false, 108L, 0, 1028L },
                    { 108216L, false, 108L, 0, 1029L },
                    { 108217L, false, 108L, 0, 1017L },
                    { 109100L, true, 109L, 67, 206L },
                    { 109101L, false, 109L, 23, 213L },
                    { 109102L, true, 109L, 75, 234L },
                    { 109103L, false, 109L, 15, 205L },
                    { 109104L, true, 109L, 81, 221L },
                    { 109105L, false, 109L, 9, 202L },
                    { 109106L, true, 109L, 90, 215L },
                    { 109107L, true, 109L, 90, 219L },
                    { 109108L, true, 109L, 90, 204L },
                    { 109109L, true, 109L, 90, 231L },
                    { 109110L, true, 109L, 90, 200L },
                    { 109111L, true, 109L, 90, 224L },
                    { 109112L, true, 109L, 90, 207L },
                    { 109113L, true, 109L, 90, 212L },
                    { 109114L, false, 109L, 0, 228L },
                    { 109115L, false, 109L, 0, 226L },
                    { 109116L, false, 109L, 0, 214L },
                    { 109117L, false, 109L, 0, 220L },
                    { 109200L, true, 109L, 71, 527L },
                    { 109201L, false, 109L, 19, 516L },
                    { 109202L, true, 109L, 89, 506L },
                    { 109203L, false, 109L, 1, 529L },
                    { 109204L, true, 109L, 89, 524L },
                    { 109205L, false, 109L, 1, 512L },
                    { 109206L, true, 109L, 90, 507L },
                    { 109207L, true, 109L, 90, 517L },
                    { 109208L, true, 109L, 90, 515L },
                    { 109209L, true, 109L, 90, 500L },
                    { 109210L, true, 109L, 90, 501L },
                    { 109211L, true, 109L, 90, 502L },
                    { 109212L, true, 109L, 90, 511L },
                    { 109213L, true, 109L, 90, 523L },
                    { 109214L, false, 109L, 0, 521L },
                    { 109215L, false, 109L, 0, 519L },
                    { 109216L, false, 109L, 0, 518L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 1001L, 0, 3, 9, 16, 3, 467, 48, 0, 7, 12, 6, 19, 1001L, 1 },
                    { 1002L, 2, 3, 13, 12, 3, 498, 52, 0, 3, 13, 7, 25, 1002L, 2 },
                    { 1011L, 5, 7, 193, 15, 1, 405, 50, 0, 0, 22, 4, 13, 1011L, 0 },
                    { 1012L, 2, 2, 12, 10, 3, 414, 50, 0, 4, 6, 0, 16, 1012L, 1 },
                    { 1021L, 6, 8, 6, 8, 0, 818, 80, 0, 0, 19, 7, 13, 1021L, 0 },
                    { 1022L, 0, 0, 4, 6, 4, 207, 20, 0, 3, 2, 1, 15, 1022L, 0 },
                    { 1031L, 1, 51, 16, 4, 1, 547, 52, 1, 2, 11, 1, 11, 1031L, 4 },
                    { 1032L, 1, 51, 3, 16, 1, 495, 48, 0, 1, 12, 5, 7, 1032L, 1 },
                    { 1041L, 7, 1, 11, 9, 0, 362, 40, 0, 7, 7, 1, 20, 1041L, 3 },
                    { 1042L, 10, 10, 8, 11, 1, 523, 60, 0, 0, 25, 7, 12, 1042L, 0 },
                    { 1051L, 3, 8, 17, 6, 7, 552, 64, 0, 2, 21, 7, 16, 1051L, 1 },
                    { 1052L, 2, 0, 153, 24, 1, 327, 36, 1, 6, 11, 3, 22, 1052L, 1 },
                    { 1061L, 2, 6, 10, 14, 2, 399, 42, 0, 0, 16, 3, 22, 1061L, 1 },
                    { 1062L, 2, 4, 16, 12, 0, 555, 58, 0, 1, 7, 2, 25, 1062L, 2 },
                    { 1071L, 2, 4, 14, 10, 5, 325, 30, 0, 4, 7, 1, 10, 1071L, 4 },
                    { 1072L, 7, 4, 10, 19, 0, 796, 70, 0, 1, 24, 8, 9, 1072L, 2 },
                    { 1081L, 1, 8, 15, 11, 7, 486, 54, 0, 5, 14, 10, 15, 1081L, 2 },
                    { 1082L, 1, 4, 12, 22, 0, 413, 46, 0, 8, 14, 6, 15, 1082L, 1 },
                    { 1091L, 0, 3, 13, 17, 4, 476, 48, 0, 5, 4, 1, 18, 1091L, 2 },
                    { 1092L, 5, 6, 13, 16, 4, 514, 52, 0, 1, 13, 6, 13, 1092L, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DE19A03D98743428FE7416BB415B6CF85B45CD27FAEB7EFE333E24E93563BF2BD8807DA50C3296CFB42B9DEC3AD487C4578628CBAEB275D548FF8CC919F243E5", new byte[] { 38, 201, 221, 56, 47, 220, 50, 226, 104, 33, 185, 215, 98, 217, 157, 39, 18, 201, 137, 99, 173, 101, 14, 28, 43, 157, 0, 127, 102, 84, 187, 97, 105, 157, 199, 133, 0, 112, 19, 67, 247, 36, 240, 129, 133, 168, 157, 158, 214, 63, 44, 54, 27, 211, 242, 113, 219, 2, 43, 147, 194, 132, 246, 107 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "65EE6D26021D8C0957F9D19A67393145538D2DBCA548D233D242B539591A33E7271951938552FD261EFF65ECAA016F3C4248D4C7438B669CFD05CB1758994ADA", new byte[] { 142, 100, 37, 14, 120, 203, 69, 30, 183, 121, 184, 203, 157, 83, 128, 21, 200, 147, 191, 244, 11, 103, 119, 17, 22, 146, 9, 64, 212, 194, 215, 134, 116, 142, 86, 193, 149, 209, 147, 162, 245, 134, 88, 133, 210, 46, 39, 174, 122, 50, 18, 22, 83, 44, 16, 209, 16, 176, 92, 41, 151, 133, 67, 13 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 10011L, 100100L, false, false, 19 },
                    { 10012L, 100113L, false, false, 10 },
                    { 10013L, 100102L, false, false, 80 },
                    { 10211L, 102101L, false, false, 84 },
                    { 10212L, 102111L, false, false, 66 },
                    { 10213L, 102111L, false, false, 87 },
                    { 10214L, 102112L, false, false, 10 },
                    { 10221L, 102213L, false, false, 77 },
                    { 10321L, 103202L, false, false, 72 },
                    { 10322L, 103213L, false, false, 14 },
                    { 10323L, 103213L, false, false, 85 },
                    { 10411L, 104112L, false, false, 48 },
                    { 10511L, 105110L, false, false, 89 },
                    { 10521L, 105208L, false, false, 30 },
                    { 10611L, 106111L, true, false, 45 },
                    { 10612L, 106111L, false, false, 83 },
                    { 10621L, 106209L, false, false, 51 },
                    { 10622L, 106204L, false, false, 56 },
                    { 10721L, 107201L, true, false, 90 },
                    { 10722L, 107212L, false, false, 57 },
                    { 10723L, 107202L, false, false, 22 },
                    { 10724L, 107213L, false, false, 62 },
                    { 10811L, 108112L, false, false, 27 },
                    { 10812L, 108113L, false, false, 49 },
                    { 10813L, 108212L, false, false, 77 },
                    { 10921L, 109204L, false, false, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10012L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10013L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10212L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10213L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10214L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10322L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10323L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10612L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10622L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10722L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10723L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10724L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10921L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 101217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109216L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1001L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1002L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1011L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1012L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1021L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1022L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1031L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1032L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1041L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1042L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1051L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1052L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1061L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1062L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1071L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1072L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1081L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1082L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1091L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 1092L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 100113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 102213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 103213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 104112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 105208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 106209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 107213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 108212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 109204L);

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
        }
    }
}
