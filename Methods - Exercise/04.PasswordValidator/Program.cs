namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }
        static void ValidatePassword(string password)
        {
            bool isValid = true;
            if (!IsLengthValid(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!IsLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsLengthValid(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool IsLettersAndDigits(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }
        static bool HasAtLeastTwoDigits(string password)
        {
            int digitCount = password.Count(char.IsDigit);
            return digitCount >= 2;
        }
    }
}