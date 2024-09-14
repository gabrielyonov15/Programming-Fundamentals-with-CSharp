namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CountVowels(input);
        }
        static void CountVowels(string input)
        {
            int vowelCount = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
