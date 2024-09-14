using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            var validPhones = matches
                .Cast<Match>()
                .Select(match => match.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}