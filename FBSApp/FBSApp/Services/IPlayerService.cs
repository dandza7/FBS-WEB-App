using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
using FBSApp.Models.DTOs.Match;
using FBSApp.Models.DTOs.Player;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface IPlayerService
    {
        PaginationWrapper<PlayerListPreviewDTO> GetListed(PlayerFilterQuery query);
        PlayerListPreviewDTO GetPlayer(long playerId);
        long CreateOrUpdatePlayer(NewPlayerDTO newPlayerDTO);
        void DeletePlayersEngagement(long playerId, long engagementId);
        void AddPlayersEngagement(AddPlayersEngagementDTO engagement);
        IEnumerable<TeamEngagementDTO> GetPlayersEngagements(long playerId);
        IEnumerable<AwardDTO> GetPlayersAwards(long playerId);
        PaginationWrapper<PlayersMatchDTO> GetMatchesByPlayer(long playerId, int page, int pageSize);
        IEnumerable<string> Temp();
    }
}
