using BikeManagementSystemDesktop.Services;
using BikeManagementSystemDesktop.Views;
using BikeManagementSystemDesktop.Views.Models;
using BikeManagementSystemLib;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using ImageModel = BikeManagementSystemLib.Models.Image;

namespace BikeManagementSystemDesktop
{
    public partial class MainView : Form
    {
        private BikeManagementDbContext context;
        private BikeServiceExtended bikeService;
        private VendorService vendorService;

        public MainView(BikeManagementDbContext context)
        {
            this.context = context;
            bikeService = new BikeServiceExtended(context);
            vendorService = new VendorService(context);
            InitializeComponent();
            SetUpTables();
        }

        private void SetUpTables()
        {
            // Bike table
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

            // Vendor table
            vendorTable.Columns.Add("Id", "Id");
            vendorTable.Columns.Add("Name", "Name");
            vendorTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Setup pages
            bikeTablePageNumber.Maximum = bikeService.GetPageCount(BikeService.DEFAULT_PAGE_SIZE) + 1;
            vendorTablePageNumber.Maximum = vendorService.GetPageCount(BikeService.DEFAULT_PAGE_SIZE) + 1;
            ChangeBikeTablePage(1);
            ChangeVendorTablePage(1);
        }

        private void ChangeBikeTablePage(int page)
        {
            BikeTable.Rows.Clear();
            bikeService.GetBikeTableRowPage(page, BikeService.DEFAULT_PAGE_SIZE)
                .ForEach(row =>
                {
                    string imgPath = Path.Combine(ImageModel.IMAGE_DIR, row.ImagePath);
                    Image img = Image.FromFile(imgPath);
                    int rowIndex = BikeTable.Rows.Add(row.Id, row.Model, img,
                        row.Vendor, row.Type, row.Available, row.LastMaintenanceDate);
                    BikeTable.Rows[rowIndex].Height = 96;
                });
        }

        private void ChangeVendorTablePage(int page)
        {
            vendorTable.Rows.Clear();
            vendorService.GetEntityPage(page, BikeService.DEFAULT_PAGE_SIZE).ForEach(vendor =>
            {
                vendorTable.Rows.Add(vendor.Id, vendor.Name);
            });
        }

        private delegate ID InsertSimpleEntity<ID>(string entityField);

        private void AddSimpleEntity<ID>(string formName, DataGridView table, NumericUpDown pageInput, InsertSimpleEntity<ID> clickCallback)
        {
            SimpleEntityFrom form = new SimpleEntityFrom("Add new vendor", "Add");
            form.Owner = this;
            form.OnClick += () =>
            {
                string entityField = form.GetInputValue();
                ID newEntityID = clickCallback.Invoke(entityField);
                if (pageInput.Value == pageInput.Maximum)
                {
                    table.Rows.Add(newEntityID, entityField);
                }
            };
            form.Show();
        }

        private delegate void UpdateSimpleEntity<ID>(ID entityID, string updatedFieldValue);

        private void EditSimpleEntity<ID>(string formName, DataGridView table, UpdateSimpleEntity<ID> clickCallback)
        {
            ID entityID = (ID)table.SelectedRows[0].Cells[0].Value;
            string entityValue = (string)table.SelectedRows[0].Cells[1].Value;
            SimpleEntityFrom form = new SimpleEntityFrom(formName, "Update", entityID);
            form.SetInputValue(entityValue);
            form.OnClick += () =>
            {
                string newValue = form.GetInputValue();
                clickCallback.Invoke(entityID, newValue);
                table.SelectedRows[0].Cells[1].Value = newValue;
            };
            form.Show();
        }

        private void DeleteSelectedEntities<ID,ET>(DataGridView table,CrudService<ID,ET> service) where ET: BaseEntity<ID>
        {
            var selectedRows = table.SelectedRows;
            for (int i = 0; i < selectedRows.Count; i++)
            {
                ID entityID = (ID)selectedRows[i].Cells[0].Value;
                service.DeleteEntity(entityID);
                table.Rows.RemoveAt(selectedRows[i].Index);
            }
        }

        private void bikeTablePageNumber_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)bikeTablePageNumber.Value;
            ChangeBikeTablePage(page);
        }

        private void vendorTablePageNumber_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)vendorTablePageNumber.Value;
            ChangeVendorTablePage(page);
        }

        private void buttonAddVendor_Click(object sender, EventArgs e)
        {
            AddSimpleEntity<long>("Add new vendor", vendorTable, vendorTablePageNumber, (name) => {
                return vendorService.AddEntity(new Vendor(name));
            });
        }

        private void buttonVendorEdit_Click(object sender, EventArgs e)
        {
            EditSimpleEntity<long>("Edit vendor", vendorTable, (id,name) => {
                Vendor edited = vendorService.GetEntity(id);
                edited.Name = name;
            });
        }

        private void buttonVendorDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntities(vendorTable, vendorService);
        }
    }
}
