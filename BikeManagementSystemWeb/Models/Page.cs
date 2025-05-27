namespace BikeManagementSystemWeb.Models
{
    public class Page<T>
    {
        public int CurrentPage { get; set; }
        public int MaxPage { get; set; }
        public IEnumerable<T> Items { get; set; } = [];

        public Page(int currentPage, int maxPage, List<T> items)
        {
            CurrentPage = currentPage;
            MaxPage = maxPage;
            Items = items;
        }
    }
}
