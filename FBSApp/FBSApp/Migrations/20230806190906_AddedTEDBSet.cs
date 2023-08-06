using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedTEDBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamEngagement_Players_PlayerId",
                table: "TeamEngagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamEngagement_Teams_TeamId",
                table: "TeamEngagement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamEngagement",
                table: "TeamEngagement");

            migrationBuilder.RenameTable(
                name: "TeamEngagement",
                newName: "TeamEngagements");

            migrationBuilder.RenameIndex(
                name: "IX_TeamEngagement_TeamId",
                table: "TeamEngagements",
                newName: "IX_TeamEngagements_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamEngagement_PlayerId",
                table: "TeamEngagements",
                newName: "IX_TeamEngagements_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamEngagements",
                table: "TeamEngagements",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "F097BC750DCEA5D27D183E62BDE8E974E6E827DC1504716E8148381C901EA62BC96F9058B5B74B27CB125570FA2A9787177E7718C949535A2F2528EABFC2CB6A", new byte[] { 202, 25, 40, 144, 32, 40, 44, 147, 123, 34, 127, 198, 172, 123, 190, 30, 74, 18, 45, 29, 242, 195, 129, 229, 171, 128, 120, 201, 193, 105, 94, 239, 10, 84, 24, 153, 83, 33, 76, 229, 254, 5, 30, 51, 190, 58, 222, 197, 229, 89, 153, 36, 38, 59, 41, 42, 6, 115, 203, 103, 2, 214, 118, 189 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TeamEngagements_Players_PlayerId",
                table: "TeamEngagements",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamEngagements_Teams_TeamId",
                table: "TeamEngagements",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamEngagements_Players_PlayerId",
                table: "TeamEngagements");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamEngagements_Teams_TeamId",
                table: "TeamEngagements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamEngagements",
                table: "TeamEngagements");

            migrationBuilder.RenameTable(
                name: "TeamEngagements",
                newName: "TeamEngagement");

            migrationBuilder.RenameIndex(
                name: "IX_TeamEngagements_TeamId",
                table: "TeamEngagement",
                newName: "IX_TeamEngagement_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamEngagements_PlayerId",
                table: "TeamEngagement",
                newName: "IX_TeamEngagement_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamEngagement",
                table: "TeamEngagement",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "186FEEE2AF809BFCC63D1736AA244CE61D1C051CB349BE023590B365398B9A3D4254D8D345C35BCDADE1238CCEC0AEE7CFCC5DC024CFB56BB638974D8E39D2B5", new byte[] { 217, 223, 198, 173, 223, 55, 186, 128, 119, 203, 101, 21, 22, 7, 184, 178, 175, 254, 226, 236, 25, 152, 137, 189, 11, 254, 184, 131, 129, 114, 186, 66, 200, 104, 139, 239, 121, 47, 57, 210, 78, 43, 209, 93, 67, 248, 82, 9, 63, 92, 233, 183, 113, 39, 140, 112, 136, 33, 153, 81, 198, 86, 30, 101 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TeamEngagement_Players_PlayerId",
                table: "TeamEngagement",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamEngagement_Teams_TeamId",
                table: "TeamEngagement",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
