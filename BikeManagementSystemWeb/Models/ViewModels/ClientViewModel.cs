namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class ClientViewModel: BaseViewModel<long?>
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ClientViewModel() {}

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {PhoneNumber}";
        }
    }
}
