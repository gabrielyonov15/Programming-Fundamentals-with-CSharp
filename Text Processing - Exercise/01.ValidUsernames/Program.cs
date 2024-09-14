namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] usernames = inputLine.Split(new string[] { ", " }, StringSplitOptions.None);
            foreach (string username in usernames)
            {
                if (IsValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        public static bool IsValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            foreach (char c in username)
            {
                if (!(char.IsLetterOrDigit(c) || c == '_' || c == '-'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}