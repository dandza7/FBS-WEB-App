namespace FBSApp.Models.DTOs
{
    public class PaginationWrapper<T>
    {
        public List<T> Entities { get; set; }
        public int TotalCount { get; set; }
    }
}
