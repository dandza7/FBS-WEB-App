using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Address : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public Country Country { get; set; }
        public long CountryId { get; set; }
    }
}
