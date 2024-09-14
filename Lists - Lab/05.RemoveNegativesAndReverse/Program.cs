namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> reversedNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int number = numbers[i];
                reversedNumbers.Add(number);
            }
            if (reversedNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", reversedNumbers));
            }
        }
    }
}
