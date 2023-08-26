using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewPlayers2608 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1612L,
                column: "IsExtraTime",
                value: false);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1622L,
                column: "IsExtraTime",
                value: false);

            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 17100L, true, 17L, 56, 408L },
                    { 17101L, false, 17L, 34, 1920L },
                    { 17102L, true, 17L, 56, 1931L },
                    { 17103L, false, 17L, 34, 1905L },
                    { 17104L, true, 17L, 72, 1903L },
                    { 17105L, false, 17L, 18, 1916L },
                    { 17106L, true, 17L, 90, 1900L },
                    { 17107L, true, 17L, 90, 1907L },
                    { 17108L, true, 17L, 90, 1912L },
                    { 17109L, true, 17L, 90, 1933L },
                    { 17110L, true, 17L, 90, 1924L },
                    { 17111L, true, 17L, 90, 1917L },
                    { 17112L, true, 17L, 90, 1926L },
                    { 17113L, true, 17L, 90, 1922L },
                    { 17114L, false, 17L, 0, 1911L },
                    { 17115L, false, 17L, 0, 1901L },
                    { 17116L, false, 17L, 0, 1925L },
                    { 17117L, false, 17L, 0, 1910L },
                    { 17200L, true, 17L, 73, 1606L },
                    { 17201L, false, 17L, 17, 1624L },
                    { 17202L, true, 17L, 76, 1612L },
                    { 17203L, false, 17L, 14, 1601L },
                    { 17204L, true, 17L, 87, 1614L },
                    { 17205L, false, 17L, 3, 1605L },
                    { 17206L, true, 17L, 90, 1613L },
                    { 17207L, true, 17L, 90, 1618L },
                    { 17208L, true, 17L, 90, 1610L },
                    { 17209L, true, 17L, 90, 1604L },
                    { 17210L, true, 17L, 90, 1625L },
                    { 17211L, true, 17L, 90, 1600L },
                    { 17212L, true, 17L, 90, 1602L },
                    { 17213L, true, 17L, 90, 1609L },
                    { 17214L, false, 17L, 0, 1622L },
                    { 17215L, false, 17L, 0, 1603L },
                    { 17216L, false, 17L, 0, 1627L },
                    { 17217L, false, 17L, 0, 1615L },
                    { 18100L, true, 18L, 69, 627L },
                    { 18101L, false, 18L, 21, 618L },
                    { 18102L, true, 18L, 82, 628L },
                    { 18103L, false, 18L, 8, 634L },
                    { 18104L, true, 18L, 87, 620L },
                    { 18105L, false, 18L, 3, 609L },
                    { 18106L, true, 18L, 90, 604L },
                    { 18107L, true, 18L, 90, 632L },
                    { 18108L, true, 18L, 90, 616L },
                    { 18109L, true, 18L, 90, 633L },
                    { 18110L, true, 18L, 90, 605L },
                    { 18111L, true, 18L, 90, 621L },
                    { 18112L, true, 18L, 90, 613L },
                    { 18113L, true, 18L, 90, 615L },
                    { 18114L, false, 18L, 0, 623L },
                    { 18115L, false, 18L, 0, 612L },
                    { 18116L, false, 18L, 0, 600L },
                    { 18200L, true, 18L, 46, 311L },
                    { 18201L, false, 18L, 44, 331L },
                    { 18202L, true, 18L, 62, 313L },
                    { 18203L, false, 18L, 28, 318L },
                    { 18204L, true, 18L, 67, 325L },
                    { 18205L, false, 18L, 23, 302L },
                    { 18206L, true, 18L, 90, 322L },
                    { 18207L, true, 18L, 90, 333L },
                    { 18208L, true, 18L, 90, 312L },
                    { 18209L, true, 18L, 90, 304L },
                    { 18210L, true, 18L, 90, 305L },
                    { 18211L, true, 18L, 90, 324L },
                    { 18212L, true, 18L, 90, 316L },
                    { 18213L, true, 18L, 90, 326L },
                    { 18214L, false, 18L, 0, 601L },
                    { 18215L, false, 18L, 0, 315L },
                    { 18216L, false, 18L, 0, 330L },
                    { 18217L, false, 18L, 0, 329L },
                    { 20100L, true, 20L, 76, 1430L },
                    { 20101L, false, 20L, 14, 1802L },
                    { 20102L, true, 20L, 78, 1812L },
                    { 20103L, false, 20L, 12, 1820L },
                    { 20104L, true, 20L, 83, 1813L },
                    { 20105L, false, 20L, 7, 1804L },
                    { 20106L, true, 20L, 90, 1821L },
                    { 20107L, true, 20L, 90, 1803L },
                    { 20108L, true, 20L, 90, 1823L },
                    { 20109L, true, 20L, 90, 1824L },
                    { 20110L, true, 20L, 90, 1810L },
                    { 20111L, true, 20L, 90, 1808L },
                    { 20112L, true, 20L, 90, 1811L },
                    { 20113L, true, 20L, 90, 1815L },
                    { 20114L, false, 20L, 0, 1807L },
                    { 20115L, false, 20L, 0, 1806L },
                    { 20116L, false, 20L, 0, 1809L },
                    { 20117L, false, 20L, 0, 1800L },
                    { 20200L, true, 20L, 46, 718L },
                    { 20201L, false, 20L, 44, 714L },
                    { 20202L, true, 20L, 65, 702L },
                    { 20203L, false, 20L, 25, 739L },
                    { 20204L, true, 20L, 70, 727L },
                    { 20205L, false, 20L, 20, 715L },
                    { 20206L, true, 20L, 90, 726L },
                    { 20207L, true, 20L, 90, 716L },
                    { 20208L, true, 20L, 90, 705L },
                    { 20209L, true, 20L, 90, 732L },
                    { 20210L, true, 20L, 90, 721L },
                    { 20211L, true, 20L, 90, 730L },
                    { 20212L, true, 20L, 90, 725L },
                    { 20213L, true, 20L, 90, 722L },
                    { 20214L, false, 20L, 0, 723L },
                    { 20215L, false, 20L, 0, 710L },
                    { 20216L, false, 20L, 0, 736L },
                    { 20217L, false, 20L, 0, 734L },
                    { 21100L, true, 21L, 67, 318L },
                    { 21101L, false, 21L, 23, 302L },
                    { 21102L, true, 21L, 77, 324L },
                    { 21103L, false, 21L, 13, 321L },
                    { 21104L, true, 21L, 77, 331L },
                    { 21105L, false, 21L, 13, 307L },
                    { 21106L, true, 21L, 90, 322L },
                    { 21107L, true, 21L, 90, 329L },
                    { 21108L, true, 21L, 90, 312L },
                    { 21109L, true, 21L, 90, 304L },
                    { 21110L, true, 21L, 90, 305L },
                    { 21111L, true, 21L, 90, 316L },
                    { 21112L, true, 21L, 90, 313L },
                    { 21113L, true, 21L, 90, 325L },
                    { 21114L, false, 21L, 0, 601L },
                    { 21115L, false, 21L, 0, 300L },
                    { 21116L, false, 21L, 0, 315L },
                    { 21117L, false, 21L, 0, 330L },
                    { 21200L, true, 21L, 78, 1711L },
                    { 21201L, false, 21L, 12, 1732L },
                    { 21202L, true, 21L, 89, 1722L },
                    { 21203L, false, 21L, 1, 1724L },
                    { 21204L, true, 21L, 90, 1706L },
                    { 21205L, true, 21L, 90, 1701L },
                    { 21206L, true, 21L, 90, 1733L },
                    { 21207L, true, 21L, 90, 1728L },
                    { 21208L, true, 21L, 90, 1708L },
                    { 21209L, true, 21L, 90, 1703L },
                    { 21210L, true, 21L, 90, 1710L },
                    { 21211L, true, 21L, 90, 1730L },
                    { 21212L, true, 21L, 90, 1707L },
                    { 21213L, false, 21L, 0, 1705L },
                    { 21214L, false, 21L, 0, 1720L },
                    { 21215L, false, 21L, 0, 1721L },
                    { 21216L, false, 21L, 0, 1734L },
                    { 21217L, false, 21L, 0, 1118L },
                    { 22100L, true, 22L, 63, 204L },
                    { 22101L, false, 22L, 27, 234L },
                    { 22102L, true, 22L, 73, 206L },
                    { 22103L, false, 22L, 17, 207L },
                    { 22104L, true, 22L, 89, 212L },
                    { 22105L, false, 22L, 1, 213L },
                    { 22106L, true, 22L, 90, 215L },
                    { 22107L, true, 22L, 90, 231L },
                    { 22108L, true, 22L, 90, 216L },
                    { 22109L, true, 22L, 90, 219L },
                    { 22110L, true, 22L, 90, 202L },
                    { 22111L, true, 22L, 90, 200L },
                    { 22112L, true, 22L, 90, 221L },
                    { 22113L, true, 22L, 90, 205L },
                    { 22114L, false, 22L, 0, 228L },
                    { 22115L, false, 22L, 0, 203L },
                    { 22116L, false, 22L, 0, 224L },
                    { 22117L, false, 22L, 0, 223L },
                    { 22200L, true, 22L, 73, 1520L },
                    { 22201L, false, 22L, 17, 1521L },
                    { 22202L, true, 22L, 85, 1508L },
                    { 22203L, false, 22L, 5, 1501L },
                    { 22204L, true, 22L, 88, 1523L },
                    { 22205L, false, 22L, 2, 1522L },
                    { 22206L, true, 22L, 90, 1503L },
                    { 22207L, true, 22L, 90, 134L },
                    { 22208L, true, 22L, 90, 406L },
                    { 22209L, true, 22L, 90, 1515L },
                    { 22210L, true, 22L, 90, 1504L },
                    { 22211L, true, 22L, 90, 1507L },
                    { 22212L, true, 22L, 90, 227L },
                    { 22213L, true, 22L, 90, 1525L },
                    { 22214L, false, 22L, 0, 1516L },
                    { 22215L, false, 22L, 0, 1509L },
                    { 22216L, false, 22L, 0, 1517L },
                    { 22217L, false, 22L, 0, 1524L },
                    { 23100L, true, 23L, 60, 2022L },
                    { 23101L, false, 23L, 30, 2005L },
                    { 23102L, true, 23L, 82, 2015L },
                    { 23103L, false, 23L, 8, 2019L },
                    { 23104L, true, 23L, 82, 2007L },
                    { 23105L, false, 23L, 8, 2000L },
                    { 23106L, true, 23L, 90, 2018L },
                    { 23107L, true, 23L, 90, 2026L },
                    { 23108L, true, 23L, 90, 2017L },
                    { 23109L, true, 23L, 90, 117L },
                    { 23110L, true, 23L, 90, 2002L },
                    { 23111L, true, 23L, 90, 2024L },
                    { 23112L, true, 23L, 90, 2030L },
                    { 23113L, true, 23L, 90, 2016L },
                    { 23114L, false, 23L, 0, 2004L },
                    { 23115L, false, 23L, 0, 2025L },
                    { 23116L, false, 23L, 0, 2029L },
                    { 23200L, true, 23L, 46, 1304L },
                    { 23201L, false, 23L, 44, 1312L },
                    { 23202L, true, 23L, 46, 1305L },
                    { 23203L, false, 23L, 44, 1300L },
                    { 23204L, true, 23L, 69, 1313L },
                    { 23205L, false, 23L, 21, 1315L },
                    { 23206L, true, 23L, 90, 1322L },
                    { 23207L, true, 23L, 90, 1323L },
                    { 23208L, true, 23L, 90, 1302L },
                    { 23209L, true, 23L, 90, 1325L },
                    { 23210L, true, 23L, 90, 1308L },
                    { 23211L, true, 23L, 90, 1320L },
                    { 23212L, true, 23L, 90, 1310L },
                    { 23213L, true, 23L, 90, 1318L },
                    { 23214L, false, 23L, 0, 820L },
                    { 23215L, false, 23L, 0, 1309L },
                    { 23216L, false, 23L, 0, 1319L },
                    { 23217L, false, 23L, 0, 1321L },
                    { 24100L, true, 24L, 24, 1021L },
                    { 24101L, false, 24L, 56, 1028L },
                    { 24102L, true, 24L, 75, 1004L },
                    { 24103L, false, 24L, 15, 1006L },
                    { 24104L, true, 24L, 86, 1024L },
                    { 24105L, false, 24L, 4, 1022L },
                    { 24106L, true, 24L, 90, 1013L },
                    { 24107L, true, 24L, 90, 1026L },
                    { 24108L, true, 24L, 90, 1018L },
                    { 24109L, true, 24L, 90, 1019L },
                    { 24110L, true, 24L, 90, 1015L },
                    { 24111L, true, 24L, 90, 1008L },
                    { 24112L, true, 24L, 90, 1027L },
                    { 24113L, true, 24L, 90, 1007L },
                    { 24114L, false, 24L, 0, 1012L },
                    { 24115L, false, 24L, 0, 1000L },
                    { 24116L, false, 24L, 0, 1017L },
                    { 24117L, false, 24L, 0, 924L },
                    { 24200L, true, 24L, 58, 1903L },
                    { 24201L, false, 24L, 32, 1928L },
                    { 24202L, true, 24L, 72, 1924L },
                    { 24203L, false, 24L, 18, 1916L },
                    { 24204L, true, 24L, 84, 1910L },
                    { 24205L, false, 24L, 6, 1931L },
                    { 24206L, true, 24L, 90, 1900L },
                    { 24207L, true, 24L, 90, 408L },
                    { 24208L, true, 24L, 90, 1907L },
                    { 24209L, true, 24L, 90, 1933L },
                    { 24210L, true, 24L, 90, 1926L },
                    { 24211L, true, 24L, 90, 1917L },
                    { 24212L, true, 24L, 90, 1922L },
                    { 24213L, true, 24L, 90, 1905L },
                    { 24214L, false, 24L, 0, 1901L },
                    { 24215L, false, 24L, 0, 1925L },
                    { 24216L, false, 24L, 0, 824L },
                    { 24217L, false, 24L, 0, 1918L },
                    { 26100L, true, 26L, 64, 506L },
                    { 26101L, false, 26L, 26, 524L },
                    { 26102L, true, 26L, 76, 527L },
                    { 26103L, false, 26L, 14, 518L },
                    { 26104L, true, 26L, 82, 513L },
                    { 26105L, false, 26L, 8, 521L },
                    { 26106L, true, 26L, 90, 507L },
                    { 26107L, true, 26L, 90, 515L },
                    { 26108L, true, 26L, 90, 529L },
                    { 26109L, true, 26L, 90, 500L },
                    { 26110L, true, 26L, 90, 511L },
                    { 26111L, true, 26L, 90, 502L },
                    { 26112L, true, 26L, 90, 501L },
                    { 26113L, true, 26L, 90, 512L },
                    { 26114L, false, 26L, 0, 503L },
                    { 26115L, false, 26L, 0, 519L },
                    { 26116L, false, 26L, 0, 523L },
                    { 26117L, false, 26L, 0, 517L },
                    { 26200L, true, 26L, 46, 2201L },
                    { 26201L, false, 26L, 44, 2219L },
                    { 26202L, true, 26L, 61, 2203L },
                    { 26203L, false, 26L, 29, 2202L },
                    { 26204L, true, 26L, 84, 2224L },
                    { 26205L, false, 26L, 6, 2223L },
                    { 26206L, true, 26L, 90, 2204L },
                    { 26207L, true, 26L, 90, 2226L },
                    { 26208L, true, 26L, 90, 2206L },
                    { 26209L, true, 26L, 90, 2225L },
                    { 26210L, true, 26L, 90, 2205L },
                    { 26211L, true, 26L, 90, 2214L },
                    { 26212L, true, 26L, 90, 1729L },
                    { 26213L, true, 26L, 90, 2211L },
                    { 26214L, false, 26L, 0, 2215L },
                    { 26215L, false, 26L, 0, 2212L },
                    { 26216L, false, 26L, 0, 2222L },
                    { 26217L, false, 26L, 0, 2208L },
                    { 27100L, true, 27L, 65, 1606L },
                    { 27101L, false, 27L, 25, 1601L },
                    { 27102L, true, 27L, 70, 1612L },
                    { 27103L, false, 27L, 20, 1624L },
                    { 27104L, true, 27L, 74, 1625L },
                    { 27105L, false, 27L, 16, 1605L },
                    { 27106L, true, 27L, 90, 1613L },
                    { 27107L, true, 27L, 90, 1618L },
                    { 27108L, true, 27L, 90, 1610L },
                    { 27109L, true, 27L, 90, 1604L },
                    { 27110L, true, 27L, 90, 1600L },
                    { 27111L, true, 27L, 90, 1609L },
                    { 27112L, true, 27L, 90, 1602L },
                    { 27113L, true, 27L, 90, 1614L },
                    { 27114L, false, 27L, 0, 1622L },
                    { 27115L, false, 27L, 0, 1603L },
                    { 27116L, false, 27L, 0, 1627L },
                    { 27117L, false, 27L, 0, 1616L },
                    { 27200L, true, 27L, 68, 2104L },
                    { 27201L, false, 27L, 22, 2128L },
                    { 27202L, true, 27L, 83, 2141L },
                    { 27203L, false, 27L, 7, 2129L },
                    { 27204L, true, 27L, 89, 2140L },
                    { 27205L, false, 27L, 1, 2121L },
                    { 27206L, true, 27L, 90, 2106L },
                    { 27207L, true, 27L, 90, 2113L },
                    { 27208L, true, 27L, 90, 2109L },
                    { 27209L, true, 27L, 90, 2110L },
                    { 27210L, true, 27L, 90, 2125L },
                    { 27211L, true, 27L, 90, 2116L },
                    { 27212L, true, 27L, 90, 2100L },
                    { 27213L, true, 27L, 90, 2134L },
                    { 27214L, false, 27L, 0, 2119L },
                    { 27215L, false, 27L, 0, 2103L },
                    { 27216L, false, 27L, 0, 2102L },
                    { 27217L, false, 27L, 0, 2136L },
                    { 28100L, true, 28L, 20, 1227L },
                    { 28101L, false, 28L, 70, 1226L },
                    { 28102L, true, 28L, 89, 1232L },
                    { 28103L, false, 28L, 1, 1209L },
                    { 28104L, true, 28L, 89, 1219L },
                    { 28105L, false, 28L, 1, 1224L },
                    { 28106L, true, 28L, 90, 1230L },
                    { 28107L, true, 28L, 90, 1229L },
                    { 28108L, true, 28L, 90, 1236L },
                    { 28109L, true, 28L, 90, 1218L },
                    { 28110L, true, 28L, 90, 1206L },
                    { 28111L, true, 28L, 90, 1212L },
                    { 28112L, true, 28L, 90, 1215L },
                    { 28113L, true, 28L, 90, 1237L },
                    { 28114L, false, 28L, 0, 1210L },
                    { 28115L, false, 28L, 0, 1245L },
                    { 28116L, false, 28L, 0, 1214L },
                    { 28117L, false, 28L, 0, 1205L },
                    { 28200L, true, 28L, 46, 103L },
                    { 28201L, false, 28L, 44, 119L },
                    { 28202L, true, 28L, 46, 120L },
                    { 28203L, false, 28L, 44, 123L },
                    { 28204L, true, 28L, 60, 105L },
                    { 28205L, false, 28L, 30, 124L },
                    { 28206L, true, 28L, 90, 113L },
                    { 28207L, true, 28L, 90, 107L },
                    { 28208L, true, 28L, 90, 115L },
                    { 28209L, true, 28L, 90, 135L },
                    { 28210L, true, 28L, 90, 121L },
                    { 28211L, true, 28L, 90, 116L },
                    { 28212L, true, 28L, 90, 129L },
                    { 28213L, true, 28L, 90, 131L },
                    { 28214L, false, 28L, 0, 102L },
                    { 28215L, false, 28L, 0, 132L },
                    { 28216L, false, 28L, 0, 111L },
                    { 29100L, true, 29L, 70, 1405L },
                    { 29101L, false, 29L, 20, 1400L },
                    { 29102L, true, 29L, 79, 1401L },
                    { 29103L, false, 29L, 11, 1412L },
                    { 29104L, true, 29L, 83, 1411L },
                    { 29105L, false, 29L, 7, 1420L },
                    { 29106L, true, 29L, 90, 1431L },
                    { 29107L, true, 29L, 90, 100L },
                    { 29108L, true, 29L, 90, 1409L },
                    { 29109L, true, 29L, 90, 1418L },
                    { 29110L, true, 29L, 90, 1422L },
                    { 29111L, true, 29L, 90, 1416L },
                    { 29112L, true, 29L, 90, 1408L },
                    { 29113L, true, 29L, 90, 1432L },
                    { 29114L, false, 29L, 0, 1414L },
                    { 29115L, false, 29L, 0, 1429L },
                    { 29116L, false, 29L, 0, 1419L },
                    { 29117L, false, 29L, 0, 1404L },
                    { 29200L, true, 29L, 67, 615L },
                    { 29201L, false, 29L, 23, 618L },
                    { 29202L, true, 29L, 87, 621L },
                    { 29203L, false, 29L, 3, 600L },
                    { 29204L, true, 29L, 89, 627L },
                    { 29205L, false, 29L, 1, 609L },
                    { 29206L, true, 29L, 90, 604L },
                    { 29207L, true, 29L, 90, 632L },
                    { 29208L, true, 29L, 90, 616L },
                    { 29209L, true, 29L, 90, 633L },
                    { 29210L, true, 29L, 90, 605L },
                    { 29211L, true, 29L, 90, 613L },
                    { 29212L, true, 29L, 90, 620L },
                    { 29213L, true, 29L, 90, 628L },
                    { 29214L, false, 29L, 0, 617L },
                    { 29215L, false, 29L, 0, 630L },
                    { 29216L, false, 29L, 0, 602L },
                    { 29217L, false, 29L, 0, 634L }
                });

            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 342L, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 601L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L },
                    { 1948L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 824L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L }
                });

            migrationBuilder.UpdateData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "Tackles", "YellowCards" },
                values: new object[] { 8, 10, 14, 2, 368, 48, 14, 0 });

            migrationBuilder.UpdateData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "Tackles", "YellowCards" },
                values: new object[] { 5, 9, 13, 4, 406, 52, 9, 1 });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 171L, 9, 7, 11, 10, 0, 502, 63, 0, 1, 18, 3, 11, 171L, 1 },
                    { 172L, 4, 4, 9, 11, 2, 287, 37, 0, 2, 16, 6, 21, 172L, 1 },
                    { 181L, 3, 5, 14, 12, 5, 673, 65, 0, 2, 18, 8, 19, 181L, 1 },
                    { 182L, 1, 4, 9, 18, 3, 360, 35, 0, 4, 5, 2, 22, 182L, 2 },
                    { 201L, 5, 5, 14, 17, 2, 314, 51, 0, 6, 12, 1, 21, 201L, 2 },
                    { 202L, 5, 5, 16, 15, 0, 305, 49, 1, 1, 12, 6, 11, 202L, 2 },
                    { 211L, 3, 6, 14, 9, 1, 493, 61, 0, 3, 11, 5, 20, 211L, 6 },
                    { 212L, 4, 4, 10, 15, 0, 322, 39, 0, 4, 12, 5, 11, 212L, 2 },
                    { 221L, 4, 5, 9, 8, 1, 629, 60, 0, 2, 25, 11, 12, 221L, 0 },
                    { 222L, 2, 2, 5, 10, 3, 435, 40, 0, 8, 10, 3, 13, 222L, 0 },
                    { 231L, 2, 1, 10, 9, 0, 382, 43, 1, 3, 6, 2, 24, 231L, 2 },
                    { 232L, 1, 9, 8, 10, 1, 500, 57, 0, 0, 11, 3, 20, 232L, 1 },
                    { 241L, 3, 2, 8, 23, 2, 423, 58, 0, 3, 14, 7, 16, 241L, 0 },
                    { 242L, 5, 5, 20, 10, 3, 299, 42, 0, 5, 15, 4, 13, 242L, 5 },
                    { 261L, 9, 10, 9, 4, 1, 760, 77, 0, 0, 32, 14, 5, 261L, 0 },
                    { 262L, 2, 3, 4, 10, 1, 224, 23, 0, 8, 5, 1, 16, 262L, 2 },
                    { 271L, 2, 5, 8, 22, 2, 461, 58, 0, 3, 8, 3, 18, 271L, 1 },
                    { 272L, 3, 2, 19, 11, 4, 345, 42, 0, 2, 9, 6, 18, 272L, 2 },
                    { 281L, 0, 3, 16, 15, 2, 283, 33, 0, 1, 6, 3, 28, 281L, 1 },
                    { 282L, 2, 5, 13, 17, 2, 572, 67, 0, 0, 9, 3, 13, 282L, 1 },
                    { 291L, 1, 6, 6, 15, 2, 359, 37, 1, 4, 8, 2, 15, 291L, 1 },
                    { 292L, 6, 7, 13, 7, 2, 625, 63, 0, 2, 16, 6, 22, 292L, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "50981A28D4F27EE028B15A70DDAB298470F273AD8573692F4683E32EDB62C1598984E6B9FF44DB2417F091F2C3D8F60FE3F1816C249D8C91B0370444DC9DF036", new byte[] { 193, 148, 189, 81, 22, 191, 116, 63, 19, 149, 219, 106, 228, 156, 224, 233, 156, 80, 31, 32, 55, 134, 8, 25, 160, 7, 118, 186, 43, 99, 237, 114, 48, 56, 177, 18, 255, 131, 14, 34, 176, 183, 197, 248, 159, 50, 235, 6, 177, 86, 56, 51, 205, 22, 199, 102, 67, 45, 22, 199, 70, 228, 51, 24 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BE4B38BA9B7467C6865C620159B805A154CE2B80C7F6FE220E066CD99FA86728F0A87B952E0603F49BF8361832EE8E4B9C57CF544F2D3CD5C8E7C6B9D64E4DFE", new byte[] { 23, 116, 98, 32, 106, 213, 126, 41, 82, 66, 64, 162, 87, 109, 22, 129, 33, 109, 69, 108, 170, 142, 58, 183, 8, 235, 105, 180, 246, 4, 47, 113, 27, 188, 92, 21, 34, 236, 217, 140, 138, 41, 152, 47, 216, 153, 210, 100, 65, 46, 105, 179, 56, 158, 28, 49, 30, 81, 250, 13, 167, 66, 150, 89 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 1811L, 18104L, false, false, 19 },
                    { 1812L, 18102L, true, false, 45 },
                    { 1813L, 18102L, false, false, 53 },
                    { 1814L, 18105L, false, false, 88 },
                    { 2111L, 21113L, false, false, 33 },
                    { 2121L, 21206L, false, false, 66 },
                    { 2122L, 21212L, false, false, 60 },
                    { 2211L, 22109L, false, false, 74 },
                    { 2212L, 22112L, false, false, 43 },
                    { 2213L, 22104L, false, false, 77 },
                    { 2221L, 22213L, false, false, 52 },
                    { 2311L, 23102L, false, false, 45 },
                    { 2321L, 23204L, false, true, 29 },
                    { 2411L, 24112L, false, false, 15 },
                    { 2412L, 24104L, false, false, 31 },
                    { 2421L, 24213L, false, false, 54 },
                    { 2611L, 26100L, false, false, 48 },
                    { 2612L, 26102L, false, false, 25 },
                    { 2613L, 26102L, false, false, 35 },
                    { 2614L, 26102L, false, false, 75 },
                    { 2615L, 26113L, false, false, 31 },
                    { 2621L, 26209L, false, true, 84 },
                    { 2622L, 26211L, false, false, 43 },
                    { 2711L, 27108L, false, false, 6 },
                    { 2721L, 27202L, false, false, 51 },
                    { 2722L, 27204L, false, false, 48 },
                    { 2723L, 27200L, false, false, 3 },
                    { 2811L, 28108L, false, false, 27 },
                    { 2812L, 28104L, false, false, 25 },
                    { 2813L, 28102L, false, false, 44 },
                    { 2821L, 28212L, true, false, 90 },
                    { 2822L, 28213L, false, false, 34 },
                    { 2921L, 29200L, false, false, 45 },
                    { 2922L, 29213L, true, false, 90 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1814L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2122L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2212L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2213L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2612L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2613L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2614L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2615L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2622L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2722L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2723L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2822L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2922L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 17217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 20217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29217L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1948L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 18105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 21212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 22213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 23204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 24213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 26211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 27204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 28213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 29213L);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1612L,
                column: "IsExtraTime",
                value: true);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1622L,
                column: "IsExtraTime",
                value: true);

            migrationBuilder.UpdateData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "Tackles", "YellowCards" },
                values: new object[] { 2, 11, 15, 7, 401, 42, 22, 2 });

            migrationBuilder.UpdateData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "Tackles", "YellowCards" },
                values: new object[] { 10, 14, 14, 2, 555, 58, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "8AB3C6E9B986747D414E1BAEA1CAA0E3AD6E9B0149B1A9CD582B00E8FBAB5A42A54E327CFA5A4D27F3AE28DBBA14D6DC382AEEEE6BE89CD2E60BEA0A32031C6A", new byte[] { 77, 39, 61, 85, 233, 172, 144, 173, 90, 216, 159, 228, 137, 242, 190, 74, 255, 100, 53, 173, 139, 200, 208, 74, 141, 255, 70, 11, 122, 177, 252, 184, 174, 173, 103, 104, 110, 72, 88, 252, 45, 22, 47, 160, 151, 206, 100, 168, 191, 219, 215, 52, 48, 94, 53, 121, 153, 216, 238, 151, 6, 198, 114, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "04963D2E08749E581727CD0F1F9D014667935F46AEC8C24337869ABA8DC735A067EB71DA7220C946BB731992E70C06DA2C0A2412E824D111C81652EF833885CB", new byte[] { 177, 98, 174, 22, 146, 12, 240, 40, 137, 137, 23, 119, 121, 185, 171, 88, 101, 146, 81, 23, 6, 33, 189, 202, 191, 39, 235, 13, 91, 29, 175, 195, 44, 3, 126, 36, 7, 246, 182, 29, 25, 167, 185, 4, 238, 32, 87, 58, 95, 210, 140, 32, 129, 211, 118, 140, 173, 234, 118, 196, 135, 203, 89, 4 } });
        }
    }
}
