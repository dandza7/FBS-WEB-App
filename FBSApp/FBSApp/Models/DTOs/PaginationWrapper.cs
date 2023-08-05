namespace FBSApp.Models.DTOs
{
    public class PaginationWrapper<T>
    {
        public IEnumerable<T> Entities { get; set; }
        public int TotalCount { get; set; }
    }
}
