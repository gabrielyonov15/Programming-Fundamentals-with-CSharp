namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorialDivision(a, b):f2}");
        }
        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static double FactorialDivision(int a, int b)
        {
            double factorialA = Factorial(a);
            double factorialB = Factorial(b);
            double result = factorialA / factorialB;
            return Math.Round(result, 2);
        }
    }
}
