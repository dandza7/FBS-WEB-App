using FBSApp.Models.DTOs.Match;

namespace FBSApp.Services
{
    public interface IMatchService
    {
        MatchListPreviewDTO GetOne(long id);
        MatchSquadDTO GetMatchSquad(long id);
        MatchStatsDTO GetMatchStats(long id);
    }
}
