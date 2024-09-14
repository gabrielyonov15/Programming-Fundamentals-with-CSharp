namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            string result = RepeatString(inputString, repeatCount);
            Console.WriteLine(result);
        }
        static string RepeatString(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
