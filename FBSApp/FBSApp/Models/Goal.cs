using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Goal : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public bool IsOwnGoal { get; set; }
        public int Minute { get; set; }
        public bool IsExtraTime { get; set; }
        public PlayedMatch GoalInfo { get; set; }
        public long GoalInfoId { get; set; }
    }
}
