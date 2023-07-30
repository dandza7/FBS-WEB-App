using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedStadiums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stadiums_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Number", "Street" },
                values: new object[,]
                {
                    { 1L, "Manchester", null, "Sir Matt Busby Way" },
                    { 2L, "London", null, "High Road" },
                    { 3L, "London", null, "Queen Elizabeth Olympic Park" },
                    { 4L, "London", "75", "Drayton Park" },
                    { 5L, "Manchester", null, "Etihad Campus" },
                    { 6L, "Liverpool", null, "Merseyside" },
                    { 7L, "Newcastle", null, "Newcastle upon Tyne" },
                    { 8L, "Birmingham", null, "Trinity Road" },
                    { 9L, "London", null, "Fulham Road" },
                    { 10L, "Liverpool", null, "Goodison Road" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "58351124FFE00083BD2029564E30E70008E4E34E2ECEAE7E416526C0399168E9903DB0ED43C27C9DDFADCF5628C73134B03FA248F148B1E4E4F3070053B34B0F", new byte[] { 39, 178, 14, 104, 248, 88, 251, 56, 238, 72, 11, 215, 240, 29, 46, 87, 84, 151, 156, 99, 167, 161, 100, 111, 55, 122, 102, 28, 236, 213, 149, 141, 195, 81, 166, 72, 242, 213, 184, 254, 234, 213, 148, 79, 47, 189, 32, 96, 140, 164, 183, 21, 61, 191, 146, 178, 77, 235, 136, 166, 183, 169, 152, 46 } });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1L, 1L, "Old Traford" },
                    { 2L, 2L, "Tottenham Hotspur Stadium" },
                    { 3L, 3L, "Londond Stadium" },
                    { 4L, 4L, "Emirates Stadium" },
                    { 5L, 5L, "Etihad Stadium" },
                    { 6L, 6L, "Anfield" },
                    { 7L, 7L, "St. James Park" },
                    { 8L, 8L, "Villa Park" },
                    { 9L, 9L, "Stamford Bridge" },
                    { 10L, 10L, "Goodison Park" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_AddressId",
                table: "Stadiums",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "91A841874A385D6B30583DC8C96A5AA05E17E048969A98F1835DCF5BCD4EB967D36DBA91AC8D3C5F29AB7A31B0347F3F65B6321274712EBA68EF12510B16539C", new byte[] { 7, 255, 15, 6, 179, 98, 63, 99, 114, 93, 129, 123, 110, 153, 178, 229, 29, 103, 230, 83, 240, 111, 31, 159, 105, 118, 159, 171, 103, 101, 244, 229, 156, 125, 182, 158, 196, 190, 86, 132, 157, 244, 82, 189, 247, 59, 3, 43, 241, 249, 206, 183, 4, 82, 164, 219, 20, 160, 133, 175, 61, 207, 226, 214 } });
        }
    }
}
