namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            foreach (int index in ladybugIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] parts = command.Split();
                int initialIndex = int.Parse(parts[0]);
                string direction = parts[1];
                int flyLength = int.Parse(parts[2]);
                if (initialIndex < 0 || initialIndex >= fieldSize || field[initialIndex] == 0)
                {
                    continue;
                }
                field[initialIndex] = 0;
                int newIndex = initialIndex;
                while (true)
                {
                    if (direction == "right")
                    {
                        newIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        newIndex -= flyLength;
                    }
                    if (newIndex < 0 || newIndex >= fieldSize)
                    {
                        break;
                    }
                    if (field[newIndex] == 0)
                    {
                        field[newIndex] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
