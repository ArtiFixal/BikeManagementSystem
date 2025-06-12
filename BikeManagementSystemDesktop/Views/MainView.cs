using BikeManagementSystemDesktop.Services;
using BikeManagementSystemDesktop.Views;
using BikeManagementSystemDesktop.Views.Models;
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
        private VendorService vendorService;
        private BikeTypeService typeService;
        private ClientService clientService;
        private RentalService rentalService;
        private MaintenanceService maintenanceService;
        private TerrainService terrainService;
        private BikeWearService bikeWearService;

        public MainView(BikeManagementDbContext context)
        {
            this.context = context;
            bikeService = new BikeServiceExtended(context);
            vendorService = new VendorService(context);
            typeService = new BikeTypeService(context);
            clientService = new ClientService(context);
            rentalService = new RentalService(context);
            maintenanceService = new MaintenanceService(context);
            terrainService = new TerrainService(context);
            bikeWearService = new BikeWearService(context);
            InitializeComponent();
            SetUpTables();
        }

        private void SetUpTables()
        {
            // Bike table
            BikeTable.Columns.Add("Id", "Id");
            BikeTable.Columns.Add("Model", "Model");
            BikeTable.Columns.Add(CreateImageColumn());
            BikeTable.Columns.Add("Vendor", "Vendor");
            BikeTable.Columns.Add("Type", "Type");
            BikeTable.Columns.Add("Available", "Available");
            BikeTable.Columns.Add("LastMaintenanceDate", "Last Maintenance Date");
            BikeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Vendor table
            SetUpSimpleTableColumns(vendorTable);

            // Type table
            SetUpSimpleTableColumns(typeTable);

            // Active Rentals
            activeRentalTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Weared bikes
            wornBikesTable.Columns.Add("Id", "Id");
            wornBikesTable.Columns.Add("Model", "Model");
            wornBikesTable.Columns.Add(CreateImageColumn());
            wornBikesTable.Columns.Add("Vendor", "Vendor");
            wornBikesTable.Columns.Add("Type", "Type");
            wornBikesTable.Columns.Add("Durability", "Durability");
            wornBikesTable.Columns.Add("LastMaintenanceDate", "Last maintenance date");
            wornBikesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Terrain table
            SetUpSimpleTableColumns(terrainTable);

            // Setup pages
            bikeTablePageNumber.Maximum = bikeService.GetPageCount(BikeService.DEFAULT_PAGE_SIZE) + 1;
            vendorTablePageNumber.Maximum = vendorService.GetPageCount(VendorService.DEFAULT_PAGE_SIZE) + 1;
            typeTablePageNumber.Maximum = typeService.GetPageCount(BikeTypeService.DEFAULT_PAGE_SIZE) + 1;
            activeRentalPageNumber.Maximum = rentalService.GetActiveRentalsPageCount(RentalService.DEFAULT_PAGE_SIZE) + 1;
            wornBikesTablePage.Maximum = bikeService.GetBikesRequiringMaintenancePageCount(BikeService.DEFAULT_PAGE_SIZE) + 1;
            terrainTablePage.Maximum = terrainService.GetPageCount(TerrainService.DEFAULT_PAGE_SIZE) + 1;
            ChangeBikeTablePage(1);
            ChangeVendorTablePage(1);
            ChangeTypeTablePage(1);
            ChangeActiveRentalsPage(1);
            ChangeWearedBikesPage(1);
            ChangeTerrainPage(1);
        }

        private void SetUpSimpleTableColumns(DataGridView table)
        {
            table.Columns.Add("Id", "Id");
            table.Columns.Add("Name", "Name");
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            vendorService.GetEntityPage(page, VendorService.DEFAULT_PAGE_SIZE).ForEach(vendor =>
            {
                vendorTable.Rows.Add(vendor.Id, vendor.Name);
            });
        }

        private void ChangeTypeTablePage(int page)
        {
            typeTable.Rows.Clear();
            typeService.GetEntityPage(page, BikeTypeService.DEFAULT_PAGE_SIZE).ForEach(type =>
            {
                typeTable.Rows.Add(type.Id, type.Name);
            });
        }

        private void ChangeActiveRentalsPage(int page)
        {
            activeRentalTable.DataSource = rentalService.GetActiveRentalsPage(page)
                .Select(rental => new ActiveRentalTableRow(rental.Id,
                    $"{rental.Client.FirstName} {rental.Client.LastName}",
                    rental.Terrain.Name, rental.Client.PhoneNumber,
                    rental.RentedFrom, rental.RentedTo)
                ).ToList();
        }

        private void ChangeWearedBikesPage(int page)
        {
            wornBikesTable.Rows.Clear();
            bikeService.GetBikesPageRequiringMaintenance(page).ForEach(bike =>
            {
                string imagePath = Path.Combine(ImageModel.IMAGE_DIR, bike.Image.Path);
                Image bikeImage = Image.FromFile(imagePath);
                wornBikesTable.Rows.Add(bike.Id, bike.Model, bikeImage, bike.Vendor.Name, bike.Type.Name, bike.Durability, bike.LastMaintenance?.MaintenanceDate);
            });
        }

        private void ChangeTerrainPage(int page)
        {
            terrainTable.Rows.Clear();
            terrainService.GetEntityPage(page, TerrainService.DEFAULT_PAGE_SIZE).ForEach(terrain =>
                terrainTable.Rows.Add(terrain.Id, terrain.Name));
        }

        private DataGridViewImageColumn CreateImageColumn()
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "ImagePath";
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return imageColumn;
        }

        /// <summary>
        /// Common code for creating new entity with one field.
        /// </summary>
        /// 
        /// <typeparam name="ID">Entity ID type</typeparam>
        /// <param name="formTitle">Title displayed at form bar</param>
        /// <param name="table">Where to add entity</param>
        /// <param name="pageInput">Where to check for current page</param>
        /// <param name="clickCallback">What will happen after form action button click</param>
        private void AddSimpleEntity<ID>(string formTitle, DataGridView table, NumericUpDown pageInput, GuiUtils.SimpleFormSubmit<ID> clickCallback)
        {
            SimpleEntityFrom form = new SimpleEntityFrom("Add new vendor", "Add");
            form.Owner = this;
            form.OnClick += () =>
            {
                string entityField = form.GetInputValue().Trim();
                ID newEntityID = clickCallback.Invoke(entityField);
                if (pageInput.Value == pageInput.Maximum)
                {
                    table.Rows.Add(newEntityID, entityField);
                }
            };
            form.ShowDialog();
        }

        private delegate void UpdateSimpleEntity<ID>(ID entityID, string updatedFieldValue);

        /// <summary>
        /// Common code for editing entity with one field.
        /// </summary>
        /// 
        /// <typeparam name="ID">Entity ID type</typeparam>
        /// <param name="formTitle">Title displayed at form bar</param>
        /// <param name="table">Where to look for selected rows</param>
        /// <param name="clickCallback">What will happen after form 
        /// action button click</param>
        private void EditSimpleEntity<ID>(string formTitle, DataGridView table, UpdateSimpleEntity<ID> clickCallback)
        {
            if (table.SelectedRows.Count == 0)
            {
                GuiUtils.ShowError(this, "To edit object you need to select row first.");
                return;
            }
            ID entityID = (ID)table.SelectedRows[0].Cells[0].Value;
            string entityValue = (string)table.SelectedRows[0].Cells[1].Value;
            SimpleEntityFrom form = new SimpleEntityFrom(formTitle, "Update", entityID);
            form.SetInputValue(entityValue);
            form.OnClick += () =>
            {
                string newValue = form.GetInputValue().Trim();
                clickCallback.Invoke(entityID, newValue);
                table.SelectedRows[0].Cells[1].Value = newValue;
            };
            form.ShowDialog();
        }

        private void DeleteSelectedEntities<ID, ET>(DataGridView table, CrudService<ID, ET> service) where ET : BaseEntity<ID>
        {
            var selectedRows = table.SelectedRows;
            if (selectedRows.Count == 0)
                GuiUtils.ShowError(this, "To delete you need to select one or more rows first.");
            else
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
            AddSimpleEntity("Add new vendor", vendorTable, vendorTablePageNumber, (name) =>
            {
                return vendorService.AddEntity(new Vendor(name));
            });
        }

        private void buttonVendorEdit_Click(object sender, EventArgs e)
        {
            EditSimpleEntity<long>("Edit vendor", vendorTable, (id, name) =>
            {
                Vendor edited = vendorService.GetEntity(id);
                edited.Name = name;
                vendorService.EditEntity(edited);
            });
        }

        private void buttonVendorDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntities(vendorTable, vendorService);
        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            AddSimpleEntity("Add new bike type", typeTable, typeTablePageNumber, (name) =>
            {
                return typeService.AddEntity(new BikeType(name));
            });
        }

        private void buttonTypeEdit_Click(object sender, EventArgs e)
        {
            EditSimpleEntity<int>("Edit bike type", typeTable, (id, name) =>
            {
                BikeType bikeType = typeService.GetEntity(id);
                bikeType.Name = name;
                typeService.EditEntity(bikeType);
            });
        }

        private void buttonTypeDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntities(typeTable, typeService);
        }

        private void typeTablePageNumber_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)typeTablePageNumber.Value;
            ChangeTypeTablePage(page);
        }

        private void buttonAddBike_Click(object sender, EventArgs e)
        {
            BikeForm addForm = new BikeForm("Add new bike", "Add", vendorService, typeService);
            addForm.Owner = this;
            addForm.OnClick += (model, imagePath, vendor, bikeType) =>
            {
                ImageModel image = new ImageModel(imagePath);
                bikeService.AddEntity(new Bike(0, model, vendor, bikeType, image, true, 100));
            };
            addForm.ShowDialog();
        }

        private void buttonEditBike_Click(object sender, EventArgs e)
        {
            if (BikeTable.SelectedRows.Count == 0)
            {
                GuiUtils.ShowError(this, "To edit object you need to select row first.");
                return;
            }
            long bikeId = (long)BikeTable.SelectedRows[0].Cells[0].Value;
            Bike toEdit = bikeService.GetEntity(bikeId);
            BikeForm editForm = new BikeForm("Edit bike", "Update", vendorService, typeService, toEdit);
            editForm.Owner = this;
            editForm.OnClick += (model, imagePath, vendor, bikeType) =>
            {
                if (imagePath != null)
                {
                    ImageModel image = new ImageModel(imagePath);
                    toEdit.Image = image;
                }
                toEdit.Model = model;
                toEdit.Vendor = vendor;
                toEdit.Type = bikeType;
                bikeService.EditEntity(toEdit);
            };
            editForm.ShowDialog();
        }

        private void buttonDeleteBike_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntities(BikeTable, bikeService);
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            BikeRentalForm rentalForm = new BikeRentalForm(bikeService, vendorService, typeService, clientService, rentalService, terrainService);
            rentalForm.Owner = this;
            rentalForm.OnSubmit += () =>
            {
                // Refresh active rentals
                if (activeRentalPageNumber.Value == activeRentalPageNumber.Maximum)
                    ChangeActiveRentalsPage((int)activeRentalPageNumber.Value);
            };
            rentalForm.ShowDialog();
        }

        private void activeRentalPageNumber_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)activeRentalPageNumber.Value;
            ChangeActiveRentalsPage(page);
        }

        private void buttonActiveRentalsOpen_Click(object sender, EventArgs e)
        {
            var selectedRow = activeRentalTable.SelectedRows;
            if (selectedRow.Count == 0)
            {
                GuiUtils.ShowError(this, "First select acitve rental to open");
                return;
            }
            long rentalID = (long)selectedRow[0].Cells[0].Value;
            Rental toOpen = rentalService.GetEntity(rentalID);
            ActiveRentalForm activeRental = new ActiveRentalForm(toOpen, rentalService);
            activeRental.Owner = this;
            activeRental.OnClose += (allBikesReturned) =>
            {
                if (allBikesReturned)
                    ChangeActiveRentalsPage((int)activeRentalPageNumber.Value);
            };
            activeRental.ShowDialog();
        }

        private void wornBikesTablePage_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)wornBikesTablePage.Value;
            ChangeWearedBikesPage(page);
        }

        private void buttonMaintenanceBike_Click(object sender, EventArgs e)
        {
            var selectedRow = wornBikesTable.SelectedRows;
            if (selectedRow.Count == 0)
            {
                GuiUtils.ShowError(this, "You must select bike first");
                return;
            }
            long bikeID = (long)selectedRow[0].Cells[0].Value;
            Bike toMaintenance = bikeService.GetEntity(bikeID);
            BikeMaintenanceForm maintenanceForm = new BikeMaintenanceForm(toMaintenance, maintenanceService);
            maintenanceForm.Owner = this;
            maintenanceForm.OnSubmit += () =>
            {
                wornBikesTable.Rows.RemoveAt(selectedRow[0].Index);
            };
            maintenanceForm.ShowDialog();
        }

        private void buttonTerrainAdd_Click(object sender, EventArgs e)
        {
            AddSimpleEntity("Add new terrain", terrainTable, terrainTablePage, (name) =>
            {
                return terrainService.AddEntity(new Terrain(name));
            });
        }

        private void buttonTerrainEdit_Click(object sender, EventArgs e)
        {
            EditSimpleEntity<int>("Edit terrain", terrainTable, (id, name) =>
            {
                Terrain toEdit = terrainService.GetEntity(id);
                toEdit.Name = name;
                terrainService.EditEntity(toEdit);
            });
        }

        private void buttonTerrainDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntities(terrainTable, terrainService);
        }

        private void terrainTablePage_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)terrainTablePage.Value;
            ChangeTerrainPage(page);
        }

        private void buttonOpenWearRatios_Click(object sender, EventArgs e)
        {
            if (typeTable.SelectedRows.Count != 0)
            {
                int bikeTypeID = (int)typeTable.SelectedRows[0].Cells[0].Value;
                BikeType selectedType = typeService.GetEntity(bikeTypeID);
                BikeWearTableForm wearTable = new(bikeWearService, terrainService, selectedType);
                wearTable.Owner = this;
                wearTable.ShowDialog();
            }
            else
                GuiUtils.ShowError(this, "You need to select bike type first");
        }

        private void buttonMaintenanceHistory_Click(object sender, EventArgs e)
        {
            if (BikeTable.SelectedRows.Count != 0)
            {
                long selectedBikeID = (long)BikeTable.SelectedRows[0].Cells[0].Value;
                Bike toShow = bikeService.GetEntity(selectedBikeID);
                MaintenanceHistoryForm maintenanceHistory = new MaintenanceHistoryForm(toShow);
                maintenanceHistory.Owner=this;
                maintenanceHistory.ShowDialog();
            }
            else
                GuiUtils.ShowError(this, "You need to select bike first");
        }
    }
}
