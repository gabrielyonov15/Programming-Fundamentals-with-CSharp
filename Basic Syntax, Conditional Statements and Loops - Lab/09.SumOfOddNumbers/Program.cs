namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentOddNumber = 1;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
                currentOddNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
