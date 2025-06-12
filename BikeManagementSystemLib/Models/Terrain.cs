using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Terrain: BaseEntity<int>
    {
        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual ICollection<BikeWear> BikeWears { get; set; }

        public Terrain(string name) : this(0, name) { }

        public Terrain(int id,string name): base(id)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
