using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Staff;

namespace FBSApp.Services
{
    public interface IStaffService
    {
        PaginationWrapper<StaffDTO> GetAll(int page, int pageSize);
        IEnumerable<TeamEmploymentDTO> GetEmployments(long staffId);
    }
}
