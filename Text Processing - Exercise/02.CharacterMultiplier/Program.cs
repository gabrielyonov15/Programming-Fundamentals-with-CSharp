namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string input = Console.ReadLine();
                string[] strings = input.Split();
                if (strings.Length == 2)
                {
                    string str1 = strings[0];
                    string str2 = strings[1];
                    int result = CharacterMultiplier(str1, str2);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            static int CharacterMultiplier(string str1, string str2)
            {
                int totalSum = 0;
                int minLength = Math.Min(str1.Length, str2.Length);
                int maxLength = Math.Max(str1.Length, str2.Length);
                for (int i = 0; i < minLength; i++)
                {
                    totalSum += str1[i] * str2[i];
                }
                if (str1.Length > minLength)
                {
                    for (int i = minLength; i < str1.Length; i++)
                    {
                        totalSum += str1[i];
                    }
                }
                else
                if (str2.Length > minLength)
                {
                    for (int i = minLength; i < str2.Length; i++)
                    {
                        totalSum += str2[i];
                    }
                }
                return totalSum;
            }
        }

    }