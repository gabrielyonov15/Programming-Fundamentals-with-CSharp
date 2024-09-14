namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] commandParts = command.Split();
                string action = commandParts[0];
                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commandParts[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int indexToInsert = int.Parse(commandParts[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
