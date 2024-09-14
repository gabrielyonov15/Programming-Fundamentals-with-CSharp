using System.Text.RegularExpressions;
namespace _02.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[@#]+([a-z]{3,})[@#]+[^a-zA-Z0-9]*\/+(\d+)\/+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string color = match.Groups[1].Value;
                string amount = match.Groups[2].Value;
                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}