namespace _05.TeamworkProjects
{
    class Team
    {
        public string Name { get; }
        public string Creator { get; }
        public List<string> Members { get; }
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string user = input[0];
                string teamName = input[1];
                bool teamExists = teams.Any(t => t.Name == teamName);
                if (teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                bool userAlreadyCreated = teams.Any(t => t.Creator == user);
                if (userAlreadyCreated)
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }
                Team team = new Team(teamName, user);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command.Split("->");
                string user = cmdArgs[0];
                string teamName = cmdArgs[1];
                Team currentTeam = teams.FirstOrDefault(t => t.Name == teamName);
                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                bool userAlreadyInTeam = teams.Any(t => t.Members.Contains(user) || t.Creator == user);
                if (userAlreadyInTeam)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }
                currentTeam.Members.Add(user);
            }
            foreach (var team in teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine($"{team.Name}");
                    Console.WriteLine($"- {team.Creator}");
                    foreach (var member in team.Members.OrderBy(m => m))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name))
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }
}
