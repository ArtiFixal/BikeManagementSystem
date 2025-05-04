using BikeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagementSystemLib.Models
{
    public class Vendor: BaseEntity<long>
    {
        [Required]
        [StringLength(40)]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }

        public Vendor(long id,string name): base(id)
        {
            Name = name;
        }
    }
}
