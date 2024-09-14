namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalSpiceExtracted = 0;
            int daysOperated = 0;
            while (startingYield >= 100)
            {
                daysOperated++;
                totalSpiceExtracted += startingYield;
                startingYield -= 10;
                totalSpiceExtracted -= 26;
            }
            if (totalSpiceExtracted >= 26)
            {
                totalSpiceExtracted -= 26;
            }
            Console.WriteLine(daysOperated);
            Console.WriteLine(totalSpiceExtracted);
        }
    }
}
