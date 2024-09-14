namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];
                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    if (parkingDatabase.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
                    }
                    else
                    {
                        parkingDatabase[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else
                if (command == "unregister")
                {
                    if (!parkingDatabase.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parkingDatabase.Remove(username);
                    }
                }
            }
            foreach (var entry in parkingDatabase)
            {
                Console.WriteLine($"{entry.Key} => {entry.Value}");
            }
        }
    }
}