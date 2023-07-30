using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreStadiums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Addresses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CountryId",
                value: 185L);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CountryId", "Number", "Street" },
                values: new object[,]
                {
                    { 11L, "Sheffield", 185L, null, "Granville Road" },
                    { 12L, "Brighton", 185L, null, "Village Way" },
                    { 13L, "Wolverhampton", 185L, null, "Waterloo Road" },
                    { 14L, "London", 185L, null, "Whitehorse Lane" },
                    { 15L, "London", 185L, null, "Stevenage Road" },
                    { 16L, "Burnley", 185L, null, "Harry Potts Way" },
                    { 17L, "Bournemouth", 185L, null, "Kings Park" },
                    { 18L, "Cardiff", 185L, null, "Sloper Road" },
                    { 19L, "Cardiff", 185L, null, "Britannia Road" },
                    { 20L, "Leicester", 185L, null, "Filbert Way" },
                    { 21L, "Watford", 185L, null, "Vicarage Road" },
                    { 22L, "Huddersfield", 185L, null, "Stadium Way" },
                    { 23L, "Norwich", 185L, null, "Carrow Road" }
                });

            migrationBuilder.UpdateData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Name",
                value: "St. James' Park");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DD13082A4C5FB52874A66E2B43C36F0C866F30F2F2F13B05890D964098D0F17895A3726C38726C8DF6BB66B93957C2E088F66FCAFDBBDFC74165834AADD418BE", new byte[] { 237, 156, 234, 32, 233, 128, 192, 31, 172, 7, 48, 247, 40, 66, 56, 85, 72, 141, 146, 167, 254, 171, 245, 126, 255, 102, 204, 104, 213, 56, 213, 91, 176, 61, 32, 55, 242, 136, 225, 189, 58, 150, 55, 246, 252, 44, 231, 188, 12, 23, 59, 175, 98, 146, 171, 4, 9, 85, 152, 45, 241, 99, 10, 3 } });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 11L, 11L, "Bramall Lane" },
                    { 12L, 12L, "Falmer Stadium" },
                    { 13L, 13L, "Molineux" },
                    { 14L, 14L, "Selhurst Park" },
                    { 15L, 15L, "Craven Cottage" },
                    { 16L, 16L, "Turf Moor" },
                    { 17L, 17L, "Dean Court" },
                    { 18L, 18L, "Cardiff City Stadium" },
                    { 19L, 19L, "St Mary's Stadium" },
                    { 20L, 20L, "King Power Stadium" },
                    { 21L, 21L, "Vicarage Road" },
                    { 22L, 22L, "Kirklees Stadium" },
                    { 23L, 23L, "Carrow Road" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Countries_CountryId",
                table: "Addresses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Countries_CountryId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Name",
                value: "St. James Park");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "58351124FFE00083BD2029564E30E70008E4E34E2ECEAE7E416526C0399168E9903DB0ED43C27C9DDFADCF5628C73134B03FA248F148B1E4E4F3070053B34B0F", new byte[] { 39, 178, 14, 104, 248, 88, 251, 56, 238, 72, 11, 215, 240, 29, 46, 87, 84, 151, 156, 99, 167, 161, 100, 111, 55, 122, 102, 28, 236, 213, 149, 141, 195, 81, 166, 72, 242, 213, 184, 254, 234, 213, 148, 79, 47, 189, 32, 96, 140, 164, 183, 21, 61, 191, 146, 178, 77, 235, 136, 166, 183, 169, 152, 46 } });
        }
    }
}
