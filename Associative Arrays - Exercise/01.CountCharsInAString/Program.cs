namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            CountChars(inputString);
        }
        static void CountChars(string input)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    if (charCounts.ContainsKey(c))
                    {
                        charCounts[c]++;
                    }
                    else
                    {
                        charCounts[c] = 1;
                    }
                }
            }
            foreach (var entry in charCounts)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}