using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup6.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public int UserSentFrom { get; set; }
        [Required]
        public int UserSentTo { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        public string? Subject { get; set; }
        [Required]
        public string? Body { get; set; }
    }
}
