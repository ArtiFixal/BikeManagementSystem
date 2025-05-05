using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public abstract class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }

        public BaseEntity(T id)
        {
            Id = id;
        }
    }
}
