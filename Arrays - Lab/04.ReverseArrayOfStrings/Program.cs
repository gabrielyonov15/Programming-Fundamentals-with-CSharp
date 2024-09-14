namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbol = Console.ReadLine().Split().ToArray();
            for (int i = symbol.Length - 1; i >= 0; i--)
            {
                Console.Write($"{symbol[i]} ");
            }
        }
    }
}
