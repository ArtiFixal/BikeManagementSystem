using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemLib.Services
{
    public class ClientService : CrudService<long, Client>
    {
        public ClientService(BikeManagementDbContext context) : base(context, context.Clients)
        {
        }
    }
}
