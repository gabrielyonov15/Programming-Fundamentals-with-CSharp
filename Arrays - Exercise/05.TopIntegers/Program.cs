namespace _05.TopIntegers
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
            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
