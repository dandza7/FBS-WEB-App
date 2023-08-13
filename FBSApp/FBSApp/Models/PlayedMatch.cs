using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class PlayedMatch : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Match Match { get; set; }
        public long MatchId { get; set; }
        public Player Player { get; set; }
        public long PlayerId { get; set; }
        public int Minutes { get; set; }
        public bool IsStarter { get; set; }
        public IEnumerable<Goal> Goals { get; set; }
    }
}
