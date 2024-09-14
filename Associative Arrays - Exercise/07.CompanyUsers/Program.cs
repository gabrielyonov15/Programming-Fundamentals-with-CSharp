namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputParts = input.Split(" -> ");
                string companyName = inputParts[0];
                string employeeId = inputParts[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new HashSet<string>();
                }
                companies[companyName].Add(employeeId);
            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
