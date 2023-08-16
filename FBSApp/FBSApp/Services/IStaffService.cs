using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
using FBSApp.Models.DTOs.Staff;

namespace FBSApp.Services
{
    public interface IStaffService
    {
        PaginationWrapper<StaffDTO> GetAll(int page, int pageSize);
        StaffDTO GetOne(long id);
        IEnumerable<TeamEmploymentDTO> GetEmployments(long staffId);
        public IEnumerable<AwardDTO> GetStaffAwards(long staffId);
    }
}
