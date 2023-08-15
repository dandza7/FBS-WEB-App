using FBSApp.Models.DTOs.Team;

namespace FBSApp.Models.DTOs.Match
{
    public class PlayersMatchDTO
    {
        public long Id { get; set; }
        public TeamListPreviewDTO HomeTeam { get; set; }
        public TeamListPreviewDTO AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public int Gameweek { get; set; }
        public int Minutes { get; set; }
        public int Goals { get; set; }
        public int OwnGoals { get; set; }
        public bool IsStarter { get; set; }
    }
}
