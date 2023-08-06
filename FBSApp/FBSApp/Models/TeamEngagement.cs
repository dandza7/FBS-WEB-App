using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class TeamEngagement : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Team Team { get; set; }
        public long TeamId { get; set; }
        public Player Player { get; set; }
        public long PlayerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
