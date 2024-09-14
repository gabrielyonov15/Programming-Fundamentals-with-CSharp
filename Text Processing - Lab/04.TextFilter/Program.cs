namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (string bannedWord in bannedWords)
            {
                string replacement = new string('*', bannedWord.Length);
                text = text.Replace(bannedWord, replacement);
            }
            Console.WriteLine(text);
        }
    }
}