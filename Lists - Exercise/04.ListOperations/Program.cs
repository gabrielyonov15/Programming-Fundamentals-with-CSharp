namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] commandParts = command.Split();
                string action = commandParts[0];
                if (action == "Add")
                {
                    int numberToAdd = int.Parse(commandParts[1]);
                    numbers.Add(numberToAdd);
                }
                else 
                if (action == "Insert")
                {
                    int numberToInsert = int.Parse(commandParts[1]);
                    int index = int.Parse(commandParts[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, numberToInsert);
                    }
                }
                else 
                if (action == "Remove")
                {
                    int index = int.Parse(commandParts[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else 
                if (action == "Shift")
                {
                    string direction = commandParts[1];
                    int count = int.Parse(commandParts[2]);
                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else 
                    if (direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void ShiftLeft(List<int> list, int count)
        {
            int actualCount = count % list.Count;
            for (int i = 0; i < actualCount; i++)
            {
                int firstElement = list[0];
                list.RemoveAt(0);
                list.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> list, int count)
        {
            int actualCount = count % list.Count;
            for (int i = 0; i < actualCount; i++)
            {
                int lastElement = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, lastElement);
            }
        }
    }
}
