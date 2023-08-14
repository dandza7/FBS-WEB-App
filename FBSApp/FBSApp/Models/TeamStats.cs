using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class TeamStats : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public int Shots { get; set; }
        public int ShotsOnTarget { get; set; }
        public int BlockedShots { get; set; }
        public int FreeKicks { get; set; }
        public int CornerKicks { get; set; }
        public int Offsides { get; set; }
        public int Possession { get; set; }
        public int Saves { get; set; }
        public int Fouls { get; set; }
        public int RedCards { get; set; }
        public int YellowCards { get; set; }
        public int Tackles { get; set; }
        public int Passes { get; set; }
        public MatchActor TeamMatchInfo { get; set; }
        public long TeamMatchInfoId { get; set; }
    }
}
