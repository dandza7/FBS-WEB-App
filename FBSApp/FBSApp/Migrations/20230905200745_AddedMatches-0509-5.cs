using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatches05095 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "GoalInfoId", "IsExtraTime", "IsOwnGoal", "Minute" },
                values: new object[,]
                {
                    { 24011L, 240109L, false, false, 66 },
                    { 24012L, 240113L, false, false, 80 },
                    { 24013L, 240113L, false, false, 86 },
                    { 24121L, 241204L, false, false, 3 },
                    { 24211L, 242103L, false, false, 79 },
                    { 24212L, 242110L, false, false, 47 },
                    { 24213L, 242112L, false, false, 58 },
                    { 24214L, 242112L, false, false, 74 },
                    { 24221L, 242212L, false, false, 3 },
                    { 24222L, 242212L, false, false, 17 },
                    { 24311L, 243112L, false, false, 83 },
                    { 24312L, 243113L, false, false, 66 },
                    { 24321L, 243201L, true, false, 90 },
                    { 24411L, 244109L, false, false, 80 },
                    { 24412L, 244112L, false, false, 66 },
                    { 24421L, 244213L, false, false, 1 },
                    { 24511L, 245105L, true, false, 90 },
                    { 24512L, 245111L, false, false, 87 },
                    { 24521L, 245210L, false, false, 51 },
                    { 24522L, 245211L, false, false, 81 },
                    { 24611L, 246110L, false, false, 77 },
                    { 24621L, 246212L, false, false, 41 },
                    { 24711L, 247103L, true, false, 90 },
                    { 24712L, 247100L, false, false, 63 },
                    { 24713L, 247113L, false, false, 47 },
                    { 24714L, 247113L, false, false, 74 },
                    { 24811L, 248112L, false, false, 87 },
                    { 24812L, 248113L, false, false, 80 },
                    { 24821L, 248207L, false, false, 38 },
                    { 24911L, 249112L, false, false, 3 },
                    { 24921L, 249209L, true, false, 45 },
                    { 25011L, 250104L, false, false, 83 },
                    { 25111L, 251110L, false, false, 27 },
                    { 25121L, 251211L, false, false, 66 },
                    { 25122L, 251200L, false, false, 7 },
                    { 25123L, 251204L, false, false, 45 },
                    { 25211L, 252113L, false, false, 25 },
                    { 25212L, 252104L, false, false, 87 },
                    { 25311L, 253102L, true, false, 45 },
                    { 25312L, 253102L, false, false, 66 },
                    { 25313L, 253109L, false, false, 86 },
                    { 25314L, 253113L, false, false, 16 },
                    { 25315L, 253113L, false, false, 39 },
                    { 25411L, 254113L, true, false, 90 },
                    { 25421L, 254204L, false, false, 55 },
                    { 25611L, 256104L, false, false, 5 },
                    { 25612L, 256104L, false, false, 46 },
                    { 25721L, 257202L, false, false, 9 },
                    { 25811L, 258100L, false, false, 1 },
                    { 25812L, 258100L, false, false, 44 },
                    { 25813L, 258100L, false, false, 61 },
                    { 25821L, 258208L, false, false, 11 },
                    { 25911L, 258112L, false, false, 28 },
                    { 25921L, 258212L, false, false, 22 },
                    { 26021L, 260200L, false, false, 23 },
                    { 26022L, 260202L, false, false, 14 },
                    { 26023L, 260202L, false, false, 65 },
                    { 26111L, 261101L, false, false, 65 },
                    { 26211L, 262108L, true, false, 90 },
                    { 26221L, 262203L, true, false, 90 },
                    { 26222L, 262210L, false, false, 69 },
                    { 26311L, 263100L, false, false, 34 },
                    { 26312L, 263113L, false, false, 48 },
                    { 26313L, 263102L, false, false, 24 },
                    { 26411L, 264105L, true, false, 90 },
                    { 26421L, 264204L, false, false, 16 },
                    { 26422L, 264213L, false, false, 44 },
                    { 26511L, 265112L, false, false, 76 },
                    { 26521L, 265211L, false, false, 27 },
                    { 26611L, 266108L, false, false, 76 },
                    { 26621L, 266209L, false, false, 74 },
                    { 26622L, 266210L, false, false, 26 },
                    { 26623L, 266210L, false, false, 61 },
                    { 26711L, 267108L, false, false, 33 },
                    { 26712L, 267112L, false, false, 63 },
                    { 26713L, 267113L, true, false, 90 },
                    { 26721L, 267201L, false, false, 76 },
                    { 26811L, 268100L, false, false, 13 },
                    { 26812L, 268100L, false, false, 19 },
                    { 26813L, 268100L, false, false, 56 },
                    { 26814L, 268111L, false, false, 25 },
                    { 26815L, 268113L, false, false, 4 },
                    { 26816L, 268113L, false, false, 80 },
                    { 26911L, 269109L, true, false, 90 },
                    { 26921L, 269202L, false, false, 56 },
                    { 27021L, 270203L, true, false, 90 },
                    { 27022L, 270210L, true, false, 45 },
                    { 27111L, 271107L, false, false, 40 },
                    { 27112L, 271111L, true, false, 90 },
                    { 27113L, 271102L, false, false, 29 },
                    { 27121L, 271212L, false, false, 3 },
                    { 27211L, 272109L, false, false, 82 },
                    { 27221L, 272204L, false, false, 18 },
                    { 27222L, 272204L, false, false, 61 },
                    { 27223L, 272204L, false, false, 63 },
                    { 27224L, 272213L, false, false, 73 },
                    { 27225L, 272213L, true, false, 90 },
                    { 27311L, 273112L, false, false, 83 },
                    { 27312L, 273113L, false, false, 57 },
                    { 27321L, 273213L, false, false, 65 },
                    { 27411L, 274111L, false, false, 52 },
                    { 27412L, 274104L, false, false, 46 },
                    { 27511L, 275111L, false, false, 14 },
                    { 27521L, 275204L, false, false, 83 },
                    { 27611L, 276108L, false, false, 64 },
                    { 27621L, 276211L, false, false, 81 },
                    { 27622L, 276204L, false, false, 40 },
                    { 27623L, 276213L, false, false, 70 },
                    { 27624L, 276213L, true, false, 90 },
                    { 27811L, 278112L, false, false, 17 },
                    { 27812L, 278113L, false, false, 6 },
                    { 27911L, 279102L, false, false, 63 },
                    { 27912L, 279113L, false, false, 38 },
                    { 27913L, 279104L, false, false, 60 },
                    { 28011L, 280112L, false, false, 10 },
                    { 28012L, 280104L, false, false, 63 },
                    { 28021L, 280211L, false, false, 66 },
                    { 28111L, 281113L, true, false, 90 },
                    { 28221L, 282204L, false, false, 41 },
                    { 28222L, 282204L, false, false, 66 },
                    { 28223L, 282213L, true, false, 90 },
                    { 28311L, 283108L, false, false, 24 },
                    { 28312L, 283102L, false, false, 38 },
                    { 28411L, 284107L, false, false, 40 },
                    { 28412L, 284108L, false, false, 23 },
                    { 28511L, 285103L, false, false, 78 },
                    { 28512L, 285108L, false, false, 47 },
                    { 28513L, 285113L, false, false, 4 },
                    { 28514L, 285102L, false, false, 27 },
                    { 28515L, 285104L, false, false, 59 },
                    { 28521L, 285213L, false, false, 30 },
                    { 28611L, 286104L, false, false, 59 },
                    { 28711L, 287109L, false, false, 79 },
                    { 28712L, 287109L, false, false, 82 },
                    { 28713L, 287102L, false, false, 9 },
                    { 28714L, 287102L, false, false, 20 },
                    { 28715L, 287113L, false, false, 66 },
                    { 28811L, 288107L, false, false, 66 },
                    { 28821L, 288207L, false, false, 83 },
                    { 28822L, 288213L, false, false, 33 },
                    { 28823L, 288213L, false, false, 52 },
                    { 28911L, 289113L, false, false, 57 },
                    { 28921L, 289207L, false, true, 84 }
                });

            migrationBuilder.InsertData(
                table: "PlayedMatches",
                columns: new[] { "Id", "IsStarter", "MatchId", "Minutes", "PlayerId" },
                values: new object[,]
                {
                    { 259100L, true, 259L, 79, 318L },
                    { 259101L, false, 259L, 11, 303L },
                    { 259102L, true, 259L, 79, 324L },
                    { 259103L, false, 259L, 11, 330L },
                    { 259104L, true, 259L, 89, 313L },
                    { 259105L, false, 259L, 1, 305L },
                    { 259106L, true, 259L, 90, 322L },
                    { 259107L, true, 259L, 90, 333L },
                    { 259108L, true, 259L, 90, 315L },
                    { 259109L, true, 259L, 90, 304L },
                    { 259110L, true, 259L, 90, 300L },
                    { 259111L, true, 259L, 90, 311L },
                    { 259112L, true, 259L, 90, 326L },
                    { 259113L, true, 259L, 90, 331L },
                    { 259114L, false, 259L, 0, 601L },
                    { 259115L, false, 259L, 0, 314L },
                    { 259116L, false, 259L, 0, 321L },
                    { 259117L, false, 259L, 0, 329L },
                    { 259200L, true, 259L, 69, 600L },
                    { 259201L, false, 259L, 21, 634L },
                    { 259202L, true, 259L, 75, 627L },
                    { 259203L, false, 259L, 15, 611L },
                    { 259204L, true, 259L, 90, 604L },
                    { 259205L, true, 259L, 90, 615L },
                    { 259206L, true, 259L, 90, 617L },
                    { 259207L, true, 259L, 90, 633L },
                    { 259208L, true, 259L, 90, 605L },
                    { 259209L, true, 259L, 90, 612L },
                    { 259210L, true, 259L, 90, 621L },
                    { 259211L, true, 259L, 90, 620L },
                    { 259212L, true, 259L, 90, 628L },
                    { 259213L, false, 259L, 0, 625L },
                    { 259214L, false, 259L, 0, 608L },
                    { 259215L, false, 259L, 0, 630L },
                    { 259216L, false, 259L, 0, 602L },
                    { 259217L, false, 259L, 0, 609L }
                });

            migrationBuilder.InsertData(
                table: "TeamStats",
                columns: new[] { "Id", "BlockedShots", "CornerKicks", "Fouls", "FreeKicks", "Offsides", "Passes", "Possession", "RedCards", "Saves", "Shots", "ShotsOnTarget", "Tackles", "TeamMatchInfoId", "YellowCards" },
                values: new object[,]
                {
                    { 2401L, 7, 5, 8, 10, 2, 477, 55, 0, 0, 20, 9, 23, 2401L, 4 },
                    { 2402L, 1, 1, 10, 10, 0, 400, 45, 0, 6, 4, 0, 16, 2402L, 1 },
                    { 2411L, 2, 3, 13, 9, 0, 548, 58, 0, 4, 10, 2, 17, 2411L, 1 },
                    { 2412L, 1, 4, 10, 14, 0, 400, 42, 1, 2, 10, 5, 25, 2412L, 4 },
                    { 2421L, 8, 10, 10, 6, 1, 623, 62, 0, 4, 24, 7, 6, 2421L, 2 },
                    { 2422L, 4, 1, 5, 12, 1, 382, 38, 0, 3, 15, 6, 14, 2422L, 3 },
                    { 2431L, 6, 4, 14, 14, 0, 590, 71, 0, 1, 15, 4, 13, 2431L, 3 },
                    { 2432L, 8, 7, 12, 13, 1, 232, 29, 0, 2, 19, 2, 16, 2432L, 3 },
                    { 2441L, 2, 1, 9, 10, 2, 239, 24, 0, 3, 6, 2, 20, 2441L, 2 },
                    { 2442L, 5, 8, 7, 11, 5, 767, 76, 0, 0, 12, 4, 22, 2442L, 3 },
                    { 2451L, 8, 11, 10, 11, 2, 650, 74, 0, 2, 28, 9, 5, 2451L, 1 },
                    { 2452L, 2, 3, 9, 12, 4, 228, 26, 0, 7, 6, 4, 13, 2452L, 3 },
                    { 2461L, 4, 3, 11, 8, 2, 529, 59, 0, 2, 13, 4, 25, 2461L, 2 },
                    { 2462L, 3, 8, 8, 13, 0, 370, 41, 1, 3, 15, 3, 24, 2462L, 4 },
                    { 2471L, 3, 3, 8, 12, 1, 331, 32, 0, 7, 12, 7, 10, 2471L, 1 },
                    { 2472L, 2, 7, 6, 8, 6, 714, 68, 0, 3, 11, 7, 17, 2472L, 0 },
                    { 2481L, 8, 9, 6, 13, 1, 588, 69, 0, 0, 17, 3, 17, 2481L, 0 },
                    { 2482L, 3, 5, 9, 8, 5, 274, 31, 0, 1, 9, 1, 18, 2482L, 4 },
                    { 2491L, 2, 7, 13, 9, 4, 779, 72, 0, 1, 10, 3, 15, 2491L, 1 },
                    { 2492L, 1, 1, 6, 18, 3, 301, 28, 0, 2, 5, 2, 19, 2492L, 3 },
                    { 2501L, 9, 6, 6, 7, 2, 744, 72, 0, 2, 21, 4, 10, 2501L, 0 },
                    { 2502L, 3, 3, 6, 8, 2, 295, 28, 0, 3, 8, 2, 17, 2502L, 1 },
                    { 2511L, 7, 3, 12, 14, 2, 534, 64, 0, 1, 13, 4, 19, 2511L, 3 },
                    { 2512L, 2, 1, 14, 13, 1, 306, 36, 0, 3, 8, 4, 22, 2512L, 1 },
                    { 2521L, 5, 11, 9, 11, 1, 346, 37, 0, 0, 17, 6, 25, 2521L, 2 },
                    { 2522L, 1, 1, 12, 10, 1, 608, 63, 0, 4, 8, 0, 16, 2522L, 3 },
                    { 2531L, 8, 11, 8, 5, 2, 737, 65, 0, 2, 23, 7, 27, 2531L, 0 },
                    { 2532L, 2, 2, 5, 10, 1, 395, 35, 0, 2, 5, 2, 13, 2532L, 0 },
                    { 2541L, 6, 4, 10, 8, 2, 457, 54, 0, 3, 15, 6, 12, 2541L, 3 },
                    { 2542L, 3, 2, 9, 12, 0, 404, 46, 0, 5, 10, 4, 17, 2542L, 1 },
                    { 2551L, 4, 7, 15, 12, 4, 456, 55, 0, 0, 21, 4, 21, 2551L, 1 },
                    { 2552L, 0, 0, 10, 17, 0, 383, 45, 0, 4, 5, 0, 26, 2552L, 0 },
                    { 2561L, 7, 6, 17, 13, 2, 218, 27, 0, 2, 12, 5, 17, 2561L, 1 },
                    { 2562L, 2, 7, 14, 18, 0, 615, 73, 0, 3, 9, 2, 13, 2562L, 2 },
                    { 2571L, 3, 7, 14, 10, 0, 418, 45, 0, 5, 17, 6, 12, 2571L, 4 },
                    { 2572L, 2, 2, 9, 14, 1, 532, 55, 0, 6, 10, 6, 17, 2572L, 4 },
                    { 2581L, 4, 4, 11, 8, 5, 613, 59, 0, 1, 19, 12, 13, 2581L, 1 },
                    { 2582L, 2, 2, 8, 17, 0, 432, 41, 0, 9, 4, 2, 10, 2582L, 1 },
                    { 2591L, 4, 2, 9, 14, 1, 245, 27, 0, 5, 13, 2, 19, 2591L, 1 },
                    { 2592L, 2, 5, 11, 10, 3, 690, 73, 0, 1, 11, 6, 16, 2592L, 1 },
                    { 2601L, 5, 5, 14, 12, 2, 503, 51, 0, 4, 15, 3, 21, 2601L, 3 },
                    { 2602L, 4, 4, 9, 13, 3, 483, 49, 0, 3, 15, 7, 11, 2602L, 2 },
                    { 2611L, 2, 8, 21, 16, 0, 327, 44, 0, 4, 7, 2, 22, 2611L, 2 },
                    { 2612L, 1, 2, 10, 22, 6, 425, 56, 1, 1, 9, 4, 22, 2612L, 2 },
                    { 2621L, 2, 8, 15, 15, 0, 539, 67, 0, 1, 14, 7, 18, 2621L, 3 },
                    { 2622L, 0, 2, 12, 15, 3, 267, 33, 0, 6, 6, 3, 15, 2622L, 3 },
                    { 2631L, 5, 8, 14, 8, 1, 707, 66, 0, 2, 20, 9, 23, 2631L, 2 },
                    { 2632L, 5, 5, 6, 16, 2, 362, 34, 0, 6, 12, 2, 12, 2632L, 2 },
                    { 2641L, 3, 5, 17, 13, 2, 482, 55, 0, 2, 15, 6, 25, 2641L, 3 },
                    { 2642L, 1, 0, 12, 18, 1, 410, 45, 0, 5, 9, 4, 19, 2642L, 2 },
                    { 2651L, 10, 10, 12, 10, 4, 482, 57, 0, 3, 25, 5, 16, 2651L, 3 },
                    { 2652L, 1, 4, 9, 15, 1, 371, 43, 0, 4, 6, 4, 21, 2652L, 0 },
                    { 2661L, 6, 9, 8, 8, 1, 519, 68, 0, 2, 16, 6, 10, 2661L, 1 },
                    { 2662L, 2, 3, 7, 8, 0, 253, 32, 0, 5, 9, 5, 11, 2662L, 1 },
                    { 2671L, 5, 2, 11, 9, 7, 499, 53, 0, 8, 12, 5, 14, 2671L, 3 },
                    { 2672L, 2, 9, 4, 17, 5, 437, 47, 0, 2, 20, 9, 12, 2672L, 1 },
                    { 2681L, 1, 2, 9, 13, 2, 681, 56, 0, 4, 15, 9, 14, 2681L, 1 },
                    { 2682L, 5, 2, 13, 12, 1, 535, 44, 0, 3, 12, 4, 23, 2682L, 2 },
                    { 2691L, 8, 13, 7, 10, 1, 623, 59, 0, 2, 22, 6, 15, 2691L, 1 },
                    { 2692L, 4, 1, 9, 8, 1, 434, 41, 0, 5, 9, 3, 21, 2692L, 3 },
                    { 2701L, 3, 5, 12, 11, 0, 336, 39, 0, 2, 4, 1, 26, 2701L, 1 },
                    { 2702L, 7, 6, 6, 12, 5, 546, 61, 0, 1, 15, 4, 21, 2702L, 1 },
                    { 2711L, 5, 12, 11, 14, 3, 553, 55, 0, 4, 21, 7, 24, 2711L, 1 },
                    { 2712L, 1, 0, 11, 16, 3, 473, 45, 0, 4, 8, 5, 18, 2712L, 1 },
                    { 2721L, 4, 3, 10, 12, 3, 313, 35, 0, 2, 15, 6, 23, 2721L, 1 },
                    { 2722L, 1, 3, 11, 13, 1, 579, 65, 0, 5, 12, 7, 14, 2722L, 2 },
                    { 2731L, 3, 7, 9, 12, 4, 214, 31, 0, 5, 10, 4, 12, 2731L, 1 },
                    { 2732L, 6, 6, 12, 12, 0, 504, 69, 0, 2, 17, 6, 16, 2732L, 3 },
                    { 2741L, 6, 12, 11, 7, 0, 549, 54, 0, 1, 29, 12, 13, 2741L, 2 },
                    { 2742L, 2, 0, 7, 11, 0, 480, 46, 1, 10, 3, 0, 10, 2742L, 0 },
                    { 2751L, 2, 9, 10, 16, 1, 370, 45, 0, 1, 10, 3, 21, 2751L, 4 },
                    { 2752L, 3, 8, 15, 10, 3, 468, 55, 0, 2, 10, 2, 21, 2752L, 5 },
                    { 2761L, 12, 8, 7, 13, 0, 541, 65, 0, 1, 27, 5, 19, 2761L, 2 },
                    { 2762L, 0, 3, 14, 5, 1, 289, 35, 0, 4, 7, 5, 15, 2762L, 1 },
                    { 2771L, 2, 3, 15, 17, 3, 317, 35, 0, 1, 6, 3, 18, 2771L, 1 },
                    { 2772L, 2, 7, 17, 18, 1, 565, 65, 0, 3, 7, 1, 19, 2772L, 3 },
                    { 2781L, 4, 6, 7, 15, 3, 582, 62, 0, 4, 12, 4, 14, 2781L, 0 },
                    { 2782L, 3, 4, 14, 10, 1, 346, 38, 0, 2, 10, 4, 16, 2782L, 0 },
                    { 2791L, 5, 7, 5, 10, 0, 753, 68, 0, 1, 17, 4, 22, 2791L, 0 },
                    { 2792L, 0, 1, 9, 5, 2, 350, 32, 0, 1, 3, 1, 18, 2792L, 0 },
                    { 2801L, 7, 4, 6, 11, 2, 446, 49, 0, 2, 19, 3, 14, 2801L, 1 },
                    { 2802L, 3, 8, 4, 11, 4, 444, 51, 0, 1, 15, 3, 6, 2802L, 1 },
                    { 2811L, 3, 3, 10, 13, 0, 445, 50, 0, 0, 15, 3, 24, 2811L, 2 },
                    { 2812L, 2, 5, 10, 9, 4, 461, 50, 0, 2, 7, 0, 20, 2812L, 2 },
                    { 2821L, 1, 3, 12, 13, 3, 257, 33, 0, 1, 6, 0, 21, 2821L, 3 },
                    { 2822L, 3, 4, 12, 15, 1, 534, 67, 0, 0, 12, 4, 10, 2822L, 1 },
                    { 2831L, 1, 4, 8, 10, 0, 445, 54, 0, 2, 12, 3, 19, 2831L, 1 },
                    { 2832L, 4, 7, 8, 8, 2, 367, 46, 0, 1, 12, 2, 24, 2832L, 3 },
                    { 2841L, 3, 7, 15, 15, 2, 380, 41, 0, 4, 14, 4, 21, 2841L, 0 },
                    { 2842L, 6, 4, 13, 17, 2, 566, 59, 0, 2, 14, 4, 15, 2842L, 1 },
                    { 2851L, 5, 9, 11, 12, 4, 650, 65, 0, 4, 16, 6, 7, 2851L, 2 },
                    { 2852L, 4, 4, 9, 13, 4, 346, 35, 0, 1, 13, 5, 18, 2852L, 2 },
                    { 2861L, 2, 12, 2, 7, 7, 780, 75, 0, 1, 20, 7, 14, 2861L, 0 },
                    { 2862L, 0, 2, 6, 9, 2, 255, 25, 0, 6, 2, 1, 14, 2862L, 2 },
                    { 2871L, 5, 6, 5, 8, 1, 627, 62, 0, 3, 19, 10, 17, 2871L, 0 },
                    { 2872L, 1, 4, 7, 6, 2, 392, 38, 0, 5, 5, 3, 29, 2872L, 2 },
                    { 2881L, 4, 5, 8, 6, 2, 374, 45, 0, 1, 17, 2, 20, 2881L, 2 },
                    { 2882L, 4, 6, 9, 10, 0, 468, 55, 0, 1, 13, 4, 20, 2882L, 3 },
                    { 2891L, 2, 2, 7, 15, 1, 480, 47, 0, 0, 11, 1, 27, 2891L, 1 },
                    { 2892L, 4, 2, 14, 8, 1, 546, 53, 0, 0, 9, 0, 23, 2892L, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "1191E6D66616CE2E7F397A4231365D6620192987668185E894936FAE07C80FF3BFF6069C6BBCDC14F5ED42CE96A28981A01ABBF5C21CEAA129F7DC63CF7A14DC", new byte[] { 222, 21, 51, 209, 48, 83, 32, 21, 59, 215, 146, 183, 121, 4, 41, 137, 194, 192, 146, 84, 49, 155, 38, 154, 66, 71, 115, 200, 12, 109, 100, 228, 131, 88, 189, 156, 216, 241, 35, 48, 214, 143, 247, 30, 123, 105, 164, 21, 139, 42, 153, 218, 92, 86, 157, 198, 78, 160, 255, 179, 185, 132, 160, 87 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "5774CA7283C63585101ECB6C964D8F95888E66884DA35AA4F1B23A29755F831C70AFCF5452C27F34A00B0E6E5122E2CA2A46102C16FC255C188003606EAD48A6", new byte[] { 104, 214, 92, 173, 101, 30, 182, 170, 66, 48, 242, 208, 70, 223, 141, 203, 224, 248, 187, 239, 198, 108, 177, 193, 187, 7, 253, 4, 204, 54, 186, 189, 227, 187, 210, 196, 47, 124, 88, 188, 135, 190, 20, 169, 12, 102, 73, 54, 4, 114, 37, 48, 98, 121, 84, 183, 212, 117, 199, 122, 23, 175, 248, 130 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24012L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24013L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24212L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24213L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24214L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24222L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24522L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24712L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24713L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24714L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 24921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25122L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25123L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25212L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25313L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25314L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25315L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25612L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 25921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26023L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26222L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26313L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26421L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26422L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26622L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26623L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26712L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26713L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26721L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26813L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26814L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26815L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26816L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 26921L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27022L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27112L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27113L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27121L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27211L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27222L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27223L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27224L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27225L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27321L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27621L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27622L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27623L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27624L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27812L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27912L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 27913L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28011L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28012L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28021L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28111L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28221L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28222L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28223L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28311L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28312L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28411L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28412L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28511L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28512L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28513L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28514L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28515L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28521L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28611L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28711L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28712L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28713L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28714L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28715L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28811L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28821L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28822L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28823L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28911L);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 28921L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259100L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259101L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259102L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259103L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259104L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259105L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259106L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259107L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259108L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259109L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259110L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259111L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259112L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259113L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259114L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259115L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259116L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259117L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259200L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259201L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259202L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259203L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259204L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259205L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259206L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259207L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259208L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259209L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259210L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259211L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259212L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259213L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259214L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259215L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259216L);

            migrationBuilder.DeleteData(
                table: "PlayedMatches",
                keyColumn: "Id",
                keyValue: 259217L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2401L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2402L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2411L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2412L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2421L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2422L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2431L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2432L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2441L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2442L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2451L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2452L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2461L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2462L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2471L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2472L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2481L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2482L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2491L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2492L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2501L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2502L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2511L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2512L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2521L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2522L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2531L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2532L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2541L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2542L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2551L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2552L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2561L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2562L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2571L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2572L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2581L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2582L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2591L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2592L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2601L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2602L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2611L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2612L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2621L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2622L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2631L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2632L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2641L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2642L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2651L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2652L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2661L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2662L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2671L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2672L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2681L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2682L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2691L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2692L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2701L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2702L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2711L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2712L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2721L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2722L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2731L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2732L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2741L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2742L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2751L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2752L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2761L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2762L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2771L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2772L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2781L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2782L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2791L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2792L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2801L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2802L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2811L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2812L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2821L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2822L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2831L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2832L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2841L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2842L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2851L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2852L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2861L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2862L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2871L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2872L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2881L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2882L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2891L);

            migrationBuilder.DeleteData(
                table: "TeamStats",
                keyColumn: "Id",
                keyValue: 2892L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "A5203348A5DC8A400E8BBCFB8C01B906A5790C1D1C1E3824F46C734DFA87DB537B1743E9F7BA1095A00E628ECC6504DD6E9C300976171B962A43F7615ED6FC9A", new byte[] { 64, 62, 180, 91, 122, 84, 92, 2, 198, 61, 0, 87, 62, 210, 185, 28, 227, 137, 182, 213, 145, 204, 91, 195, 158, 248, 218, 135, 96, 62, 57, 179, 245, 172, 221, 176, 52, 90, 130, 142, 153, 176, 255, 91, 8, 172, 244, 95, 10, 171, 86, 172, 74, 185, 138, 96, 235, 25, 154, 87, 78, 160, 39, 69 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "38EFE0AB47F9D2FC5527DD924CCE07405C65905843169F7DE37AF94C9889974CE956A8B19B88B329ED34EC7074A19D38AD05CD1A6EE4B6B14F95E06E148890A4", new byte[] { 34, 228, 11, 25, 149, 78, 25, 111, 147, 161, 251, 84, 83, 58, 190, 67, 159, 123, 7, 183, 59, 198, 53, 136, 142, 122, 245, 233, 157, 188, 231, 96, 71, 116, 5, 94, 106, 86, 231, 187, 214, 152, 64, 254, 153, 132, 177, 138, 35, 25, 105, 101, 77, 75, 101, 35, 94, 255, 210, 12, 215, 158, 128, 119 } });
        }
    }
}
