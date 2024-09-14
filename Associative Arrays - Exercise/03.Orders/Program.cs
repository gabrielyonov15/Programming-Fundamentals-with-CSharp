namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputParts = input.Split();
                string productName = inputParts[0];
                decimal price = decimal.Parse(inputParts[1]);
                int quantity = int.Parse(inputParts[2]);
                if (products.ContainsKey(productName))
                {
                    Product existingProduct = products[productName];
                    existingProduct.Price = price; 
                    existingProduct.Quantity += quantity; 
                }
                else
                {
                    Product newProduct = new Product(productName, price, quantity);
                    products.Add(productName, newProduct);
                }
            }
            foreach (var product in products)
            {
                string productName = product.Key;
                decimal totalPrice = product.Value.Price * product.Value.Quantity;
                Console.WriteLine($"{productName} -> {totalPrice:f2}");
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}