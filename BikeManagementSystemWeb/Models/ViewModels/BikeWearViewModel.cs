namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class BikeWearViewModel
    {
        public int BikeTypeID { get; set; }
        public int TerrainID { get; set; }
        public string? Terrain { get; set; }
        public decimal? WearRatio { get; set; }
    }
}
