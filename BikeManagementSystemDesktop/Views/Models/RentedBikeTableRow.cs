using BikeManagementSystemLib.Models;
using Image = System.Drawing.Image;
using ImageModel = BikeManagementSystemLib.Models.Image;

namespace BikeManagementSystemDesktop.Views.Models
{
    /// <summary>
    /// Class representing single DataGridView row for <see cref="RentedBike">RentedBike</see>.
    /// </summary>
    public class RentedBikeTableRow
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public Image Image { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? StatusDescription { get; set; }

        public RentedBikeTableRow(Bike bike,DateTime? returnDate,string? statusDescription) : this(bike.Id, bike.Model, bike.Image.Path, bike.Vendor.Name, bike.Type.Name, returnDate, statusDescription) { }

        public RentedBikeTableRow(long id, string model, string imagePath, string vendor, string type, DateTime? returnDate, string? statusDescription)
        {
            Id = id;
            Model = model;
            string absolutePath = Path.Combine(ImageModel.IMAGE_DIR, imagePath);
            Image = Image.FromFile(absolutePath);
            Vendor = vendor;
            Type = type;
            ReturnDate = returnDate;
            StatusDescription = statusDescription;
        }
    }
}
