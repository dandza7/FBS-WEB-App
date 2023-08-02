namespace FBSApp.Models.DTOs.Team
{
    public class PlayerFilterQuery
    {
        public bool IsOrderAscending { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}
