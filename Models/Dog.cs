using System.ComponentModel;

namespace FinalProjectGroup6.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string? Picture { get; set; }
        public int Status { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Breed { get; set; }
        public string? Size { get; set; }
        public int Age { get; set; }
        public string? Color { get; set; }
        public bool IsNeuteredSpayed { get; set; }
        public int ShelterId { get; set; }
    }
}
