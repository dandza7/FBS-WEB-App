using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class TeamEmployment : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Team Team { get; set; }
        public long TeamId { get; set; }
        public Staff Staff { get; set; }
        public long StaffId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
