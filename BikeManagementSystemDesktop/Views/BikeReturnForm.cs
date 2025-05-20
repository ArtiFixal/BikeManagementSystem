using BikeManagementSystemDesktop.Views.Models;
using BikeManagementSystemLib.Models;

namespace BikeManagementSystemDesktop.Views
{
    public partial class BikeReturnForm : Form
    {
        private long bikeID;

        public delegate void FormSubmit(BikeReturn toReturn);
        public event FormSubmit OnClick;

        public BikeReturnForm(Bike bike)
        {
            bikeID = bike.Id;
            InitializeComponent();
            labelBikeID.Text = bike.Id.ToString();
            labelModel.Text = bike.Model;
            labelVendor.Text = bike.Vendor.Name;
            labelType.Text = bike.Type.Name;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            string? statusDescription = (bikeStatus.Text.Length > 0) ? bikeStatus.Text : null;
            OnClick.Invoke(new BikeReturn(bikeID, statusDescription));
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
