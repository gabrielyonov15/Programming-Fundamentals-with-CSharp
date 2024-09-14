namespace _03.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] songData = Console.ReadLine().Split('_');
                Song song = new Song
                {
                    TypeList = songData[0],
                    Name = songData[1],
                    Time = songData[2]
                };
                songs.Add(song);
            }
            string filter = Console.ReadLine();
            foreach (Song song in songs)
            {
                if (filter == "all" || song.TypeList == filter)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
