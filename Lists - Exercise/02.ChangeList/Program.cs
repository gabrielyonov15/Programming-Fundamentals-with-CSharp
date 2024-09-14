namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] commandParts = command.Split();
                string action = commandParts[0];
                if (action == "Delete")
                {
                    int elementToDelete = int.Parse(commandParts[1]);
                    numbers.RemoveAll(num => num == elementToDelete);
                }
                else 
                if (action == "Insert")
                {
                    int elementToInsert = int.Parse(commandParts[1]);
                    int position = int.Parse(commandParts[2]);
                    numbers.Insert(position, elementToInsert);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
