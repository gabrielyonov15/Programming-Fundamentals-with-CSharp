namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool arraysAreIdentical = true;
            for (int i = 0;i<firstNumber.Length;i++)
            {
                if (firstNumber[i] == secondNumber[i])
                {
                    sum += firstNumber[i];
                }
                else
                if (firstNumber[i] != secondNumber[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreIdentical = false;
                    break;
                }
            }
            if(arraysAreIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
