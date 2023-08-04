using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedM2MRelationShipBetweenTeamAndSeason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeasonTeam",
                columns: table => new
                {
                    SeasonsId = table.Column<long>(type: "bigint", nullable: false),
                    TeamsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonTeam", x => new { x.SeasonsId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_SeasonTeam_Seasons_SeasonsId",
                        column: x => x.SeasonsId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeasonTeam_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BC6E5EEF1440BC2F178B209B27AD232F664187F56C27AF9B9797C1B60C3684961D12D839FAEE38238AAF1352BE7A31B9BA67878115BBEB1DCBC7EB1F9172D35E", new byte[] { 178, 28, 37, 161, 183, 162, 163, 4, 104, 33, 152, 157, 138, 93, 146, 75, 117, 149, 199, 151, 77, 83, 249, 81, 52, 43, 120, 237, 79, 129, 97, 208, 35, 122, 144, 243, 188, 122, 143, 179, 26, 246, 217, 255, 108, 142, 9, 82, 107, 94, 40, 96, 96, 159, 81, 103, 5, 103, 198, 132, 225, 233, 134, 163 } });

            migrationBuilder.CreateIndex(
                name: "IX_SeasonTeam_TeamsId",
                table: "SeasonTeam",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeasonTeam");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "755BD69776389DBD4A4E2FEB60DC5E2AB018D46EDA3B2C4DECD45AC61F2F2FD8C26F4594909FE1B3CFD2D64279B7195EB3479A433B92706ECB630D79EA5F8387", new byte[] { 4, 56, 143, 222, 228, 0, 65, 231, 171, 21, 221, 211, 34, 70, 22, 135, 223, 241, 23, 250, 173, 241, 201, 111, 36, 174, 200, 24, 146, 145, 184, 39, 189, 77, 9, 138, 53, 64, 159, 1, 25, 242, 201, 195, 127, 156, 57, 84, 122, 133, 16, 25, 172, 32, 193, 140, 50, 50, 146, 179, 73, 63, 172, 187 } });
        }
    }
}
