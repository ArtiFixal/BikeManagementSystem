namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class BaseViewModel<ID>
    {
        public ID? Id { get; set; }

        public BaseViewModel(ID? id=default)
        {
            Id = id;
        }
    }
}
