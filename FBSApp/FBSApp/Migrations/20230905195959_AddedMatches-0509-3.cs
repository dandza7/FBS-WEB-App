using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches05093 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 254100L, true, 254L, 58, 1612L },
                    { 254101L, false, 254L, 32, 1614L },
                    { 254102L, true, 254L, 76, 1606L },
                    { 254103L, false, 254L, 14, 1621L },
                    { 254104L, true, 254L, 81, 1608L },
                    { 254105L, false, 254L, 9, 1623L },
                    { 254106L, true, 254L, 90, 1627L },
                    { 254107L, true, 254L, 90, 1622L },
                    { 254108L, true, 254L, 90, 1610L },
                    { 254109L, true, 254L, 90, 1604L },
                    { 254110L, true, 254L, 90, 1605L },
                    { 254111L, true, 254L, 90, 1602L },
                    { 254112L, true, 254L, 90, 1609L },
                    { 254113L, true, 254L, 90, 1601L },
                    { 254114L, false, 254L, 0, 1603L },
                    { 254115L, false, 254L, 0, 1613L },
                    { 254116L, false, 254L, 0, 1617L },
                    { 254117L, false, 254L, 0, 1625L },
                    { 254200L, true, 254L, 27, 1905L },
                    { 254201L, false, 254L, 63, 1928L },
                    { 254202L, true, 254L, 77, 1931L },
                    { 254203L, false, 254L, 13, 1935L },
                    { 254204L, true, 254L, 87, 1922L },
                    { 254205L, false, 254L, 3, 1903L },
                    { 254206L, true, 254L, 90, 1900L },
                    { 254207L, true, 254L, 90, 1911L },
                    { 254208L, true, 254L, 90, 1907L },
                    { 254209L, true, 254L, 90, 1912L },
                    { 254210L, true, 254L, 90, 1910L },
                    { 254211L, true, 254L, 90, 1902L },
                    { 254212L, true, 254L, 90, 1924L },
                    { 254213L, true, 254L, 90, 824L },
                    { 254214L, false, 254L, 0, 1920L },
                    { 254215L, false, 254L, 0, 1901L },
                    { 254216L, false, 254L, 0, 1913L },
                    { 255100L, true, 255L, 72, 1219L },
                    { 255101L, false, 255L, 18, 1217L },
                    { 255102L, true, 255L, 90, 1230L },
                    { 255103L, true, 255L, 90, 1229L },
                    { 255104L, true, 255L, 90, 1236L },
                    { 255105L, true, 255L, 90, 1227L },
                    { 255106L, true, 255L, 90, 1218L },
                    { 255107L, true, 255L, 90, 1232L },
                    { 255108L, true, 255L, 90, 1215L },
                    { 255109L, true, 255L, 90, 1245L },
                    { 255110L, true, 255L, 90, 1237L },
                    { 255111L, true, 255L, 90, 1224L },
                    { 255112L, false, 255L, 0, 1226L },
                    { 255113L, false, 255L, 0, 1213L },
                    { 255114L, false, 255L, 0, 1214L },
                    { 255115L, false, 255L, 0, 1205L },
                    { 255116L, false, 255L, 0, 1209L },
                    { 255117L, false, 255L, 0, 1206L },
                    { 255200L, true, 255L, 70, 2117L },
                    { 255201L, false, 255L, 20, 2104L },
                    { 255202L, true, 255L, 81, 2128L },
                    { 255203L, false, 255L, 9, 2115L },
                    { 255204L, true, 255L, 90, 2106L },
                    { 255205L, true, 255L, 90, 2113L },
                    { 255206L, true, 255L, 90, 2103L },
                    { 255207L, true, 255L, 90, 2110L },
                    { 255208L, true, 255L, 90, 2125L },
                    { 255209L, true, 255L, 90, 2138L },
                    { 255210L, true, 255L, 90, 2116L },
                    { 255211L, true, 255L, 90, 2141L },
                    { 255212L, true, 255L, 90, 2140L },
                    { 255213L, false, 255L, 0, 2132L },
                    { 255214L, false, 255L, 0, 2133L },
                    { 255215L, false, 255L, 0, 2119L },
                    { 255216L, false, 255L, 0, 2102L },
                    { 255217L, false, 255L, 0, 2101L },
                    { 256100L, true, 256L, 69, 1812L },
                    { 256101L, false, 256L, 21, 1813L },
                    { 256102L, true, 256L, 83, 1022L },
                    { 256103L, false, 256L, 7, 1815L },
                    { 256104L, true, 256L, 86, 1802L },
                    { 256105L, false, 256L, 4, 1816L },
                    { 256106L, true, 256L, 90, 1821L },
                    { 256107L, true, 256L, 90, 1817L },
                    { 256108L, true, 256L, 90, 1803L },
                    { 256109L, true, 256L, 90, 1824L },
                    { 256110L, true, 256L, 90, 1810L },
                    { 256111L, true, 256L, 90, 1804L },
                    { 256112L, true, 256L, 90, 1801L },
                    { 256113L, true, 256L, 90, 1811L },
                    { 256114L, false, 256L, 0, 1807L },
                    { 256115L, false, 256L, 0, 1822L },
                    { 256116L, false, 256L, 0, 1820L },
                    { 256117L, false, 256L, 0, 1800L },
                    { 256200L, true, 256L, 62, 1723L },
                    { 256201L, false, 256L, 28, 1721L },
                    { 256202L, true, 256L, 62, 1713L },
                    { 256203L, false, 256L, 28, 1118L },
                    { 256204L, true, 256L, 69, 1710L },
                    { 256205L, false, 256L, 21, 1719L },
                    { 256206L, true, 256L, 90, 1705L },
                    { 256207L, true, 256L, 90, 623L },
                    { 256208L, true, 256L, 90, 1733L },
                    { 256209L, true, 256L, 90, 1728L },
                    { 256210L, true, 256L, 90, 1701L },
                    { 256211L, true, 256L, 90, 1703L },
                    { 256212L, true, 256L, 90, 1730L },
                    { 256213L, true, 256L, 90, 1722L },
                    { 256214L, false, 256L, 0, 1706L },
                    { 256215L, false, 256L, 0, 1708L },
                    { 256216L, false, 256L, 0, 1709L },
                    { 256217L, false, 256L, 0, 1712L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "A3817FCDD6BDDAD86DF36588587799D89F598BD9615BCE59FA23718563C8CB916ED9CD045BD56EEF77A4E722262D4C0BEAA63D796889B7673A8CC5C771E903C1", new byte[] { 217, 121, 223, 239, 221, 47, 129, 121, 128, 124, 253, 81, 254, 181, 32, 84, 136, 205, 30, 201, 148, 23, 25, 104, 182, 117, 80, 185, 121, 132, 188, 35, 11, 241, 65, 228, 40, 5, 55, 172, 141, 240, 141, 249, 22, 86, 108, 134, 240, 72, 104, 20, 191, 27, 230, 37, 189, 180, 170, 250, 83, 95, 94, 42 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "2A4603D5ADE10784FC158232B63FF3F3531C8026A71CFBC515B3869D9D087D5903D7B8EB5BBB71AB73745FFD3492554A3129961FFF528AA4BAE0E87C30C75FC5", new byte[] { 191, 7, 167, 116, 120, 205, 222, 23, 180, 154, 247, 195, 74, 65, 194, 226, 242, 184, 33, 99, 94, 84, 236, 85, 217, 75, 41, 58, 46, 119, 229, 59, 20, 240, 139, 15, 12, 13, 83, 193, 177, 214, 175, 240, 152, 183, 180, 238, 155, 66, 29, 156, 170, 158, 172, 238, 85, 180, 62, 52, 150, 74, 182, 67 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 254216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 255217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 256217L);

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
    }
}
