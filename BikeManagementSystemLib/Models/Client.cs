using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Client: BaseEntity<long>
    {
        [Required]
        [MinLength(1)]
        public string IdentityNumber { get; set; }

        [Required]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        public string LastName { get; set; }

        [Required]
        [MinLength(9)]
        [MaxLength(15)]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

        public Client(string identityNumber,string firstName, string lastName, string phoneNumber) : this(0, identityNumber, firstName, lastName, phoneNumber) { }

        public Client(long id,string identityNumber, string firstName, string lastName, string phoneNumber): base(id)
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {PhoneNumber}";
        }
    }
}
