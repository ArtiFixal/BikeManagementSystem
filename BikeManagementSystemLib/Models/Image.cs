using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Image: BaseEntity<long>
    {
        public static readonly string IMAGE_DIR = "/BikeManagementSystem/images";

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
