namespace FBSApp.Models.DTOs
{
    public class AwardDTO
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Month { get; set; }
        public string Type { get; set; }
        public string League { get; set; }
        public string Season { get; set; }
    }
}
