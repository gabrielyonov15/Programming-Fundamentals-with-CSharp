namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = n / 1000m;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
