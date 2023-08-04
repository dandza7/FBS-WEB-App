using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedSeasonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeagueId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "LeagueId", "Year" },
                values: new object[] { 1L, 1L, "2018/19 Big6Only" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "755BD69776389DBD4A4E2FEB60DC5E2AB018D46EDA3B2C4DECD45AC61F2F2FD8C26F4594909FE1B3CFD2D64279B7195EB3479A433B92706ECB630D79EA5F8387", new byte[] { 4, 56, 143, 222, 228, 0, 65, 231, 171, 21, 221, 211, 34, 70, 22, 135, 223, 241, 23, 250, 173, 241, 201, 111, 36, 174, 200, 24, 146, 145, 184, 39, 189, 77, 9, 138, 53, 64, 159, 1, 25, 242, 201, 195, 127, 156, 57, 84, 122, 133, 16, 25, 172, 32, 193, 140, 50, 50, 146, 179, 73, 63, 172, 187 } });

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_LeagueId",
                table: "Seasons",
                column: "LeagueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7DAC72C6E44B6EB76C5F9DD00ECAE4DD074275E99076D9DF8C7518B55A14877D31E30335AE47FB7496E7D51884ADEC2C3C9FBE5269A05AB6C6BDB2DBAD6C8142", new byte[] { 101, 45, 235, 96, 0, 114, 46, 167, 221, 169, 18, 135, 68, 193, 166, 20, 208, 123, 8, 236, 130, 123, 178, 108, 140, 166, 10, 20, 121, 154, 211, 165, 159, 96, 190, 187, 155, 162, 246, 138, 190, 182, 76, 69, 6, 216, 240, 174, 12, 230, 35, 85, 165, 231, 15, 160, 63, 139, 169, 167, 161, 229, 132, 207 } });
        }
    }
}
