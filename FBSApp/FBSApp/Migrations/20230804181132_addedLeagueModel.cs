using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedLeagueModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Premier League" },
                    { 2L, "LaLiga Santander" },
                    { 3L, "Ligue 1" },
                    { 4L, "Bundesliga" },
                    { 5L, "Seria A" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7DAC72C6E44B6EB76C5F9DD00ECAE4DD074275E99076D9DF8C7518B55A14877D31E30335AE47FB7496E7D51884ADEC2C3C9FBE5269A05AB6C6BDB2DBAD6C8142", new byte[] { 101, 45, 235, 96, 0, 114, 46, 167, 221, 169, 18, 135, 68, 193, 166, 20, 208, 123, 8, 236, 130, 123, 178, 108, 140, 166, 10, 20, 121, 154, 211, 165, 159, 96, 190, 187, 155, 162, 246, 138, 190, 182, 76, 69, 6, 216, 240, 174, 12, 230, 35, 85, 165, 231, 15, 160, 63, 139, 169, 167, 161, 229, 132, 207 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BFFB858ECF8C019102C266A86ECA02C1295B517EA70F62A391965A05F8D90169FF17433AB17F49C1CC0FEC8849978AAAB3A4EFF213FDE09EBDF3CE65BD792247", new byte[] { 54, 192, 41, 177, 216, 90, 231, 38, 20, 38, 6, 172, 144, 19, 181, 179, 55, 132, 45, 18, 12, 244, 75, 109, 159, 109, 177, 77, 62, 221, 216, 29, 178, 110, 30, 184, 225, 192, 173, 11, 119, 109, 197, 169, 152, 71, 199, 13, 157, 222, 87, 192, 187, 243, 245, 75, 140, 2, 175, 44, 168, 150, 81, 254 } });
        }
    }
}
