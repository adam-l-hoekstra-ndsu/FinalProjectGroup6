namespace FinalProjectGroup6.Models
{
    public class Application
    {
        private int numPetsOwned;
        private int hrsLeftAlone;
        public int Id { get; set; }
        public string DogID { get; set; }
        public string CustomerID { get; set; }
        public string Status { get; set; }
        public DateOnly SubmitDate{  get; set; }
        public DateOnly? ReviewDate{ get; set; }
        public string WhyHaveDog {  get; set; }
        public string Experience {  get; set; }
        
        // validation for no negative values.
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
        public string Activities { get; set; }
        public bool Inside { get; set; }
        // validation for no negative values.
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
