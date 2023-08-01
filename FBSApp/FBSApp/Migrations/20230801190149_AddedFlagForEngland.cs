using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedFlagForEngland : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Flag", "Name" },
                values: new object[] { new byte[] { 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 125, 0, 0, 0, 80, 8, 3, 0, 0, 0, 3, 108, 138, 255, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 0, 32, 99, 72, 82, 77, 0, 0, 122, 38, 0, 0, 128, 132, 0, 0, 250, 0, 0, 0, 128, 232, 0, 0, 117, 48, 0, 0, 234, 96, 0, 0, 58, 152, 0, 0, 23, 112, 156, 186, 81, 60, 0, 0, 1, 26, 80, 76, 84, 69, 253, 253, 253, 254, 254, 254, 252, 252, 252, 250, 126, 126, 248, 42, 42, 248, 50, 50, 248, 49, 49, 248, 48, 48, 248, 44, 44, 249, 76, 76, 252, 221, 221, 251, 253, 253, 251, 250, 250, 251, 251, 251, 250, 250, 250, 250, 249, 249, 249, 249, 249, 234, 234, 234, 255, 255, 255, 255, 254, 254, 252, 127, 127, 250, 42, 42, 250, 50, 50, 250, 49, 49, 250, 48, 48, 250, 44, 44, 251, 76, 76, 255, 223, 223, 239, 238, 238, 249, 42, 42, 249, 50, 50, 249, 49, 49, 249, 48, 48, 249, 44, 44, 250, 76, 76, 254, 222, 222, 254, 253, 253, 238, 237, 237, 238, 238, 238, 239, 239, 239, 242, 242, 242, 243, 243, 243, 243, 242, 242, 245, 245, 245, 246, 246, 246, 248, 247, 247, 248, 248, 248, 252, 126, 126, 250, 75, 75, 254, 221, 221, 254, 252, 252, 252, 251, 251, 252, 129, 129, 254, 226, 226, 252, 255, 255, 254, 234, 234, 254, 235, 235, 252, 117, 117, 249, 45, 45, 250, 73, 73, 253, 207, 207, 254, 236, 236, 254, 233, 233, 252, 232, 232, 250, 79, 79, 250, 80, 80, 250, 57, 57, 249, 47, 47, 250, 52, 52, 250, 81, 81, 251, 80, 80, 249, 79, 79, 249, 43, 43, 250, 43, 43, 249, 41, 41, 250, 41, 41, 252, 160, 160, 252, 162, 162, 251, 87, 87, 249, 46, 46, 250, 63, 63, 252, 143, 143, 252, 163, 163, 253, 161, 161, 250, 159, 159, 252, 130, 130, 250, 77, 77, 254, 230, 230, 253, 255, 255, 253, 254, 254, 251, 126, 126, 248, 41, 41, 251, 252, 252, 252, 250, 250, 233, 13, 146, 87, 0, 0, 0, 1, 98, 75, 71, 68, 18, 123, 188, 108, 0, 0, 0, 0, 9, 112, 72, 89, 115, 0, 0, 14, 195, 0, 0, 14, 195, 1, 199, 111, 168, 100, 0, 0, 0, 7, 116, 73, 77, 69, 7, 231, 8, 1, 18, 32, 49, 148, 161, 254, 184, 0, 0, 1, 151, 73, 68, 65, 84, 104, 222, 237, 154, 87, 83, 194, 64, 20, 133, 55, 106, 4, 17, 34, 110, 48, 27, 11, 16, 48, 246, 134, 216, 177, 139, 5, 177, 247, 254, 255, 255, 134, 97, 38, 74, 130, 160, 120, 198, 97, 199, 201, 253, 158, 242, 116, 190, 156, 151, 187, 247, 225, 50, 230, 160, 124, 11, 251, 74, 27, 107, 239, 80, 59, 93, 66, 106, 184, 43, 210, 29, 141, 213, 69, 139, 106, 21, 122, 234, 16, 215, 122, 25, 7, 208, 117, 158, 232, 51, 132, 139, 105, 244, 15, 12, 114, 29, 200, 25, 250, 161, 119, 67, 18, 201, 84, 218, 197, 74, 101, 178, 195, 138, 13, 132, 140, 96, 221, 21, 158, 72, 122, 186, 59, 118, 110, 255, 182, 188, 19, 34, 215, 62, 26, 212, 238, 92, 225, 99, 82, 237, 227, 1, 182, 79, 144, 61, 144, 246, 201, 0, 119, 159, 10, 176, 125, 90, 170, 125, 134, 236, 129, 180, 207, 6, 184, 123, 92, 170, 61, 38, 213, 174, 145, 93, 146, 61, 198, 108, 140, 57, 159, 61, 55, 111, 231, 129, 144, 5, 168, 187, 195, 162, 191, 251, 18, 20, 178, 204, 86, 32, 86, 215, 188, 246, 194, 250, 198, 230, 22, 144, 178, 205, 118, 32, 118, 247, 138, 162, 138, 181, 159, 59, 0, 66, 14, 143, 88, 9, 163, 40, 172, 79, 185, 41, 172, 12, 146, 113, 92, 98, 6, 134, 71, 94, 209, 35, 17, 41, 35, 197, 76, 16, 225, 3, 73, 176, 132, 197, 132, 52, 200, 78, 246, 255, 101, 55, 27, 124, 55, 79, 218, 177, 163, 211, 198, 111, 71, 167, 77, 25, 163, 144, 174, 14, 28, 83, 20, 147, 72, 198, 73, 153, 157, 66, 156, 157, 103, 60, 205, 47, 46, 175, 174, 129, 144, 155, 91, 244, 125, 191, 243, 189, 239, 247, 15, 80, 200, 35, 180, 219, 228, 243, 127, 181, 219, 232, 8, 138, 94, 187, 215, 233, 54, 16, 210, 38, 117, 171, 36, 59, 217, 201, 222, 74, 59, 35, 59, 217, 201, 78, 118, 178, 147, 157, 236, 100, 39, 123, 171, 237, 245, 46, 157, 44, 23, 248, 210, 9, 236, 238, 187, 242, 18, 240, 149, 151, 210, 156, 93, 225, 254, 95, 102, 79, 207, 47, 106, 232, 3, 53, 156, 141, 188, 190, 213, 92, 182, 53, 67, 252, 29, 46, 169, 97, 46, 169, 73, 160, 63, 0, 0, 0, 37, 116, 69, 88, 116, 100, 97, 116, 101, 58, 99, 114, 101, 97, 116, 101, 0, 50, 48, 50, 51, 45, 48, 56, 45, 48, 49, 84, 49, 56, 58, 51, 50, 58, 51, 54, 43, 48, 48, 58, 48, 48, 37, 105, 241, 88, 0, 0, 0, 37, 116, 69, 88, 116, 100, 97, 116, 101, 58, 109, 111, 100, 105, 102, 121, 0, 50, 48, 50, 51, 45, 48, 56, 45, 48, 49, 84, 49, 56, 58, 51, 50, 58, 51, 54, 43, 48, 48, 58, 48, 48, 84, 52, 73, 228, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130 }, "England" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L,
                column: "Name",
                value: "Equatorial Guinea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L,
                column: "Name",
                value: "Eritrea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L,
                column: "Name",
                value: "Estonia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L,
                column: "Name",
                value: "Ethiopia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L,
                column: "Name",
                value: "Fiji");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L,
                column: "Name",
                value: "Finland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L,
                column: "Name",
                value: "France");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L,
                column: "Name",
                value: "Gabon");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L,
                column: "Name",
                value: "Gambia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L,
                column: "Name",
                value: "Georgia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L,
                column: "Name",
                value: "Germany");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L,
                column: "Name",
                value: "Ghana");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L,
                column: "Name",
                value: "Greece");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L,
                column: "Name",
                value: "Grenada");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L,
                column: "Name",
                value: "Guatemala");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L,
                column: "Name",
                value: "Guinea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L,
                column: "Name",
                value: "Guinea-Bissau");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L,
                column: "Name",
                value: "Guyana");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L,
                column: "Name",
                value: "Haiti");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L,
                column: "Name",
                value: "Honduras");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L,
                column: "Name",
                value: "Hungary");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L,
                column: "Name",
                value: "Iceland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L,
                column: "Name",
                value: "India");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L,
                column: "Name",
                value: "Indonesia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L,
                column: "Name",
                value: "Iran");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L,
                column: "Name",
                value: "Iraq");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L,
                column: "Name",
                value: "Ireland {Republic}");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L,
                column: "Name",
                value: "Israel");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L,
                column: "Name",
                value: "Italy");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L,
                column: "Name",
                value: "Ivory Coast");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L,
                column: "Name",
                value: "Jamaica");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L,
                column: "Name",
                value: "Japan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L,
                column: "Name",
                value: "Jordan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L,
                column: "Name",
                value: "Kazakhstan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L,
                column: "Name",
                value: "Kenya");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90L,
                column: "Name",
                value: "Kiribati");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L,
                column: "Name",
                value: "Korea North");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L,
                column: "Name",
                value: "Korea South");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L,
                column: "Name",
                value: "Kuwait");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L,
                column: "Name",
                value: "Kyrgyzstan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L,
                column: "Name",
                value: "Laos");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L,
                column: "Name",
                value: "Latvia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L,
                column: "Name",
                value: "Lebanon");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L,
                column: "Name",
                value: "Lesotho");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L,
                column: "Name",
                value: "Liberia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L,
                column: "Name",
                value: "Libya");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L,
                column: "Name",
                value: "Liechtenstein");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L,
                column: "Name",
                value: "Lithuania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L,
                column: "Name",
                value: "Luxembourg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L,
                column: "Name",
                value: "Macedonia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L,
                column: "Name",
                value: "Madagascar");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L,
                column: "Name",
                value: "Malawi");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L,
                column: "Name",
                value: "Malaysia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L,
                column: "Name",
                value: "Maldives");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L,
                column: "Name",
                value: "Mali");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L,
                column: "Name",
                value: "Malta");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L,
                column: "Name",
                value: "Marshall Islands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L,
                column: "Name",
                value: "Mauritania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L,
                column: "Name",
                value: "Mauritius");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L,
                column: "Name",
                value: "Mexico");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L,
                column: "Name",
                value: "Micronesia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L,
                column: "Name",
                value: "Moldova");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L,
                column: "Name",
                value: "Monaco");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L,
                column: "Name",
                value: "Mongolia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L,
                column: "Name",
                value: "Montenegro");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L,
                column: "Name",
                value: "Morocco");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L,
                column: "Name",
                value: "Mozambique");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L,
                column: "Name",
                value: "Myanmar {Burma}");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L,
                column: "Name",
                value: "Namibia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L,
                column: "Name",
                value: "Nauru");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L,
                column: "Name",
                value: "Nepal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L,
                column: "Name",
                value: "Netherlands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L,
                column: "Name",
                value: "New Zealand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L,
                column: "Name",
                value: "Nicaragua");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L,
                column: "Name",
                value: "Niger");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L,
                column: "Name",
                value: "Nigeria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L,
                column: "Name",
                value: "Norway");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L,
                column: "Name",
                value: "Oman");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L,
                column: "Name",
                value: "Pakistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L,
                column: "Name",
                value: "Palau");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L,
                column: "Name",
                value: "Panama");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L,
                column: "Name",
                value: "Papua New Guinea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L,
                column: "Name",
                value: "Paraguay");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L,
                column: "Name",
                value: "Peru");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L,
                column: "Name",
                value: "Philippines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L,
                column: "Name",
                value: "Poland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L,
                column: "Name",
                value: "Portugal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L,
                column: "Name",
                value: "Qatar");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L,
                column: "Name",
                value: "Romania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L,
                column: "Name",
                value: "Russian Federation");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L,
                column: "Name",
                value: "Rwanda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L,
                column: "Name",
                value: "St Kitts & Nevis");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L,
                column: "Name",
                value: "St Lucia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L,
                column: "Name",
                value: "Saint Vincent & the Grenadines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L,
                column: "Name",
                value: "Samoa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L,
                column: "Name",
                value: "San Marino");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L,
                column: "Name",
                value: "Sao Tome & Principe");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L,
                column: "Name",
                value: "Saudi Arabia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L,
                column: "Name",
                value: "Scotland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "Name",
                value: "Senegal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "Name",
                value: "Serbia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "Name",
                value: "Seychelles");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "Name",
                value: "Sierra Leone");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "Name",
                value: "Singapore");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Name",
                value: "Slovakia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "Name",
                value: "Slovenia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "Name",
                value: "Solomon Islands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "Name",
                value: "Somalia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "Name",
                value: "South Africa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "Name",
                value: "South Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Name",
                value: "Spain");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "Name",
                value: "Sri Lanka");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "Name",
                value: "Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "Name",
                value: "Suriname");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "Name",
                value: "Swaziland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "Name",
                value: "Sweden");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "Name",
                value: "Switzerland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "Name",
                value: "Syria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "Name",
                value: "Taiwan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "Name",
                value: "Tajikistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "Name",
                value: "Tanzania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "Name",
                value: "Thailand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "Name",
                value: "Togo");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Name",
                value: "Tonga");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "Name",
                value: "Trinidad & Tobago");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "Name",
                value: "Tunisia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "Name",
                value: "Turkey");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "Name",
                value: "Turkmenistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "Name",
                value: "Tuvalu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "Name",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "Name",
                value: "Ukraine");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "Name",
                value: "United Arab Emirates");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "Name",
                value: "United Kingdom");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L,
                column: "Name",
                value: "United States");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L,
                column: "Name",
                value: "Uruguay");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L,
                column: "Name",
                value: "Uzbekistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L,
                column: "Name",
                value: "Vanuatu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L,
                column: "Name",
                value: "Vatican City");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L,
                column: "Name",
                value: "Venezuela");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L,
                column: "Name",
                value: "Vietnam");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L,
                column: "Name",
                value: "Wales");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Flag", "Name" },
                values: new object[,]
                {
                    { 196L, new byte[0], "Yemen" },
                    { 197L, new byte[0], "Zambia" },
                    { 198L, new byte[0], "Zimbabwe" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "F4C69FAB57334A5C1B4BD37F06FE6FF046DB6C1A3C8D045A4AF8F2580253E5A68B4ED34655F8BD248C2E6ED3C0C3E3D3B40E32A4D751037F4E85805338472DB0", new byte[] { 35, 179, 57, 250, 159, 109, 203, 101, 124, 66, 156, 114, 219, 191, 164, 97, 244, 110, 101, 20, 108, 143, 122, 46, 98, 90, 21, 218, 204, 193, 24, 78, 57, 172, 103, 128, 254, 78, 14, 47, 131, 239, 229, 158, 172, 146, 30, 198, 196, 44, 11, 189, 189, 248, 136, 35, 26, 196, 31, 210, 203, 100, 41, 197 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Flag", "Name" },
                values: new object[] { new byte[0], "Equatorial Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L,
                column: "Name",
                value: "Eritrea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L,
                column: "Name",
                value: "Estonia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L,
                column: "Name",
                value: "Ethiopia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L,
                column: "Name",
                value: "Fiji");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L,
                column: "Name",
                value: "Finland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L,
                column: "Name",
                value: "France");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L,
                column: "Name",
                value: "Gabon");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L,
                column: "Name",
                value: "Gambia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L,
                column: "Name",
                value: "Georgia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L,
                column: "Name",
                value: "Germany");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L,
                column: "Name",
                value: "Ghana");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L,
                column: "Name",
                value: "Greece");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L,
                column: "Name",
                value: "Grenada");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L,
                column: "Name",
                value: "Guatemala");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L,
                column: "Name",
                value: "Guinea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L,
                column: "Name",
                value: "Guinea-Bissau");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L,
                column: "Name",
                value: "Guyana");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L,
                column: "Name",
                value: "Haiti");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L,
                column: "Name",
                value: "Honduras");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L,
                column: "Name",
                value: "Hungary");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L,
                column: "Name",
                value: "Iceland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L,
                column: "Name",
                value: "India");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L,
                column: "Name",
                value: "Indonesia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L,
                column: "Name",
                value: "Iran");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L,
                column: "Name",
                value: "Iraq");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L,
                column: "Name",
                value: "Ireland {Republic}");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L,
                column: "Name",
                value: "Israel");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L,
                column: "Name",
                value: "Italy");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L,
                column: "Name",
                value: "Ivory Coast");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L,
                column: "Name",
                value: "Jamaica");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L,
                column: "Name",
                value: "Japan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L,
                column: "Name",
                value: "Jordan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L,
                column: "Name",
                value: "Kazakhstan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L,
                column: "Name",
                value: "Kenya");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L,
                column: "Name",
                value: "Kiribati");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90L,
                column: "Name",
                value: "Korea North");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L,
                column: "Name",
                value: "Korea South");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L,
                column: "Name",
                value: "Kuwait");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L,
                column: "Name",
                value: "Kyrgyzstan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L,
                column: "Name",
                value: "Laos");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L,
                column: "Name",
                value: "Latvia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L,
                column: "Name",
                value: "Lebanon");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L,
                column: "Name",
                value: "Lesotho");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L,
                column: "Name",
                value: "Liberia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L,
                column: "Name",
                value: "Libya");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L,
                column: "Name",
                value: "Liechtenstein");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L,
                column: "Name",
                value: "Lithuania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L,
                column: "Name",
                value: "Luxembourg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L,
                column: "Name",
                value: "Macedonia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L,
                column: "Name",
                value: "Madagascar");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L,
                column: "Name",
                value: "Malawi");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L,
                column: "Name",
                value: "Malaysia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L,
                column: "Name",
                value: "Maldives");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L,
                column: "Name",
                value: "Mali");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L,
                column: "Name",
                value: "Malta");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L,
                column: "Name",
                value: "Marshall Islands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L,
                column: "Name",
                value: "Mauritania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L,
                column: "Name",
                value: "Mauritius");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L,
                column: "Name",
                value: "Mexico");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L,
                column: "Name",
                value: "Micronesia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L,
                column: "Name",
                value: "Moldova");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L,
                column: "Name",
                value: "Monaco");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L,
                column: "Name",
                value: "Mongolia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L,
                column: "Name",
                value: "Montenegro");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L,
                column: "Name",
                value: "Morocco");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L,
                column: "Name",
                value: "Mozambique");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L,
                column: "Name",
                value: "Myanmar {Burma}");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L,
                column: "Name",
                value: "Namibia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L,
                column: "Name",
                value: "Nauru");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L,
                column: "Name",
                value: "Nepal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L,
                column: "Name",
                value: "Netherlands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L,
                column: "Name",
                value: "New Zealand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L,
                column: "Name",
                value: "Nicaragua");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L,
                column: "Name",
                value: "Niger");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L,
                column: "Name",
                value: "Nigeria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L,
                column: "Name",
                value: "Norway");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L,
                column: "Name",
                value: "Oman");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L,
                column: "Name",
                value: "Pakistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L,
                column: "Name",
                value: "Palau");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L,
                column: "Name",
                value: "Panama");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L,
                column: "Name",
                value: "Papua New Guinea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L,
                column: "Name",
                value: "Paraguay");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L,
                column: "Name",
                value: "Peru");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L,
                column: "Name",
                value: "Philippines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L,
                column: "Name",
                value: "Poland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L,
                column: "Name",
                value: "Portugal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L,
                column: "Name",
                value: "Qatar");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L,
                column: "Name",
                value: "Romania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L,
                column: "Name",
                value: "Russian Federation");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L,
                column: "Name",
                value: "Rwanda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L,
                column: "Name",
                value: "St Kitts & Nevis");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L,
                column: "Name",
                value: "St Lucia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L,
                column: "Name",
                value: "Saint Vincent & the Grenadines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L,
                column: "Name",
                value: "Samoa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L,
                column: "Name",
                value: "San Marino");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L,
                column: "Name",
                value: "Sao Tome & Principe");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L,
                column: "Name",
                value: "Saudi Arabia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L,
                column: "Name",
                value: "Senegal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L,
                column: "Name",
                value: "Serbia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "Name",
                value: "Seychelles");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "Name",
                value: "Sierra Leone");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "Name",
                value: "Singapore");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "Name",
                value: "Slovakia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "Name",
                value: "Slovenia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Name",
                value: "Solomon Islands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "Name",
                value: "Somalia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "Name",
                value: "South Africa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "Name",
                value: "South Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "Name",
                value: "Spain");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "Name",
                value: "Sri Lanka");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Name",
                value: "Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "Name",
                value: "Suriname");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "Name",
                value: "Swaziland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "Name",
                value: "Sweden");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "Name",
                value: "Switzerland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "Name",
                value: "Syria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "Name",
                value: "Taiwan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "Name",
                value: "Tajikistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "Name",
                value: "Tanzania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "Name",
                value: "Thailand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "Name",
                value: "Togo");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "Name",
                value: "Tonga");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "Name",
                value: "Trinidad & Tobago");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Name",
                value: "Tunisia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "Name",
                value: "Turkey");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "Name",
                value: "Turkmenistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "Name",
                value: "Tuvalu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "Name",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "Name",
                value: "Ukraine");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "Name",
                value: "United Arab Emirates");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "Name",
                value: "United Kingdom");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "Name",
                value: "United States");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "Name",
                value: "Uruguay");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L,
                column: "Name",
                value: "Uzbekistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L,
                column: "Name",
                value: "Vanuatu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L,
                column: "Name",
                value: "Vatican City");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L,
                column: "Name",
                value: "Venezuela");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L,
                column: "Name",
                value: "Vietnam");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L,
                column: "Name",
                value: "Yemen");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L,
                column: "Name",
                value: "Zambia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L,
                column: "Name",
                value: "Zimbabwe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "B0D8FCD55014EF8B1FB5EE3C999043C99EBFD32A7DFB9A323E090C247EB0F95E900B649452DEABED66C4BB2FE5155C29E1747BF067A11F27F01A486283687071", new byte[] { 111, 235, 144, 240, 116, 218, 79, 187, 134, 98, 128, 132, 41, 151, 54, 197, 188, 179, 63, 243, 216, 61, 42, 106, 251, 48, 181, 123, 23, 233, 197, 71, 73, 116, 156, 194, 149, 26, 140, 102, 206, 47, 196, 96, 219, 196, 99, 131, 100, 69, 62, 53, 122, 244, 55, 141, 157, 124, 160, 88, 61, 52, 78, 37 } });
        }
    }
}
