namespace _03.Articles2._0
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] articleInfo = inputLine.Split(", ");
                string title = articleInfo[0];
                string content = articleInfo[1];
                string author = articleInfo[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
