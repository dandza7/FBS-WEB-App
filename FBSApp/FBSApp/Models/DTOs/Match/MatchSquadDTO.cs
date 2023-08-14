using FBSApp.Models.DTOs.Player;

namespace FBSApp.Models.DTOs.Match
{
    public class MatchSquadDTO
    {
        public List<PlayerAppearanceDTO> HomeTeam { get; set; } = new List<PlayerAppearanceDTO>();
        public List<PlayerAppearanceDTO> AwayTeam { get; set; } = new List<PlayerAppearanceDTO>();
    }
}
