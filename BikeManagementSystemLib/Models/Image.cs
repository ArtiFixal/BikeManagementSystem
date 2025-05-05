using BikeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagementSystemLib.Models
{
    public class Image: BaseEntity<long>
    {
        public static readonly string IMAGE_DIR = "images";

        [Required]
        [StringLength(255)]
        [MinLength(1)]
        public string Path { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }

        public Image(string path): this(0,path){}

        public Image(long id,string path): base(id)
        {
            Path = path;
        }
    }
}
