using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 50100L, true, 50L, 60, 234L },
                    { 50101L, false, 50L, 30, 207L },
                    { 50102L, true, 50L, 73, 213L },
                    { 50103L, false, 50L, 17, 214L },
                    { 50104L, true, 50L, 83, 206L },
                    { 50105L, false, 50L, 7, 232L },
                    { 50106L, true, 50L, 90, 223L },
                    { 50107L, true, 50L, 90, 219L },
                    { 50108L, true, 50L, 90, 231L },
                    { 50109L, true, 50L, 90, 216L },
                    { 50110L, true, 50L, 90, 203L },
                    { 50111L, true, 50L, 90, 202L },
                    { 50112L, true, 50L, 90, 221L },
                    { 50113L, true, 50L, 90, 212L },
                    { 50114L, false, 50L, 0, 228L },
                    { 50115L, false, 50L, 0, 200L },
                    { 50116L, false, 50L, 0, 226L },
                    { 50117L, false, 50L, 0, 204L },
                    { 50200L, true, 50L, 74, 627L },
                    { 50201L, false, 50L, 16, 618L },
                    { 50202L, true, 50L, 83, 621L },
                    { 50203L, false, 50L, 7, 609L },
                    { 50204L, true, 50L, 89, 632L },
                    { 50205L, false, 50L, 1, 617L },
                    { 50206L, true, 50L, 90, 604L },
                    { 50207L, true, 50L, 90, 616L },
                    { 50208L, true, 50L, 90, 633L },
                    { 50209L, true, 50L, 90, 605L },
                    { 50210L, true, 50L, 90, 615L },
                    { 50211L, true, 50L, 90, 613L },
                    { 50212L, true, 50L, 90, 620L },
                    { 50213L, true, 50L, 90, 628L },
                    { 50214L, false, 50L, 0, 612L },
                    { 50215L, false, 50L, 0, 630L },
                    { 50216L, false, 50L, 0, 602L },
                    { 50217L, false, 50L, 0, 634L },
                    { 51100L, true, 51L, 46, 716L },
                    { 51101L, false, 51L, 44, 705L },
                    { 51102L, true, 51L, 69, 515L },
                    { 51103L, false, 51L, 21, 725L },
                    { 51104L, true, 51L, 79, 727L },
                    { 51105L, false, 51L, 11, 739L },
                    { 51106L, true, 51L, 90, 726L },
                    { 51107L, true, 51L, 90, 706L },
                    { 51108L, true, 51L, 90, 710L },
                    { 51109L, true, 51L, 90, 732L },
                    { 51110L, true, 51L, 90, 714L },
                    { 51111L, true, 51L, 90, 730L },
                    { 51112L, true, 51L, 90, 702L },
                    { 51113L, true, 51L, 90, 722L },
                    { 51114L, false, 51L, 0, 723L },
                    { 51115L, false, 51L, 0, 718L },
                    { 51116L, false, 51L, 0, 734L },
                    { 51117L, false, 51L, 0, 721L },
                    { 51200L, true, 51L, 46, 426L },
                    { 51201L, false, 51L, 44, 424L },
                    { 51202L, true, 51L, 69, 433L },
                    { 51203L, false, 51L, 21, 419L },
                    { 51204L, true, 51L, 80, 400L },
                    { 51205L, false, 51L, 10, 410L },
                    { 51206L, true, 51L, 90, 432L },
                    { 51207L, true, 51L, 90, 418L },
                    { 51208L, true, 51L, 90, 437L },
                    { 51209L, true, 51L, 90, 438L },
                    { 51210L, true, 51L, 90, 429L },
                    { 51211L, true, 51L, 90, 417L },
                    { 51212L, true, 51L, 90, 427L },
                    { 51213L, true, 51L, 90, 403L },
                    { 51214L, false, 51L, 0, 428L },
                    { 51215L, false, 51L, 0, 435L },
                    { 51216L, false, 51L, 0, 404L },
                    { 51217L, false, 51L, 0, 439L },
                    { 52100L, true, 52L, 54, 527L },
                    { 52101L, false, 52L, 36, 512L },
                    { 52102L, true, 52L, 67, 510L },
                    { 52103L, false, 52L, 23, 513L },
                    { 52104L, true, 52L, 74, 523L },
                    { 52105L, false, 52L, 16, 524L },
                    { 52106L, true, 52L, 90, 507L },
                    { 52107L, true, 52L, 90, 517L },
                    { 52108L, true, 52L, 90, 519L },
                    { 52109L, true, 52L, 90, 500L },
                    { 52110L, true, 52L, 90, 502L },
                    { 52111L, true, 52L, 90, 511L },
                    { 52112L, true, 52L, 90, 506L },
                    { 52113L, true, 52L, 90, 518L },
                    { 52114L, false, 52L, 0, 521L },
                    { 52115L, false, 52L, 0, 515L },
                    { 52116L, false, 52L, 0, 520L },
                    { 52200L, true, 52L, 56, 1507L },
                    { 52201L, false, 52L, 34, 1504L },
                    { 52202L, true, 52L, 69, 1524L },
                    { 52203L, false, 52L, 21, 1526L },
                    { 52204L, true, 52L, 90, 1513L },
                    { 52205L, true, 52L, 90, 1501L },
                    { 52206L, true, 52L, 90, 1502L },
                    { 52207L, true, 52L, 90, 1500L },
                    { 52208L, true, 52L, 90, 227L },
                    { 52209L, true, 52L, 90, 1509L },
                    { 52210L, true, 52L, 90, 1521L },
                    { 52211L, true, 52L, 90, 1525L },
                    { 52212L, true, 52L, 90, 1522L },
                    { 52213L, false, 52L, 0, 1508L },
                    { 52214L, false, 52L, 0, 406L },
                    { 52215L, false, 52L, 0, 1503L },
                    { 52216L, false, 52L, 0, 134L },
                    { 52217L, false, 52L, 0, 1515L },
                    { 53100L, true, 53L, 68, 2227L },
                    { 53101L, false, 53L, 22, 2202L },
                    { 53102L, true, 53L, 78, 2220L },
                    { 53103L, false, 53L, 12, 2219L },
                    { 53104L, true, 53L, 78, 2222L },
                    { 53105L, false, 53L, 12, 2212L },
                    { 53106L, true, 53L, 90, 2215L },
                    { 53107L, true, 53L, 90, 2206L },
                    { 53108L, true, 53L, 90, 2225L },
                    { 53109L, true, 53L, 90, 2211L },
                    { 53110L, true, 53L, 90, 1201L },
                    { 53111L, true, 53L, 90, 1729L },
                    { 53112L, true, 53L, 90, 2205L },
                    { 53113L, true, 53L, 90, 2224L },
                    { 53114L, false, 53L, 0, 2204L },
                    { 53115L, false, 53L, 0, 2203L },
                    { 53116L, false, 53L, 0, 2226L },
                    { 53117L, false, 53L, 0, 2208L },
                    { 53200L, true, 53L, 89, 1401L },
                    { 53201L, false, 53L, 1, 1411L },
                    { 53202L, true, 53L, 90, 1431L },
                    { 53203L, true, 53L, 90, 100L },
                    { 53204L, true, 53L, 90, 1409L },
                    { 53205L, true, 53L, 90, 1418L },
                    { 53206L, true, 53L, 90, 1422L },
                    { 53207L, true, 53L, 90, 1404L },
                    { 53208L, true, 53L, 90, 1416L },
                    { 53209L, true, 53L, 90, 1408L },
                    { 53210L, true, 53L, 90, 1414L },
                    { 53211L, true, 53L, 90, 1432L },
                    { 53212L, false, 53L, 0, 1429L },
                    { 53213L, false, 53L, 0, 1419L },
                    { 53214L, false, 53L, 0, 1420L },
                    { 53215L, false, 53L, 0, 1407L },
                    { 53216L, false, 53L, 0, 1400L },
                    { 53217L, false, 53L, 0, 1412L },
                    { 54100L, true, 54L, 50, 930L },
                    { 54101L, false, 54L, 40, 937L },
                    { 54102L, true, 54L, 68, 934L },
                    { 54103L, false, 54L, 22, 941L },
                    { 54104L, true, 54L, 84, 912L },
                    { 54105L, false, 54L, 6, 910L },
                    { 54106L, true, 54L, 90, 923L },
                    { 54107L, true, 54L, 90, 905L },
                    { 54108L, true, 54L, 90, 901L },
                    { 54109L, true, 54L, 90, 909L },
                    { 54110L, true, 54L, 90, 928L },
                    { 54111L, true, 54L, 90, 932L },
                    { 54112L, true, 54L, 90, 922L },
                    { 54113L, true, 54L, 90, 933L },
                    { 54114L, false, 54L, 0, 942L },
                    { 54115L, false, 54L, 0, 900L },
                    { 54116L, false, 54L, 0, 908L },
                    { 54117L, false, 54L, 0, 944L },
                    { 54200L, true, 54L, 46, 1808L },
                    { 54201L, false, 54L, 44, 1809L },
                    { 54202L, true, 54L, 71, 1802L },
                    { 54203L, false, 54L, 19, 1804L },
                    { 54204L, true, 54L, 77, 1805L },
                    { 54205L, false, 54L, 13, 1806L },
                    { 54206L, true, 54L, 90, 1821L },
                    { 54207L, true, 54L, 90, 1803L },
                    { 54208L, true, 54L, 90, 1823L },
                    { 54209L, true, 54L, 90, 1824L },
                    { 54210L, true, 54L, 90, 1810L },
                    { 54211L, true, 54L, 90, 1430L },
                    { 54212L, true, 54L, 90, 1811L },
                    { 54213L, true, 54L, 90, 1813L },
                    { 54214L, false, 54L, 0, 1807L },
                    { 54215L, false, 54L, 0, 1812L },
                    { 54216L, false, 54L, 0, 1817L },
                    { 54217L, false, 54L, 0, 1815L },
                    { 55100L, true, 55L, 68, 1711L },
                    { 55101L, false, 55L, 22, 1732L },
                    { 55102L, true, 55L, 78, 1719L },
                    { 55103L, false, 55L, 12, 1724L },
                    { 55104L, true, 55L, 85, 1722L },
                    { 55105L, false, 55L, 5, 1118L },
                    { 55106L, true, 55L, 90, 1706L },
                    { 55107L, true, 55L, 90, 1701L },
                    { 55108L, true, 55L, 90, 1733L },
                    { 55109L, true, 55L, 90, 1728L },
                    { 55110L, true, 55L, 90, 1712L },
                    { 55111L, true, 55L, 90, 1710L },
                    { 55112L, true, 55L, 90, 1730L },
                    { 55113L, true, 55L, 90, 1707L },
                    { 55114L, false, 55L, 0, 1705L },
                    { 55115L, false, 55L, 0, 1720L },
                    { 55116L, false, 55L, 0, 1721L },
                    { 55117L, false, 55L, 0, 1703L },
                    { 55200L, true, 55L, 61, 2025L },
                    { 55201L, false, 55L, 29, 2022L },
                    { 55202L, true, 55L, 61, 2007L },
                    { 55203L, false, 55L, 29, 2019L },
                    { 55204L, true, 55L, 84, 2016L },
                    { 55205L, false, 55L, 6, 2017L },
                    { 55206L, true, 55L, 90, 2017L },
                    { 55207L, true, 55L, 90, 2026L },
                    { 55208L, true, 55L, 90, 2029L },
                    { 55209L, true, 55L, 90, 117L },
                    { 55210L, true, 55L, 90, 2002L },
                    { 55211L, true, 55L, 90, 2030L },
                    { 55212L, true, 55L, 90, 2024L },
                    { 55213L, true, 55L, 90, 2015L },
                    { 55214L, false, 55L, 0, 2005L },
                    { 55215L, false, 55L, 0, 2004L },
                    { 55216L, false, 55L, 0, 2028L },
                    { 55217L, false, 55L, 0, 2016L },
                    { 56100L, true, 56L, 72, 2113L },
                    { 56101L, false, 56L, 18, 2129L },
                    { 56102L, true, 56L, 84, 2125L },
                    { 56103L, false, 56L, 6, 2102L },
                    { 56104L, true, 56L, 88, 2110L },
                    { 56105L, false, 56L, 2, 2121L },
                    { 56106L, true, 56L, 90, 2106L },
                    { 56107L, true, 56L, 90, 2109L },
                    { 56108L, true, 56L, 90, 2100L },
                    { 56109L, true, 56L, 90, 2116L },
                    { 56110L, true, 56L, 90, 2141L },
                    { 56111L, true, 56L, 90, 2134L },
                    { 56112L, true, 56L, 90, 2140L },
                    { 56113L, true, 56L, 90, 2104L },
                    { 56114L, false, 56L, 0, 2133L },
                    { 56115L, false, 56L, 0, 2119L },
                    { 56116L, false, 56L, 0, 2103L },
                    { 56117L, false, 56L, 0, 2128L },
                    { 56200L, true, 56L, 71, 119L },
                    { 56201L, false, 56L, 19, 105L },
                    { 56202L, true, 56L, 84, 101L },
                    { 56203L, false, 56L, 6, 132L },
                    { 56204L, true, 56L, 89, 106L },
                    { 56205L, false, 56L, 1, 115L },
                    { 56206L, true, 56L, 90, 113L },
                    { 56207L, true, 56L, 90, 111L },
                    { 56208L, true, 56L, 90, 135L },
                    { 56209L, true, 56L, 90, 107L },
                    { 56210L, true, 56L, 90, 129L },
                    { 56211L, true, 56L, 90, 124L },
                    { 56212L, true, 56L, 90, 127L },
                    { 56213L, true, 56L, 90, 131L },
                    { 56214L, false, 56L, 0, 126L },
                    { 56215L, false, 56L, 0, 116L },
                    { 56216L, false, 56L, 0, 120L },
                    { 57100L, true, 57L, 66, 1305L },
                    { 57101L, false, 57L, 34, 1300L },
                    { 57102L, true, 57L, 76, 1318L },
                    { 57103L, false, 57L, 14, 1312L },
                    { 57104L, true, 57L, 88, 1304L },
                    { 57105L, false, 57L, 2, 1315L },
                    { 57106L, true, 57L, 90, 1322L },
                    { 57107L, true, 57L, 90, 1323L },
                    { 57108L, true, 57L, 90, 1302L },
                    { 57109L, true, 57L, 90, 1325L },
                    { 57110L, true, 57L, 90, 1313L },
                    { 57111L, true, 57L, 90, 1308L },
                    { 57112L, true, 57L, 90, 1320L },
                    { 57113L, true, 57L, 90, 1310L },
                    { 57114L, false, 57L, 0, 820L },
                    { 57115L, false, 57L, 0, 1309L },
                    { 57116L, false, 57L, 0, 1319L },
                    { 57117L, false, 57L, 0, 1321L },
                    { 57200L, true, 57L, 56, 1601L },
                    { 57201L, false, 57L, 34, 1617L },
                    { 57202L, true, 57L, 70, 1624L },
                    { 57203L, false, 57L, 20, 1606L },
                    { 57204L, true, 57L, 79, 1612L },
                    { 57205L, false, 57L, 11, 1602L },
                    { 57206L, true, 57L, 90, 1613L },
                    { 57207L, true, 57L, 90, 1622L },
                    { 57208L, true, 57L, 90, 1610L },
                    { 57209L, true, 57L, 90, 1604L },
                    { 57210L, true, 57L, 90, 1605L },
                    { 57211L, true, 57L, 90, 1600L },
                    { 57212L, true, 57L, 90, 1609L },
                    { 57213L, true, 57L, 90, 1614L },
                    { 57214L, false, 57L, 0, 1627L },
                    { 57215L, false, 57L, 0, 1616L },
                    { 57216L, false, 57L, 0, 1618L },
                    { 57217L, false, 57L, 0, 1625L },
                    { 58100L, true, 58L, 44, 1021L },
                    { 58101L, false, 58L, 46, 1003L },
                    { 58102L, true, 58L, 69, 1004L },
                    { 58103L, false, 58L, 21, 1022L },
                    { 58104L, true, 58L, 77, 1027L },
                    { 58105L, false, 58L, 13, 1000L },
                    { 58106L, true, 58L, 90, 1013L },
                    { 58107L, true, 58L, 90, 1012L },
                    { 58108L, true, 58L, 90, 1018L },
                    { 58109L, true, 58L, 90, 924L },
                    { 58110L, true, 58L, 90, 1016L },
                    { 58111L, true, 58L, 90, 1008L },
                    { 58112L, true, 58L, 90, 1007L },
                    { 58113L, true, 58L, 90, 1006L },
                    { 58114L, false, 58L, 0, 1015L },
                    { 58115L, false, 58L, 0, 1028L },
                    { 58116L, false, 58L, 0, 1014L },
                    { 58117L, false, 58L, 0, 1017L },
                    { 58200L, true, 58L, 64, 325L },
                    { 58201L, false, 58L, 26, 326L },
                    { 58202L, true, 58L, 71, 324L },
                    { 58203L, false, 58L, 19, 307L },
                    { 58204L, true, 58L, 82, 302L },
                    { 58205L, false, 58L, 8, 331L },
                    { 58206L, true, 58L, 90, 322L },
                    { 58207L, true, 58L, 90, 329L },
                    { 58208L, true, 58L, 90, 312L },
                    { 58209L, true, 58L, 90, 315L },
                    { 58210L, true, 58L, 90, 305L },
                    { 58211L, true, 58L, 90, 311L },
                    { 58212L, true, 58L, 90, 330L },
                    { 58213L, true, 58L, 90, 313L },
                    { 58214L, false, 58L, 0, 601L },
                    { 58215L, false, 58L, 0, 300L },
                    { 58216L, false, 58L, 0, 304L },
                    { 58217L, false, 58L, 0, 321L },
                    { 59100L, true, 59L, 76, 1928L },
                    { 59101L, false, 59L, 14, 1916L },
                    { 59102L, true, 59L, 76, 1920L },
                    { 59103L, false, 59L, 14, 1910L },
                    { 59104L, true, 59L, 84, 1905L },
                    { 59105L, false, 59L, 6, 1930L },
                    { 59106L, true, 59L, 90, 1900L },
                    { 59107L, true, 59L, 90, 408L },
                    { 59108L, true, 59L, 90, 1912L },
                    { 59109L, true, 59L, 90, 1933L },
                    { 59110L, true, 59L, 90, 1926L },
                    { 59111L, true, 59L, 90, 1925L },
                    { 59112L, true, 59L, 90, 1917L },
                    { 59113L, true, 59L, 90, 1922L },
                    { 59114L, false, 59L, 0, 1903L },
                    { 59115L, false, 59L, 0, 1901L },
                    { 59116L, false, 59L, 0, 824L },
                    { 59117L, false, 59L, 0, 1918L },
                    { 59200L, true, 59L, 71, 1237L },
                    { 59201L, false, 59L, 19, 1205L },
                    { 59202L, true, 59L, 76, 1245L },
                    { 59203L, false, 59L, 24, 1224L },
                    { 59204L, true, 59L, 90, 1230L },
                    { 59205L, true, 59L, 90, 1229L },
                    { 59206L, true, 59L, 90, 1236L },
                    { 59207L, true, 59L, 90, 1227L },
                    { 59208L, true, 59L, 90, 1218L },
                    { 59209L, true, 59L, 90, 1206L },
                    { 59210L, true, 59L, 90, 1212L },
                    { 59211L, true, 59L, 90, 1215L },
                    { 59212L, true, 59L, 90, 1219L },
                    { 59213L, false, 59L, 0, 1226L },
                    { 59214L, false, 59L, 0, 1210L },
                    { 59215L, false, 59L, 0, 1214L },
                    { 59216L, false, 59L, 0, 1209L },
                    { 59217L, false, 59L, 0, 1211L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 501L, 3, 5, 17, 18, 3, 549, 60, 0, 8, 11, 3, 9, 501L, 0 },
                    { 502L, 2, 4, 16, 20, 2, 356, 40, 0, 2, 17, 10, 17, 502L, 0 },
                    { 511L, 2, 10, 13, 12, 3, 327, 36, 0, 0, 4, 2, 17, 511L, 0 },
                    { 512L, 5, 4, 11, 16, 1, 598, 64, 0, 1, 12, 2, 14, 512L, 0 },
                    { 521L, 11, 10, 7, 8, 5, 736, 65, 0, 3, 28, 9, 16, 521L, 0 },
                    { 522L, 1, 4, 7, 12, 2, 400, 35, 0, 6, 9, 3, 13, 522L, 0 },
                    { 531L, 4, 5, 11, 19, 5, 494, 58, 0, 1, 15, 2, 17, 531L, 1 },
                    { 532L, 3, 3, 17, 16, 2, 363, 42, 0, 2, 7, 2, 13, 532L, 2 },
                    { 541L, 3, 5, 8, 9, 0, 766, 77, 0, 1, 18, 7, 11, 541L, 0 },
                    { 542L, 0, 4, 10, 8, 0, 227, 23, 0, 3, 7, 2, 12, 542L, 0 },
                    { 551L, 3, 4, 13, 18, 1, 360, 47, 0, 6, 10, 5, 14, 551L, 3 },
                    { 552L, 2, 6, 15, 13, 3, 398, 53, 1, 1, 14, 8, 20, 552L, 4 },
                    { 561L, 6, 6, 9, 14, 2, 387, 43, 0, 4, 14, 5, 25, 561L, 2 },
                    { 562L, 2, 8, 11, 11, 4, 520, 57, 1, 4, 9, 6, 11, 562L, 3 },
                    { 571L, 10, 8, 10, 10, 1, 567, 59, 0, 2, 30, 7, 13, 571L, 2 },
                    { 572L, 0, 2, 9, 11, 1, 395, 41, 0, 6, 7, 2, 7, 572L, 4 },
                    { 581L, 6, 4, 15, 12, 3, 458, 56, 0, 1, 16, 4, 23, 581L, 2 },
                    { 582L, 3, 24, 12, 18, 0, 380, 44, 0, 3, 9, 4, 19, 582L, 5 },
                    { 591L, 3, 1, 10, 14, 2, 468, 51, 0, 2, 14, 5, 17, 591L, 2 },
                    { 592L, 3, 4, 13, 11, 2, 441, 49, 0, 3, 12, 4, 14, 592L, 3 }
                });

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

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 5011L, 50101L, true, false, 90 },
                    { 5021L, 50200L, false, false, 54 },
                    { 5022L, 50211L, false, false, 39 },
                    { 5111L, 51101L, true, false, 90 },
                    { 5121L, 51211L, false, false, 49 },
                    { 5122L, 51212L, false, false, 58 },
                    { 5211L, 52112L, false, false, 21 },
                    { 5212L, 52104L, false, false, 47 },
                    { 5213L, 52113L, false, false, 2 },
                    { 5321L, 52211L, false, false, 38 },
                    { 5411L, 54104L, false, false, 37 },
                    { 5412L, 54104L, false, false, 44 },
                    { 5413L, 54104L, false, false, 80 },
                    { 5414L, 54103L, false, false, 83 },
                    { 5421L, 54209L, false, false, 16 },
                    { 5511L, 55107L, false, false, 81 },
                    { 5512L, 55112L, false, false, 19 },
                    { 5513L, 55112L, false, false, 37 },
                    { 5514L, 55104L, false, false, 41 },
                    { 5521L, 55201L, false, false, 89 },
                    { 5522L, 55213L, false, false, 88 },
                    { 5611L, 56113L, false, false, 65 },
                    { 5621L, 56207L, false, false, 38 },
                    { 5622L, 56213L, false, false, 35 },
                    { 5711L, 57102L, false, false, 61 },
                    { 5811L, 58112L, true, false, 45 },
                    { 5821L, 58204L, false, false, 11 },
                    { 5822L, 58204L, false, false, 31 },
                    { 5823L, 58200L, false, false, 61 },
                    { 5911L, 59111L, false, false, 35 },
                    { 5912L, 59104L, false, false, 65 },
                    { 5921L, 59206L, false, false, 67 },
                    { 5922L, 59212L, true, false, 90 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5122L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5212L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5213L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5413L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5414L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5513L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5514L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5522L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5622L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5822L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5823L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5912L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5922L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 53217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 50211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 51212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 52211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 54209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 55213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 56213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 57102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 58204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 59212L);

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
        }
    }
}
