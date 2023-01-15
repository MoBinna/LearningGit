namespace Homes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var type = Type();
            Console.Clear();
            switch (type)
            {
                case 1:
                    Apartment();
                    break;

                case 2:
                    Townhome();
                    break;

                case 3:
                    Ranchhome();
                    break;
            }
        }
        private static int Type()
        {
          Console.WriteLine("\t\t***WELCOME***");
          Console.WriteLine("Please Choose Type Of Your House:");
          Console.WriteLine("1-Apartment\n2-Townhome\n3-Ranchhome");
          int type = Convert.ToInt32(Console.ReadLine());
          return type;
        }

        public static void Apartment()
        {
            Console.WriteLine("Please enter the City:");
            string city = Console.ReadLine();
            Console.WriteLine("Please enter the Area:");
            string area = Console.ReadLine();
            Console.WriteLine("Please enter the Price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Bedrooms:");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Beathrooms:");
            int beathrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the LivingSpacesqm:");
            int livingSpacesqm = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the floor:");
            int floor = int.Parse(Console.ReadLine());
            House h1 = new Apartment(city, area, price, bedrooms, beathrooms, livingSpacesqm, floor);
            Console.Clear();
            display(h1);
        }
        public static void Townhome()
        {
            Console.WriteLine("Please enter the City:");
            string city = Console.ReadLine();
            Console.WriteLine("Please enter the Area:");
            string area = Console.ReadLine();
            Console.WriteLine("Please enter the Price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Bedrooms:");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Beathrooms:");
            int beathrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the LivingSpacesqm:");
            int livingSpacesqm = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the  Garage spaces:");
            int garage = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Year of construction:");
            int year = int.Parse(Console.ReadLine());

            House h2 = new Townhome(city, area, price, bedrooms, beathrooms, livingSpacesqm, year, garage);
            Console.Clear();
            display(h2);
        }
        public static void Ranchhome()
        {
            Console.WriteLine("Please enter the City:");
            string city = Console.ReadLine();
            Console.WriteLine("Please enter the Area:");
            string area = Console.ReadLine();
            Console.WriteLine("Please enter the Price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Bedrooms:");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Beathrooms:");
            int beathrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the LivingSpacesqm:");
            int livingSpacesqm = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the  Garage spaces:");
            int garage = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Year of construction:");
            int year = int.Parse(Console.ReadLine());
            House h3 = new Ranchhome(city, area, price, bedrooms, beathrooms, livingSpacesqm, year, garage);
            Console.Clear();
            display(h3);
        }

         static void display(House H)
        {
           
            Console.WriteLine("Saleable? "+ H.Saleable());
            Console.WriteLine(H.DispayInfo());
            Console.ReadKey();
        }
    }
}