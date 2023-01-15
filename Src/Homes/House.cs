#nullable disable

namespace Homes
{
    abstract class House : ISale
    {
        protected string Type { get; set; }
        protected string City { get; set; }
        protected string Area { get; set; }
        protected double Price { get; set; }
        protected double LivingSpacesqm { get; set; }
        protected int Bedrooms { get; set; }    
        protected int Beathrooms { get; set; }

        abstract public bool Saleable();
        abstract public double SellingPrice();
        abstract public string DispayInfo();

        public string Location()
        {
            return $"{City} {Area}";
        }

    }
}
