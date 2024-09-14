namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayerHand.Count > 0 && secondPlayerHand.Count > 0)
            {
                int firstCard = firstPlayerHand[0];
                int secondCard = secondPlayerHand[0];
                firstPlayerHand.RemoveAt(0);
                secondPlayerHand.RemoveAt(0);
                if (firstCard > secondCard)
                {
                    firstPlayerHand.Add(firstCard);
                    firstPlayerHand.Add(secondCard);
                }
                else
                if (secondCard > firstCard)
                {
                    secondPlayerHand.Add(secondCard);
                    secondPlayerHand.Add(firstCard);
                }
            }
            if (firstPlayerHand.Count > 0)
            {
                int sum = firstPlayerHand.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondPlayerHand.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
