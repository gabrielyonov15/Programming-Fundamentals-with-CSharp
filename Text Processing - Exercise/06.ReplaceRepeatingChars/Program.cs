namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string input = Console.ReadLine();
                string result = ReplaceRepeatingChars(input);
                Console.WriteLine(result);
        }
            public static string ReplaceRepeatingChars(string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return string.Empty;
                }
                char currentChar = str[0];
                string result = currentChar.ToString();
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] != currentChar)
                    {
                        currentChar = str[i];
                        result += currentChar;
                    }
                }
                return result;
            }
        }
    }