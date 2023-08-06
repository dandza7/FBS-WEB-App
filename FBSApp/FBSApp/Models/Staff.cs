using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Staff : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Staff Boss { get; set; }
        public long? BossId { get; set; }
        public Country Country { get; set; }
        public long CountryId { get; set; }
    }
}
