namespace _03.DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split(", ");
                string command = commandParts[0];
                switch (command)
                {
                    case "Add":
                        AddCard(cards, commandParts[1]);
                        break;
                    case "Remove":
                        RemoveCard(cards, commandParts[1]);
                        break;
                    case "Remove At":
                        RemoveCardAt(cards, int.Parse(commandParts[1]));
                        break;
                    case "Insert":
                        InsertCard(cards, int.Parse(commandParts[1]), commandParts[2]);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", cards));
        }
        static void AddCard(List<string> cards, string cardName)
        {
            if (cards.Contains(cardName))
            {
                Console.WriteLine("Card is already in the deck");
            }
            else
            {
                cards.Add(cardName);
                Console.WriteLine("Card successfully added");
            }
        }
        static void RemoveCard(List<string> cards, string cardName)
        {
            if (cards.Contains(cardName))
            {
                cards.Remove(cardName);
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Card not found");
            }
        }
        static void RemoveCardAt(List<string> cards, int index)
        {
            if (index >= 0 && index < cards.Count)
            {
                cards.RemoveAt(index);
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }
        static void InsertCard(List<string> cards, int index, string cardName)
        {
            if (index < 0 || index >= cards.Count)
            {
                Console.WriteLine("Index out of range");
            }
            else
            if (cards.Contains(cardName))
            {
                Console.WriteLine("Card is already added");
            }
            else
            {
                cards.Insert(index, cardName);
                Console.WriteLine("Card successfully added");
            }
        }
    }
}
