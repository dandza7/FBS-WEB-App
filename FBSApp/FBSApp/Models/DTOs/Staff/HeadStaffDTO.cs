namespace FBSApp.Models.DTOs.Staff
{
    public class HeadStaffDTO
    {
        public StaffDTO Staff { get; set; }
        public DateTime StartOfEmployment { get; set; }
        public DateTime EndOfEmployment { get; set; }
        public IEnumerable<StaffEmployeeDTO> Empolyees { get; set; }
    }
}
