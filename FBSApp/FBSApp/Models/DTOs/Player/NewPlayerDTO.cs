namespace FBSApp.Models.DTOs.Player
{
    public class NewPlayerDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string? Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public long CountryId { get; set; }
    }
}
