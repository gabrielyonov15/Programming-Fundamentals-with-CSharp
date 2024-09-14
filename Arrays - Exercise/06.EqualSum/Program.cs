namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
