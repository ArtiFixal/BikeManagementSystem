namespace BikeManagementSystemDesktop.Views.Models
{
    public class BikeTableRow
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public string ImagePath { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }

        public BikeTableRow(long id, string model, string imagePath, string vendor, string type, bool available, DateTime? lastMaintenanceDate)
        {
            Id = id;
            Model = model;
            ImagePath = imagePath;
            Vendor = vendor;
            Type = type;
            Available = available;
            LastMaintenanceDate = lastMaintenanceDate;
        }
    }
}
