namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char whether = char.Parse(Console.ReadLine());
            if(whether >= 'A' && whether <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else
            if (whether >= 'a' && whether <= 'z')
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
