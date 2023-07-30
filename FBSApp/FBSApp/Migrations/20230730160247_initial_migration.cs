using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
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
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Password", "Role", "Salt" },
                values: new object[] { 1L, "admin@gmail.com", "A09CE485059AB8DAA9DEBE3067FF0FF4E167345220867F191D03F6653D51C9C4238F5ADF171ED8437ABA49A582874F4FFF198C85188F25F0B5149F4A44AF9278", "ADMIN", new byte[] { 75, 191, 154, 59, 62, 200, 26, 119, 83, 147, 168, 62, 43, 173, 70, 190, 34, 154, 54, 37, 163, 49, 206, 177, 156, 35, 47, 179, 226, 105, 84, 44, 29, 9, 224, 138, 196, 69, 148, 229, 217, 54, 134, 73, 107, 128, 195, 92, 208, 255, 43, 15, 191, 157, 38, 220, 35, 30, 201, 114, 67, 151, 187, 248 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
