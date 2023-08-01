using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Team;

namespace FBSApp.Services
{
    public interface ITeamService
    {
        public PaginationWrapper<TeamListPreviewDTO> GetListed(TeamFilterQuery query);
    }
}
