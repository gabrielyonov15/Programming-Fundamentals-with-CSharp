namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
            static void Main(string[] args)
            {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
            }
            static int GetMultipleOfEvenAndOdds(int number)
            {
                int evenSum = GetSumOfEvenDigits(number);
                int oddSum = GetSumOfOddDigits(number);
                return evenSum * oddSum;
            }
            static int GetSumOfEvenDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    int digit = Math.Abs(number % 10);
                    if (digit % 2 == 0)
                    {
                        sum += digit;
                    }
                    number /= 10;
                }
                return sum;
            }
            static int GetSumOfOddDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    int digit = Math.Abs(number % 10);
                    if (digit % 2 != 0)
                    {
                        sum += digit;
                    }
                    number /= 10;
                }
                return sum;
            }
        }
    }
