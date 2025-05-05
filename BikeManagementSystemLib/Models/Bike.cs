using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Bike: BaseEntity<long>
    {
        [Required]
        [StringLength(60)]
        [MinLength(1)]
        public string Model { get; set; }

        [Required]
        public int VendorId { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public long ImageId { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int Durability { get; set; }

        public long LastMaintenanceId { get; set; }

        public virtual Maintenance LastMaintenance { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual BikeType Type { get; set; }
        public virtual Image Image { get; set; }

        public virtual ICollection<Maintenance> Maintenances { get; set; }

        public Bike(string model, BikeType type, long imageId, bool isAvailable, int durability, long lastMaintenanceId) : this(0, model, type, imageId, isAvailable, durability, lastMaintenance) { }

        public Bike(long id, string model, BikeType type, long imageId, bool isAvailable, int durability, long lastMaintenanceId): base(id)
        {
            Model = model;
            Type = type;
            ImageId = imageId;
            IsAvailable = isAvailable;
            Durability = durability;
            LastMaintenanceId = lastMaintenanceId;
        }
    }
}
