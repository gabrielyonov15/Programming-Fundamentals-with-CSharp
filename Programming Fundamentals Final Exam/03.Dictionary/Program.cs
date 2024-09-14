namespace _03.Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordsDefinitionsInput = Console.ReadLine();
            string testWordsInput = Console.ReadLine();
            string command = Console.ReadLine();
            Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();
            string[] wordsDefinitionsPairs = wordsDefinitionsInput.Split(" | ");
            foreach (string pair in wordsDefinitionsPairs)
            {
                string[] wordDefinition = pair.Split(": ");
                string word = wordDefinition[0];
                string definition = wordDefinition[1];
                if (!notebook.ContainsKey(word))
                {
                    notebook[word] = new List<string>();
                }
                notebook[word].Add(definition);
            }
            string[] testWords = testWordsInput.Split(" | ");
            if (command == "Test")
            {
                foreach (string testWord in testWords)
                {
                    if (notebook.ContainsKey(testWord))
                    {
                        Console.WriteLine($"{testWord}:");
                        foreach (string definition in notebook[testWord])
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else 
            if (command == "Hand Over")
            {
                Console.WriteLine(string.Join(" ", notebook.Keys));
            }
        }
    }
}