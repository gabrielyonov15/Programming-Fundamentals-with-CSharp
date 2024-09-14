namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            int sum = 0;
            for(int i = 0;i<n;i++)
            {
                number[i]= int.Parse(Console.ReadLine());
                sum += number[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
