using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches05094 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 257100L, true, 257L, 62, 2015L },
                    { 257101L, false, 257L, 28, 2025L },
                    { 257102L, true, 257L, 74, 2017L },
                    { 257103L, false, 257L, 16, 2027L },
                    { 257104L, true, 257L, 84, 2024L },
                    { 257105L, false, 257L, 6, 2019L },
                    { 257106L, true, 257L, 90, 2018L },
                    { 257107L, true, 257L, 90, 2026L },
                    { 257108L, true, 257L, 90, 2017L },
                    { 257109L, true, 257L, 90, 117L },
                    { 257110L, true, 257L, 90, 2002L },
                    { 257111L, true, 257L, 90, 2030L },
                    { 257112L, true, 257L, 90, 2013L },
                    { 257113L, true, 257L, 90, 2016L },
                    { 257114L, false, 257L, 0, 2012L },
                    { 257115L, false, 257L, 0, 2014L },
                    { 257116L, false, 257L, 0, 2029L },
                    { 257200L, true, 257L, 67, 101L },
                    { 257201L, false, 257L, 23, 105L },
                    { 257202L, true, 257L, 78, 123L },
                    { 257203L, false, 257L, 12, 131L },
                    { 257204L, true, 257L, 89, 119L },
                    { 257205L, false, 257L, 1, 130L },
                    { 257206L, true, 257L, 90, 113L },
                    { 257207L, true, 257L, 90, 107L },
                    { 257208L, true, 257L, 90, 115L },
                    { 257209L, true, 257L, 90, 135L },
                    { 257210L, true, 257L, 90, 121L },
                    { 257211L, true, 257L, 90, 102L },
                    { 257212L, true, 257L, 90, 127L },
                    { 257213L, true, 257L, 90, 129L },
                    { 257214L, false, 257L, 0, 114L },
                    { 257215L, false, 257L, 0, 116L },
                    { 257216L, false, 257L, 0, 120L },
                    { 258100L, true, 258L, 81, 527L },
                    { 258101L, false, 258L, 9, 512L },
                    { 258102L, true, 258L, 88, 516L },
                    { 258103L, false, 258L, 2, 524L },
                    { 258104L, true, 258L, 90, 507L },
                    { 258105L, true, 258L, 90, 517L },
                    { 258106L, true, 258L, 90, 511L },
                    { 258107L, true, 258L, 90, 519L },
                    { 258108L, true, 258L, 90, 500L },
                    { 258109L, true, 258L, 90, 513L },
                    { 258110L, true, 258L, 90, 506L },
                    { 258111L, true, 258L, 90, 502L },
                    { 258112L, true, 258L, 90, 523L },
                    { 258114L, false, 258L, 0, 505L },
                    { 258115L, false, 258L, 0, 510L },
                    { 258116L, false, 258L, 0, 518L },
                    { 258117L, false, 258L, 0, 515L },
                    { 258200L, true, 258L, 66, 402L },
                    { 258201L, false, 258L, 24, 400L },
                    { 258202L, true, 258L, 66, 436L },
                    { 258203L, false, 258L, 24, 412L },
                    { 258204L, true, 258L, 79, 437L },
                    { 258205L, false, 258L, 11, 422L },
                    { 258206L, true, 258L, 90, 404L },
                    { 258207L, true, 258L, 90, 439L },
                    { 258208L, true, 258L, 90, 423L },
                    { 258209L, true, 258L, 90, 429L },
                    { 258210L, true, 258L, 90, 424L },
                    { 258211L, true, 258L, 90, 426L },
                    { 258212L, true, 258L, 90, 403L },
                    { 258213L, true, 258L, 90, 433L },
                    { 258214L, false, 258L, 0, 432L },
                    { 258215L, false, 258L, 0, 428L },
                    { 258216L, false, 258L, 0, 413L },
                    { 258217L, false, 258L, 0, 427L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "A5203348A5DC8A400E8BBCFB8C01B906A5790C1D1C1E3824F46C734DFA87DB537B1743E9F7BA1095A00E628ECC6504DD6E9C300976171B962A43F7615ED6FC9A", new byte[] { 64, 62, 180, 91, 122, 84, 92, 2, 198, 61, 0, 87, 62, 210, 185, 28, 227, 137, 182, 213, 145, 204, 91, 195, 158, 248, 218, 135, 96, 62, 57, 179, 245, 172, 221, 176, 52, 90, 130, 142, 153, 176, 255, 91, 8, 172, 244, 95, 10, 171, 86, 172, 74, 185, 138, 96, 235, 25, 154, 87, 78, 160, 39, 69 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "38EFE0AB47F9D2FC5527DD924CCE07405C65905843169F7DE37AF94C9889974CE956A8B19B88B329ED34EC7074A19D38AD05CD1A6EE4B6B14F95E06E148890A4", new byte[] { 34, 228, 11, 25, 149, 78, 25, 111, 147, 161, 251, 84, 83, 58, 190, 67, 159, 123, 7, 183, 59, 198, 53, 136, 142, 122, 245, 233, 157, 188, 231, 96, 71, 116, 5, 94, 106, 86, 231, 187, 214, 152, 64, 254, 153, 132, 177, 138, 35, 25, 105, 101, 77, 75, 101, 35, 94, 255, 210, 12, 215, 158, 128, 119 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 257216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 258217L);

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
    }
}
