using BikeManagementSystemLib.Models;
using Image = System.Drawing.Image;
using ImageModel = BikeManagementSystemLib.Models.Image;

namespace BikeManagementSystemDesktop.Views
{
    public partial class MaintenanceHistoryForm : Form
    {
        public MaintenanceHistoryForm(Bike bike)
        {
            InitializeComponent();
            labelBikeId.Text=bike.Id.ToString();
            labelBikeModel.Text=bike.Model;
            labelVendor.Text=bike.Vendor.Name;
            labelBikeType.Text=bike.Type.Name;
            string imagePath = Path.Combine(ImageModel.IMAGE_DIR, bike.Image.Path);
            bikeImage.Image = Image.FromFile(imagePath);
            maintenaceTable.Columns.Add("Id", "ID");
            maintenaceTable.Columns.Add("MaintenanceDate", "Maintenance date");
            maintenaceTable.Columns.Add("Description", "Description");
            maintenaceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (var maintenance in bike.Maintenances.OrderByDescending(maintenance => maintenance.MaintenanceDate))
                maintenaceTable.Rows.Add(maintenance.Id, maintenance.MaintenanceDate, maintenance.Description);
        }
    }
}
