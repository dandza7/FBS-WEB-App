namespace FBSApp.Models.DTOs.Team
{
    public class PlayerListPreviewDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
