namespace BikeManagementSystemDesktop.Views
{
    public partial class ClientForm : Form
    {
        public delegate void FormSubmit(string firstName, string lastName, string phoneNumber, string identityNumber);
        public event FormSubmit OnClick;

        public ClientForm(string formTitle, string actionButtonText)
        {
            InitializeComponent();
            Text = formTitle;
            buttonAction.Text = actionButtonText;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateTextBox(firstNameBox))
            {
                GuiUtils.ShowError(this,"First name can't be blank");
                return;
            }
            if (!InputValidator.ValidateTextBox(lastNameBox))
            {
                GuiUtils.ShowError(this,"Last name can't be blank");
                return;
            }
            if (!InputValidator.ValidateTextBox(phoneNumberBox))
            {
                GuiUtils.ShowError(this,"Phone number can't be blank");
                return;
            }
            if (!InputValidator.ValidateTextBox(IdentityNumberBox))
            {
                GuiUtils.ShowError(this,"Identity number can't be blank");
                return;
            }
            OnClick.Invoke(firstNameBox.Text, lastNameBox.Text, phoneNumberBox.Text, IdentityNumberBox.Text);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
