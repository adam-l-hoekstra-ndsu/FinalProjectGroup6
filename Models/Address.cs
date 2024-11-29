using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup6.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required ()]
        public string? StreetAddress { get; set; }

        [Required()]
        public string? City { get; set; }

        [Required()]
        public string? State { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "ZIP Code is invalid.")]
        public int ZipCode { get; set; } 
    }
}
