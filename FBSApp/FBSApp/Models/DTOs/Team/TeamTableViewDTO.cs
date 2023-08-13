namespace FBSApp.Models.DTOs.Team
{
    public class TeamTableViewDTO
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Flag { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
    }
}
