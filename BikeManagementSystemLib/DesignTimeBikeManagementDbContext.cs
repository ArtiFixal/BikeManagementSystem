using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagementSystemLib
{
    public class DesignTimeBikeManagementDbContext : IDesignTimeDbContextFactory<BikeManagementDbContext>
    {
        public BikeManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BikeManagementDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=BikeManagementService;Trusted_Connection=True;Encrypt=False;");
            return new BikeManagementDbContext(optionsBuilder.Options);
        }
    }
}
