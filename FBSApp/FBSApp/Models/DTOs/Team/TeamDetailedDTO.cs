using FBSApp.Models.DTOs.Season;

namespace FBSApp.Models.DTOs.Team
{
    public class TeamDetailedDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Flag { get; set; }
        public string StadiumName { get; set; }
        public string StadiumAddress { get; set; }
        public IEnumerable<SeasonDTO> Seasons { get; set; }

    }
}
