using FBSApp.Models.DTOs.Player;
using FBSApp.Models.DTOs.Staff;

namespace FBSApp.Models.DTOs.Match
{
    public class MatchSquadDTO
    {
        public List<PlayerAppearanceDTO> HomeTeam { get; set; } = new List<PlayerAppearanceDTO>();
        public List<PlayerAppearanceDTO> AwayTeam { get; set; } = new List<PlayerAppearanceDTO>();
        public StaffDTO HomeHeadCoach { get; set; }
        public StaffDTO AwayHeadCoach { get; set; }
    }
}
