using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Match : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public int Gameweek { get; set; }
        public DateTime Date { get; set; }
        public Season Season { get; set; }
        public long SeasonId { get; set; }
        public IEnumerable<MatchActor> MatchActors { get; set; }
        public IEnumerable<PlayedMatch> PlayersEvidention { get; set; }
    }
}
