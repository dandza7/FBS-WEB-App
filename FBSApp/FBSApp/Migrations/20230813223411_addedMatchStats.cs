using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedMatchStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamStats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shots = table.Column<int>(type: "int", nullable: false),
                    ShotsOnTarget = table.Column<int>(type: "int", nullable: false),
                    BlockedShots = table.Column<int>(type: "int", nullable: false),
                    FreeKicks = table.Column<int>(type: "int", nullable: false),
                    CornerKicks = table.Column<int>(type: "int", nullable: false),
                    Offsides = table.Column<int>(type: "int", nullable: false),
                    Possession = table.Column<int>(type: "int", nullable: false),
                    Saves = table.Column<int>(type: "int", nullable: false),
                    Fouls = table.Column<int>(type: "int", nullable: false),
                    RedCards = table.Column<int>(type: "int", nullable: false),
                    YellowCards = table.Column<int>(type: "int", nullable: false),
                    Tackles = table.Column<int>(type: "int", nullable: false),
                    Passes = table.Column<int>(type: "int", nullable: false),
                    TeamMatchInfoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamStats_MatchActors_TeamMatchInfoId",
                        column: x => x.TeamMatchInfoId,
                        principalTable: "MatchActors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 1L, 0, 6, 9, 19, 5, 467, 52, 0, 2, 7, 7, 15, 1L, 3 },
                    { 2L, 6, 6, 14, 14, 5, 422, 48, 0, 4, 16, 5, 18, 2L, 3 },
                    { 8L, 5, 5, 5, 5, 5, 555, 75, 5, 5, 5, 5, 5, 8L, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E326AFC1F41000F45979BB75C97CBC8960F8C4E77EB46180E64A4A8F70660D976BAC8EDE0DD0E5DE62F128E7C5A233775895DA1962E09F97B7C1BF0A85A8F72E", new byte[] { 36, 238, 80, 35, 52, 238, 212, 223, 0, 126, 127, 207, 20, 63, 106, 100, 6, 93, 31, 209, 104, 111, 32, 93, 76, 1, 197, 200, 44, 9, 53, 85, 23, 133, 222, 176, 180, 77, 192, 164, 169, 215, 35, 113, 246, 12, 76, 75, 243, 143, 207, 173, 122, 89, 138, 77, 213, 88, 208, 192, 69, 137, 20, 51 } });

            migrationBuilder.CreateIndex(
                name: "IX_TeamStats_TeamMatchInfoId",
                table: "TeamStats",
                column: "TeamMatchInfoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamStats");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4624DB4E71CAD8F8FB291796538BFADCE1927B18AEFB0866C02A01E7EA8A8B51F5BD47EB852786B879D818530F2228859BDCB9B4B8C7F5A12427DD12D09FF000", new byte[] { 176, 40, 167, 114, 205, 234, 88, 250, 59, 48, 203, 21, 158, 40, 211, 101, 71, 72, 32, 254, 215, 251, 46, 77, 219, 84, 101, 144, 22, 149, 251, 138, 18, 181, 39, 192, 101, 61, 22, 14, 110, 148, 45, 193, 136, 20, 52, 89, 33, 61, 249, 91, 250, 216, 70, 57, 132, 242, 253, 135, 16, 172, 46, 197 } });
        }
    }
}
