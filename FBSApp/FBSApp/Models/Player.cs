using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Player : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public Country Country { get; set; }
        public long CountryId { get; set; }
    }
}
