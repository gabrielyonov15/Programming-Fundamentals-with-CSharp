using System.Threading.Tasks;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int currentWater = 0;
            for (int i = 0; i < n; i++)
            {
                int litersToAdd = int.Parse(Console.ReadLine());
                if (currentWater + litersToAdd > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentWater += litersToAdd;
                }
            }
            Console.WriteLine(currentWater);
        }
    }
}