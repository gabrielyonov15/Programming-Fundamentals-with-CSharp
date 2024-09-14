namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);
                bool isPalindrome = IsPalindrome(number);
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int left = 0;
            int right = numberString.Length - 1;
            while (left < right)
            {
                if (numberString[left] != numberString[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
