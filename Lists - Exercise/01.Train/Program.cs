﻿namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    string[] commandParts = command.Split();
                    if (commandParts[0] == "Add")
                    {
                        int passengers = int.Parse(commandParts[1]);
                        wagons.Add(passengers);
                    }
                    else
                    {
                        int passengersToAdd = int.Parse(commandParts[0]);
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (wagons[i] + passengersToAdd <= maxCapacity)
                            {
                                wagons[i] += passengersToAdd;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
