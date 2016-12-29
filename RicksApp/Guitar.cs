namespace RicksApp
{
    public class Guitar
    {
        public string SerialNumber { get; }
        public double Price { get; set; }
        public GuitarSpec Spec { get;  }
        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            Spec = spec;
            SerialNumber = serialNumber;
            Price = price;
        }



    }
}