namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumbers(n);
        }
        static void PrintTopNumbers(int n)
        {
            for (int number = 1; number <= n; number++)
            {
                if (IsTopNumber(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        static bool IsTopNumber(int number)
        {
            return SumOfDigitsDivisibleBy8(number) && ContainsAtLeastOneOddDigit(number);
        }
        static bool SumOfDigitsDivisibleBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum % 8 == 0;
        }
        static bool ContainsAtLeastOneOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
