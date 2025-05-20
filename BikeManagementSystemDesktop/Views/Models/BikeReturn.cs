namespace BikeManagementSystemDesktop.Views.Models
{
    /// <summary>
    /// Stores info about bike to return.
    /// </summary>
    public class BikeReturn
    {
        public long BikeId { get; set; }
        public string? ReturnStatusDescription { get; set; }

        public BikeReturn(long bikeId, string? returnStatusDescription)
        {
            BikeId = bikeId;
            ReturnStatusDescription = returnStatusDescription;
        }
    }
}
