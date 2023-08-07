namespace FBSApp.Models.DTOs.Staff
{
    public class StaffEmployeeDTO
    {
        public StaffDTO Staff { get; set; }
        public IEnumerable<StaffEmployeeDTO> Empolyees { get; set; }
    }
}
