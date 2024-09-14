namespace _01.DecryptingCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                    break;
                string[] parts = input.Split();
                string command = parts[0];
                switch (command)
                {
                    case "Replace":
                        char currentChar = parts[1][0];
                        char newChar = parts[2][0];
                        message = message.Replace(currentChar, newChar);
                        Console.WriteLine(message);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(parts[1]);
                        int endIndex = int.Parse(parts[2]);
                        if (startIndex >= 0 && endIndex < message.Length && startIndex <= endIndex)
                        {
                            message = message.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    case "Make":
                        string caseType = parts[1];
                        if (caseType == "Upper")
                        {
                            message = message.ToUpper();
                        }
                        else 
                        if (caseType == "Lower")
                        {
                            message = message.ToLower();
                        }
                        Console.WriteLine(message);
                        break;
                    case "Check":
                        string substring = parts[1];
                        if (message.Contains(substring))
                        {
                            Console.WriteLine($"Message contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {substring}");
                        }
                        break;
                    case "Sum":
                        startIndex = int.Parse(parts[1]);
                        endIndex = int.Parse(parts[2]);
                        if (startIndex >= 0 && endIndex < message.Length && startIndex <= endIndex)
                        {
                            int sum = 0;
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                sum += message[i];
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
            }
        }
    }
}