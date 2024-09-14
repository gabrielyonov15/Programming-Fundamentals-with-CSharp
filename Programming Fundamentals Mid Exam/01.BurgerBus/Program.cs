namespace _01.BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double totalProfit = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());
                double profit = income - expenses;
                if (i % 3 == 0 && i % 5 != 0)
                {
                    expenses *= 1.5;
                    profit = income - expenses;
                }
                if (i % 5 == 0)
                {
                    income *= 0.9;
                    profit = income - expenses;
                }
                Console.WriteLine($"In {cityName} Burger Bus earned {profit:F2} leva.");
                totalProfit += profit;
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
        }
    }
}
