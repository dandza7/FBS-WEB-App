using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches05092 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 250100L, true, 250L, 60, 221L },
                    { 250101L, false, 250L, 30, 208L },
                    { 250102L, true, 250L, 78, 207L },
                    { 250103L, false, 250L, 12, 203L },
                    { 250104L, true, 250L, 89, 214L },
                    { 250105L, false, 250L, 1, 206L },
                    { 250106L, true, 250L, 90, 215L },
                    { 250107L, true, 250L, 90, 219L },
                    { 250108L, true, 250L, 90, 204L },
                    { 250109L, true, 250L, 90, 231L },
                    { 250110L, true, 250L, 90, 216L },
                    { 250111L, true, 250L, 90, 224L },
                    { 250112L, true, 250L, 90, 213L },
                    { 250113L, true, 250L, 90, 202L },
                    { 250114L, false, 250L, 0, 218L },
                    { 250115L, false, 250L, 0, 226L },
                    { 250116L, false, 250L, 0, 220L },
                    { 250117L, false, 250L, 0, 232L },
                    { 250200L, true, 250L, 82, 704L },
                    { 250201L, false, 250L, 8, 725L },
                    { 250202L, true, 250L, 86, 727L },
                    { 250203L, false, 250L, 4, 701L },
                    { 250204L, true, 250L, 90, 726L },
                    { 250205L, true, 250L, 90, 706L },
                    { 250206L, true, 250L, 90, 709L },
                    { 250207L, true, 250L, 90, 716L },
                    { 250208L, true, 250L, 90, 711L },
                    { 250209L, true, 250L, 90, 702L },
                    { 250210L, true, 250L, 90, 735L },
                    { 250211L, true, 250L, 90, 714L },
                    { 250212L, true, 250L, 90, 734L },
                    { 250213L, false, 250L, 0, 705L },
                    { 250214L, false, 250L, 0, 710L },
                    { 250215L, false, 250L, 0, 722L },
                    { 250216L, false, 250L, 0, 718L },
                    { 250217L, false, 250L, 0, 712L },
                    { 251100L, true, 251L, 37, 1015L },
                    { 251101L, false, 251L, 53, 1012L },
                    { 251102L, true, 251L, 60, 1027L },
                    { 251103L, false, 251L, 30, 1000L },
                    { 251104L, true, 251L, 73, 1026L },
                    { 251105L, false, 251L, 17, 1006L },
                    { 251106L, true, 251L, 90, 1013L },
                    { 251107L, true, 251L, 90, 1019L },
                    { 251108L, true, 251L, 90, 924L },
                    { 251109L, true, 251L, 90, 1028L },
                    { 251110L, true, 251L, 90, 1001L },
                    { 251111L, true, 251L, 90, 1007L },
                    { 251112L, true, 251L, 90, 1024L },
                    { 251113L, true, 251L, 90, 1004L },
                    { 251114L, false, 251L, 0, 1003L },
                    { 251115L, false, 251L, 0, 1009L },
                    { 251116L, false, 251L, 0, 1021L },
                    { 251117L, false, 251L, 0, 1017L },
                    { 251200L, true, 251L, 49, 1320L },
                    { 251201L, false, 251L, 41, 1319L },
                    { 251202L, true, 251L, 77, 1304L },
                    { 251203L, false, 251L, 13, 1305L },
                    { 251204L, true, 251L, 89, 1318L },
                    { 251205L, false, 251L, 1, 1300L },
                    { 251206L, true, 251L, 90, 1322L },
                    { 251207L, true, 251L, 90, 1323L },
                    { 251208L, true, 251L, 90, 1302L },
                    { 251209L, true, 251L, 90, 1325L },
                    { 251210L, true, 251L, 90, 1313L },
                    { 251211L, true, 251L, 90, 1311L },
                    { 251212L, true, 251L, 90, 1308L },
                    { 251213L, true, 251L, 90, 1310L },
                    { 251214L, false, 251L, 0, 1306L },
                    { 251215L, false, 251L, 0, 1315L },
                    { 251216L, false, 251L, 0, 1309L },
                    { 252100L, true, 252L, 72, 1405L },
                    { 252101L, false, 252L, 18, 1420L },
                    { 252102L, true, 252L, 82, 1414L },
                    { 252103L, false, 252L, 8, 931L },
                    { 252104L, true, 252L, 89, 1411L },
                    { 252105L, false, 252L, 1, 1402L },
                    { 252106L, true, 252L, 90, 1429L },
                    { 252107L, true, 252L, 90, 100L },
                    { 252108L, true, 252L, 90, 1409L },
                    { 252109L, true, 252L, 90, 1418L },
                    { 252110L, true, 252L, 90, 1422L },
                    { 252111L, true, 252L, 90, 1401L },
                    { 252112L, true, 252L, 90, 1408L },
                    { 252113L, true, 252L, 90, 1416L },
                    { 252114L, false, 252L, 0, 1425L },
                    { 252115L, false, 252L, 0, 1431L },
                    { 252116L, false, 252L, 0, 1419L },
                    { 252117L, false, 252L, 0, 1407L },
                    { 252200L, true, 252L, 46, 1519L },
                    { 252201L, false, 252L, 44, 1524L },
                    { 252202L, true, 252L, 62, 1501L },
                    { 252203L, false, 252L, 28, 134L },
                    { 252204L, true, 252L, 88, 1527L },
                    { 252205L, false, 252L, 2, 1526L },
                    { 252206L, true, 252L, 90, 1517L },
                    { 252207L, true, 252L, 90, 1502L },
                    { 252208L, true, 252L, 90, 1515L },
                    { 252209L, true, 252L, 90, 406L },
                    { 252210L, true, 252L, 90, 1507L },
                    { 252211L, true, 252L, 90, 1508L },
                    { 252212L, true, 252L, 90, 1520L },
                    { 252213L, true, 252L, 90, 1525L },
                    { 252214L, false, 252L, 0, 1506L },
                    { 252215L, false, 252L, 0, 1503L },
                    { 252216L, false, 252L, 0, 1516L },
                    { 252217L, false, 252L, 0, 227L },
                    { 253100L, true, 253L, 70, 922L },
                    { 253101L, false, 253L, 20, 930L },
                    { 253102L, true, 253L, 77, 912L },
                    { 253103L, false, 253L, 13, 904L },
                    { 253104L, true, 253L, 83, 932L },
                    { 253105L, false, 253L, 7, 938L },
                    { 253106L, true, 253L, 90, 923L },
                    { 253107L, true, 253L, 90, 905L },
                    { 253108L, true, 253L, 90, 900L },
                    { 253109L, true, 253L, 90, 909L },
                    { 253110L, true, 253L, 90, 928L },
                    { 253111L, true, 253L, 90, 937L },
                    { 253112L, true, 253L, 90, 941L },
                    { 253113L, true, 253L, 90, 918L },
                    { 253114L, false, 253L, 0, 942L },
                    { 253115L, false, 253L, 0, 933L },
                    { 253116L, false, 253L, 0, 934L },
                    { 253117L, false, 253L, 0, 901L },
                    { 253200L, true, 253L, 27, 2212L },
                    { 253201L, false, 253L, 63, 2224L },
                    { 253202L, true, 253L, 67, 1729L },
                    { 253203L, false, 253L, 23, 2218L },
                    { 253204L, true, 253L, 84, 2202L },
                    { 253205L, false, 253L, 6, 2203L },
                    { 253206L, true, 253L, 90, 2215L },
                    { 253207L, true, 253L, 90, 2226L },
                    { 253208L, true, 253L, 90, 2206L },
                    { 253209L, true, 253L, 90, 2225L },
                    { 253210L, true, 253L, 90, 2205L },
                    { 253211L, true, 253L, 90, 2217L },
                    { 253212L, true, 253L, 90, 1201L },
                    { 253213L, true, 253L, 90, 2227L },
                    { 253214L, false, 253L, 0, 2211L },
                    { 253215L, false, 253L, 0, 2204L },
                    { 253216L, false, 253L, 0, 1410L },
                    { 253217L, false, 253L, 0, 2220L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "771CE3A9D940D00D18A6AC6B2C81886B1D9BC112D1020CBC877BF71F90268CD933F55E7622B8321CA9A38A1A7C2745CD18016653792E2392B77E86A87B9A4171", new byte[] { 103, 113, 238, 199, 214, 132, 208, 102, 135, 32, 69, 42, 28, 57, 179, 90, 41, 143, 212, 66, 56, 241, 210, 147, 150, 104, 238, 80, 6, 86, 197, 72, 5, 167, 120, 71, 123, 136, 70, 15, 237, 178, 108, 104, 156, 136, 228, 217, 125, 154, 188, 140, 57, 245, 11, 141, 188, 91, 133, 109, 54, 225, 65, 86 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E908C8C8CADEE9339D4D3176B04E3EB1B43C13559B873193A53C129FE21FBC4E8DFDA1537E6A19C2E1E7E2D0205C3E4273C73A59984CE28ADE88D26D241BF9F0", new byte[] { 77, 70, 175, 204, 96, 171, 62, 233, 247, 150, 31, 4, 231, 15, 232, 144, 15, 230, 193, 191, 7, 162, 217, 10, 48, 16, 69, 109, 46, 237, 255, 213, 144, 216, 62, 81, 176, 137, 176, 187, 79, 25, 13, 151, 88, 193, 214, 144, 110, 172, 72, 30, 28, 19, 130, 62, 205, 254, 32, 166, 146, 45, 72, 94 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 250217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 251216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 252217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 253217L);

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
    }
}
