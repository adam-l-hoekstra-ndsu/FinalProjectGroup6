using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup6.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "The Street Address field is required.")]
        public string? StreetAddress { get; set; }

        [Required(ErrorMessage = "The city field is required.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "The state field is required.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "The Zip Code field is required.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "ZIP Code is invalid.")]
        public int ZipCode { get; set; } 
    }
}
