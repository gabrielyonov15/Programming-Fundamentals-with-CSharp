namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (string name, int age)> people = new Dictionary<string, (string name, int age)>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                if (people.ContainsKey(id))
                {
                    people[id] = (name, age);
                }
                else
                {
                    people.Add(id, (name, age));
                }
            }
            foreach (var person in people.OrderBy(p => p.Value.age))
            {
                Console.WriteLine($"{person.Value.name} with ID: {person.Key} is {person.Value.age} years old.");
            }
        }
    }
}