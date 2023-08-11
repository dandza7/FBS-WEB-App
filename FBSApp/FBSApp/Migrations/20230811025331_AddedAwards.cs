using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedAwards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeasonId = table.Column<long>(type: "bigint", nullable: false),
                    PlayerId = table.Column<long>(type: "bigint", nullable: true),
                    StaffId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Awards_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Awards_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Awards_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Awards",
                columns: new[] { "Id", "Date", "Month", "PlayerId", "SeasonId", "StaffId", "Type" },
                values: new object[,]
                {
                    { 1L, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "August", 221L, 1L, null, "Player of the Month" },
                    { 2L, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "September", 912L, 1L, null, "Player of the Month" },
                    { 3L, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "October", 433L, 1L, null, "Player of the Month" },
                    { 4L, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "November", 523L, 1L, null, "Player of the Month" },
                    { 5L, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "December", 633L, 1L, null, "Player of the Month" },
                    { 6L, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "January", 123L, 1L, null, "Player of the Month" },
                    { 7L, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "February", 527L, 1L, null, "Player of the Month" },
                    { 8L, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "March", 628L, 1L, null, "Player of the Month" },
                    { 9L, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "April", 2016L, 1L, null, "Player of the Month" },
                    { 10L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 633L, 1L, null, "Player of the Season" },
                    { 11L, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "August", null, 1L, 59L, "Manager of the Month" },
                    { 12L, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "September", null, 1L, 39L, "Manager of the Month" },
                    { 13L, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "October", null, 1L, 51L, "Manager of the Month" },
                    { 14L, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "November", null, 1L, 19L, "Manager of the Month" },
                    { 15L, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "December", null, 1L, 16L, "Manager of the Month" },
                    { 16L, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "January", null, 1L, 3L, "Manager of the Month" },
                    { 17L, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "February", null, 1L, 13L, "Manager of the Month" },
                    { 18L, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "March", null, 1L, 16L, "Manager of the Month" },
                    { 19L, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "April", null, 1L, 13L, "Manager of the Month" },
                    { 20L, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1L, 13L, "Manager of the Season" },
                    { 21L, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "August", 2320L, 1L, null, "Player of the Month" },
                    { 22L, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "September", 433L, 1L, null, "Player of the Month" },
                    { 23L, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "October", 2016L, 1L, null, "Player of the Month" },
                    { 24L, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "November", 628L, 1L, null, "Player of the Month" },
                    { 25L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "December", 623L, 1L, null, "Player of the Month" },
                    { 26L, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "January", 527L, 1L, null, "Player of the Month" },
                    { 27L, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "February", 110L, 1L, null, "Player of the Month" },
                    { 28L, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jun", 110L, 1L, null, "Player of the Month" },
                    { 29L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jul", 326L, 1L, null, "Player of the Month" },
                    { 30L, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 516L, 1L, null, "Player of the Season" },
                    { 31L, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "August", null, 1L, 16L, "Manager of the Month" },
                    { 32L, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "September", null, 1L, 16L, "Manager of the Month" },
                    { 33L, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "October", null, 1L, 27L, "Manager of the Month" },
                    { 34L, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "November", null, 1L, 16L, "Manager of the Month" },
                    { 35L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "December", null, 1L, 16L, "Manager of the Month" },
                    { 36L, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "January", null, 1L, 16L, "Manager of the Month" },
                    { 37L, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "February", null, 1L, 49L, "Manager of the Month" },
                    { 38L, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jun", null, 1L, 39L, "Manager of the Month" },
                    { 39L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jul", null, 1L, 57L, "Manager of the Month" },
                    { 40L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1L, 16L, "Manager of the Season" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4E5796E6ED5D35F6F11EEB68C1A12E8BB4016D2B7495F3D2315BA66125036A12C16DA6E4D26941E8A0930799285EFADBD8F51B0E4B13C1D3D78E0EDF1C062DC0", new byte[] { 79, 170, 226, 91, 15, 87, 174, 181, 221, 43, 52, 25, 201, 76, 27, 8, 45, 230, 128, 226, 145, 214, 88, 133, 43, 241, 42, 125, 58, 225, 143, 238, 47, 95, 12, 160, 21, 141, 58, 199, 48, 113, 85, 16, 121, 228, 16, 159, 134, 199, 12, 18, 130, 139, 182, 58, 217, 229, 70, 107, 205, 41, 147, 82 } });

            migrationBuilder.CreateIndex(
                name: "IX_Awards_PlayerId",
                table: "Awards",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_SeasonId",
                table: "Awards",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_StaffId",
                table: "Awards",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "32BB1F434CCAB0927051C7E713D0E487FD30DAA1B0E923FA50A397648D17DD2387553FD01A3628441E3EE28A153C654A9D060C29801AF22964A219A353F36A7C", new byte[] { 34, 26, 99, 91, 248, 182, 187, 184, 245, 175, 6, 217, 77, 130, 215, 94, 62, 251, 231, 169, 58, 2, 206, 17, 215, 102, 209, 43, 240, 20, 43, 139, 35, 230, 3, 178, 85, 50, 104, 49, 153, 232, 226, 39, 15, 57, 208, 138, 21, 139, 147, 91, 191, 126, 116, 28, 41, 190, 1, 236, 232, 236, 170, 125 } });
        }
    }
}
