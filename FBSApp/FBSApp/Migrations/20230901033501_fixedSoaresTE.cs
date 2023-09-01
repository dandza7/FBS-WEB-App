using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class fixedSoaresTE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeamEngagements",
                columns: new[] { "Id", "EndDate", "PlayerId", "StartDate", "TeamId" },
                values: new object[] { 1949L, new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 408L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "1225DA01BB941F517EB1103A6DCA49322E39DF71BE4F9BF2A237A29036C7909F598CBC002A93608FB87F4884C965E6167167762529DE69C5346A5C4EBA0B96C2", new byte[] { 167, 104, 145, 75, 63, 165, 177, 167, 241, 11, 32, 161, 202, 8, 86, 139, 253, 129, 9, 239, 255, 6, 3, 146, 21, 218, 37, 174, 91, 221, 0, 117, 206, 226, 63, 161, 94, 200, 186, 32, 92, 107, 49, 116, 126, 137, 61, 176, 193, 92, 113, 177, 155, 165, 144, 216, 111, 78, 29, 70, 235, 100, 208, 138 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "AB4E4E62BAB02D65D68CB03F396C78FA82065F90F39BC9A0AFC3DB0CA2E143BEF89A17A52B50EA969DFF1F093A72CF816E77F9DA73CA3C0DB5D61B7F804A9580", new byte[] { 228, 215, 18, 115, 102, 13, 22, 201, 240, 35, 80, 111, 106, 22, 138, 54, 227, 130, 29, 227, 70, 136, 48, 88, 240, 255, 204, 173, 40, 28, 252, 216, 18, 168, 64, 119, 192, 88, 132, 90, 212, 93, 117, 59, 83, 184, 112, 238, 88, 71, 1, 49, 63, 48, 168, 254, 93, 255, 105, 92, 71, 11, 29, 234 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamEngagements",
                keyColumn: "Id",
                keyValue: 1949L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "1256E172579A5330F78A4C60CB2981B2AEE03871D7BF05CD1E9F947BB846CAE3CC34BBC9349B877B3D5AB0F467E6A1F672A3A506E98E2A553FB13029420FF4A2", new byte[] { 74, 218, 57, 20, 33, 48, 186, 90, 248, 79, 0, 67, 114, 246, 234, 33, 197, 194, 115, 217, 81, 181, 116, 208, 105, 92, 30, 138, 218, 5, 160, 151, 66, 47, 128, 143, 139, 14, 101, 144, 223, 136, 12, 140, 159, 52, 171, 139, 64, 3, 162, 72, 254, 250, 170, 32, 205, 12, 80, 192, 77, 147, 238, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E77598C56EB34709D8D6BF889E78EE4C37CFE953828702B1230B4ADCFE20EA48CE6C886E86ED91CEED6A41EE086C1556469276F0CA8A4E3FA702E09839E1099F", new byte[] { 181, 118, 116, 73, 112, 210, 155, 66, 127, 16, 87, 1, 96, 130, 10, 202, 102, 81, 207, 226, 42, 161, 179, 149, 190, 13, 242, 106, 103, 141, 178, 56, 223, 241, 50, 218, 242, 249, 225, 0, 60, 45, 152, 191, 33, 61, 244, 120, 210, 208, 72, 179, 236, 105, 216, 34, 169, 106, 214, 88, 131, 241, 55, 222 } });
        }
    }
}
