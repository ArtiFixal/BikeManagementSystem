using BikeManagementSystemDesktop.Services;
using BikeManagementSystemLib;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using Image = System.Drawing.Image;
using ImageModel = BikeManagementSystemLib.Models.Image;

namespace BikeManagementSystemDesktop
{
    public partial class MainView : Form
    {
        private BikeManagementDbContext context;
        private BikeServiceExtended bikeService;

        public MainView(BikeManagementDbContext context)
        {
            this.context = context;
            bikeService = new BikeServiceExtended(context);
            InitializeComponent();
            SetUpTables();
        }

        private void SetUpTables()
        {
            // Bike Table
            BikeTable.Columns.Add("Id", "Id");
            BikeTable.Columns.Add("Model", "Model");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "ImagePath";
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            BikeTable.Columns.Add(imageColumn);
            BikeTable.Columns.Add("Vendor", "Vendor");
            BikeTable.Columns.Add("Type", "Type");
            BikeTable.Columns.Add("Available", "Available");
            BikeTable.Columns.Add("LastMaintenanceDate", "Last Maintenance Date");
            BikeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BikeTablePageNumber.Maximum = bikeService.GetPageCount(BikeService.DEFAULT_PAGE_SIZE) + 1;
            ChangeBikeTablePage(1);
        }

        private void ChangeBikeTablePage(int page)
        {
            BikeTable.Rows.Clear();
            bikeService.GetBikeTableRowPage(page, BikeServiceExtended.DEFAULT_PAGE_SIZE)
                .ForEach(row =>{
                    string imgPath = Path.Combine(ImageModel.IMAGE_DIR, row.ImagePath);
                    Image img = Image.FromFile(imgPath);
                    int rowIndex=BikeTable.Rows.Add(row.Id, row.Model, img,
                        row.Vendor, row.Type, row.Available, row.LastMaintenanceDate);
                    BikeTable.Rows[rowIndex].Height = 96;
                });
        }

        private void BikeTablePageNumber_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)BikeTablePageNumber.Value;
            ChangeBikeTablePage(page);
        }
    }
}
