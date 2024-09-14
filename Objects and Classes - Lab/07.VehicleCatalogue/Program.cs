namespace _07.VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public List<Truck> Trucks { get; set; } = new List<Truck>();
        public List<Car> Cars { get; set; } = new List<Car>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] vehicleData = input.Split('/');
                string type = vehicleData[0];
                string brand = vehicleData[1];
                string model = vehicleData[2];
                int spec = int.Parse(vehicleData[3]);
                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = spec
                    };
                    catalog.Cars.Add(car);
                }
                else 
                if (type == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = spec
                    };
                    catalog.Trucks.Add(truck);
                }
            }
            List<Car> sortedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
            List<Truck> sortedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
            if (sortedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (sortedTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
