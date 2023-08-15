using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchesPt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 319100L, true, 319L, 72, 103L },
                    { 319101L, false, 319L, 18, 131L },
                    { 319102L, true, 319L, 83, 119L },
                    { 319103L, false, 319L, 7, 105L },
                    { 319104L, true, 319L, 83, 126L },
                    { 319105L, false, 319L, 7, 101L },
                    { 319106L, true, 319L, 90, 113L },
                    { 319107L, true, 319L, 90, 107L },
                    { 319108L, true, 319L, 90, 111L },
                    { 319109L, true, 319L, 90, 135L },
                    { 319110L, true, 319L, 90, 121L },
                    { 319111L, true, 319L, 90, 116L },
                    { 319112L, true, 319L, 90, 129L },
                    { 319113L, true, 319L, 90, 123L },
                    { 319114L, false, 319L, 0, 114L },
                    { 319115L, false, 319L, 0, 120L },
                    { 319116L, false, 319L, 0, 127L },
                    { 319200L, true, 319L, 51, 511L },
                    { 319201L, false, 319L, 39, 518L },
                    { 319202L, true, 319L, 89, 513L },
                    { 319203L, false, 319L, 1, 505L },
                    { 319204L, true, 319L, 89, 527L },
                    { 319205L, false, 319L, 1, 512L },
                    { 319206L, true, 319L, 90, 507L },
                    { 319207L, true, 319L, 90, 517L },
                    { 319208L, true, 319L, 90, 529L },
                    { 319209L, true, 319L, 90, 500L },
                    { 319210L, true, 319L, 90, 520L },
                    { 319211L, true, 319L, 90, 506L },
                    { 319212L, true, 319L, 90, 502L },
                    { 319213L, true, 319L, 90, 523L },
                    { 319214L, false, 319L, 0, 521L },
                    { 319215L, false, 319L, 0, 524L },
                    { 319216L, false, 319L, 0, 519L },
                    { 328100L, true, 328L, 77, 615L },
                    { 328101L, false, 328L, 13, 612L },
                    { 328102L, true, 328L, 77, 618L },
                    { 328103L, false, 328L, 13, 611L },
                    { 328104L, true, 328L, 89, 620L },
                    { 328105L, false, 328L, 1, 610L },
                    { 328106L, true, 328L, 90, 604L },
                    { 328107L, true, 328L, 90, 632L },
                    { 328108L, true, 328L, 90, 617L },
                    { 328109L, true, 328L, 90, 633L },
                    { 328110L, true, 328L, 90, 605L },
                    { 328111L, true, 328L, 90, 613L },
                    { 328112L, true, 328L, 90, 627L },
                    { 328113L, true, 328L, 90, 628L },
                    { 328114L, false, 328L, 0, 621L },
                    { 328115L, false, 328L, 0, 600L },
                    { 328116L, false, 328L, 0, 630L },
                    { 328117L, false, 328L, 0, 634L },
                    { 328200L, true, 328L, 69, 204L },
                    { 328201L, false, 328L, 21, 214L },
                    { 328202L, true, 328L, 82, 221L },
                    { 328203L, false, 328L, 8, 200L },
                    { 328204L, true, 328L, 89, 202L },
                    { 328205L, false, 328L, 1, 208L },
                    { 328206L, true, 328L, 90, 215L },
                    { 328207L, true, 328L, 90, 216L },
                    { 328208L, true, 328L, 90, 231L },
                    { 328209L, true, 328L, 90, 224L },
                    { 328210L, true, 328L, 90, 219L },
                    { 328211L, true, 328L, 90, 205L },
                    { 328212L, true, 328L, 90, 203L },
                    { 328213L, true, 328L, 90, 212L },
                    { 328214L, false, 328L, 0, 218L },
                    { 328215L, false, 328L, 0, 226L },
                    { 328216L, false, 328L, 0, 225L },
                    { 328217L, false, 328L, 0, 232L },
                    { 348100L, true, 348L, 66, 621L },
                    { 348101L, false, 348L, 24, 613L },
                    { 348102L, true, 348L, 77, 618L },
                    { 348103L, false, 348L, 13, 615L },
                    { 348104L, true, 348L, 89, 620L },
                    { 348105L, false, 348L, 1, 634L },
                    { 348106L, true, 348L, 90, 604L },
                    { 348107L, true, 348L, 90, 632L },
                    { 348108L, true, 348L, 90, 617L },
                    { 348109L, true, 348L, 90, 633L },
                    { 348110L, true, 348L, 90, 605L },
                    { 348111L, true, 348L, 90, 612L },
                    { 348112L, true, 348L, 90, 627L },
                    { 348113L, true, 348L, 90, 628L },
                    { 348114L, false, 348L, 0, 610L },
                    { 348115L, false, 348L, 0, 630L },
                    { 348116L, false, 348L, 0, 611L },
                    { 348117L, false, 348L, 0, 609L },
                    { 348200L, true, 348L, 40, 901L },
                    { 348201L, false, 348L, 50, 900L },
                    { 348202L, true, 348L, 56, 904L },
                    { 348203L, false, 348L, 34, 918L },
                    { 348204L, true, 348L, 75, 938L },
                    { 348205L, false, 348L, 15, 937L },
                    { 348206L, true, 348L, 90, 923L },
                    { 348207L, true, 348L, 90, 905L },
                    { 348208L, true, 348L, 90, 909L },
                    { 348209L, true, 348L, 90, 913L },
                    { 348210L, true, 348L, 90, 932L },
                    { 348211L, true, 348L, 90, 922L },
                    { 348212L, true, 348L, 90, 941L },
                    { 348213L, true, 348L, 90, 912L },
                    { 348214L, false, 348L, 0, 942L },
                    { 348215L, false, 348L, 0, 933L },
                    { 348216L, false, 348L, 0, 930L },
                    { 348217L, false, 348L, 0, 934L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 3191L, 5, 1, 10, 12, 0, 406, 37, 0, 3, 12, 1, 13, 3191L, 2 },
                    { 3192L, 0, 1, 10, 10, 2, 702, 63, 0, 1, 8, 5, 14, 3192L, 2 },
                    { 3281L, 3, 10, 5, 10, 2, 445, 49, 0, 1, 14, 3, 17, 3281L, 0 },
                    { 3282L, 2, 3, 8, 7, 2, 485, 51, 0, 1, 11, 2, 14, 3282L, 1 },
                    { 3481L, 5, 9, 5, 11, 2, 646, 62, 0, 3, 15, 7, 20, 3481L, 0 },
                    { 3482L, 1, 2, 9, 6, 2, 401, 38, 0, 5, 6, 3, 30, 3482L, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E52840F4F0AC36EC2E160C94C66D44B82C18B7566CD204598A67393CA7EF5E95B842346A5A2ACABEB1566C42174ABDB6B79E8DEE833059D8B37E277A46177BBE", new byte[] { 184, 11, 140, 174, 212, 29, 75, 21, 45, 242, 200, 124, 249, 86, 2, 165, 152, 51, 152, 215, 153, 164, 216, 83, 124, 87, 154, 106, 167, 38, 239, 48, 193, 8, 69, 140, 159, 3, 237, 20, 190, 1, 151, 161, 243, 219, 31, 92, 14, 164, 31, 127, 68, 76, 21, 159, 35, 52, 37, 178, 209, 10, 141, 197 } });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 31921L, 319201L, false, false, 66 },
                    { 31922L, 319212L, false, false, 54 },
                    { 32811L, 328112L, false, false, 16 },
                    { 32821L, 328208L, false, true, 90 },
                    { 32822L, 328202L, false, false, 70 },
                    { 34811L, 348104L, false, false, 53 },
                    { 34812L, 348113L, false, false, 51 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 31921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 31922L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 32811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 32821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 32822L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 34811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 34812L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328217L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3191L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3192L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3281L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3282L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3481L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 3482L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 319212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 328208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 348113L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "8B1BABC3EC3A8FCAF430BCF4AFB16CD38FB7752CFD65B4436CA7494B31975B765F730BE8816DC6BD9604763AAE9C203728714E972B9B1DA988A1A9850E19D540", new byte[] { 151, 55, 75, 83, 213, 217, 65, 1, 106, 217, 44, 8, 244, 32, 53, 99, 198, 112, 189, 155, 142, 137, 182, 208, 109, 164, 70, 208, 16, 128, 100, 165, 103, 44, 108, 37, 57, 94, 42, 78, 140, 66, 203, 184, 109, 13, 212, 238, 170, 243, 22, 145, 236, 86, 119, 72, 217, 83, 39, 138, 102, 247, 188, 119 } });
        }
    }
}
