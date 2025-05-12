using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using Image = System.Drawing.Image;
using ImageModel = BikeManagementSystemLib.Models.Image;

namespace BikeManagementSystemDesktop.Views
{
    public partial class BikeForm : Form
    {
        public delegate void ButtonAction(string modelName, string imagePath, Vendor vendor, BikeType bikeType);
        public event ButtonAction OnClick;
        public long BikeID { get; }
        private string imagePath;

        public BikeForm(string formTitle, string actionButtonText,VendorService vendorService,BikeTypeService bikeTypeService)
        {
            InitializeComponent();
            Text = formTitle;
            buttonAction.Text = actionButtonText;
            vendorBox.DataSource=vendorService.GetAllEntities();
            typeBox.DataSource=bikeTypeService.GetAllEntities();
        }

        public BikeForm(string formTitle, string actionButtonText, VendorService vendorService, BikeTypeService bikeTypeService, Bike toEdit): this(formTitle,actionButtonText,vendorService,bikeTypeService)
        {
            modelBox.Text = toEdit.Model;
            vendorBox.SelectedItem = toEdit.Vendor;
            typeBox.SelectedItem = toEdit.Type;
            string imagePath = Path.Combine(ImageModel.IMAGE_DIR, toEdit.Image.Path);
            bikeImage.Image=Image.FromFile(imagePath);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowErrorDialog(string reason)
        {
            MessageBox.Show(this, reason, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateTextBox(modelBox))
            {
                ShowErrorDialog("Model can't be blank.");
                return;
            }
            if (!InputValidator.ValidateComboBox(vendorBox))
            {
                ShowErrorDialog("Vendor must be selected.");
                return;
            }
            if (!InputValidator.ValidateComboBox(typeBox))
            {
                ShowErrorDialog("Bike type must be selected.");
                return;
            }
            OnClick.Invoke(modelBox.Text, imagePath, (Vendor)vendorBox.SelectedItem, (BikeType)typeBox.SelectedItem);
            Close();
        }

        private void buttonImageChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select bike image";
            openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);
                bikeImage.Image = image;
            }
        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {
            InputValidator.ValidateTextBox(modelBox);
        }

        private delegate T ValueAdd<T>(string fieldValue);

        private void AddNewComboboxValue<T>(ComboBox comboBox, string formTitle, ValueAdd<T> clickCallback)
        {
            SimpleEntityFrom form = new SimpleEntityFrom(formTitle, "Add");
            form.Owner = this;
            form.OnClick += () =>
            {
                string formInput = form.GetInputValue();
                T item = clickCallback.Invoke(formInput);
                comboBox.Items.Add(item);
            };
            form.Show();
        }

        private void buttonAddVendor_Click(object sender, EventArgs e)
        {
            AddNewComboboxValue(vendorBox, "Add new vendor", (name) =>
            {
                return new Vendor(name);
            });
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            AddNewComboboxValue(typeBox, "Add new bike type", (name) => {
                return new BikeType(name);
            });
        }

    }
}
