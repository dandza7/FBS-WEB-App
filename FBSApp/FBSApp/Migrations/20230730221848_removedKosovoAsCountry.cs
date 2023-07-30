using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class removedKosovoAsCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L);

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
                value: "Myanmar");

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
                values: new object[] { "91A841874A385D6B30583DC8C96A5AA05E17E048969A98F1835DCF5BCD4EB967D36DBA91AC8D3C5F29AB7A31B0347F3F65B6321274712EBA68EF12510B16539C", new byte[] { 7, 255, 15, 6, 179, 98, 63, 99, 114, 93, 129, 123, 110, 153, 178, 229, 29, 103, 230, 83, 240, 111, 31, 159, 105, 118, 159, 171, 103, 101, 244, 229, 156, 125, 182, 158, 196, 190, 86, 132, 157, 244, 82, 189, 247, 59, 3, 43, 241, 249, 206, 183, 4, 82, 164, 219, 20, 160, 133, 175, 61, 207, 226, 214 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L,
                column: "Name",
                value: "Kosovo");

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
                value: "Senegal");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "Name",
                value: "Serbia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "Name",
                value: "Seychelles");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "Name",
                value: "Sierra Leone");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "Name",
                value: "Singapore");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "Name",
                value: "Slovakia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Name",
                value: "Slovenia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "Name",
                value: "Solomon Islands");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "Name",
                value: "Somalia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "Name",
                value: "South Africa");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "Name",
                value: "South Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "Name",
                value: "Spain");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Name",
                value: "Sri Lanka");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "Name",
                value: "Sudan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "Name",
                value: "Suriname");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "Name",
                value: "Swaziland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "Name",
                value: "Sweden");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "Name",
                value: "Switzerland");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "Name",
                value: "Syria");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "Name",
                value: "Taiwan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "Name",
                value: "Tajikistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "Name",
                value: "Tanzania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "Name",
                value: "Thailand");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "Name",
                value: "Togo");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "Name",
                value: "Tonga");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Name",
                value: "Trinidad & Tobago");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "Name",
                value: "Tunisia");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "Name",
                value: "Turkey");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "Name",
                value: "Turkmenistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "Name",
                value: "Tuvalu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "Name",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "Name",
                value: "Ukraine");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "Name",
                value: "United Arab Emirates");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "Name",
                value: "United Kingdom");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "Name",
                value: "United States");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L,
                column: "Name",
                value: "Uruguay");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L,
                column: "Name",
                value: "Uzbekistan");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L,
                column: "Name",
                value: "Vanuatu");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L,
                column: "Name",
                value: "Vatican City");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L,
                column: "Name",
                value: "Venezuela");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L,
                column: "Name",
                value: "Vietnam");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L,
                column: "Name",
                value: "Yemen");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L,
                column: "Name",
                value: "Zambia");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Flag", "Name" },
                values: new object[] { 196L, null, "Zimbabwe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "CE6D652E264FDB262A53C3B37092E55E8C9CAE3DDFDEA0CA32B332547F99211458169C97C36E45F6048A4105FF2EA4D6C3D438E5354E7978D1AEB4E016E08EF8", new byte[] { 79, 89, 22, 68, 184, 223, 159, 247, 90, 85, 142, 50, 156, 217, 154, 221, 139, 160, 210, 207, 171, 98, 63, 185, 20, 93, 224, 132, 253, 253, 238, 205, 134, 229, 55, 79, 148, 66, 194, 29, 140, 160, 88, 13, 245, 65, 132, 109, 12, 0, 100, 248, 129, 87, 27, 245, 234, 244, 218, 198, 56, 126, 162, 206 } });
        }
    }
}
