namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }
        static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;
            int middleIndex = length / 2;
            if (length % 2 == 0)
            {
                Console.WriteLine(input.Substring(middleIndex - 1, 2));
            }
            else
            {
                Console.WriteLine(input[middleIndex]);
            }
        }
    }
}
