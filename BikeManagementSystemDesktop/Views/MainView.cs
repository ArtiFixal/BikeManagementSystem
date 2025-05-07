using BikeManagementSystemLib;

namespace BikeManagementSystemDesktop
{
    public partial class MainView : Form
    {
        private BikeManagementDbContext context;

        public MainView(BikeManagementDbContext context)
        {
            this.context = context;
            InitializeComponent();
        }
    }
}
