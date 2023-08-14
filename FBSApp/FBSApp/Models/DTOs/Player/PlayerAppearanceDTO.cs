namespace FBSApp.Models.DTOs.Player
{
    public class PlayerAppearanceDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public int Goals { get; set; }
        public int OwnGoals { get; set; }
        public int Minutes { get; set; }
        public bool IsStarter { get; set; }
    }
}
