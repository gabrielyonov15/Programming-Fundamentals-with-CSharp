namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Random rng = new Random();
            words = words.OrderBy(word => rng.Next()).ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
