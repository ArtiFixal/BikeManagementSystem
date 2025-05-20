using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using System.ComponentModel.DataAnnotations;
using Image = System.Drawing.Image;
using ImageModel = BikeManagementSystemLib.Models.Image;

namespace BikeManagementSystemDesktop.Views
{
    public partial class BikeRentalForm : Form
    {
        private BikeService bikeService;
        private VendorService vendorService;
        private BikeTypeService bikeTypeService;
        private ClientService clientService;
        private RentalService rentalService;
        private HashSet<TableRow> rentalTableRows;

        public delegate void FormSubmit();
        public event FormSubmit OnSubmit;

        public BikeRentalForm(BikeService bikeService, VendorService vendorService, BikeTypeService bikeTypeService, ClientService clientService, RentalService rentalService)
        {
            rentalTableRows = [];
            InitializeComponent();
            this.bikeService = bikeService;
            this.vendorService = vendorService;
            this.bikeTypeService = bikeTypeService;
            this.clientService = clientService;
            this.rentalService = rentalService;
            bikeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rentalTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rentalTable.DataSource = rentalTableRows.ToList();
            var vendors = vendorService.GetAllEntities();
            // Allow to select no filter
            vendors.Insert(0, null);
            vendorBox.DataSource = vendors;
            var types = bikeTypeService.GetAllEntities();
            types.Insert(0, null);
            typeBox.DataSource = types;
            clientBox.DataSource = clientService.GetAllEntities();
            SearchBikes();
        }

        protected class TableRow
        {
            public long Id { get; set; }
            public string Model { get; set; }
            public Image Image { get; set; }
            public string Vendor { get; set; }
            public string Type { get; set; }
            public DateTime? LastMaintenance { get; set; }

            public TableRow(long id, string model, Image image, string vendor, string type, DateTime? lastMaintenance)
            {
                Id = id;
                Model = model;
                Image = image;
                Vendor = vendor;
                Type = type;
                LastMaintenance = lastMaintenance;
            }
        }

        private void SearchBikes()
        {
            long? vendorId = null;
            int? bikeTypeId = null;
            if (vendorBox.SelectedIndex != 0)
                vendorId = ((Vendor?)vendorBox.SelectedItem)?.Id;
            if (typeBox.SelectedIndex != 0)
                bikeTypeId = ((BikeType?)vendorBox.SelectedItem)?.Id;
            bikeTable.DataSource = bikeService.GetAvailableBikes(modelBox.Text, vendorId, bikeTypeId)
                .Select(bike =>
                {
                    string imagePath = Path.Combine(ImageModel.IMAGE_DIR, bike.Image.Path);
                    Image image = Image.FromFile(imagePath);
                    return new TableRow(bike.Id, bike.Model, image, bike.Vendor.Name, bike.Type.Name, bike.LastMaintenance?.MaintenanceDate);
                })
                .ToList();
            GuiUtils.FixImageScaling(bikeTable, 2);
        }

        private void buttonAddToRent_Click(object sender, EventArgs e)
        {
            var selectedRows = bikeTable.SelectedRows;
            if (selectedRows.Count == 0)
                GuiUtils.ShowError(this, "You need to select one or more bikes first.");
            else
            {
                // Force rentalTable redraw
                rentalTable.DataSource = null;
                // From top of selection to bottom
                for (int i = selectedRows.Count - 1; i >= 0; i--)
                    rentalTableRows.Add((TableRow)selectedRows[i].DataBoundItem);
                rentalTable.DataSource = rentalTableRows.ToList();
                GuiUtils.FixImageScaling(rentalTable, 2);
            }
        }

        private void buttonRemoveBike_Click(object sender, EventArgs e)
        {
            var selectedRows = rentalTable.SelectedRows;
            if (selectedRows.Count == 0)
                GuiUtils.ShowError(this, "You need to select one or more rented bikes first.");
            else
            {
                for (int i = selectedRows.Count - 1; i >= 0; i--)
                    rentalTableRows.RemoveWhere(bikeRow => bikeRow.Id == ((TableRow)selectedRows[i].DataBoundItem).Id);
                rentalTable.DataSource = null;
                rentalTable.DataSource = rentalTableRows.ToList();
                GuiUtils.FixImageScaling(rentalTable, 2);
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            ClientForm addClient = new ClientForm("Add new client", "Add");
            addClient.Owner = this;
            addClient.OnClick += (firstName, lastName, phoneNumber, identityNumber) =>
            {
                clientBox.Items.Add(new Client(identityNumber, firstName, lastName, phoneNumber));
            };
            addClient.ShowDialog();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateDateChronology(rentFrom, rentTo))
            {
                GuiUtils.ShowError(this, "Rent from date can't be after rent to date");
                return;
            }
            Client selectedClient = (Client)clientBox.SelectedItem;
            Rental rental = new Rental(selectedClient, rentFrom.Value, rentTo.Value);
            foreach (var item in rentalTableRows)
            {
                Bike bikeToRent = bikeService.GetEntity(item.Id);
                rental.RentedBikes.Add(new RentedBike(rental, bikeToRent));
            }
            rentalService.AddEntity(rental);
            OnSubmit.Invoke();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchBikes();
        }

        private void rentFrom_ValueChanged(object sender, EventArgs e)
        {
            InputValidator.ValidateDateChronology(rentFrom, rentTo);
        }

        private void rentTo_ValueChanged(object sender, EventArgs e)
        {
            InputValidator.ValidateDateChronology(rentFrom, rentTo);
        }
    }
}
