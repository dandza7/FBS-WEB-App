using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Award : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Month { get; set; }
        public string Type { get; set; }
        public Season Season { get; set; }
        public long SeasonId { get; set; }
        public Player Player { get; set; }
        public long? PlayerId { get; set; }
        public Staff Staff { get; set; }
        public long? StaffId { get; set; }
    }
}
