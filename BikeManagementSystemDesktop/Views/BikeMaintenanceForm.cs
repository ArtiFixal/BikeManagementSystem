using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;

namespace BikeManagementSystemDesktop.Views
{
    public partial class BikeMaintenanceForm : Form
    {
        private long bikeID;
        private MaintenanceService maintenanceService;

        public delegate void FormSubmit();
        public event FormSubmit OnSubmit;

        public BikeMaintenanceForm(Bike bike, MaintenanceService maintenanceService)
        {
            bikeID = bike.Id;
            this.maintenanceService = maintenanceService;
            InitializeComponent();
            labelBikeID.Text = bike.Id.ToString();
            labelModel.Text = bike.Model;
            labelVendor.Text = bike.Vendor.Name;
            labelType.Text = bike.Type.Name;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if(!InputValidator.ValidateTextBox(maintenanceDescritpion))
            {
                GuiUtils.ShowError(this,"Maintenance description can't be blank");
                return;
            }
            maintenanceService.MaintenanceBike(bikeID, maintenanceDate.Value, maintenanceDescritpion.Text);
            OnSubmit.Invoke();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
