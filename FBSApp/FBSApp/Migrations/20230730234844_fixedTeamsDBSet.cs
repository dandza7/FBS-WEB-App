using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class fixedTeamsDBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stadium_Addresses_AddressId",
                table: "Stadium");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Stadium_StadiumId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stadium",
                table: "Stadium");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "Stadium",
                newName: "Stadiums");

            migrationBuilder.RenameIndex(
                name: "IX_Team_StadiumId",
                table: "Teams",
                newName: "IX_Teams_StadiumId");

            migrationBuilder.RenameIndex(
                name: "IX_Stadium_AddressId",
                table: "Stadiums",
                newName: "IX_Stadiums_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stadiums",
                table: "Stadiums",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6B22B3E65D773FE5638B1BAE74C38FC8ED5A9CE41D8E3302AF81E9F6C22B57E960A0E8A3B5E148675D6D19CC0860CDDA81D222D3809381F2EA322B483AC74B52", new byte[] { 57, 205, 239, 122, 244, 141, 180, 216, 219, 51, 16, 140, 65, 165, 194, 97, 108, 166, 127, 37, 132, 151, 119, 119, 252, 148, 219, 4, 76, 87, 140, 44, 109, 64, 192, 246, 209, 94, 31, 36, 177, 82, 86, 236, 87, 62, 47, 207, 189, 146, 21, 76, 200, 3, 187, 222, 165, 51, 198, 71, 31, 140, 167, 95 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Addresses_AddressId",
                table: "Stadiums",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Stadiums_StadiumId",
                table: "Teams",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Addresses_AddressId",
                table: "Stadiums");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Stadiums_StadiumId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stadiums",
                table: "Stadiums");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "Stadiums",
                newName: "Stadium");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_StadiumId",
                table: "Team",
                newName: "IX_Team_StadiumId");

            migrationBuilder.RenameIndex(
                name: "IX_Stadiums_AddressId",
                table: "Stadium",
                newName: "IX_Stadium_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stadium",
                table: "Stadium",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "F128EAF0838CF532AE561D08E704F5EF2D83A1B3AFD16A19DEB18264EEC79A348E7FF82CB1A4BDAE5C7E289FEF67CD2F7C19E35FA4D261BA46DC90AEE9532421", new byte[] { 229, 217, 182, 239, 170, 181, 131, 215, 131, 150, 180, 84, 204, 89, 6, 206, 33, 30, 72, 162, 210, 60, 73, 213, 32, 188, 198, 18, 91, 22, 208, 48, 194, 216, 207, 158, 5, 94, 111, 208, 43, 131, 192, 89, 90, 7, 86, 89, 85, 240, 19, 72, 208, 37, 172, 7, 225, 126, 1, 191, 130, 53, 59, 69 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Stadium_Addresses_AddressId",
                table: "Stadium",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Stadium_StadiumId",
                table: "Team",
                column: "StadiumId",
                principalTable: "Stadium",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
