namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = CalculateResult(a, b, c);
            Console.WriteLine(result);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int sum, int c)
        {
            return sum - c;
        }
        static int CalculateResult(int a, int b, int c)
        {
            int sum = Sum(a, b);
            return Subtract(sum, c);
        }
    }
}
