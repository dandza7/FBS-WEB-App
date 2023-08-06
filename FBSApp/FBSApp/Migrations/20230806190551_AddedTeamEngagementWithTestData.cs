using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedTeamEngagementWithTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Seasons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Seasons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TeamEngagement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    PlayerId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamEngagement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamEngagement_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeamEngagement_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "LeagueId", "StartDate", "Year" },
                values: new object[] { 2L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "2019/20   [TEST]" });

            migrationBuilder.InsertData(
                table: "TeamEngagement",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 110L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 2L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 129L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 3L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 113L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 4L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 123L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 5L, new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 131L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 6L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 131L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 7L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 905L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 8L, new DateTime(2019, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 918L, new DateTime(2018, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L },
                    { 9L, new DateTime(2020, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 929L, new DateTime(2019, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 9L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "186FEEE2AF809BFCC63D1736AA244CE61D1C051CB349BE023590B365398B9A3D4254D8D345C35BCDADE1238CCEC0AEE7CFCC5DC024CFB56BB638974D8E39D2B5", new byte[] { 217, 223, 198, 173, 223, 55, 186, 128, 119, 203, 101, 21, 22, 7, 184, 178, 175, 254, 226, 236, 25, 152, 137, 189, 11, 254, 184, 131, 129, 114, 186, 66, 200, 104, 139, 239, 121, 47, 57, 210, 78, 43, 209, 93, 67, 248, 82, 9, 63, 92, 233, 183, 113, 39, 140, 112, 136, 33, 153, 81, 198, 86, 30, 101 } });

            migrationBuilder.CreateIndex(
                name: "IX_TeamEngagement_PlayerId",
                table: "TeamEngagement",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamEngagement_TeamId",
                table: "TeamEngagement",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamEngagement");

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Seasons");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "AA45DAD2921B6D4D97A24407E4B263C41FE1725BD9E7444AA9DA6ABB9AC810C22FE1A7A54D1E5482796A2E0AAD3553B509AC4078A8CBE1655815B7A10D267B06", new byte[] { 27, 92, 191, 38, 95, 69, 93, 8, 126, 215, 54, 42, 46, 178, 249, 174, 182, 234, 253, 25, 176, 234, 7, 19, 119, 112, 86, 222, 247, 18, 72, 213, 173, 174, 238, 79, 137, 111, 184, 205, 197, 141, 74, 119, 183, 227, 31, 96, 109, 155, 249, 55, 162, 92, 152, 25, 117, 154, 6, 110, 109, 232, 12, 58 } });
        }
    }
}
