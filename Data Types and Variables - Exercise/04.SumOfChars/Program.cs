namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <= n; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                totalSum += (int)symbols;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
