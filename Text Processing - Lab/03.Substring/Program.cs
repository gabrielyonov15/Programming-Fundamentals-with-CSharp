namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(substringToRemove))
            {
                int index = text.IndexOf(substringToRemove);
                if (index != -1)
                {
                    text = text.Remove(index, substringToRemove.Length);
                }
            }
            Console.WriteLine(text);
        }
    }
}