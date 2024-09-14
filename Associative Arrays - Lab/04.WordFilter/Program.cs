namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
