using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Stadium : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public long AddressId { get; set; }
    }
}
