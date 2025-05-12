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
        public long VendorId { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public long ImageId { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int Durability { get; set; }

        public long? LastMaintenanceId { get; set; }

        public virtual Maintenance? LastMaintenance { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual BikeType Type { get; set; }
        public virtual Image Image { get; set; }

        public virtual ICollection<Maintenance> Maintenances { get; set; }
        public virtual ICollection<RentedBike> RentedBikes { get; set; }

        public Bike(string model,int vendorId, int typeId, long imageId, bool isAvailable, int durability, long? lastMaintenanceId) : this(0, model,vendorId, typeId, imageId, isAvailable, durability, lastMaintenanceId) { }

        public Bike(long id, string model, int vendorId, int typeId, long imageId, bool isAvailable, int durability, long? lastMaintenanceId): base(id)
        {
            Model = model;
            VendorId=vendorId;
            TypeId = typeId;
            ImageId = imageId;
            IsAvailable = isAvailable;
            Durability = durability;
            LastMaintenanceId = lastMaintenanceId;
        }

        public Bike(long id, string model, Vendor vendor, BikeType type, Image image, bool isAvailable, int durability) : base(id)
        {
            Model = model;
            Vendor = vendor;
            Type = type;
            Image = image;
            IsAvailable = isAvailable;
            Durability = durability;
        }
    }
}
