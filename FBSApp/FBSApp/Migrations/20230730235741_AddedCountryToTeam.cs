using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountryToTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Teams",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CountryId",
                value: 195L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CountryId",
                value: 54L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6617E8CA4FB09B09AD60CA83D4386D10C03CF0668107485212BC431305E7F2ED89192C992B31AF37894B0CBCA05AD7060CC6D0C13209759E997974FF14FF5B79", new byte[] { 158, 27, 52, 50, 186, 233, 12, 138, 76, 6, 238, 244, 75, 69, 29, 233, 132, 152, 115, 223, 141, 176, 2, 41, 209, 43, 95, 75, 24, 220, 0, 75, 139, 245, 157, 89, 3, 226, 209, 91, 232, 96, 92, 18, 134, 8, 211, 93, 144, 80, 210, 67, 181, 15, 243, 39, 235, 155, 240, 152, 174, 135, 6, 198 } });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CountryId",
                table: "Teams",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Countries_CountryId",
                table: "Teams",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Countries_CountryId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CountryId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "292EC360C5465021CE4D00E9AE9817CE231194940CF6CE9FDBEC486E73D9D30E6808758A8B6FCDF5EB0FFAB191A584327A4889240B5E485B4FBA6CA97E4FCEFE", new byte[] { 49, 104, 76, 160, 188, 31, 175, 86, 209, 169, 173, 143, 19, 233, 200, 99, 247, 85, 121, 245, 100, 242, 89, 124, 135, 133, 6, 93, 20, 249, 229, 170, 2, 109, 34, 239, 18, 212, 125, 236, 209, 196, 97, 209, 63, 30, 79, 142, 241, 89, 184, 63, 177, 150, 138, 119, 206, 93, 133, 137, 49, 149, 22, 234 } });
        }
    }
}
