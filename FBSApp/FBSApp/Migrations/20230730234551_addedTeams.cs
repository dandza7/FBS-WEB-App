using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StadiumId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name", "StadiumId" },
                values: new object[,]
                {
                    { 1L, "Manchester United", 1L },
                    { 2L, "Tottenham Hotspur", 2L },
                    { 3L, "West Ham United", 3L },
                    { 4L, "Arsenal", 4L },
                    { 5L, "Manchester City", 5L },
                    { 6L, "Liverpool", 6L },
                    { 7L, "Newcastle United", 7L },
                    { 8L, "Aston Villa", 8L },
                    { 9L, "Chelsea", 9L },
                    { 10L, "Everton", 10L },
                    { 11L, "Sheffield United", 11L },
                    { 12L, "Brighton & Hove Albion", 12L },
                    { 13L, "Wolverhampton Wanderers", 13L },
                    { 14L, "Crystal Palace", 14L },
                    { 15L, "Fulham", 15L },
                    { 16L, "Burnley", 16L },
                    { 17L, "AFC Bournemouth", 17L },
                    { 18L, "Cardiff City", 18L },
                    { 19L, "Southampton", 19L },
                    { 20L, "Leicester", 20L },
                    { 21L, "Watford", 21L },
                    { 22L, "Huddersfield Town", 22L },
                    { 23L, "Norwich City", 23L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "47E7E84C149F9D255FBC86A4ABE811255FD4183C9037010DD41C1B675ADED674DC20E082E78FB367E9CD966D80956E0DC9E177901DBF8FC0100D40E268FC7B21", new byte[] { 115, 176, 218, 43, 176, 137, 92, 204, 33, 100, 254, 186, 247, 243, 249, 145, 41, 172, 60, 92, 1, 70, 128, 89, 45, 58, 83, 229, 142, 118, 18, 132, 180, 132, 153, 31, 187, 216, 14, 126, 48, 197, 158, 81, 162, 71, 56, 173, 167, 42, 216, 242, 43, 141, 21, 10, 129, 72, 133, 176, 172, 22, 40, 31 } });

            migrationBuilder.CreateIndex(
                name: "IX_Team_StadiumId",
                table: "Team",
                column: "StadiumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DD13082A4C5FB52874A66E2B43C36F0C866F30F2F2F13B05890D964098D0F17895A3726C38726C8DF6BB66B93957C2E088F66FCAFDBBDFC74165834AADD418BE", new byte[] { 237, 156, 234, 32, 233, 128, 192, 31, 172, 7, 48, 247, 40, 66, 56, 85, 72, 141, 146, 167, 254, 171, 245, 126, 255, 102, 204, 104, 213, 56, 213, 91, 176, 61, 32, 55, 242, 136, 225, 189, 58, 150, 55, 246, 252, 44, 231, 188, 12, 23, 59, 175, 98, 146, 171, 4, 9, 85, 152, 45, 241, 99, 10, 3 } });
        }
    }
}
