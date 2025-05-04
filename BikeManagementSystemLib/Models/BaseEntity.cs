using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagementSystem.Models
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
