namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrays = input.Split('|').Reverse().ToArray();
            List<int> result = new List<int>();
            foreach (string array in arrays)
            {
                int[] numbers = array
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                result.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
