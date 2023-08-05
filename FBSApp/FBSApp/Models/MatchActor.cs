using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class MatchActor : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Match Match { get; set; }
        public long MatchId { get; set; }
        public Team Team { get; set; }
        public long TeamId { get; set; }
        public bool IsTeamHost { get; set; }
    }
}
