using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlayedMatchModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayedMatches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<long>(type: "bigint", nullable: false),
                    PlayerId = table.Column<long>(type: "bigint", nullable: false),
                    Minutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayedMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayedMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayedMatches_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BCD866F0EE3E25F9B521A0FC06448F952D976B5C3575A37FFBABDBC21A285E82490B44D0BC5C3F311E0665711F01E7C108CAD5F70CF763E66F1CDE4383C42D18", new byte[] { 189, 97, 139, 203, 51, 179, 134, 86, 64, 104, 54, 144, 177, 144, 219, 206, 186, 233, 140, 224, 4, 108, 182, 66, 202, 84, 204, 141, 186, 152, 32, 128, 193, 69, 247, 120, 218, 135, 119, 126, 157, 50, 208, 50, 191, 158, 115, 157, 194, 3, 214, 127, 135, 132, 227, 22, 99, 156, 24, 70, 12, 49, 72, 139 } });

            migrationBuilder.CreateIndex(
                name: "IX_PlayedMatches_MatchId",
                table: "PlayedMatches",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayedMatches_PlayerId",
                table: "PlayedMatches",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayedMatches");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4E5796E6ED5D35F6F11EEB68C1A12E8BB4016D2B7495F3D2315BA66125036A12C16DA6E4D26941E8A0930799285EFADBD8F51B0E4B13C1D3D78E0EDF1C062DC0", new byte[] { 79, 170, 226, 91, 15, 87, 174, 181, 221, 43, 52, 25, 201, 76, 27, 8, 45, 230, 128, 226, 145, 214, 88, 133, 43, 241, 42, 125, 58, 225, 143, 238, 47, 95, 12, 160, 21, 141, 58, 199, 48, 113, 85, 16, 121, 228, 16, 159, 134, 199, 12, 18, 130, 139, 182, 58, 217, 229, 70, 107, 205, 41, 147, 82 } });
        }
    }
}
