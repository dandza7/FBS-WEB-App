using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class League : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public long? CountryId { get; set; }
    }
}
