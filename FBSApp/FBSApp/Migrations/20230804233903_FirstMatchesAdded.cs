using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class FirstMatchesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gameweek = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeasonId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchActors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    IsTeamHost = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchActors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchActors_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchActors_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "Gameweek", "SeasonId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1L },
                    { 2L, new DateTime(2018, 12, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), 1, 1L },
                    { 3L, new DateTime(2018, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, 1L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "88B1F73EFFA91C273E5F564E93F0868A6529B1514D88E9E0DFC1D2846D5AAC11BE6E91825B16B20F84F51ECE15082424C498E8A2B10E9AD5A362FC533B283206", new byte[] { 65, 188, 69, 215, 55, 192, 123, 131, 36, 127, 120, 113, 253, 206, 87, 91, 117, 115, 215, 151, 225, 22, 77, 222, 191, 213, 8, 184, 108, 236, 166, 239, 98, 193, 220, 163, 146, 69, 126, 21, 153, 107, 148, 248, 1, 156, 171, 196, 83, 78, 23, 143, 125, 57, 232, 95, 90, 79, 241, 16, 240, 172, 239, 46 } });

            migrationBuilder.InsertData(
                table: "MatchActors",
                columns: new[] { "Id", "IsTeamHost", "MatchId", "TeamId" },
                values: new object[,]
                {
                    { 1L, true, 1L, 1L },
                    { 2L, false, 1L, 9L },
                    { 3L, true, 2L, 2L },
                    { 4L, false, 2L, 5L },
                    { 5L, true, 3L, 6L },
                    { 6L, false, 3L, 4L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchActors_MatchId",
                table: "MatchActors",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchActors_TeamId",
                table: "MatchActors",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SeasonId",
                table: "Matches",
                column: "SeasonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchActors");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9BDD54F916FEC9F6D0B9A500EBCCBD79A000A785B7FB642E8D844DB131BDE7E9241F2B93D9DD6006B2D9E44BCD9735925D59E45AE5E60AF07776964618B8B809", new byte[] { 9, 227, 214, 220, 220, 135, 101, 98, 57, 162, 165, 70, 0, 96, 72, 197, 188, 55, 28, 93, 161, 129, 137, 223, 66, 20, 244, 140, 23, 136, 123, 84, 61, 86, 244, 81, 0, 48, 151, 136, 194, 0, 144, 52, 161, 8, 79, 186, 227, 225, 97, 141, 104, 178, 19, 188, 79, 221, 30, 116, 245, 152, 88, 127 } });
        }
    }
}
