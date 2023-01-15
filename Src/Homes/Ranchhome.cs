#nullable disable

namespace Homes
{
    internal class Ranchhome : House
    {
        protected int Year { get; set; }
        protected int Garage { get; set; }

        public Ranchhome(string city, string area, double price, int bedrooms, int beathrooms, int livingSpacesqm, int year, int garage)
        {
            base.Type = "Ranchhome";
            base.City = city;
            base.Area = area;
            base.Price = price;
            base.Bedrooms = bedrooms;
            base.Beathrooms = beathrooms;
            base.LivingSpacesqm = livingSpacesqm;
            this.Year = year;
            this.Garage = garage;
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
        return $"Type:{Type}\nLocation:{Location()}\nprice:{Price}\nlivingSpacesqm:{LivingSpacesqm}\nnumber of Bedrooms:{Bedrooms}\nnumber of Beathrooms:{Beathrooms}\nBuilt in:{Year}\nGarage spaces:{Garage}\n";

        }
    }
}
