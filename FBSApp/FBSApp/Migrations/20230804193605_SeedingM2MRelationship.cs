using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedingM2MRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeasonTeam");

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    SeasonId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.SeasonId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_PostTag_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 1L, 2L },
                    { 1L, 4L },
                    { 1L, 5L },
                    { 1L, 6L },
                    { 1L, 9L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "A944CE7859FE6C8181914CF167922391075535D51511F76E50988959CF65FD6FE11E1278A51E9CD630D0046755142DD6200DE51EEB9D3D5E58C15F6E72B24B54", new byte[] { 0, 163, 99, 159, 126, 168, 94, 33, 119, 69, 121, 123, 86, 7, 158, 66, 147, 236, 204, 196, 115, 40, 253, 58, 144, 30, 159, 74, 67, 239, 184, 76, 104, 173, 24, 146, 61, 136, 248, 160, 188, 57, 218, 144, 43, 115, 57, 216, 158, 202, 34, 234, 80, 18, 224, 18, 108, 91, 61, 192, 28, 255, 194, 15 } });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TeamId",
                table: "PostTag",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

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
    }
}
