namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] array = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }
            int targetSum = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        Console.WriteLine(array[i] + " " + array[j]);
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
