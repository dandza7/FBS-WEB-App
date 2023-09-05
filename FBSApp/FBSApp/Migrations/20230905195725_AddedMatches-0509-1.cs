using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches05091 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 240100L, true, 240L, 89, 1304L },
                    { 240101L, false, 240L, 155, 1306L },
                    { 240102L, true, 240L, 89, 1308L },
                    { 240103L, false, 240L, 1, 1315L },
                    { 240104L, true, 240L, 89, 1310L },
                    { 240105L, false, 240L, 1, 1321L },
                    { 240106L, true, 240L, 90, 1322L },
                    { 240107L, true, 240L, 90, 1323L },
                    { 240108L, true, 240L, 90, 1302L },
                    { 240109L, true, 240L, 90, 1319L },
                    { 240110L, true, 240L, 90, 1313L },
                    { 240111L, true, 240L, 90, 1311L },
                    { 240112L, true, 240L, 90, 1320L },
                    { 240113L, true, 240L, 90, 1318L },
                    { 240114L, false, 240L, 0, 1305L },
                    { 240115L, false, 240L, 0, 1314L },
                    { 240116L, false, 240L, 0, 1309L },
                    { 240117L, false, 240L, 0, 1300L },
                    { 240200L, true, 240L, 60, 324L },
                    { 240201L, false, 240L, 30, 303L },
                    { 240202L, true, 240L, 79, 331L },
                    { 240203L, false, 240L, 11, 330L },
                    { 240204L, true, 240L, 87, 325L },
                    { 240205L, false, 240L, 3, 318L },
                    { 240206L, true, 240L, 90, 322L },
                    { 240207L, true, 240L, 90, 329L },
                    { 240208L, true, 240L, 90, 315L },
                    { 240209L, true, 240L, 90, 304L },
                    { 240210L, true, 240L, 90, 305L },
                    { 240211L, true, 240L, 90, 311L },
                    { 240212L, true, 240L, 90, 313L },
                    { 240213L, true, 240L, 90, 326L },
                    { 240214L, false, 240L, 0, 601L },
                    { 240215L, false, 240L, 0, 308L },
                    { 240216L, false, 240L, 0, 314L },
                    { 240217L, false, 240L, 0, 333L },
                    { 241100L, true, 241L, 55, 2216L },
                    { 241101L, false, 241L, 35, 1201L },
                    { 241102L, true, 241L, 81, 2227L },
                    { 241103L, false, 241L, 9, 2205L },
                    { 241104L, true, 241L, 87, 2202L },
                    { 241105L, false, 241L, 3, 2219L },
                    { 241106L, true, 241L, 90, 2215L },
                    { 241107L, true, 241L, 90, 2211L },
                    { 241108L, true, 241L, 90, 2220L },
                    { 241109L, true, 241L, 90, 2206L },
                    { 241110L, true, 241L, 90, 2225L },
                    { 241111L, true, 241L, 90, 2217L },
                    { 241112L, true, 241L, 90, 1410L },
                    { 241113L, true, 241L, 90, 2224L },
                    { 241114L, false, 241L, 0, 2210L },
                    { 241115L, false, 241L, 0, 2204L },
                    { 241116L, false, 241L, 0, 2203L },
                    { 241117L, false, 241L, 0, 2226L },
                    { 241200L, true, 241L, 55, 1015L },
                    { 241201L, false, 241L, 35, 1016L },
                    { 241202L, true, 241L, 70, 1004L },
                    { 241203L, false, 241L, 20, 1012L },
                    { 241204L, true, 241L, 86, 1024L },
                    { 241205L, false, 241L, 4, 1006L },
                    { 241206L, true, 241L, 90, 1013L },
                    { 241207L, true, 241L, 90, 1026L },
                    { 241208L, true, 241L, 90, 1019L },
                    { 241209L, true, 241L, 90, 924L },
                    { 241210L, true, 241L, 90, 1001L },
                    { 241211L, true, 241L, 90, 1003L },
                    { 241212L, true, 241L, 90, 1028L },
                    { 241213L, true, 241L, 90, 1007L },
                    { 241214L, false, 241L, 0, 1000L },
                    { 241215L, false, 241L, 0, 1009L },
                    { 241216L, false, 241L, 0, 1017L },
                    { 241217L, false, 241L, 0, 1027L },
                    { 242100L, true, 242L, 27, 1519L },
                    { 242101L, false, 242L, 63, 1520L },
                    { 242102L, true, 242L, 46, 1522L },
                    { 242103L, false, 242L, 44, 1524L },
                    { 242104L, true, 242L, 77, 1508L },
                    { 242105L, false, 242L, 13, 227L },
                    { 242106L, true, 242L, 90, 1517L },
                    { 242107L, true, 242L, 90, 1502L },
                    { 242108L, true, 242L, 90, 1515L },
                    { 242109L, true, 242L, 90, 1501L },
                    { 242110L, true, 242L, 90, 406L },
                    { 242111L, true, 242L, 90, 1507L },
                    { 242112L, true, 242L, 90, 1525L },
                    { 242113L, true, 242L, 90, 1527L },
                    { 242114L, false, 242L, 0, 1526L },
                    { 242115L, false, 242L, 0, 1513L },
                    { 242116L, false, 242L, 0, 1506L },
                    { 242117L, false, 242L, 0, 1516L },
                    { 242200L, true, 242L, 71, 1224L },
                    { 242201L, false, 242L, 19, 1206L },
                    { 242202L, true, 242L, 77, 1232L },
                    { 242203L, false, 242L, 13, 1217L },
                    { 242204L, true, 242L, 90, 1230L },
                    { 242205L, true, 242L, 90, 1229L },
                    { 242206L, true, 242L, 90, 1236L },
                    { 242207L, true, 242L, 90, 1227L },
                    { 242208L, true, 242L, 90, 1218L },
                    { 242209L, true, 242L, 90, 1212L },
                    { 242210L, true, 242L, 90, 1215L },
                    { 242211L, true, 242L, 90, 1237L },
                    { 242212L, true, 242L, 90, 1219L },
                    { 242213L, false, 242L, 0, 1245L },
                    { 242214L, false, 242L, 0, 1213L },
                    { 242215L, false, 242L, 0, 1214L },
                    { 242216L, false, 242L, 0, 1209L },
                    { 242217L, false, 242L, 0, 1211L },
                    { 243100L, true, 243L, 46, 428L },
                    { 243101L, false, 243L, 44, 402L },
                    { 243102L, true, 243L, 60, 439L },
                    { 243103L, false, 243L, 30, 407L },
                    { 243104L, true, 243L, 76, 427L },
                    { 243105L, false, 243L, 14, 400L },
                    { 243106L, true, 243L, 90, 404L },
                    { 243107L, true, 243L, 90, 437L },
                    { 243108L, true, 243L, 90, 429L },
                    { 243109L, true, 243L, 90, 436L },
                    { 243110L, true, 243L, 90, 424L },
                    { 243111L, true, 243L, 90, 426L },
                    { 243112L, true, 243L, 90, 403L },
                    { 243113L, true, 243L, 90, 433L },
                    { 243114L, false, 243L, 0, 432L },
                    { 243115L, false, 243L, 0, 422L },
                    { 243116L, false, 243L, 0, 413L },
                    { 243117L, false, 243L, 0, 417L },
                    { 243200L, true, 243L, 70, 1802L },
                    { 243201L, false, 243L, 20, 1820L },
                    { 243202L, true, 243L, 73, 1022L },
                    { 243203L, false, 243L, 17, 1815L },
                    { 243204L, true, 243L, 81, 1808L },
                    { 243205L, false, 243L, 9, 1814L },
                    { 243206L, true, 243L, 90, 1821L },
                    { 243207L, true, 243L, 90, 1817L },
                    { 243208L, true, 243L, 90, 1803L },
                    { 243209L, true, 243L, 90, 1824L },
                    { 243210L, true, 243L, 90, 1810L },
                    { 243211L, true, 243L, 90, 1804L },
                    { 243212L, true, 243L, 90, 1801L },
                    { 243213L, true, 243L, 90, 1811L },
                    { 243214L, false, 243L, 0, 1807L },
                    { 243215L, false, 243L, 0, 1822L },
                    { 243216L, false, 243L, 0, 1813L },
                    { 243217L, false, 243L, 0, 1800L },
                    { 244100L, true, 244L, 87, 704L },
                    { 244101L, false, 244L, 3, 725L },
                    { 244102L, true, 244L, 89, 702L },
                    { 244103L, false, 244L, 1, 718L },
                    { 244104L, true, 244L, 90, 726L },
                    { 244105L, true, 244L, 90, 706L },
                    { 244106L, true, 244L, 90, 709L },
                    { 244107L, true, 244L, 90, 716L },
                    { 244108L, true, 244L, 90, 711L },
                    { 244109L, true, 244L, 90, 727L },
                    { 244110L, true, 244L, 90, 714L },
                    { 244111L, true, 244L, 90, 735L },
                    { 244112L, true, 244L, 90, 734L },
                    { 244113L, false, 244L, 0, 705L },
                    { 244114L, false, 244L, 0, 710L },
                    { 244115L, false, 244L, 0, 715L },
                    { 244116L, false, 244L, 0, 703L },
                    { 244117L, false, 244L, 0, 712L },
                    { 244200L, true, 244L, 65, 516L },
                    { 244201L, false, 244L, 25, 502L },
                    { 244202L, true, 244L, 73, 518L },
                    { 244203L, false, 244L, 17, 512L },
                    { 244204L, true, 244L, 83, 505L },
                    { 244205L, false, 244L, 7, 513L },
                    { 244206L, true, 244L, 90, 507L },
                    { 244207L, true, 244L, 90, 517L },
                    { 244208L, true, 244L, 90, 515L },
                    { 244209L, true, 244L, 90, 500L },
                    { 244210L, true, 244L, 90, 511L },
                    { 244211L, true, 244L, 90, 506L },
                    { 244212L, true, 244L, 90, 523L },
                    { 244213L, true, 244L, 90, 527L },
                    { 244214L, false, 244L, 0, 521L },
                    { 244215L, false, 244L, 0, 524L },
                    { 244216L, false, 244L, 0, 519L },
                    { 245100L, true, 245L, 63, 103L },
                    { 245101L, false, 245L, 27, 119L },
                    { 245102L, true, 245L, 67, 131L },
                    { 245103L, false, 245L, 23, 101L },
                    { 245104L, true, 245L, 90, 113L },
                    { 245105L, true, 245L, 90, 107L },
                    { 245106L, true, 245L, 90, 135L },
                    { 245107L, true, 245L, 90, 130L },
                    { 245108L, true, 245L, 90, 121L },
                    { 245109L, true, 245L, 90, 127L },
                    { 245110L, true, 245L, 90, 120L },
                    { 245111L, true, 245L, 90, 129L },
                    { 245112L, true, 245L, 90, 123L },
                    { 245113L, false, 245L, 0, 114L },
                    { 245114L, false, 245L, 0, 116L },
                    { 245115L, false, 245L, 0, 102L },
                    { 245116L, false, 245L, 0, 111L },
                    { 245200L, true, 245L, 78, 1608L },
                    { 245201L, false, 245L, 12, 1614L },
                    { 245202L, true, 245L, 90, 1627L },
                    { 245203L, true, 245L, 90, 1622L },
                    { 245204L, true, 245L, 90, 1610L },
                    { 245205L, true, 245L, 90, 1604L },
                    { 245206L, true, 245L, 90, 1605L },
                    { 245207L, true, 245L, 90, 1612L },
                    { 245208L, true, 245L, 90, 1602L },
                    { 245209L, true, 245L, 90, 1609L },
                    { 245210L, true, 245L, 90, 1601L },
                    { 245211L, true, 245L, 90, 1606L },
                    { 245212L, false, 245L, 0, 1603L },
                    { 245213L, false, 245L, 0, 1613L },
                    { 245214L, false, 245L, 0, 1624L },
                    { 245215L, false, 245L, 0, 1617L },
                    { 245216L, false, 245L, 0, 1625L },
                    { 246100L, true, 246L, 62, 1935L },
                    { 246101L, false, 246L, 28, 1931L },
                    { 246102L, true, 246L, 75, 1912L },
                    { 246103L, false, 246L, 15, 1920L },
                    { 246104L, true, 246L, 84, 1925L },
                    { 246105L, false, 246L, 6, 1902L },
                    { 246106L, true, 246L, 90, 1900L },
                    { 246107L, true, 246L, 90, 1911L },
                    { 246108L, true, 246L, 90, 1907L },
                    { 246109L, true, 246L, 90, 1924L },
                    { 246110L, true, 246L, 90, 1910L },
                    { 246111L, true, 246L, 90, 824L },
                    { 246112L, true, 246L, 90, 1922L },
                    { 246113L, true, 246L, 90, 1905L },
                    { 246114L, false, 246L, 0, 1927L },
                    { 246115L, false, 246L, 0, 1901L },
                    { 246116L, false, 246L, 0, 1928L },
                    { 246117L, false, 246L, 0, 1914L },
                    { 246200L, true, 246L, 71, 1404L },
                    { 246201L, false, 246L, 19, 1411L },
                    { 246202L, true, 246L, 89, 1409L },
                    { 246203L, false, 246L, 1, 1425L },
                    { 246204L, true, 246L, 90, 1429L },
                    { 246205L, true, 246L, 90, 100L },
                    { 246206L, true, 246L, 90, 1418L },
                    { 246207L, true, 246L, 90, 1422L },
                    { 246208L, true, 246L, 90, 1416L },
                    { 246209L, true, 246L, 90, 1408L },
                    { 246210L, true, 246L, 90, 1401L },
                    { 246211L, true, 246L, 90, 1414L },
                    { 246212L, true, 246L, 87, 1432L },
                    { 246213L, false, 246L, 0, 1405L },
                    { 246214L, false, 246L, 0, 1431L },
                    { 246215L, false, 246L, 0, 1419L },
                    { 246216L, false, 246L, 0, 1420L },
                    { 246217L, false, 246L, 0, 1406L },
                    { 247100L, true, 247L, 68, 1711L },
                    { 247101L, false, 247L, 22, 1721L },
                    { 247102L, true, 247L, 89, 1730L },
                    { 247103L, false, 247L, 1, 1708L },
                    { 247104L, true, 247L, 89, 1723L },
                    { 247105L, false, 247L, 1, 1709L },
                    { 247106L, true, 247L, 90, 1705L },
                    { 247107L, true, 247L, 90, 623L },
                    { 247108L, true, 247L, 90, 1733L },
                    { 247109L, true, 247L, 90, 1728L },
                    { 247110L, true, 247L, 90, 1701L },
                    { 247111L, true, 247L, 90, 1710L },
                    { 247112L, true, 247L, 90, 1703L },
                    { 247113L, true, 247L, 90, 1722L },
                    { 247114L, false, 247L, 0, 1706L },
                    { 247115L, false, 247L, 0, 1118L },
                    { 247116L, false, 247L, 0, 1712L },
                    { 247117L, false, 247L, 0, 1713L },
                    { 247200L, true, 247L, 61, 934L },
                    { 247201L, false, 247L, 29, 941L },
                    { 247202L, true, 247L, 65, 918L },
                    { 247203L, false, 247L, 25, 933L },
                    { 247204L, true, 247L, 77, 930L },
                    { 247205L, false, 247L, 13, 938L },
                    { 247206L, true, 247L, 90, 923L },
                    { 247207L, true, 247L, 90, 905L },
                    { 247208L, true, 247L, 90, 901L },
                    { 247209L, true, 247L, 90, 909L },
                    { 247210L, true, 247L, 90, 913L },
                    { 247211L, true, 247L, 90, 932L },
                    { 247212L, true, 247L, 90, 922L },
                    { 247213L, true, 247L, 90, 912L },
                    { 247214L, false, 247L, 0, 928L },
                    { 247215L, false, 247L, 0, 937L },
                    { 247216L, false, 247L, 0, 942L },
                    { 247217L, false, 247L, 0, 900L },
                    { 248100L, true, 248L, 46, 228L },
                    { 248101L, false, 248L, 44, 221L },
                    { 248102L, true, 248L, 69, 224L },
                    { 248103L, false, 248L, 21, 219L },
                    { 248104L, true, 248L, 79, 216L },
                    { 248105L, false, 248L, 11, 207L },
                    { 248106L, true, 248L, 90, 215L },
                    { 248107L, true, 248L, 90, 231L },
                    { 248108L, true, 248L, 90, 204L },
                    { 248109L, true, 248L, 90, 213L },
                    { 248110L, true, 248L, 90, 202L },
                    { 248111L, true, 248L, 90, 203L },
                    { 248112L, true, 248L, 90, 208L },
                    { 248113L, true, 248L, 90, 214L },
                    { 248114L, false, 248L, 0, 206L },
                    { 248115L, false, 248L, 0, 226L },
                    { 248116L, false, 248L, 0, 225L },
                    { 248117L, false, 248L, 0, 220L },
                    { 248200L, true, 248L, 61, 2117L },
                    { 248201L, false, 248L, 29, 2121L },
                    { 248202L, true, 248L, 66, 2138L },
                    { 248203L, false, 248L, 24, 2107L },
                    { 248204L, true, 248L, 90, 2106L },
                    { 248205L, true, 248L, 90, 2113L },
                    { 248206L, true, 248L, 90, 2103L },
                    { 248207L, true, 248L, 90, 2110L },
                    { 248208L, true, 248L, 90, 2125L },
                    { 248209L, true, 248L, 90, 2116L },
                    { 248210L, true, 248L, 90, 2141L },
                    { 248211L, true, 248L, 90, 2134L },
                    { 248212L, true, 248L, 90, 2140L },
                    { 248213L, false, 248L, 0, 2132L },
                    { 248214L, false, 248L, 0, 2119L },
                    { 248215L, false, 248L, 0, 2102L },
                    { 248216L, false, 248L, 0, 2115L },
                    { 248217L, false, 248L, 0, 2128L },
                    { 249100L, true, 249L, 66, 621L },
                    { 249101L, false, 249L, 24, 600L },
                    { 249102L, true, 249L, 67, 634L },
                    { 249103L, false, 249L, 23, 612L },
                    { 249104L, true, 249L, 82, 627L },
                    { 249105L, false, 249L, 8, 609L },
                    { 249106L, true, 249L, 90, 604L },
                    { 249107L, true, 249L, 90, 618L },
                    { 249108L, true, 249L, 90, 617L },
                    { 249109L, true, 249L, 90, 633L },
                    { 249110L, true, 249L, 90, 605L },
                    { 249111L, true, 249L, 90, 613L },
                    { 249112L, true, 249L, 90, 628L },
                    { 249113L, true, 249L, 90, 620L },
                    { 249114L, false, 249L, 0, 625L },
                    { 249115L, false, 249L, 0, 610L },
                    { 249116L, false, 249L, 0, 630L },
                    { 249117L, false, 249L, 0, 611L },
                    { 249200L, true, 249L, 75, 2015L },
                    { 249201L, false, 249L, 15, 2012L },
                    { 249202L, true, 249L, 84, 2007L },
                    { 249203L, false, 249L, 6, 2027L },
                    { 249204L, true, 249L, 89, 2016L },
                    { 249205L, false, 249L, 1, 2019L },
                    { 249206L, true, 249L, 90, 2018L },
                    { 249207L, true, 249L, 90, 2026L },
                    { 249208L, true, 249L, 90, 2017L },
                    { 249209L, true, 249L, 90, 117L },
                    { 249210L, true, 249L, 90, 2002L },
                    { 249211L, true, 249L, 90, 2024L },
                    { 249212L, true, 249L, 90, 2030L },
                    { 249213L, true, 249L, 90, 2022L },
                    { 249214L, false, 249L, 0, 2013L },
                    { 249215L, false, 249L, 0, 2029L },
                    { 249216L, false, 249L, 0, 2006L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4AF3AE240D497B3D15662EB2B448C7E300885B4F8DBAA7148B66B9EDF870E056A67199773599B04578604C84617D264F53C997CFC78DF19C9032C6387A8A26C2", new byte[] { 202, 65, 216, 188, 159, 105, 21, 57, 28, 180, 35, 164, 190, 115, 211, 47, 66, 241, 160, 14, 132, 29, 73, 43, 138, 169, 147, 200, 105, 187, 71, 208, 125, 133, 33, 190, 124, 51, 119, 143, 93, 42, 77, 178, 232, 52, 116, 133, 121, 110, 189, 245, 203, 97, 220, 249, 62, 66, 228, 96, 184, 48, 214, 164 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "0FB7FD2C62CD580FB78613E2B9442C6AC31AAF433E499DABBF8D55938736DF84DDB259F3FEAF23403BDC1EB60C1F6BBBCC62A5429CB12C5CDD6532BDEDC296FA", new byte[] { 227, 10, 108, 63, 172, 183, 221, 10, 231, 2, 5, 208, 137, 115, 25, 47, 168, 33, 59, 199, 27, 72, 173, 14, 206, 118, 205, 107, 167, 236, 94, 8, 1, 105, 224, 39, 89, 108, 249, 14, 254, 101, 31, 8, 113, 34, 246, 216, 82, 248, 98, 88, 57, 83, 89, 86, 249, 75, 107, 144, 10, 68, 136, 242 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 240217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 241217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 242217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 243217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 244216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 245216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 246217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 247217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 248217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 249216L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BC44240515E5F89F0A0B731519B51DF6D9C30AD961385F822B018AE539E50F6323D0B001E265BD1A916A2CCDFFEECFDCDE05BDB482197C1FD46F362C4B7A7E11", new byte[] { 177, 89, 109, 225, 7, 198, 36, 196, 1, 32, 11, 101, 160, 158, 147, 218, 140, 100, 114, 170, 185, 6, 200, 61, 121, 220, 30, 4, 99, 254, 180, 241, 55, 219, 248, 80, 17, 103, 247, 10, 106, 176, 237, 113, 252, 230, 54, 131, 231, 116, 138, 93, 48, 240, 135, 7, 146, 187, 220, 253, 192, 71, 2, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "FBE1C727E71E90F4B708CC16ED4A8302E6D9C105F5B214E7C59927A949BF5B60633D52B4510B6F8CFD38F61C4C323489AD27578BD70E5B4981A0D85EBE5415D8", new byte[] { 93, 107, 62, 83, 242, 159, 1, 146, 234, 154, 244, 178, 85, 208, 93, 234, 171, 246, 129, 66, 216, 1, 205, 182, 33, 206, 244, 152, 157, 4, 68, 96, 123, 200, 98, 88, 245, 236, 60, 127, 250, 3, 209, 33, 131, 149, 3, 140, 199, 117, 243, 46, 137, 201, 228, 242, 135, 222, 47, 115, 115, 16, 14, 131 } });
        }
    }
}
