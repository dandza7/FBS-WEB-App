using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedTeamsDBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Addresses_AddressId",
                table: "Stadiums");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Stadiums_StadiumId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stadiums",
                table: "Stadiums");

            migrationBuilder.RenameTable(
                name: "Stadiums",
                newName: "Stadium");

            migrationBuilder.RenameIndex(
                name: "IX_Stadiums_AddressId",
                table: "Stadium",
                newName: "IX_Stadium_AddressId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stadium_Addresses_AddressId",
                table: "Stadium");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Stadium_StadiumId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stadium",
                table: "Stadium");

            migrationBuilder.RenameTable(
                name: "Stadium",
                newName: "Stadiums");

            migrationBuilder.RenameIndex(
                name: "IX_Stadium_AddressId",
                table: "Stadiums",
                newName: "IX_Stadiums_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stadiums",
                table: "Stadiums",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "47E7E84C149F9D255FBC86A4ABE811255FD4183C9037010DD41C1B675ADED674DC20E082E78FB367E9CD966D80956E0DC9E177901DBF8FC0100D40E268FC7B21", new byte[] { 115, 176, 218, 43, 176, 137, 92, 204, 33, 100, 254, 186, 247, 243, 249, 145, 41, 172, 60, 92, 1, 70, 128, 89, 45, 58, 83, 229, 142, 118, 18, 132, 180, 132, 153, 31, 187, 216, 14, 126, 48, 197, 158, 81, 162, 71, 56, 173, 167, 42, 216, 242, 43, 141, 21, 10, 129, 72, 133, 176, 172, 22, 40, 31 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Addresses_AddressId",
                table: "Stadiums",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Stadiums_StadiumId",
                table: "Team",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
