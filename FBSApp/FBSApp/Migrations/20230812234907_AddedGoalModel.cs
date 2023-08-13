using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedGoalModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOwnGoal = table.Column<bool>(type: "bit", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    GoalInfoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goal_PlayedMatches_GoalInfoId",
                        column: x => x.GoalInfoId,
                        principalTable: "PlayedMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "FED8F446C20B2FFA7BA7D9EAD37CA95516457A1D150BB83270ADFF03D57955479CBE3922E9A88759248B2D46B140D21850A434C96C3B80B7CE9DD7C9FDF4E2EE", new byte[] { 133, 95, 216, 240, 218, 174, 54, 188, 95, 240, 239, 196, 75, 72, 190, 236, 89, 114, 242, 32, 59, 175, 207, 152, 168, 221, 126, 4, 214, 37, 93, 226, 236, 99, 32, 195, 223, 190, 34, 96, 134, 62, 37, 212, 119, 56, 245, 221, 54, 232, 204, 83, 26, 59, 70, 145, 88, 7, 94, 72, 21, 189, 105, 197 } });

            migrationBuilder.CreateIndex(
                name: "IX_Goal_GoalInfoId",
                table: "Goal",
                column: "GoalInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "BCD866F0EE3E25F9B521A0FC06448F952D976B5C3575A37FFBABDBC21A285E82490B44D0BC5C3F311E0665711F01E7C108CAD5F70CF763E66F1CDE4383C42D18", new byte[] { 189, 97, 139, 203, 51, 179, 134, 86, 64, 104, 54, 144, 177, 144, 219, 206, 186, 233, 140, 224, 4, 108, 182, 66, 202, 84, 204, 141, 186, 152, 32, 128, 193, 69, 247, 120, 218, 135, 119, 126, 157, 50, 208, 50, 191, 158, 115, 157, 194, 3, 214, 127, 135, 132, 227, 22, 99, 156, 24, 70, 12, 49, 72, 139 } });
        }
    }
}
