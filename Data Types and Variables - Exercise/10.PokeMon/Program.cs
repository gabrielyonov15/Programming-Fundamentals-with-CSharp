namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int originalN = N;
            int targetsPoked = 0;
            while (N >= M)
            {
                N -= M;
                targetsPoked++;
                if (N == originalN / 2 && Y != 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(targetsPoked);
        }
    }
}
