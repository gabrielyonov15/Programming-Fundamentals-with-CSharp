namespace _04.ArrayRotation
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
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }

                array[array.Length - 1] = firstElement;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
