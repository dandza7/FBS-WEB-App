namespace FBSApp.Models.DTOs.Player
{
    public class AddPlayersEngagementDTO
    {
        public long PlayerId { get; set; }
        public long TeamId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
