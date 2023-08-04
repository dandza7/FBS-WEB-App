using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class JunicionTableRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.CreateTable(
                name: "TeamSeason",
                columns: table => new
                {
                    SeasonId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamSeason", x => new { x.SeasonId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_TeamSeason_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamSeason_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TeamSeason",
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
                values: new object[] { "9BDD54F916FEC9F6D0B9A500EBCCBD79A000A785B7FB642E8D844DB131BDE7E9241F2B93D9DD6006B2D9E44BCD9735925D59E45AE5E60AF07776964618B8B809", new byte[] { 9, 227, 214, 220, 220, 135, 101, 98, 57, 162, 165, 70, 0, 96, 72, 197, 188, 55, 28, 93, 161, 129, 137, 223, 66, 20, 244, 140, 23, 136, 123, 84, 61, 86, 244, 81, 0, 48, 151, 136, 194, 0, 144, 52, 161, 8, 79, 186, 227, 225, 97, 141, 104, 178, 19, 188, 79, 221, 30, 116, 245, 152, 88, 127 } });

            migrationBuilder.CreateIndex(
                name: "IX_TeamSeason_TeamId",
                table: "TeamSeason",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamSeason");

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
    }
}
