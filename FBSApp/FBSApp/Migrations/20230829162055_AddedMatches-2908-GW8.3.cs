using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW83 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 8011L, 80113L, false, false, 25 },
                    { 8211L, 82111L, false, false, 8 },
                    { 8311L, 83104L, false, false, 40 },
                    { 8321L, 83212L, false, false, 77 },
                    { 8322L, 83213L, false, false, 7 },
                    { 8421L, 84210L, false, false, 56 },
                    { 8511L, 85104L, false, false, 20 },
                    { 8512L, 85109L, false, false, 66 },
                    { 8611L, 86101L, false, false, 70 },
                    { 8612L, 86105L, false, false, 90 },
                    { 8613L, 86113L, false, false, 76 },
                    { 8621L, 86200L, false, false, 7 },
                    { 8622L, 86202L, false, false, 10 },
                    { 8711L, 87113L, false, false, 44 },
                    { 8721L, 87201L, false, false, 79 },
                    { 8722L, 87201L, true, false, 90 },
                    { 8723L, 87203L, false, false, 67 },
                    { 8724L, 87204L, false, false, 29 },
                    { 8725L, 87204L, false, false, 49 },
                    { 8821L, 88201L, true, false, 90 },
                    { 8822L, 88204L, false, false, 57 },
                    { 8823L, 88213L, false, false, 30 }
                });

            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 81100L, true, 81L, 55, 2141L },
                    { 81101L, false, 81L, 35, 2103L },
                    { 81102L, true, 81L, 55, 2104L },
                    { 81103L, false, 81L, 35, 2121L },
                    { 81104L, true, 81L, 74, 2134L },
                    { 81105L, false, 81L, 16, 2117L },
                    { 81106L, true, 81L, 90, 2106L },
                    { 81107L, true, 81L, 90, 2129L },
                    { 81108L, true, 81L, 90, 2110L },
                    { 81109L, true, 81L, 90, 2109L },
                    { 81110L, true, 81L, 90, 2125L },
                    { 81111L, true, 81L, 90, 2116L },
                    { 81112L, true, 81L, 90, 2100L },
                    { 81113L, true, 81L, 90, 2140L },
                    { 81114L, false, 81L, 0, 2133L },
                    { 81115L, false, 81L, 0, 2119L },
                    { 81116L, false, 81L, 0, 2102L },
                    { 81117L, false, 81L, 0, 2128L },
                    { 81200L, true, 81L, 66, 1730L },
                    { 81201L, false, 81L, 24, 1723L },
                    { 81202L, true, 81L, 70, 1711L },
                    { 81203L, false, 81L, 20, 1710L },
                    { 81204L, true, 81L, 78, 1724L },
                    { 81205L, false, 81L, 12, 1703L },
                    { 81206L, true, 81L, 90, 1706L },
                    { 81207L, true, 81L, 90, 1732L },
                    { 81208L, true, 81L, 90, 1733L },
                    { 81209L, true, 81L, 90, 1728L },
                    { 81210L, true, 81L, 90, 1701L },
                    { 81211L, true, 81L, 90, 1719L },
                    { 81212L, true, 81L, 90, 1722L },
                    { 81213L, true, 81L, 90, 1707L },
                    { 81214L, false, 81L, 0, 1705L },
                    { 81215L, false, 81L, 0, 1720L },
                    { 81216L, false, 81L, 0, 1721L },
                    { 81217L, false, 81L, 0, 1712L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 891L, 1, 2, 10, 15, 2, 515, 49, 0, 2, 7, 2, 17, 891L, 1 },
                    { 892L, 1, 6, 10, 11, 5, 528, 51, 0, 2, 6, 2, 16, 892L, 3 }
                });

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

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 8121L, 81202L, false, false, 14 },
                    { 8122L, 81212L, false, false, 33 },
                    { 8123L, 81212L, false, false, 45 },
                    { 8124L, 81213L, false, false, 47 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8122L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8123L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8124L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8322L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8612L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8613L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8622L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8722L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8723L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8724L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8725L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8822L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8823L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 891L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 892L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 81213L);

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
    }
}
