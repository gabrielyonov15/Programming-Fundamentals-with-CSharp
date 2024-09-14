namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                int repeatCount = word.Length;
                for (int i = 0; i < repeatCount; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}