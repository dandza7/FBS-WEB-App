using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedStaffModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BossId = table.Column<long>(type: "bigint", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Staff_BossId",
                        column: x => x.BossId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(1963, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 141L, "Jose Mourinho" },
                    { 3L, new DateTime(1972, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7L, "Mauricio Pochettino" },
                    { 5L, new DateTime(1971, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 167L, "Unai Emery" },
                    { 7L, new DateTime(1971, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 167L, "Josep Guardiola" },
                    { 9L, new DateTime(1967, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65L, "Jurgen Klopp" },
                    { 11L, new DateTime(1959, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83L, "Maurizio Sarri" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "11D273C8596188234535E081846B37BC6E45274DEACFF53B9196C969B089D2B404F0A52D8D4D2AF033A1D777963CB07B87AB06572293B13CBD3DC54F01BAD6F4", new byte[] { 151, 89, 101, 18, 161, 154, 244, 207, 164, 226, 158, 189, 100, 34, 58, 245, 184, 187, 159, 164, 174, 11, 235, 141, 247, 146, 83, 34, 179, 202, 115, 181, 23, 66, 229, 12, 100, 86, 130, 45, 52, 219, 111, 152, 201, 25, 49, 137, 41, 234, 139, 224, 205, 148, 37, 2, 245, 4, 175, 134, 167, 219, 80, 45 } });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BirthDate", "BossId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 2L, new DateTime(1975, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 141L, "Rue Faria" },
                    { 4L, new DateTime(1971, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 167L, "Jesus Perez" },
                    { 6L, new DateTime(1963, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, 167L, "Pako Ayestaran" },
                    { 8L, new DateTime(1982, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L, 167L, "Mikel Arteta" },
                    { 10L, new DateTime(1975, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L, 22L, "Zeljko Buvac" },
                    { 12L, new DateTime(1966, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L, 83L, "Gianfranco Zola" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BossId",
                table: "Staff",
                column: "BossId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CountryId",
                table: "Staff",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "F097BC750DCEA5D27D183E62BDE8E974E6E827DC1504716E8148381C901EA62BC96F9058B5B74B27CB125570FA2A9787177E7718C949535A2F2528EABFC2CB6A", new byte[] { 202, 25, 40, 144, 32, 40, 44, 147, 123, 34, 127, 198, 172, 123, 190, 30, 74, 18, 45, 29, 242, 195, 129, 229, 171, 128, 120, 201, 193, 105, 94, 239, 10, 84, 24, 153, 83, 33, 76, 229, 254, 5, 30, 51, 190, 58, 222, 197, 229, 89, 153, 36, 38, 59, 41, 42, 6, 115, 203, 103, 2, 214, 118, 189 } });
        }
    }
}
