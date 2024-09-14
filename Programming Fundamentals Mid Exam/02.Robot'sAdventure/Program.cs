namespace _02.Robot_sAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != "Adventure over")
            {
                input.Add(line);
            }
            input.Add("Adventure over"); 
            robo_adventure(input.ToArray()); 
        }
        public static void robo_adventure(string[] input_data)
        {
            List<int> grid = input_data[0].Split('|').Select(int.Parse).ToList();
            List<string> commands = input_data.Skip(1).ToList();
            int totalItemsCollected = 0;
            foreach (string command in commands)
            {
                if (command.StartsWith("Step Backward$"))
                {
                    string[] parts = command.Split('$');
                    int startIndex = int.Parse(parts[1]);
                    int steps = int.Parse(parts[2]);
                    if (startIndex >= 0 && startIndex < grid.Count)
                    {
                        int newPosition = (startIndex - steps) % grid.Count;
                        if (newPosition < 0)
                            newPosition += grid.Count;
                        totalItemsCollected += grid[newPosition];
                        grid[newPosition] = 0;
                    }
                }
                else
                if (command.StartsWith("Step Forward$"))
                {
                    string[] parts = command.Split('$');
                    int startIndex = int.Parse(parts[1]);
                    int steps = int.Parse(parts[2]);
                    if (startIndex >= 0 && startIndex < grid.Count)
                    {
                        int newPosition = (startIndex + steps) % grid.Count;
                        totalItemsCollected += grid[newPosition];
                        grid[newPosition] = 0;
                    }
                }
                else
                if (command.StartsWith("Double "))
                {
                    int index = int.Parse(command.Split()[1]);
                    if (index >= 0 && index < grid.Count)
                    {
                        grid[index] *= 2;
                    }
                }
                else
                if (command == "Switch")
                {
                    grid.Reverse();
                }
                else
                if (command == "Adventure over")
                {
                    Console.WriteLine(string.Join(" - ", grid));
                    Console.WriteLine($"Robo finished the adventure with {totalItemsCollected} items!");
                    return;
                }
            }
        }
    }
}
