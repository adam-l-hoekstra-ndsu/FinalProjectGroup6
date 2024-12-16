using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup6.Models
{
    public class Application
    {
        private int numPetsOwned;
        private int hrsLeftAlone;
        public int Id { get; set; }
        public int DogID { get; set; }
        public int CustomerID { get; set; }
        public string Status { get; set; }
        [Required]
        public DateOnly SubmitDate{  get; set; }
        public DateOnly? ReviewDate{ get; set; }
        [Required]
        public string WhyHaveDog {  get; set; }
        [Required]
        public string Experience {  get; set; }

        [Required]

        public int NumPetsOwned
        {
            get { return numPetsOwned; }
            set
            {
                if (value >= 0)
                {
                    numPetsOwned = value;
                }
            }
        }
        [Required]
        public string Activities { get; set; }
        public bool Inside { get; set; }
        [Required]
        public int HrsLeftAlone 
        {
            get { return hrsLeftAlone; }
            set
            {
                if (value >= 0)
                {
                    hrsLeftAlone = value;
                }
            }
        }
        public bool CanProvideCare { get; set; }
        public string? RejectReason {  get; set; }

    }
}
