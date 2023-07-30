using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class addedUserDBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "Salt" },
                values: new object[] { 1L, "admin@gmail.com", "79FC2AA5454A196D8FF394B439AD3C4AC00114821738C23BB05AA69C6F342EBE56A7ED3168C1379773B45DE1BD2B02F5FD1BCC534BD7DDE0BE1CE3C33B1AEECB", "ADMIN", new byte[] { 23, 47, 146, 60, 175, 131, 112, 93, 166, 113, 50, 101, 203, 71, 151, 213, 169, 203, 245, 232, 128, 142, 170, 185, 78, 166, 75, 191, 107, 106, 214, 199, 128, 179, 12, 81, 115, 184, 177, 7, 128, 9, 62, 224, 129, 235, 149, 113, 29, 137, 124, 79, 145, 89, 167, 243, 42, 153, 56, 193, 39, 144, 245, 68 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Password", "Role", "Salt" },
                values: new object[] { 1L, "admin@gmail.com", "A09CE485059AB8DAA9DEBE3067FF0FF4E167345220867F191D03F6653D51C9C4238F5ADF171ED8437ABA49A582874F4FFF198C85188F25F0B5149F4A44AF9278", "ADMIN", new byte[] { 75, 191, 154, 59, 62, 200, 26, 119, 83, 147, 168, 62, 43, 173, 70, 190, 34, 154, 54, 37, 163, 49, 206, 177, 156, 35, 47, 179, 226, 105, 84, 44, 29, 9, 224, 138, 196, 69, 148, 229, 217, 54, 134, 73, 107, 128, 195, 92, 208, 255, 43, 15, 191, 157, 38, 220, 35, 30, 201, 114, 67, 151, 187, 248 } });
        }
    }
}
