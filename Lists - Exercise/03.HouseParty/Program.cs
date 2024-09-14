namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split();
                string name = commandParts[0];
                if (commandParts[2] == "going!")
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else 
                if (commandParts[2] == "not")
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
