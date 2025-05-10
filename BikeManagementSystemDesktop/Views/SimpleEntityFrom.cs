namespace BikeManagementSystemDesktop.Views
{
    public partial class SimpleEntityFrom : Form
    {
        public delegate void ButtonAction();
        public event ButtonAction OnClick;
        private object EntityId { get; }

        public SimpleEntityFrom(string formName, string actionButtonText)
        {
            InitializeComponent();
            Text = formName;
            ActionButton.Text = actionButtonText;
        }

        public SimpleEntityFrom(string formName, string actionButtonText,object entityId):this(formName,actionButtonText)
        {
            EntityId = entityId;
        }

        /// <summary>
        /// Sets text and placeholder value to allow editing.
        /// </summary>
        /// 
        /// <param name="value">New input value</param>
        public void SetInputValue(string value)
        {
            textBox.Text = value;
            textBox.PlaceholderText = value;
        }

        public string GetInputValue()
        {
            return textBox.Text;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            OnClick.Invoke();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
