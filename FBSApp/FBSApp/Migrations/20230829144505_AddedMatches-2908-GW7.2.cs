using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches2908GW72 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 78100L, true, 78L, 71, 1815L },
                    { 78101L, false, 78L, 19, 1805L },
                    { 78102L, true, 78L, 79, 1811L },
                    { 78103L, false, 78L, 11, 1806L },
                    { 78104L, true, 78L, 90, 1821L },
                    { 78105L, true, 78L, 90, 1803L },
                    { 78106L, true, 78L, 90, 1823L },
                    { 78107L, true, 78L, 90, 1824L },
                    { 78108L, true, 78L, 90, 1807L },
                    { 78109L, true, 78L, 90, 1430L },
                    { 78110L, true, 78L, 90, 1808L },
                    { 78111L, true, 78L, 90, 1812L },
                    { 78112L, true, 78L, 90, 1804L },
                    { 78113L, false, 78L, 0, 1810L },
                    { 78114L, false, 78L, 0, 1802L },
                    { 78115L, false, 78L, 0, 1814L },
                    { 78116L, false, 78L, 0, 1809L },
                    { 78200L, true, 78L, 27, 1610L },
                    { 78201L, false, 78L, 63, 1616L },
                    { 78202L, true, 78L, 72, 1617L },
                    { 78203L, false, 78L, 18, 1606L },
                    { 78204L, true, 78L, 90, 1613L },
                    { 78205L, true, 78L, 90, 1618L },
                    { 78206L, true, 78L, 90, 1604L },
                    { 78207L, true, 78L, 90, 1605L },
                    { 78208L, true, 78L, 90, 1614L },
                    { 78209L, true, 78L, 90, 1609L },
                    { 78210L, true, 78L, 90, 1602L },
                    { 78211L, true, 78L, 90, 1600L },
                    { 78212L, true, 78L, 90, 1624L },
                    { 78213L, false, 78L, 0, 1622L },
                    { 78214L, false, 78L, 0, 1601L },
                    { 78215L, false, 78L, 0, 1626L },
                    { 78216L, false, 78L, 0, 1627L },
                    { 78217L, false, 78L, 0, 1612L },
                    { 79100L, true, 79L, 58, 1711L },
                    { 79101L, false, 79L, 32, 1710L },
                    { 79102L, true, 79L, 84, 1722L },
                    { 79103L, false, 79L, 6, 1723L },
                    { 79104L, true, 79L, 90, 1706L },
                    { 79105L, true, 79L, 90, 1732L },
                    { 79106L, true, 79L, 90, 1733L },
                    { 79107L, true, 79L, 90, 1728L },
                    { 79108L, true, 79L, 90, 1701L },
                    { 79109L, true, 79L, 90, 1719L },
                    { 79110L, true, 79L, 90, 1724L },
                    { 79111L, true, 79L, 90, 1730L },
                    { 79112L, true, 79L, 90, 1707L },
                    { 79113L, false, 79L, 0, 1705L },
                    { 79114L, false, 79L, 0, 1720L },
                    { 79115L, false, 79L, 0, 1118L },
                    { 79116L, false, 79L, 0, 1712L },
                    { 79117L, false, 79L, 0, 1703L },
                    { 79200L, true, 79L, 77, 1411L },
                    { 79201L, false, 79L, 13, 1408L },
                    { 79202L, true, 79L, 82, 1414L },
                    { 79203L, false, 79L, 8, 1400L },
                    { 79204L, true, 79L, 84, 1420L },
                    { 79205L, false, 79L, 6, 1404L },
                    { 79206L, true, 79L, 90, 1431L },
                    { 79207L, true, 79L, 90, 100L },
                    { 79208L, true, 79L, 90, 1409L },
                    { 79209L, true, 79L, 90, 1418L },
                    { 79210L, true, 79L, 90, 1422L },
                    { 79211L, true, 79L, 90, 1416L },
                    { 79212L, true, 79L, 90, 1401L },
                    { 79213L, true, 79L, 90, 1432L },
                    { 79214L, false, 79L, 0, 1429L },
                    { 79215L, false, 79L, 0, 1419L },
                    { 79216L, false, 79L, 0, 1410L },
                    { 79217L, false, 79L, 0, 1412L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 781L, 6, 10, 11, 16, 2, 317, 54, 0, 0, 19, 5, 9, 781L, 1 },
                    { 782L, 0, 2, 15, 13, 1, 286, 46, 0, 4, 3, 2, 12, 782L, 3 },
                    { 791L, 2, 3, 9, 13, 2, 425, 44, 0, 1, 11, 5, 12, 791L, 3 },
                    { 792L, 4, 3, 12, 11, 2, 532, 56, 0, 3, 10, 2, 20, 792L, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "32EAD1C094A92997E84BC327A15C61CE8AF61D155067164862589EF40933E986A29CECA7CB4E0064AC26451F37B2E587E4172DDA4F58E08A571542C0F497EA91", new byte[] { 88, 145, 19, 2, 200, 141, 232, 229, 39, 191, 62, 80, 86, 16, 72, 122, 135, 120, 88, 189, 65, 180, 254, 62, 253, 161, 8, 8, 15, 96, 30, 218, 113, 213, 94, 93, 67, 218, 138, 54, 65, 198, 195, 33, 96, 184, 193, 124, 97, 111, 178, 142, 150, 88, 67, 36, 181, 32, 184, 241, 166, 160, 79, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6943E11D4519DC36A5E9EEF40532F1E51FE0A7F6952E9EEE64210EAA5EDD1317EFE89E14CE9E2BDF667B3849BD4985916F9B8CCFE94D265A138E920E611C54A5", new byte[] { 39, 13, 152, 217, 36, 64, 48, 186, 38, 41, 71, 30, 62, 250, 183, 89, 45, 0, 91, 149, 133, 229, 210, 250, 171, 164, 214, 28, 123, 146, 92, 183, 75, 252, 189, 7, 37, 198, 22, 12, 118, 8, 148, 169, 234, 148, 91, 98, 175, 238, 20, 61, 188, 24, 4, 76, 145, 163, 195, 230, 82, 80, 196, 113 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 7811L, 78111L, false, false, 60 },
                    { 7821L, 78208L, false, false, 51 },
                    { 7822L, 78212L, false, false, 70 },
                    { 7911L, 79103L, false, false, 87 },
                    { 7912L, 79100L, false, false, 5 },
                    { 7921L, 79210L, false, false, 55 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7822L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7912L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7921L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 781L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 782L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 791L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 792L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 78212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 79210L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "1F83224D387ED96561178BD24B1C11CD28D1A6ACE06DED684121420EC8368EEC6EB725EF191440D1B52E2669F2A6D4B704D5473BDEF2AE1F9327B89CA5EA247A", new byte[] { 36, 111, 221, 117, 110, 211, 234, 79, 12, 173, 81, 207, 188, 88, 186, 149, 176, 121, 37, 98, 114, 226, 183, 182, 56, 246, 133, 138, 122, 194, 201, 15, 93, 196, 8, 158, 124, 100, 171, 124, 157, 162, 236, 195, 173, 80, 39, 69, 210, 133, 217, 204, 17, 106, 112, 242, 160, 21, 230, 122, 154, 167, 25, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "DA0B7EBC1BB9CE180D2077FCA83ABE9922A1E33AE51EA7FDE166A3639E2FA0D1FE83B2DC65F0844742230EFFC4C2D5A47FE0BB9457C159ADDE7A0FF8D2C77272", new byte[] { 145, 140, 91, 9, 193, 115, 66, 164, 30, 225, 100, 14, 21, 204, 178, 94, 235, 134, 132, 26, 151, 170, 3, 145, 142, 77, 161, 62, 198, 78, 242, 93, 138, 127, 6, 200, 142, 69, 117, 167, 225, 140, 219, 66, 94, 4, 9, 79, 154, 56, 153, 119, 189, 135, 242, 215, 177, 42, 191, 17, 255, 29, 211, 113 } });
        }
    }
}
