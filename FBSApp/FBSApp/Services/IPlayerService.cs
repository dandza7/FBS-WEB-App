using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface IPlayerService
    {
        public PaginationWrapper<PlayerListPreviewDTO> GetListed(PlayerFilterQuery query);
        public IEnumerable<TeamEngagementDTO> GetPlayersEngagements(long playerId);
        public IEnumerable<AwardDTO> GetPlayersAwards(long playerId);
        public IEnumerable<string> Temp();
    }
}
