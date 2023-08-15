namespace FBSApp.Models.DTOs.Season
{
    public class TableCalculationQuery
    {
        public TCQ_GoalsMinuteFilter? GoalsMinuteFilter { get; set; }
        public TCQ_DateFilter? DateFilter { get; set; }
        public TCQ_GameweeksFilter? GameweeksFilter { get; set; }
        public TCQ_PlayedGameweeksFilter? PlayedGameweeksFilter { get; set; }
        public TCQ_TeamsSubsetFilter? TeamsSubsetFilter { get; set; }
    }

    public class TCQ_GoalsMinuteFilter
    {
        public int LowerLimitFirstHalf { get; set; }
        public int UpperLimitFirstHalf { get; set; }
        public bool ExtraTimeIncludedFirstHalf { get; set; }
        public int LowerLimitSecondHalf { get; set; }
        public int UpperLimitSecondHalf { get; set; }
        public bool ExtraTimeIncludedSecondHalf { get; set; }
    }

    public class TCQ_DateFilter
    {
        public DateTime LowerLimit { get; set; }
        public DateTime UpperLimit { get; set; }
    }

    public class TCQ_GameweeksFilter
    {
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
    }

    public class TCQ_PlayedGameweeksFilter
    {
        public int PlayedGameweeks { get; set; }
    }

    public class TCQ_TeamsSubsetFilter
    {
        public List<long> Ids { get; set; }
    }
}
