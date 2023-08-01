using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangedInsertionOfCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 40L,
                column: "Name",
                value: "Congo {Democratic Rep}");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                column: "Name",
                value: "Equatorial Guinea");

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
                values: new object[] { "55E3C92606A7306DBCDBDB59CF52861E7691AFA1BE243721ABDA5BC098D53FACAF49DA0100252F7417DB0B913C6CB24BC12976DE8F31461816D8374CA2B1D98B", new byte[] { 200, 231, 241, 92, 110, 133, 248, 91, 244, 177, 245, 14, 161, 203, 105, 5, 123, 47, 38, 229, 144, 136, 197, 196, 161, 123, 155, 107, 177, 152, 107, 36, 47, 126, 133, 189, 90, 92, 140, 39, 116, 241, 28, 131, 30, 32, 171, 40, 105, 23, 75, 109, 159, 38, 47, 115, 114, 39, 196, 238, 205, 138, 82, 36 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40L,
                column: "Name",
                value: "DR Congo");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                column: "Name",
                value: "England");

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
                value: "Ireland");

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
                value: "Myanmar");

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
                value: "Northern Ireland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L,
                column: "Name",
                value: "Norway");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L,
                column: "Name",
                value: "Oman");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L,
                column: "Name",
                value: "Pakistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L,
                column: "Name",
                value: "Palau");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L,
                column: "Name",
                value: "Panama");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L,
                column: "Name",
                value: "Papua New Guinea");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L,
                column: "Name",
                value: "Paraguay");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L,
                column: "Name",
                value: "Peru");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L,
                column: "Name",
                value: "Philippines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L,
                column: "Name",
                value: "Poland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L,
                column: "Name",
                value: "Portugal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L,
                column: "Name",
                value: "Qatar");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L,
                column: "Name",
                value: "Romania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L,
                column: "Name",
                value: "Russian Federation");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L,
                column: "Name",
                value: "Rwanda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L,
                column: "Name",
                value: "St Kitts & Nevis");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L,
                column: "Name",
                value: "St Lucia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L,
                column: "Name",
                value: "Saint Vincent & the Grenadines");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L,
                column: "Name",
                value: "Samoa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L,
                column: "Name",
                value: "San Marino");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L,
                column: "Name",
                value: "Sao Tome & Principe");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L,
                column: "Name",
                value: "Saudi Arabia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "Name",
                value: "Scotland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "Name",
                value: "Senegal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "Name",
                value: "Serbia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "Name",
                value: "Seychelles");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "Name",
                value: "Sierra Leone");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Name",
                value: "Singapore");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "Name",
                value: "Slovakia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "Name",
                value: "Slovenia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "Name",
                value: "Solomon Islands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "Name",
                value: "Somalia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "Name",
                value: "South Africa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Name",
                value: "South Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "Name",
                value: "Spain");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "Name",
                value: "Sri Lanka");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "Name",
                value: "Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "Name",
                value: "Suriname");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "Name",
                value: "Swaziland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "Name",
                value: "Sweden");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "Name",
                value: "Switzerland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "Name",
                value: "Syria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "Name",
                value: "Taiwan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "Name",
                value: "Tajikistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "Name",
                value: "Tanzania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "Name",
                value: "Thailand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Name",
                value: "Togo");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "Name",
                value: "Tonga");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "Name",
                value: "Trinidad & Tobago");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "Name",
                value: "Tunisia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "Name",
                value: "Turkey");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "Name",
                value: "Turkmenistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "Name",
                value: "Tuvalu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "Name",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "Name",
                value: "Ukraine");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "Name",
                value: "United Arab Emirates");

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
                    { 196L, null, "Yemen" },
                    { 197L, null, "Zambia" },
                    { 198L, null, "Zimbabwe" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "29294EBC61AAC9B0130B3FD70DB42F7C9560256FE65C53937393784646F3E4BC8903755220DBF5E8E4DAEA8CF8B4A4A9F6127E4EC6F9ED2499D6C51339B3DED0", new byte[] { 150, 52, 149, 5, 53, 189, 15, 108, 239, 199, 89, 86, 163, 66, 164, 26, 66, 239, 239, 21, 96, 137, 66, 106, 158, 123, 162, 231, 151, 88, 22, 134, 54, 52, 245, 175, 78, 16, 184, 117, 96, 34, 173, 46, 68, 223, 128, 70, 243, 189, 31, 246, 240, 35, 76, 168, 75, 47, 133, 179, 166, 26, 82, 146 } });
        }
    }
}
