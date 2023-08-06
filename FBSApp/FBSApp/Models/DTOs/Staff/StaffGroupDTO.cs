namespace FBSApp.Models.DTOs.Staff
{
    public class StaffGroupDTO
    {
        public StaffDTO Staff { get; set; }
        public DateTime StartOfEmployment { get; set; }
        public DateTime EndOfEmployment { get; set; }
        public IEnumerable<StaffGroupDTO> Empolyees { get; set; }
    }
}
