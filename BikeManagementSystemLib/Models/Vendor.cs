using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Vendor: BaseEntity<long>
    {
        [Required]
        [StringLength(40)]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }

        public Vendor(string name): this(0, name) { }

        public Vendor(long id,string name): base(id)
        {
            Name = name;
        }
    }
}
