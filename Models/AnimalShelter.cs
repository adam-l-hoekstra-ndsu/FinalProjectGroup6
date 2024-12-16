using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup6.Models
{
    public class AnimalShelter
    {
        public int Id { get; set; }
        public string? Picture { get; set; }
        [Required(ErrorMessage = "Shelter Name field is required.")]
        public string? Name { get; set; }
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Shelter Opening Hour field is required.")]
        [Range(0, 23, ErrorMessage = "Invalid hour")]
        public int OpeningHour { get; set; }
        [Required(ErrorMessage = "Shelter Closing Hour field is required.")]
        public int ClosingHour { get; set; }
        [Required(ErrorMessage = "Shelter Phone Number field is required.")]
        [Range(0, 23, ErrorMessage = "Invalid hour")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Shelter Email Address field is required.")]
        public string? EmailAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
