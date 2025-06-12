using BikeManagementSystemLib.Models;

namespace BikeManagementSystemDesktop.Views
{
    public partial class BikeWearForm : Form
    {
        public delegate void SubmitForm(decimal wearRatio);
        public event SubmitForm OnSubmit;

        public BikeWearForm(string formName, string buttonText,BikeType bikeType,Terrain terrain): this(formName,buttonText,bikeType,terrain,1) {}

        public BikeWearForm(string formName, string buttonText, BikeType bikeType, Terrain terrain,decimal wearRatioValue)
        {
            InitializeComponent();
            Text = formName;
            buttonAction.Text = buttonText;
            labelBikeType.Text = bikeType.Name;
            labelTerrain.Text = terrain.Name;
            wearRatio.Value = wearRatioValue;
            wearRatio.DecimalPlaces = 2;
            wearRatio.Increment = 0.1M;
        }

        public void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (InputValidator.ValidateNumber(wearRatio, 0, wearRatio.Maximum))
            {
                OnSubmit.Invoke(wearRatio.Value);
                Close();
            }
            else
                GuiUtils.ShowError(this, $"Wear ratio must be in range 0 to {wearRatio.Maximum}");
        }
    }
}
