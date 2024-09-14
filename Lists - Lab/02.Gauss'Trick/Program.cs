namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
            List<int> newList = new List<int>();
            int i = 0;
            while (i < inputList.Count / 2)
            {
                int sum = inputList[i] + inputList[inputList.Count - 1 - i];
                newList.Add(sum);
                i++;
            }
            if (inputList.Count % 2 != 0)
            {
                newList.Add(inputList[inputList.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
