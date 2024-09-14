namespace _06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice
        {
            get { return Item.Price * ItemQuantity; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] boxData = input.Split(' ');
                string serialNumber = boxData[0];
                string itemName = boxData[1];
                int itemQuantity = int.Parse(boxData[2]);
                decimal itemPrice = decimal.Parse(boxData[3]);
                Item item = new Item
                {
                    Name = itemName,
                    Price = itemPrice
                };
                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity
                };
                boxes.Add(box);
            }
            List<Box> sortedBoxes = boxes.OrderByDescending(b => b.BoxPrice).ToList();
            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }
}
