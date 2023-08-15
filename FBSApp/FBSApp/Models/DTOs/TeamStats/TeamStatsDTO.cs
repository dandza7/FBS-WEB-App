namespace FBSApp.Models.DTOs.TeamStats
{
    public class TeamStatsDTO
    {
        public long Id { get; set; }
        public float Shots { get; set; }
        public float ShotsOnTarget { get; set; }
        public float BlockedShots { get; set; }
        public float ShotsOffTarget { get; set; }
        public float FreeKicks { get; set; }
        public float CornerKicks { get; set; }
        public float Offsides { get; set; }
        public float Possession { get; set; }
        public float Saves { get; set; }
        public float Fouls { get; set; }
        public float RedCards { get; set; }
        public float YellowCards { get; set; }
        public float Tackles { get; set; }
        public float Passes { get; set; }
    }
}
