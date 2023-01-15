#nullable disable


namespace Homes
{
    internal class Apartment : House
    {
        protected int Floor { get; set; }
        public Apartment(string city, string area, double price, int bedrooms, int beathrooms, int livingSpacesqm, int floor)
        {
            base.Type = "Apartment";
            base.City = city;
            base.Area = area;
            base.Price = price;
            base.Bedrooms = bedrooms;
            base.Beathrooms = beathrooms;
            base.LivingSpacesqm = livingSpacesqm;
            this.Floor = floor;
        }

        public override bool Saleable()
        {
            return Price > 0;
        }
        public override double SellingPrice()
        {
            return Price;
        }
        public override string DispayInfo()
        {

          return $"Type:{Type}\nLocation:{Location()}\nprice:{Price}\nlivingSpacesqm:{LivingSpacesqm}\nnumber of Bedrooms:{Bedrooms}\nnumber of Beathrooms:{Beathrooms}\nFloor:{Floor}\n";
        }
    }
}
