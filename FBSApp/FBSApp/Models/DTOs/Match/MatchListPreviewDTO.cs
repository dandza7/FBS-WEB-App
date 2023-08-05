using FBSApp.Models.DTOs.Team;

namespace FBSApp.Models.DTOs.Match
{
    public class MatchListPreviewDTO
    {
        public long Id { get; set; }
        public TeamListPreviewDTO HomeTeam { get; set; }
        public TeamListPreviewDTO AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
