namespace _02.Articles
{
    class Article
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] articleInfo = inputLine.Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];
            Article article = new Article(title, content, author);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(": ");
                string action = commandParts[0];
                string parameter = commandParts[1];
                switch (action)
                {
                    case "Edit":
                        article.Edit(parameter);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(parameter);
                        break;
                    case "Rename":
                        article.Rename(parameter);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
}