namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharactersInRange(start, end);
        }
        static void PrintCharactersInRange(char start, char end)
        {
            if (start > end)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            for (char c = (char)(start + 1); c < end; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
}
