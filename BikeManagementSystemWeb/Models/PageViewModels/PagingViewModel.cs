namespace BikeManagementSystemWeb.Models.PageViewModels
{
    public class PagingViewModel
    {
        public int CurrentPage { get; set; }
        public int MaxPage { get; set; }
        public string? ActionName { get; set; }
        public string? ControllerName { get; set; }
    }
}
