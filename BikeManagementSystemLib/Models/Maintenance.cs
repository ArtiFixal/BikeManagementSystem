using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Maintenance: BaseEntity<long>
    {
        [Required]
        public long BikeId { get; set; }

        [Required]
        public DateTime MaintenanceDate { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual Bike Bike { get; set; }

        public Maintenance(long bikeId, DateTime maintenanceDate, string description) : this(0, bikeId, maintenanceDate, description) { }

        public Maintenance(long id,long bikeId, DateTime maintenanceDate, string description):base(id)
        {
            BikeId = bikeId;
            MaintenanceDate = maintenanceDate;
            Description = description;
        }
    }
}
