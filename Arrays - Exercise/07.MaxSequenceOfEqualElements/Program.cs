namespace _07.MaxSequenceOfEqualElements
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
            int maxLength = 1;
            int currentLength = 1;
            int bestElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        bestElement = array[i];
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(bestElement + " ");
            }
            Console.WriteLine();
        }
    }
}
