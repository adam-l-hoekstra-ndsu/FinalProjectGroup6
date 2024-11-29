using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup6.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Username is invalid. It must be at least 10 characters long.")]
        public string? UserName { get; set; }

        [Required()]
        public string? Role { get; set; }

        [Required()]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{10,60}$",
        ErrorMessage = "Password must be at least 10 characters long and a mix of uppercase letters, lowercase letters, numbers, and special characters.")]
        public string? Password { get; set; }

        [Required()]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "First name is invalid. It must be at least one character long.")]
        public string? FirstName { get; set; }

        [Required()]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Last name is invalid. It must be at least one character long.")]
        public string? LastName { get; set; }

        [Required()]
        public int AddressId { get; set; }

        [Required()]
        [EmailAddress(ErrorMessage = "Email address is invalid.")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Date of birth is invalid.")]
        public DateTime DateOfBirth { get; set; }

        [Phone(ErrorMessage = "Phone number is invalid.")]
        public string? PhoneNumber { get; set; }
        public int? ShelterId { get; set; }

        [Required]
        public Boolean IsActive { get; set; }
    }
}
