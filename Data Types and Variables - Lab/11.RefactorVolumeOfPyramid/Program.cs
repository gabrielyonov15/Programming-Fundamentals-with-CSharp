namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lengt = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double  width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (lengt * width * height) /3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
