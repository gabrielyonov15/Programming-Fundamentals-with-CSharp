namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = MathPower(baseNumber, power);
            Console.WriteLine(result);
        }
        static double MathPower(double baseNumber, int power)
        {
            return Math.Pow(baseNumber, power);
        }
    }
}

