using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class SmallFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_PlayedMatches_GoalInfoId",
                table: "Goal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Goal",
                table: "Goal");

            migrationBuilder.RenameTable(
                name: "Goal",
                newName: "Goals");

            migrationBuilder.RenameIndex(
                name: "IX_Goal_GoalInfoId",
                table: "Goals",
                newName: "IX_Goals_GoalInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goals",
                table: "Goals",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1130L,
                column: "Minutes",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4C7C28FD62244CCFEA42CC61F49A287D6968732F3256A8BE11F46B5C14A59446F4D90FEB56CD79FB52802FE291DF185A71038B7C83E73FDD7F68F3A834B43E4A", new byte[] { 164, 29, 141, 56, 220, 34, 120, 205, 150, 28, 12, 21, 10, 186, 133, 248, 241, 90, 102, 197, 75, 70, 0, 105, 3, 245, 102, 168, 179, 193, 80, 223, 138, 192, 75, 43, 196, 85, 84, 100, 178, 187, 212, 80, 33, 198, 157, 240, 176, 39, 68, 144, 33, 77, 150, 117, 78, 244, 103, 146, 111, 10, 130, 72 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_PlayedMatches_GoalInfoId",
                table: "Goals",
                column: "GoalInfoId",
                principalTable: "PlayedMatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_PlayedMatches_GoalInfoId",
                table: "Goals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Goals",
                table: "Goals");

            migrationBuilder.RenameTable(
                name: "Goals",
                newName: "Goal");

            migrationBuilder.RenameIndex(
                name: "IX_Goals_GoalInfoId",
                table: "Goal",
                newName: "IX_Goal_GoalInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goal",
                table: "Goal",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 1130L,
                column: "Minutes",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9ACAB166DA14406B5067A3934CAE6457BF46276101FCD15D391933354EF3461366952590D068A2E8465BE1AAEB9B0A798E50906569B27960893EC885A394CF6F", new byte[] { 191, 93, 183, 210, 47, 50, 83, 238, 29, 172, 99, 88, 24, 32, 40, 112, 26, 171, 120, 207, 80, 112, 239, 236, 171, 121, 36, 56, 5, 11, 34, 155, 40, 152, 137, 177, 74, 106, 56, 251, 232, 34, 30, 82, 160, 236, 190, 101, 42, 30, 117, 99, 43, 58, 194, 220, 190, 108, 110, 52, 29, 49, 65, 81 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_PlayedMatches_GoalInfoId",
                table: "Goal",
                column: "GoalInfoId",
                principalTable: "PlayedMatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
