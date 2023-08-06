using FBSApp.Models.DTOs.Staff;

namespace FBSApp.Services
{
    public interface IStaffService
    {
        IEnumerable<StaffDTO> GetAll();
    }
}
