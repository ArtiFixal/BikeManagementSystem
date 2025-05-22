using BikeManagementSystemDesktop.Views.Models;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;

namespace BikeManagementSystemDesktop.Views
{
    public partial class ActiveRentalForm : Form
    {
        private RentalService rentalService;
        private Rental currentRental;

        public delegate void FormClose(bool allBikesReturned);
        public event FormClose OnClose;

        public ActiveRentalForm(Rental rental, RentalService rentalService)
        {
            this.rentalService = rentalService;
            currentRental = rental;
            InitializeComponent();
            rentedBikes.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            labelClient.Text = $"{rental.Client.FirstName} {rental.Client.LastName}";
            labelPhoneNumber.Text = rental.Client.PhoneNumber;
            labelClientId.Text = rental.Client.IdentityNumber;
            labelRentedFrom.Text = rental.RentedFrom.ToString();
            labelRentedTo.Text = rental.RentedTo.ToString();
            FetchRentedBikes();
        }

        private void FetchRentedBikes()
        {
            rentedBikes.DataSource = null;
            rentedBikes.DataSource = currentRental.RentedBikes
                .Select(bike => new RentedBikeTableRow(bike.Bike, bike.ReturnDate, bike.ReturnStatusDescription))
                .ToList();
            GuiUtils.FixImageScaling(rentedBikes, 2);
        }

        private void buttonReturnBike_Click(object sender, EventArgs e)
        {
            var selectedRow = rentedBikes.SelectedRows;
            if (selectedRow == null)
            {
                GuiUtils.ShowError(this, "First select bike to return");
                return;
            }
            long selectedBikeID = (long)selectedRow[0].Cells[0].Value;
            if (selectedRow[0].Cells[5].Value!=null)
            {
                GuiUtils.ShowError(this, "Selected bike is already returned");
                return;
            }
            RentedBike selected = currentRental.RentedBikes.First(bike => bike.Id.BikeId == selectedBikeID);
            BikeReturnForm returnForm = new BikeReturnForm(selected.Bike);
            returnForm.OnClick += (toReturn) => {
                RentedBike returned=rentalService.ReturnBike(currentRental.Id, toReturn.BikeId, toReturn.ReturnStatusDescription);
                selectedRow[0].Cells[5].Value = returned.ReturnDate;
                selectedRow[0].Cells[6].Value = returned.ReturnStatusDescription;
            };
            returnForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            OnClose.Invoke(currentRental.AllBikesReturned);
            Close();
        }
    }
}
