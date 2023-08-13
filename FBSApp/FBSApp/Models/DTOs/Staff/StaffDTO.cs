namespace FBSApp.Models.DTOs.Staff
{
    public class StaffDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public string CountryFlag { get; set; }
    }
}
