using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Team : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public Stadium Stadium { get; set; }
        public long StadiumId { get; set; }
        public Country Country { get; set; }
        public long CountryId { get; set; }
        public byte[] Logo { get; set; }
        public IEnumerable<Season> Seasons { get; set; }
    }
}
