using System.Diagnostics;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            PrintsOutTheSmallest(firstNumber, secondNumber, thirdNumber);
        }
        static void PrintsOutTheSmallest(int firstNumber,int secondNumber,int thirdNumber)
        {
            int smallest = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            Console.WriteLine(smallest);
        }
    }
}
