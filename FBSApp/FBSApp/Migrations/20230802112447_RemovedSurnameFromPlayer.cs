using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSurnameFromPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Kevin De Bruyne");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "053F9C8BC956CF75F60E89F34904C8DA61212355B3C12117E50F81ACECD2775D06D6543EA44F1F5317A0E40D6026DDD7B5928B323BA889BFFD76CB3903D6304C", new byte[] { 36, 0, 185, 200, 16, 54, 75, 165, 95, 67, 69, 102, 148, 92, 59, 176, 27, 7, 92, 10, 51, 190, 179, 113, 80, 47, 159, 176, 97, 122, 38, 243, 5, 208, 15, 94, 22, 234, 109, 49, 165, 47, 150, 85, 55, 23, 210, 69, 65, 118, 81, 40, 4, 188, 35, 206, 111, 144, 30, 238, 68, 84, 189, 229 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Kevin", "De Bruyne" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "493AF273C6C22DBC0DD420B892465A531188A560AD8B5113A8595AC7D023D5CA14EF148C738FDDE67D395045E061B890487D1581DB8A8F21445228E530D7DB06", new byte[] { 135, 31, 20, 135, 170, 90, 217, 245, 220, 231, 14, 75, 168, 102, 172, 115, 225, 87, 178, 248, 22, 114, 114, 152, 129, 67, 42, 106, 161, 190, 91, 37, 93, 60, 211, 57, 56, 238, 60, 211, 54, 28, 142, 236, 42, 27, 33, 89, 10, 158, 131, 99, 6, 17, 120, 135, 241, 121, 251, 75, 90, 155, 245, 148 } });
        }
    }
}
