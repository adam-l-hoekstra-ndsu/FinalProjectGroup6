namespace FinalProjectGroup6.Models
{
    public class AnimalShelter
    {
        public int Id { get; set; }
        public string? Picture { get; set; }
        public string? Name { get; set; }
        public int AddressId { get; set; }
        public int OpeningHour { get; set; }
        public int ClosingHour { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
