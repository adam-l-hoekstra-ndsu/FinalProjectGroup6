using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace FinalProjectGroup6.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string? Picture { get; set; }
        [Required(ErrorMessage = "The status field is required")]
        public int Status { get; set; }
        [Required(ErrorMessage = "The dog name field is required")]
        public string? Name { get; set; }
        public string? Gender { get; set; }
        [Required(ErrorMessage = "The dog breed field is required")]
        public string? Breed { get; set; }

        [Required(ErrorMessage = "The size field is required")]
        public string? Size { get; set; }
        [Required(ErrorMessage = "The dog age field is required")]
        [Range(0, 35, ErrorMessage ="Invalid Dog Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "The dog color field is required")]
        public string? Color { get; set; }
        public bool IsNeuteredSpayed { get; set; }
        [Required(ErrorMessage = "The shelter field is required")]
        public int ShelterId { get; set; }
    }
}
