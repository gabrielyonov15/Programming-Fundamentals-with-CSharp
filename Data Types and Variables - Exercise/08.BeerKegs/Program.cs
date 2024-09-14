namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string largestKegModel = "";
            double largestKegVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > largestKegVolume)
                {
                    largestKegVolume = volume;
                    largestKegModel = model;
                }
            }
            Console.WriteLine(largestKegModel);
        }
    }
}
