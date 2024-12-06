using NuGet.Packaging.Signing;

namespace FinalProjectGroup6.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int UserSentFrom { get; set; }
        public int UserSentTo { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}
