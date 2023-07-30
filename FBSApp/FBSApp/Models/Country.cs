using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Country : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public byte[] Flag { get; set; }
    }
}
