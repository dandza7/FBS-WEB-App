using FBSApp.Models.DTOs.Season;

namespace FBSApp.Models.DTOs.League
{
    public class LeagueDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public IEnumerable<SeasonDTO> Seasons { get; set; }
    }
}
