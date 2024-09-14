using Microsoft.VisualBasic;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number =Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNums = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(number[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number[i]} => {roundedNums[i]}");
            }
        }
    }
}
