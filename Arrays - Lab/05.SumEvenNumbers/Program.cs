namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;
            for(int i = 0;i<number.Length;i++)
            {
                int currentNumber = number[i];
                if (currentNumber % 2==0)
                {
                    result += currentNumber;
                }
            }
           Console.WriteLine(result);
        }
    }
}
