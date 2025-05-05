using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagementSystem.Models
{
    public class BikeType: BaseEntity<int>
    {
        [Required]
        [StringLength(40)]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }

        public BikeType(string name) : this(0, name) { }

        public BikeType(int id, string name): base(id)
        {
            Name = name;
        }
    }
}
