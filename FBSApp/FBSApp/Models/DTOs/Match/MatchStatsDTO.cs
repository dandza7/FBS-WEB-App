using FBSApp.Models.DTOs.TeamStats;

namespace FBSApp.Models.DTOs.Match
{
    public class MatchStatsDTO
    {
        public TeamStatsDTO HomeTeamStats { get; set; }
        public TeamStatsDTO AwayTeamStats { get; set; }
    }
}
